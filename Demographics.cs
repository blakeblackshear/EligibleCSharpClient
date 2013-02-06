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

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eligible
{
    /// <summary>
    /// Interface to retrieve demographic information from Eligible
    /// </summary>
    public class Demographics : EligibleAPI
    {
        public Demographics(string npi, string physicianLastName, string physicianFirstName)
           : this(EligibleConfiguration.Instance.APIKey, npi, physicianLastName, physicianFirstName)
        {
        } // Services

        public Demographics(string apiKey, string npi, string physicianLastName, string physicianFirstName)
            : base(apiKey, npi, physicianLastName, physicianFirstName)
        {

        } // Services

        /// <summary>
        /// Returns patient's address, dob, and employer on file with insurance company
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleDemographics GetAll(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleDemographics>(@"demographic", @"all.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetAll

        /// <summary>
        /// Returns patient's zip code on file with insurance company
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleAddress GetZipcode(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleAddress>(@"demographic", @"zip.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetZipcode

        /// <summary>
        /// Returns patient's employer on file with insurance company
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleDemographics GetEmployer(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleDemographics>(@"demographic", @"employer.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetEmployer

        /// <summary>
        /// Returns patient's address on file with insurance company
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleDemographics GetAddress(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleDemographics>(@"demographic", @"address.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetAddress

        /// <summary>
        /// Returns patient's address on file with insurance company
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleDemographics GetDateOfBirth(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleDemographics>(@"demographic", @"dob.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetDateOfBirth

    }

}
