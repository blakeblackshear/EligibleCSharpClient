/// Copyright (c) 2013, Dr. Rounds Holdings, Dr. Rounds Cloud
///
/// Permission is hereby granted, free of charge, to any person 
/// obtaining a copy of this software and associated documentation 
/// files (the "Software"), to deal in the Software without 
/// restriction, including without limitation the rights to use, 
/// copy, modify, merge, publish, distribute, sublicense, and/or sell 
/// copies of the Software, and to permit persons to whom the Software 
/// is furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included 
/// in all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
/// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
/// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
/// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
/// IN THE SOFTWARE.
using System;
using System.Web;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Eligible
{
    /// <summary>
    /// Our Eligible API Eligibility check caller
    /// </summary>
    public abstract class EligibleAPI : IDisposable
    {
        #region Class Members
        /// <summary>
        /// The NPI for the physician
        /// </summary>
        protected string NPI { get; set; }
        protected string PhysicianFirstName { get; set; }
        protected string PhysicianLastName { get; set; }
        protected string APIKey { get; set; }

        

        #endregion Class Members

        #region Static Members

        /// <summary>
        /// Defines the root API calls
        /// </summary>
        private static string ROOT_API = @"https://v1.eligibleapi.net/{0}/{1}?api_key={2}";

        #endregion Static Members

        #region Constructors

        public EligibleAPI(string npi, string physicianLastName, string physicianFirstName)
            : this(EligibleConfiguration.Instance.APIKey, npi, physicianLastName, physicianFirstName)
        {
        }

        public EligibleAPI(string apiKey, string npi, string physicianLastName, string physicianFirstName)
        {
            APIKey = apiKey;
            NPI = npi;
            PhysicianFirstName = physicianFirstName;
            PhysicianLastName = physicianLastName;

        } // EligibleAPI

        #endregion Constructors

        #region Utility Methods

        /// <summary>
        /// Constructs a URL
        /// </summary>
        /// <param name="url">The root URL we are calling</param>
        /// <param name="npi">The physicians NPI value</param>
        /// <param name="physicianFirstName">The first name of the physician</param>
        /// <param name="physicianLastName">The last name of the physician</param>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <param name="extraCodes">An array of string arrays. the child string arrays should have a key:value</param>
        /// <returns>The URL for the request</returns>
        protected static string BuildUrl(string url, string npi, string physicianFirstName, string physicianLastName, string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber, params string[][] extraCodes)
        {
            // Update the URL
            url = AddUrlParameter(url, @"payer_name", insuranceCompany);
            url = AddUrlParameter(url, @"payer_id", payerId);
            url = AddUrlParameter(url, @"service_provider_npi", npi);
            url = AddUrlParameter(url, @"subscriber_id", insuranceMemberNumber);
            url = AddUrlParameter(url, @"subscriber_first_name", patientFirstName);
            url = AddUrlParameter(url, @"subscriber_last_name", patientLastName);
            url = AddUrlParameter(url, @"service_provider_last_name", physicianLastName);
            url = AddUrlParameter(url, @"service_provider_first_name", physicianFirstName);

            // Build up the parameters of our extra codes
            foreach (string[] s in extraCodes)
                url = AddUrlParameter(url, s[0], s[1]);


            // Do we have a DOB? If so, set it
            if (dateOfBirth.HasValue)
                url = AddUrlParameter(url, @"subscriber_dob", dateOfBirth.Value.ToString(DateOfBirthTimeConverter.DATE_OF_BIRTH_FORMAT));

            return url;

        } // BuildUrl

        /// <summary>
        /// Grabs a URL
        /// </summary>
        /// <typeparam name="T">A subclass of EligibleResponse</typeparam>
        /// <param name="jsonResource">The resource we are invoking</param>
        /// <param name="jsonMethod">The method for the resource we are invoking</param>
        /// <param name="npi">The physicians NPI value</param>
        /// <param name="physicianFirstName">The first name of the physician</param>
        /// <param name="physicianLastName">The last name of the physician</param>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <param name="extraCodes">An array of string arrays. the child string arrays should have a key:value</param>
        /// <returns></returns>
        protected T Get<T>(string jsonResource, string jsonMethod, string npi, string physicianFirstName, string physicianLastName, string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber, params string[][] extraCodes) where T : EligibleResponse
        {
            // Init the URL
            string url = string.Format(ROOT_API, jsonResource, jsonMethod, APIKey);

            // Update the URL
            url = BuildUrl(url, npi, physicianFirstName, physicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber,  extraCodes);

            try
            {
                // Grab the response
                string responseBody = PostRequest(url);

                // Parse the response object
                T response = JsonConvert.DeserializeObject<T>(responseBody);

                // Set our requested URL
                response.RequestedURL = url;

                // Save the JSON, may want it later
                response.JSON = responseBody;

                return response;

            } // try
            catch (Exception ex) { throw ex; }

        } // Get

        /// <summary>
        /// Posts a request to the server
        /// </summary>
        /// <param name="url"></param>
        /// <param name="json"></param>
        /// <returns></returns>
        private static string PostRequest(string url, string json = null)
        {
            WebRequest request = HttpWebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            if (!string.IsNullOrEmpty(json))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(json);
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

            } // if

            using (WebResponse r = request.GetResponse())
            using (StreamReader sr = new StreamReader(r.GetResponseStream()))
                return sr.ReadToEnd();

        } // PostRequest

        /// <summary>
        /// Adds a URL parameter 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string AddUrlParameter(string url, string name, string value)
        {
            if (string.IsNullOrEmpty(value))
                return url;

            return string.Concat(url, @"&", name, @"=", HttpUtility.UrlEncode(value));

        } // AddUrlParameter

        #endregion Utility Methods

        #region IDisposable
        
        public void Dispose()
        {
            // Er, at this time there really isn't anything to dispose... 
            // Should remove the IDisposable interface...
        }

        #endregion IDisposable
    }
}
