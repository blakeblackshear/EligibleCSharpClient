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
    /// Interface to retrieve service information from Eligible
    /// </summary>
    public class Services : EligibleAPI
    {
        public Services(string npi, string physicianLastName, string physicianFirstName)
           : this(EligibleConfiguration.Instance.APIKey, npi, physicianLastName, physicianFirstName)
        {
        } // Services

        public Services(string apiKey, string npi, string physicianLastName, string physicianFirstName)
            : base(apiKey, npi, physicianLastName, physicianFirstName)
        {

        } // Services

        /// <summary>
        /// Returns visit amounts allowed per year and how many are remaining for a specific service
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <param name="serviceCode">Code for the service being provided</param>
        /// <returns></returns>
        public EligibleService GetAll(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber, string serviceCode)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"service", @"all.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber, new string[] { "service_type_code", serviceCode });

        } // GetAll

        /// <summary>
        /// Returns visit amounts allowed per year and how many are remaining for a specific service
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <param name="serviceCode">Code for the service being provided</param>
        /// <returns></returns>
        public EligibleService GetVisits(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber, string serviceCode)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"service", @"visits.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber, new string[] { "service_type_code", serviceCode });

        } // GetVisits

        /// <summary>
        /// Returns status, visit amounts allowed per year, co-payments, deductibles, coinsurance, and comments for service
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <param name="serviceCode">Code for the service being provided</param>
        /// <returns></returns>
        public EligibleService GetCopayment(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber, string serviceCode)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"service", @"copayment.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber, new string[] { "service_type_code", serviceCode });

        } // GetCopayment

        /// <summary>
        /// Returns coinsurance responsibility of patient
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <param name="serviceCode">Code for the service being provided</param>
        /// <returns></returns>
        public EligibleService GetCoinsurance(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber, string serviceCode)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"service", @"coinsurance.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber, new string[] { "service_type_code", serviceCode });

        } // GetCoinsurance

        /// <summary>
        /// Returns patient's deductible
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <param name="serviceCode">Code for the service being provided</param>
        /// <returns></returns>
        public EligibleService GetDeductible(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber, string serviceCode)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"service", @"deductible.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber, new string[] { "service_type_code", serviceCode });

        } // GetDeductible

    }
}
