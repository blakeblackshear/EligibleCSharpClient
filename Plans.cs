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
    /// Interface to retrieve plan information from Eligible
    /// </summary>
    public class Plans : EligibleAPI
    {
        public Plans(string npi, string physicianLastName, string physicianFirstName)
           : this(EligibleConfiguration.Instance.APIKey, npi, physicianLastName, physicianFirstName)
        {
        } // Services

        public Plans(string apiKey, string npi, string physicianLastName, string physicianFirstName)
            : base(apiKey, npi, physicianLastName, physicianFirstName)
        {

        } // Services

        /// <summary>
        /// Returns all plan information including: status, dates, & deductibles
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleService GetAll(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"plan", @"all.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetAll

        /// <summary>
        /// Returns the patient's coverage status
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleService GetStatus(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"plan", @"status.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetStatus

        /// <summary>
        /// Returns the patient's deductible for both in and out of network
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleService GetDeductible(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"plan", @"deductible.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetDeductible

        /// <summary>
        /// Retrieves the patients dates of eligibility
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleService GetDates(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"plan", @"dates.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetDates

        /// <summary>
        /// Retrieves the patients balance for claims
        /// </summary>
        /// <param name="insuranceCompany">The name of the health care provider</param>
        /// <param name="payerId">The code for the health care provider</param>
        /// <param name="patientLastName">The last name of the patient</param>
        /// <param name="patientFirstName">The first name of the patient</param>
        /// <param name="dateOfBirth">The Date of Birth of the patient</param>
        /// <param name="insuranceMemberNumber">The insurance card number of the patient</param>
        /// <returns></returns>
        public EligibleService GetBalance(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"plan", @"balance.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetBalance

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insuranceCompany"></param>
        /// <param name="payerId"></param>
        /// <param name="patientLastName"></param>
        /// <param name="patientFirstName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="insuranceMemberNumber"></param>
        /// <returns></returns>
        public EligibleService GetStopLoss(string insuranceCompany, string payerId, string patientLastName, string patientFirstName, DateTime? dateOfBirth, string insuranceMemberNumber)
        {
            // Return the Eligible Response
            return Get<EligibleService>(@"plan", @"stop_loss.json", NPI, PhysicianFirstName, PhysicianLastName, insuranceCompany, payerId, patientLastName, patientFirstName, dateOfBirth, insuranceMemberNumber);

        } // GetStopLoss

    }

}
