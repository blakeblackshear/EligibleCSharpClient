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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Eligible
{
    /// <summary>
    /// These are hard coded values for Eligible reference data, once these become
    /// dynamic, they will be provided in a dynamic manner
    /// </summary>
    public static class EligibleReferenceData
    {

        #region Services

        /// <summary>
        /// Returns the collection of providers for Eligible
        /// </summary>
        /// <returns></returns>
        public static List<EligibleServiceType> GetServices()
        {
            return JsonConvert.DeserializeObject<List<EligibleServiceType>>(SERVICE_JSON);

        } // GetServices

        private static string SERVICE_JSON = @"[ { ""service_id"" : ""1"",
    ""service_name"" : ""Medical Care""
  },
  { ""service_id"" : ""2"",
    ""service_name"" : ""Surgical""
  },
  { ""service_id"" : ""3"",
    ""service_name"" : ""Consultation""
  },
  { ""service_id"" : ""4"",
    ""service_name"" : ""Diagnostic X-Ray""
  },
  { ""service_id"" : ""5"",
    ""service_name"" : ""Diagnostic Lab""
  },
  { ""service_id"" : ""6"",
    ""service_name"" : ""Radiation Therapy""
  },
  { ""service_id"" : ""7"",
    ""service_name"" : ""Anesthesia""
  },
  { ""service_id"" : ""8"",
    ""service_name"" : ""Surgical Assistance""
  },
  { ""service_id"" : ""9"",
    ""service_name"" : ""Other Medical""
  },
  { ""service_id"" : ""10"",
    ""service_name"" : ""Blood Charges""
  },
  { ""service_id"" : ""11"",
    ""service_name"" : ""Used Durable Medical Equipment""
  },
  { ""service_id"" : ""12"",
    ""service_name"" : ""Durable Medical Equipment Purchase""
  },
  { ""service_id"" : ""13"",
    ""service_name"" : ""Ambulatory Service Center Facility""
  },
  { ""service_id"" : ""14"",
    ""service_name"" : ""Renal Supplies in the Home""
  },
  { ""service_id"" : ""15"",
    ""service_name"" : ""Alternate Method Dialysis""
  },
  { ""service_id"" : ""16"",
    ""service_name"" : ""Chronic Renal Disease (CRD) Equipment""
  },
  { ""service_id"" : ""17"",
    ""service_name"" : ""Pre-Admission Testing""
  },
  { ""service_id"" : ""18"",
    ""service_name"" : ""Durable Medical Equipment Rental""
  },
  { ""service_id"" : ""19"",
    ""service_name"" : ""Pneumonia Vaccine""
  },
  { ""service_id"" : ""20"",
    ""service_name"" : ""Second Surgical Opinion""
  },
  { ""service_id"" : ""21"",
    ""service_name"" : ""Third Surgical Opinion""
  },
  { ""service_id"" : ""22"",
    ""service_name"" : ""Social Work""
  },
  { ""service_id"" : ""23"",
    ""service_name"" : ""Diagnostic Dental""
  },
  { ""service_id"" : ""24"",
    ""service_name"" : ""Periodontics""
  },
  { ""service_id"" : ""25"",
    ""service_name"" : ""Restorative""
  },
  { ""service_id"" : ""26"",
    ""service_name"" : ""Endodontics""
  },
  { ""service_id"" : ""27"",
    ""service_name"" : ""Maxillofacial Prosthetics""
  },
  { ""service_id"" : ""28"",
    ""service_name"" : ""Adjunctive Dental Services""
  },
  { ""service_id"" : ""30"",
    ""service_name"" : ""Health Benefit Plan Coverage""
  },
  { ""service_id"" : ""31"",
    ""service_name"" : ""Benefit Disclaimer""
  },
  { ""service_id"" : ""32"",
    ""service_name"" : ""Plan Waiting Period""
  },
  { ""service_id"" : ""33"",
    ""service_name"" : ""Chiropractic""
  },
  { ""service_id"" : ""34"",
    ""service_name"" : ""Chiropractic Office Visits""
  },
  { ""service_id"" : ""35"",
    ""service_name"" : ""Dental Care""
  },
  { ""service_id"" : ""36"",
    ""service_name"" : ""Dental Crowns""
  },
  { ""service_id"" : ""37"",
    ""service_name"" : ""Dental Accident""
  },
  { ""service_id"" : ""38"",
    ""service_name"" : ""Orthodontics""
  },
  { ""service_id"" : ""39"",
    ""service_name"" : ""Prosthodontics""
  },
  { ""service_id"" : ""40"",
    ""service_name"" : ""Oral Surgery""
  },
  { ""service_id"" : ""41"",
    ""service_name"" : ""Routine Preventive Dental""
  },
  { ""service_id"" : ""42"",
    ""service_name"" : ""Home Health Care""
  },
  { ""service_id"" : ""43"",
    ""service_name"" : ""Home Health Prescriptions""
  },
  { ""service_id"" : ""44"",
    ""service_name"" : ""Home Health Visits""
  },
  { ""service_id"" : ""45"",
    ""service_name"" : ""Hospice""
  },
  { ""service_id"" : ""46"",
    ""service_name"" : ""Respite Care""
  },
  { ""service_id"" : ""47"",
    ""service_name"" : ""Hospital""
  },
  { ""service_id"" : ""48"",
    ""service_name"" : ""Hospital - Inpatient""
  },
  { ""service_id"" : ""49"",
    ""service_name"" : ""Hospital - Room and Board""
  },
  { ""service_id"" : ""50"",
    ""service_name"" : ""Hospital - Outpatient""
  },
  { ""service_id"" : ""51"",
    ""service_name"" : ""Hospital - Emergency Accident""
  },
  { ""service_id"" : ""52"",
    ""service_name"" : ""Hospital - Emergency Medical""
  },
  { ""service_id"" : ""53"",
    ""service_name"" : ""Hospital - Ambulatory Surgical""
  },
  { ""service_id"" : ""54"",
    ""service_name"" : ""Long Term Care""
  },
  { ""service_id"" : ""55"",
    ""service_name"" : ""Major Medical""
  },
  { ""service_id"" : ""56"",
    ""service_name"" : ""Medically Related Transportation""
  },
  { ""service_id"" : ""57"",
    ""service_name"" : ""Air Transportation""
  },
  { ""service_id"" : ""58"",
    ""service_name"" : ""Cabulance""
  },
  { ""service_id"" : ""59"",
    ""service_name"" : ""Licensed Ambulance""
  },
  { ""service_id"" : ""60"",
    ""service_name"" : ""General Benefits""
  },
  { ""service_id"" : ""61"",
    ""service_name"" : ""In-vitro Fertilization""
  },
  { ""service_id"" : ""62"",
    ""service_name"" : ""MRI/CAT Scan""
  },
  { ""service_id"" : ""63"",
    ""service_name"" : ""Donor Procedure""
  },
  { ""service_id"" : ""64"",
    ""service_name"" : ""Acupuncture""
  },
  { ""service_id"" : ""65"",
    ""service_name"" : ""Newborn Care""
  },
  { ""service_id"" : ""66"",
    ""service_name"" : ""Pathology""
  },
  { ""service_id"" : ""67"",
    ""service_name"" : ""Smoking Cessation""
  },
  { ""service_id"" : ""68"",
    ""service_name"" : ""Well Baby Care""
  },
  { ""service_id"" : ""69"",
    ""service_name"" : ""Maternity""
  },
  { ""service_id"" : ""70"",
    ""service_name"" : ""Transplants""
  },
  { ""service_id"" : ""71"",
    ""service_name"" : ""Audiology Exam""
  },
  { ""service_id"" : ""72"",
    ""service_name"" : ""Inhalation Therapy""
  },
  { ""service_id"" : ""73"",
    ""service_name"" : ""Diagnostic Medical""
  },
  { ""service_id"" : ""74"",
    ""service_name"" : ""Private Duty Nursing""
  },
  { ""service_id"" : ""75"",
    ""service_name"" : ""Prosthetic Device""
  },
  { ""service_id"" : ""76"",
    ""service_name"" : ""Dialysis""
  },
  { ""service_id"" : ""77"",
    ""service_name"" : ""Otological Exam""
  },
  { ""service_id"" : ""78"",
    ""service_name"" : ""Chemotherapy""
  },
  { ""service_id"" : ""79"",
    ""service_name"" : ""Allergy Testing""
  },
  { ""service_id"" : ""80"",
    ""service_name"" : ""Immunizations""
  },
  { ""service_id"" : ""81"",
    ""service_name"" : ""Routine Physical""
  },
  { ""service_id"" : ""82"",
    ""service_name"" : ""Family Planning""
  },
  { ""service_id"" : ""83"",
    ""service_name"" : ""Infertility""
  },
  { ""service_id"" : ""84"",
    ""service_name"" : ""Abortion""
  },
  { ""service_id"" : ""85"",
    ""service_name"" : ""HIV - AIDS Treatment""
  },
  { ""service_id"" : ""86"",
    ""service_name"" : ""Emergency Services""
  },
  { ""service_id"" : ""87"",
    ""service_name"" : ""Cancer Treatment""
  },
  { ""service_id"" : ""88"",
    ""service_name"" : ""Pharmacy""
  },
  { ""service_id"" : ""89"",
    ""service_name"" : ""Free Standing Prescription Drug""
  },
  { ""service_id"" : ""90"",
    ""service_name"" : ""Mail Order Prescription Drug""
  },
  { ""service_id"" : ""91"",
    ""service_name"" : ""Brand Name Prescription Drug""
  },
  { ""service_id"" : ""92"",
    ""service_name"" : ""Generic Prescription Drug""
  },
  { ""service_id"" : ""93"",
    ""service_name"" : ""Podiatry""
  },
  { ""service_id"" : ""94"",
    ""service_name"" : ""Podiatry - Office Visits""
  },
  { ""service_id"" : ""95"",
    ""service_name"" : ""Podiatry - Nursing Home Visits""
  },
  { ""service_id"" : ""96"",
    ""service_name"" : ""Professional (Physician)""
  },
  { ""service_id"" : ""97"",
    ""service_name"" : ""Anesthesiologist""
  },
  { ""service_id"" : ""98"",
    ""service_name"" : ""Professional (Physician) Visit - Office""
  },
  { ""service_id"" : ""99"",
    ""service_name"" : ""Professional (Physician) Visit - Inpatient""
  },
  { ""service_id"" : ""A0"",
    ""service_name"" : ""Professional (Physician) Visit - Outpatient""
  },
  { ""service_id"" : ""A1"",
    ""service_name"" : ""Professional (Physician) Visit - Nursing Home""
  },
  { ""service_id"" : ""A2"",
    ""service_name"" : ""Professional (Physician) Visit - Skilled Nursing Facility""
  },
  { ""service_id"" : ""A3"",
    ""service_name"" : ""Professional (Physician) Visit - Home""
  },
  { ""service_id"" : ""A4"",
    ""service_name"" : ""Psychiatric""
  },
  { ""service_id"" : ""A5"",
    ""service_name"" : ""Psychiatric - Room and Board""
  },
  { ""service_id"" : ""A6"",
    ""service_name"" : ""Psychotherapy""
  },
  { ""service_id"" : ""A7"",
    ""service_name"" : ""Psychiatric - Inpatient""
  },
  { ""service_id"" : ""A8"",
    ""service_name"" : ""Psychiatric - Outpatient""
  },
  { ""service_id"" : ""A9"",
    ""service_name"" : ""Rehabilitation""
  },
  { ""service_id"" : ""AA"",
    ""service_name"" : ""Rehabilitation - Room and Board""
  },
  { ""service_id"" : ""AB"",
    ""service_name"" : ""Rehabilitation - Inpatient""
  },
  { ""service_id"" : ""AC"",
    ""service_name"" : ""Rehabilitation - Outpatient""
  },
  { ""service_id"" : ""AD"",
    ""service_name"" : ""Occupational Therapy""
  },
  { ""service_id"" : ""AE"",
    ""service_name"" : ""Physical Medicine""
  },
  { ""service_id"" : ""AF"",
    ""service_name"" : ""Speech Therapy""
  },
  { ""service_id"" : ""AG"",
    ""service_name"" : ""Skilled Nursing Care""
  },
  { ""service_id"" : ""AH"",
    ""service_name"" : ""Skilled Nursing Care - Room and Board""
  },
  { ""service_id"" : ""AI"",
    ""service_name"" : ""Substance Abuse""
  },
  { ""service_id"" : ""AJ"",
    ""service_name"" : ""Alcoholism Treatment""
  },
  { ""service_id"" : ""AK"",
    ""service_name"" : ""Drug Addiction""
  },
  { ""service_id"" : ""AL"",
    ""service_name"" : ""Optometry Vision""
  },
  { ""service_id"" : ""AM"",
    ""service_name"" : ""Frames""
  },
  { ""service_id"" : ""AN"",
    ""service_name"" : ""Routine Exam""
  },
  { ""service_id"" : ""AO"",
    ""service_name"" : ""Lenses""
  },
  { ""service_id"" : ""AP"",
    ""service_name"" : ""Routine Eye Exam""
  },
  { ""service_id"" : ""AQ"",
    ""service_name"" : ""Nonmedically Necessary Physical""
  },
  { ""service_id"" : ""AR"",
    ""service_name"" : ""Experimental Drug Therapy""
  },
  { ""service_id"" : ""B1"",
    ""service_name"" : ""Burn Care""
  },
  { ""service_id"" : ""B2"",
    ""service_name"" : ""Brand Name Prescription Drug - Formulary""
  },
  { ""service_id"" : ""B3"",
    ""service_name"" : ""Brand Name Prescription Drug - Non-Formulary""
  },
  { ""service_id"" : ""BA"",
    ""service_name"" : ""Independent Medical Evaluation""
  },
  { ""service_id"" : ""BB"",
    ""service_name"" : ""Psychiatric Treatment Partial Hospitalization""
  },
  { ""service_id"" : ""BC"",
    ""service_name"" : ""Day Care (Psychiatric)""
  },
  { ""service_id"" : ""BD"",
    ""service_name"" : ""Cognitive Therapy""
  },
  { ""service_id"" : ""BE"",
    ""service_name"" : ""Massage Therapy""
  },
  { ""service_id"" : ""BF"",
    ""service_name"" : ""Pulmonary Rehabilitation""
  },
  { ""service_id"" : ""BG"",
    ""service_name"" : ""Cardiac Rehabilitation""
  },
  { ""service_id"" : ""BH"",
    ""service_name"" : ""Pediatric""
  },
  { ""service_id"" : ""BI"",
    ""service_name"" : ""Nursery Room and Board""
  },
  { ""service_id"" : ""BJ"",
    ""service_name"" : ""Skin""
  },
  { ""service_id"" : ""BK"",
    ""service_name"" : ""Orthopedic""
  },
  { ""service_id"" : ""BL"",
    ""service_name"" : ""Cardiac""
  },
  { ""service_id"" : ""BM"",
    ""service_name"" : ""Lymphatic""
  },
  { ""service_id"" : ""BN"",
    ""service_name"" : ""Gastrointestinal""
  },
  { ""service_id"" : ""BP"",
    ""service_name"" : ""Endocrine""
  },
  { ""service_id"" : ""BQ"",
    ""service_name"" : ""Neurology""
  },
  { ""service_id"" : ""BR"",
    ""service_name"" : ""Eye""
  },
  { ""service_id"" : ""BS"",
    ""service_name"" : ""Invasive Procedures""
  },
  { ""service_id"" : ""BT"",
    ""service_name"" : ""Gynecological""
  },
  { ""service_id"" : ""BU"",
    ""service_name"" : ""Obstetrical""
  },
  { ""service_id"" : ""BV"",
    ""service_name"" : ""Obstetrical/Gynecological""
  },
  { ""service_id"" : ""BW"",
    ""service_name"" : ""Mail Order Prescription Drug: Brand Name""
  },
  { ""service_id"" : ""BX"",
    ""service_name"" : ""Mail Order Prescription Drug: Generic""
  },
  { ""service_id"" : ""BY"",
    ""service_name"" : ""Physician Visit - Sick""
  },
  { ""service_id"" : ""BZ"",
    ""service_name"" : ""Physician Visit - Well""
  },
  { ""service_id"" : ""C1"",
    ""service_name"" : ""Coronary Care""
  },
  { ""service_id"" : ""CA"",
    ""service_name"" : ""Private Duty Nursing - Inpatient""
  },
  { ""service_id"" : ""CB"",
    ""service_name"" : ""Private Duty Nursing - Home""
  },
  { ""service_id"" : ""CC"",
    ""service_name"" : ""Surgical Benefits - Professional (Physician)""
  },
  { ""service_id"" : ""CD"",
    ""service_name"" : ""Surgical Benefits - Facility""
  },
  { ""service_id"" : ""CE"",
    ""service_name"" : ""Mental Health Provider - Inpatient""
  },
  { ""service_id"" : ""CF"",
    ""service_name"" : ""Mental Health Provider - Outpatient""
  },
  { ""service_id"" : ""CG"",
    ""service_name"" : ""Mental Health Facility - Inpatient""
  },
  { ""service_id"" : ""CH"",
    ""service_name"" : ""Mental Health Facility - Outpatient""
  },
  { ""service_id"" : ""CI"",
    ""service_name"" : ""Substance Abuse Facility - Inpatient""
  },
  { ""service_id"" : ""CJ"",
    ""service_name"" : ""Substance Abuse Facility - Outpatient""
  },
  { ""service_id"" : ""CK"",
    ""service_name"" : ""Screening X-ray""
  },
  { ""service_id"" : ""CL"",
    ""service_name"" : ""Screening laboratory""
  },
  { ""service_id"" : ""CM"",
    ""service_name"" : ""Mammogram, High Risk Patient""
  },
  { ""service_id"" : ""CN"",
    ""service_name"" : ""Mammogram, Low Risk Patient""
  },
  { ""service_id"" : ""CO"",
    ""service_name"" : ""Flu Vaccination""
  },
  { ""service_id"" : ""CP"",
    ""service_name"" : ""Eyewear Accessories""
  },
  { ""service_id"" : ""CQ"",
    ""service_name"" : ""Case Management""
  },
  { ""service_id"" : ""DG"",
    ""service_name"" : ""Dermatology""
  },
  { ""service_id"" : ""DM"",
    ""service_name"" : ""Durable Medical Equipment""
  },
  { ""service_id"" : ""DS"",
    ""service_name"" : ""Diabetic Supplies""
  },
  { ""service_id"" : ""GF"",
    ""service_name"" : ""Generic Prescription Drug - Formulary""
  },
  { ""service_id"" : ""GN"",
    ""service_name"" : ""Generic Prescription Drug - Non-Formulary""
  },
  { ""service_id"" : ""GY"",
    ""service_name"" : ""Allergy""
  },
  { ""service_id"" : ""IC"",
    ""service_name"" : ""Intensive Care""
  },
  { ""service_id"" : ""MH"",
    ""service_name"" : ""Mental Health""
  },
  { ""service_id"" : ""NI"",
    ""service_name"" : ""Neonatal Intensive Care""
  },
  { ""service_id"" : ""ON"",
    ""service_name"" : ""Oncology""
  },
  { ""service_id"" : ""PT"",
    ""service_name"" : ""Physical Therapy""
  },
  { ""service_id"" : ""PU"",
    ""service_name"" : ""Pulmonary""
  },
  { ""service_id"" : ""RN"",
    ""service_name"" : ""Renal""
  },
  { ""service_id"" : ""RT"",
    ""service_name"" : ""Residential Psychiatric treatment""
  },
  { ""service_id"" : ""TC"",
    ""service_name"" : ""Transitional Care""
  },
  { ""service_id"" : ""TN"",
    ""service_name"" : ""Transitional Nursery Care""
  },
  { ""service_id"" : ""UC"",
    ""service_name"" : ""Urgent Care""
  },
  { ""service_id"" : ""E0"",
    ""service_name"" : ""Allied Behavioral Analysis Therapy""
  },
  { ""service_id"" : ""E1"",
    ""service_name"" : ""Non-Medical Equipment (non DME)""
  },
  { ""service_id"" : ""E2"",
    ""service_name"" : ""Psychiatric Emergency""
  },
  { ""service_id"" : ""E3"",
    ""service_name"" : ""Step Down Unit""
  },
  { ""service_id"" : ""E4"",
    ""service_name"" : ""Skilled Nursing Facility Head Level of Care""
  },
  { ""service_id"" : ""E5"",
    ""service_name"" : ""Skilled Nursing Facility Ventilator Level of Care""
  },
  { ""service_id"" : ""E6"",
    ""service_name"" : ""Level of Care 1""
  },
  { ""service_id"" : ""E7"",
    ""service_name"" : ""Level of Care 2""
  },
  { ""service_id"" : ""E8"",
    ""service_name"" : ""Level of Care 3""
  },
  { ""service_id"" : ""E9"",
    ""service_name"" : ""Level of Care 4""
  },
  { ""service_id"" : ""E10"",
    ""service_name"" : ""Radiographs""
  },
  { ""service_id"" : ""E11"",
    ""service_name"" : ""Diagnostic Imaging""
  },
  { ""service_id"" : ""E12"",
    ""service_name"" : ""Basic Restorative - Dental""
  },
  { ""service_id"" : ""E13"",
    ""service_name"" : ""Major Restorative - Dental""
  },
  { ""service_id"" : ""E14"",
    ""service_name"" : ""Fixed Prosthodontics""
  },
  { ""service_id"" : ""E15"",
    ""service_name"" : ""Removable Prosthodontics""
  },
  { ""service_id"" : ""E16"",
    ""service_name"" : ""Intraoral Images - Complete Series""
  }
]";
        #endregion Services

        #region Providers

        /// <summary>
        /// Returns the collection of providers for Eligible
        /// </summary>
        /// <returns></returns>
        public static List<EligibleProviderType> GetProviders()
        {
            return JsonConvert.DeserializeObject<List<EligibleProviderType>>(PROVIDER_JSON);

        } // GetProviders

        private static string PROVIDER_JSON = @"[ { ""payer_id"" : ""WCOHP"",
    ""payer_name"" : ""Ohana Health Plan (WellCare of Hawaii) OHANA HEALTH PLAN""
  },
  { ""payer_id"" : ""AARP"",
    ""payer_name"" : ""AARP AARP HEALTH PLAN ""
  },
  { ""payer_id"" : ""258"",
    ""payer_name"" : ""AFTRA Health Fund AFTRA HEALTH FUND ""
  },
  { ""payer_id"" : ""ASINC"",
    ""payer_name"" : ""Administrative Services Inc. ADMINISTRATIVE SERVICES ""
  },
  { ""payer_id"" : ""453"",
    ""payer_name"" : ""Advantra Freedom ADVANTRA FREEDOM ""
  },
  { ""payer_id"" : ""456"",
    ""payer_name"" : ""Advantra Savings COVENTRY ADVANTRA SAVINGS""
  },
  { ""payer_id"" : ""2"",
    ""payer_name"" : ""Aetna AETNA ""
  },
  { ""payer_id"" : ""00225"",
    ""payer_name"" : ""Aetna Long Term Care AETNA LONG TERM CARE ""
  },
  { ""payer_id"" : ""ABSYS"",
    ""payer_name"" : ""Allied Benefit Services Inc. ALLIED BENEFIT SERVICES INC""
  },
  { ""payer_id"" : ""00091"",
    ""payer_name"" : ""AmeriChoice of New Jersey AMERICHOICE OF NJ ""
  },
  { ""payer_id"" : ""AHMHP"",
    ""payer_name"" : ""AmeriHealth Mercy Health Plan AMERIHEALTH MERCY ""
  },
  { ""payer_id"" : ""AMFAM"",
    ""payer_name"" : ""American Family Insurance Group - Medicare Supplemental and PPO Policies AMERICAN FAMILY INSURANCE GROUP""
  },
  { ""payer_id"" : ""AFLAC"",
    ""payer_name"" : ""American Family Life Assurance Co. (AFLAC) AFLAC-DENTAL""
  },
  { ""payer_id"" : ""00237"",
    ""payer_name"" : ""American General Life & Accident AMC AMERICAN GENERAL ""
  },
  { ""payer_id"" : ""ANICO"",
    ""payer_name"" : ""American National Insurance Company AMERICAN NATIONAL INSURANCE ""
  },
  { ""payer_id"" : ""ANTEX"",
    ""payer_name"" : ""American National Life Insurance Company of Texas AMERICAN NATIONAL LIFE INS TX ""
  },
  { ""payer_id"" : ""224"",
    ""payer_name"" : ""American Republic Insurance AMERICAN REPUBLIC INS ""
  },
  { ""payer_id"" : ""AMGRP"",
    ""payer_name"" : ""Amerigroup Corporation AMERIGROUP ""
  },
  { ""payer_id"" : ""425"",
    ""payer_name"" : ""Ameritas Life Insurance Company AMERITAS LIFE ""
  },
  { ""payer_id"" : ""ANTAR"",
    ""payer_name"" : ""Antares Management Solutions ANTARES ""
  },
  { ""payer_id"" : ""252"",
    ""payer_name"" : ""Assurant Health ASSURANT HEALTH ""
  },
  { ""payer_id"" : ""00361"",
    ""payer_name"" : ""Blue Shield of California BLUE SHIELD OF CALIFORNIA""
  },
  { ""payer_id"" : ""257"",
    ""payer_name"" : ""Best Life and Health BEST LIFE AND HEALTH ""
  },
  { ""payer_id"" : ""BCHSC"",
    ""payer_name"" : ""BlueChoice HealthPlan of South Carolina Medicaid (HMO) BLUECHOICE HEALPLAN SC MEDICAID ""
  },
  { ""payer_id"" : ""BFHLT"",
    ""payer_name"" : ""Bluegrass Family Health BLUEGRASS FAMILY HEALTH ""
  },
  { ""payer_id"" : ""ELDER"",
    ""payer_name"" : ""Bravo Health Inc. BRAVO HEALTH ""
  },
  { ""payer_id"" : ""232"",
    ""payer_name"" : ""CHAMPVA - HAC DEPT of VA HEALTH ADMIN CENTER""
  },
  { ""payer_id"" : ""512"",
    ""payer_name"" : ""CHC Florida/VISTA/Summit CHC FLORIDA/VISTA/SUMMIT ""
  },
  { ""payer_id"" : ""1"",
    ""payer_name"" : ""CIGNA CIGNA ""
  },
  { ""payer_id"" : ""1"",
    ""payer_name"" : ""CIGNA HealthCare CIGNA""
  },
  { ""payer_id"" : ""1"",
    ""payer_name"" : ""CIGNA HealthCare - HMO CIGNA""
  },
  { ""payer_id"" : ""1"",
    ""payer_name"" : ""CIGNA HealthCare - PPO CIGNA""
  },
  { ""payer_id"" : ""324"",
    ""payer_name"" : ""CarePlus Health Plan CAREPLUS HEALTH PLAN ""
  },
  { ""payer_id"" : ""160"",
    ""payer_name"" : ""Carelink Advantra CHC CARELINK (ADVANTRA)""
  },
  { ""payer_id"" : ""160"",
    ""payer_name"" : ""Carelink Health Plan CHC CARELINK (ADVANTRA)""
  },
  { ""payer_id"" : ""182"",
    ""payer_name"" : ""Carelink Medicaid CHC CARELINK MEDICAID ""
  },
  { ""payer_id"" : ""190"",
    ""payer_name"" : ""Carenet COVENTRY HEALTH CARE CARENET ""
  },
  { ""payer_id"" : ""CELTI"",
    ""payer_name"" : ""CeltiCare CELTICARE ""
  },
  { ""payer_id"" : ""CBHKY"",
    ""payer_name"" : ""Cenpatico - Kentucky CENPATICO - KENTUCKY ""
  },
  { ""payer_id"" : ""CBHMA"",
    ""payer_name"" : ""Cenpatico - Massachusetts CENPATICO - MASSACHUSETTS ""
  },
  { ""payer_id"" : ""CBHMA"",
    ""payer_name"" : ""Cenpatico Behavioral Health CENPATICO - MASSACHUSETTS ""
  },
  { ""payer_id"" : ""CBNIN"",
    ""payer_name"" : ""Cenpatico Behavioral Health (Indiana) CENPATICO - INDIANA ""
  },
  { ""payer_id"" : ""CBNIN"",
    ""payer_name"" : ""Cenpatico-Indiana CENPATICO - INDIANA ""
  },
  { ""payer_id"" : ""CTRSV"",
    ""payer_name"" : ""Central Reserve Insurance Company (Non-Medicare Supplement) CENTRAL RESERVE ""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Central SeniorCare TEXANPLUS SOUTHEAST TEXAS AREA""
  },
  { ""payer_id"" : ""CSFND"",
    ""payer_name"" : ""Central States Funds CENTRAL STATES FUND ""
  },
  { ""payer_id"" : ""207"",
    ""payer_name"" : ""Chesapeake National Life Insurance (HealthMarkets) CHESAPEAKE NATIONAL LIFE ""
  },
  { ""payer_id"" : ""232"",
    ""payer_name"" : ""Children of Women Vietnam Veterans-VA HAC DEPT OF VA HEALTH ADMIN CENTER ""
  },
  { ""payer_id"" : ""143"",
    ""payer_name"" : ""Christian Brothers Services PRINCIPAL LIFE INSURANCE COMPANY""
  },
  { ""payer_id"" : ""STRHG"",
    ""payer_name"" : ""Cigna Voluntary Limited Medical (aka Cigna Voluntary) CIGNA""
  },
  { ""payer_id"" : ""1"",
    ""payer_name"" : ""Connecticut General CIGNA ""
  },
  { ""payer_id"" : ""CTLGN"",
    ""payer_name"" : ""Continental General Insurance Company (Non-Medicare Supplement) CONTINENTAL GENERAL ""
  },
  { ""payer_id"" : ""223"",
    ""payer_name"" : ""Cooperative Benefit Administrators COOPERATIVE BENEFIT ADMINISTRATORS ""
  },
  { ""payer_id"" : ""236"",
    ""payer_name"" : ""Coresource - Maryland Pennsylvania & Illinois CORESOURCE-MD\\PA\\AND IL (Includes NC and IN.) ""
  },
  { ""payer_id"" : ""239"",
    ""payer_name"" : ""Coresource - Ohio CORESOURCE-OH ""
  },
  { ""payer_id"" : ""205"",
    ""payer_name"" : ""Coresource Little Rock CORESOURCE-LITTLE ROCK ""
  },
  { ""payer_id"" : ""504"",
    ""payer_name"" : ""Coventry Advantra (Texas New Mexico Arizona) ADVANTRA (TEXAS\\NEW MEXICO\\ARIZONA ONLY)""
  },
  { ""payer_id"" : ""509"",
    ""payer_name"" : ""Coventry Health Care Federal COVENTRY HEALTH CARE FEDERAL ""
  },
  { ""payer_id"" : ""166"",
    ""payer_name"" : ""Coventry Health Care of Delaware Inc. CHC OF DELAWARE ""
  },
  { ""payer_id"" : ""154"",
    ""payer_name"" : ""Coventry Health Care of Georgia Inc. CHC OF GEORGIA ""
  },
  { ""payer_id"" : ""170"",
    ""payer_name"" : ""Coventry Health Care of Iowa Inc. CHC OF IOWA ""
  },
  { ""payer_id"" : ""172"",
    ""payer_name"" : ""Coventry Health Care of Kansas Inc. CHC OF KANSAS ""
  },
  { ""payer_id"" : ""158"",
    ""payer_name"" : ""Coventry Health Care of Louisiana Inc. CHC OF LOUISIANA ""
  },
  { ""payer_id"" : ""176"",
    ""payer_name"" : ""Coventry Health Care of Nebraska Inc. CHC OF NEBRASKA ""
  },
  { ""payer_id"" : ""441"",
    ""payer_name"" : ""Coventry Health and Life (Oklahoma) COVENTRY HEALTH AND LIFE (OK ONLY) ""
  },
  { ""payer_id"" : ""455"",
    ""payer_name"" : ""Coventry Health and Life (Tennessee Only) COVENTRY HEALTH AND LIFE (TN ONLY) ""
  },
  { ""payer_id"" : ""505"",
    ""payer_name"" : ""Coventry Health and Life-Nevada COVENTRY HEALTH AND LIFE_NEVADA ""
  },
  { ""payer_id"" : ""250"",
    ""payer_name"" : ""Coventry Healthcare National Network COVENTRY HEALTHCARE NATIONAL NETWORK ""
  },
  { ""payer_id"" : ""507"",
    ""payer_name"" : ""Coventry-Missouri COVENTRY MISSOURI ""
  },
  { ""payer_id"" : ""510"",
    ""payer_name"" : ""CoventryCares COVENTRYCARES ""
  },
  { ""payer_id"" : ""COVON"",
    ""payer_name"" : ""CoventryOne COVENTRYONE ""
  },
  { ""payer_id"" : ""177"",
    ""payer_name"" : ""Diamond Plan DIAMOND PLAN ""
  },
  { ""payer_id"" : ""259"",
    ""payer_name"" : ""Directors Guild of America - Producers DIRECTOR’S GUILD""
  },
  { ""payer_id"" : ""1"",
    ""payer_name"" : ""EQUICORE CIGNA""
  },
  { ""payer_id"" : ""1"",
    ""payer_name"" : ""EQUICORE - PPO CIGNA""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""Evercare UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""272"",
    ""payer_name"" : ""Fallon Health Plan FALLON HEALTH PLAN ""
  },
  { ""payer_id"" : ""262"",
    ""payer_name"" : ""Federated Insurance Company FEDERATED INSURANCE COMPANY ""
  },
  { ""payer_id"" : ""426"",
    ""payer_name"" : ""First Ameritas of New York FIRST AMERITAS OF NEW YORK ""
  },
  { ""payer_id"" : ""253"",
    ""payer_name"" : ""Fortis Benefits Insurance Company ASSURANT HEALTH-UNION SECURITY""
  },
  { ""payer_id"" : ""252"",
    ""payer_name"" : ""Fortis Life Insurance Company ASSURANT HEALTH-TIME INSURANCE""
  },
  { ""payer_id"" : ""FRSMC"",
    ""payer_name"" : ""Fresenius Medical Care FRESENIUS MEDICAL CARE ""
  },
  { ""payer_id"" : ""GENHC"",
    ""payer_name"" : ""Generations Healthcare GENERATIONS HEALTHCARE ""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Golden Triangle Physician Alliance/SelectCare of Texas (GTPA) GTPA""
  },
  { ""payer_id"" : ""GEHA"",
    ""payer_name"" : ""Government Employees Hospital Association GOVERNMENT EMPLOYEES HOSPITAL ASSOC ""
  },
  { ""payer_id"" : ""328"",
    ""payer_name"" : ""Great-West Healthcare GREAT WEST HEALTHCARE ""
  },
  { ""payer_id"" : ""184"",
    ""payer_name"" : ""Group Health Plan - CMR GROUP HEALTH PLAN (GHP) ""
  },
  { ""payer_id"" : ""THEXI"",
    ""payer_name"" : ""HEALTHe Exchange HEALTHE EXCHANGE ""
  },
  { ""payer_id"" : ""HIPNY"",
    ""payer_name"" : ""HIPNY HEALTH PLAN OF NEW YORK""
  },
  { ""payer_id"" : ""WCHHP"",
    ""payer_name"" : ""Harmony Health Plan (WellCare of Florida) HARMONY HEALTH PLAN ""
  },
  { ""payer_id"" : ""HPHC"",
    ""payer_name"" : ""Harvard Pilgrim HealthCare HAVARD PILGRIM HEALTHCARE""
  },
  { ""payer_id"" : ""43"",
    ""payer_name"" : ""Health 123/Tripoint/Vanderbilt Health Plan VANDERBILT""
  },
  { ""payer_id"" : ""HAPMC"",
    ""payer_name"" : ""Health Alliance Plan HEALTH ALLIANCE ""
  },
  { ""payer_id"" : ""148"",
    ""payer_name"" : ""Health America Inc./Health Assurance/Advantra HEALTHAMERICA AND HEALTHASSURANCE""
  },
  { ""payer_id"" : ""246"",
    ""payer_name"" : ""Health Future LLC. AMC HEALTH FUTURE ""
  },
  { ""payer_id"" : ""HNNC"",
    ""payer_name"" : ""Health Net National HEALTH NET""
  },
  { ""payer_id"" : ""213"",
    ""payer_name"" : ""Health Net of Arizona HEALTH NET""
  },
  { ""payer_id"" : ""213"",
    ""payer_name"" : ""Health Net of the Northeast Inc. HEALTH NET""
  },
  { ""payer_id"" : ""288"",
    ""payer_name"" : ""Health Partners of Philadelphia HEALTH PARTNERS OF PHILADELPHIA""
  },
  { ""payer_id"" : ""AMTPA"",
    ""payer_name"" : ""HealthEZ HEALTHEZ""
  },
  { ""payer_id"" : ""WCHEA"",
    ""payer_name"" : ""HealthEase (WellCare of Florida) HEALTHEASE ""
  },
  { ""payer_id"" : ""WCHEK"",
    ""payer_name"" : ""HealthEase Kids (WellCare of Florida) HEALTHEASE KIDS ""
  },
  { ""payer_id"" : ""HLTPM"",
    ""payer_name"" : ""HealthPlus of Michigan HEALTHPLUS OF MICHIGAN ""
  },
  { ""payer_id"" : ""HSBS"",
    ""payer_name"" : ""HealthSmart Benefit Solutions HEALTHSMART BENEFIT SOLUTIONS ""
  },
  { ""payer_id"" : ""186"",
    ""payer_name"" : ""Healthcare USA HEALTHCARE USA (HCUSA)""
  },
  { ""payer_id"" : ""HFNJ"",
    ""payer_name"" : ""Healthfirst of New Jersey HEALTHFIRST OF NEW JERSEY""
  },
  { ""payer_id"" : ""240"",
    ""payer_name"" : ""Healthfirst of New York HEALTHFIRST OF NEW YORK""
  },
  { ""payer_id"" : ""HNJH"",
    ""payer_name"" : ""Horizon New Jersey Health HORIZON NJ HEALTH ""
  },
  { ""payer_id"" : ""HUMANA"",
    ""payer_name"" : ""Humana HUMANA ""
  },
  { ""payer_id"" : ""143"",
    ""payer_name"" : ""J. F. Molloy and Associates Inc. PRINCIPAL LIFE INSURANCE COMPANY""
  },
  { ""payer_id"" : ""254"",
    ""payer_name"" : ""John Alden Life Insurance Company (Assurant Health) ASSURANT HEALTH-JOHN ALDEN LIFE ""
  },
  { ""payer_id"" : ""277"",
    ""payer_name"" : ""Kaiser Foundation Health Plan of Colorado KAISER FOUNDATION HEALTH PLAN OF CO ""
  },
  { ""payer_id"" : ""281"",
    ""payer_name"" : ""Kaiser Foundation Health Plan of Georgia KAISER PERMANENTE OF GEORGIA ""
  },
  { ""payer_id"" : ""282"",
    ""payer_name"" : ""Kaiser Foundation Health Plan of Northern CA Region KAISER PERMANENTE OF NORTH CA ""
  },
  { ""payer_id"" : ""280"",
    ""payer_name"" : ""Kaiser Foundation Health Plan of Ohio KAISER FOUNDATION HEALTH PLAN OF OH ""
  },
  { ""payer_id"" : ""283"",
    ""payer_name"" : ""Kaiser Foundation Health Plan of Southern CA Region KAISER PERMANENTE OF SOUTH CA ""
  },
  { ""payer_id"" : ""276"",
    ""payer_name"" : ""Kaiser Foundation Health Plan of the Mid-Atlantic States Inc. KAISER FOUNDATION HP MID ATLANTIC""
  },
  { ""payer_id"" : ""279"",
    ""payer_name"" : ""Kaiser Foundation Health Plan of the Northwest KAISER FOUNDATION HEALTH PLAN OF NW ""
  },
  { ""payer_id"" : ""278"",
    ""payer_name"" : ""Kaiser Foundation Health Plan Inc. - Hawaii Region KAISER FOUNDATION HEALTH PLAN OF HI ""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Katy Medical Group TEXANPLUS SOUTHEAST TEXAS AREA""
  },
  { ""payer_id"" : ""CKYHP"",
    ""payer_name"" : ""Kentucky Spirit Health Plan KENTUCKY SPIRIT HEALTH PLAN ""
  },
  { ""payer_id"" : ""KEYIN"",
    ""payer_name"" : ""Key Benefit Administrators - Indianapolis KEY BENEFIT ADMINISTRATORS""
  },
  { ""payer_id"" : ""KYMHP"",
    ""payer_name"" : ""Keystone Mercy Health Plan KEYSTONE MERCY HEALTH PLAN""
  },
  { ""payer_id"" : ""MDWHA"",
    ""payer_name"" : ""MDWise Hoosier Alliance MDWISE HOOSIER ALLIANCE""
  },
  { ""payer_id"" : ""514"",
    ""payer_name"" : ""MHNet Behavioral Health MHNet BEHAVIORAL HEALTH ""
  },
  { ""payer_id"" : ""00514"",
    ""payer_name"" : ""MHNet Behavioral Health MHNet BEHAVIORAL HEALTH ""
  },
  { ""payer_id"" : ""85"",
    ""payer_name"" : ""MMSI MMSI MAYO HEALTH ""
  },
  { ""payer_id"" : ""432"",
    ""payer_name"" : ""MVP Health Plan of NY MVP HEALTH CARE NY""
  },
  { ""payer_id"" : ""251"",
    ""payer_name"" : ""Mail Handlers Benefit Plan MAIL HANDLERS BENEFIT PLAN ""
  },
  { ""payer_id"" : ""CMHIN"",
    ""payer_name"" : ""Managed Health Services Indiana MANAGED HEALTH SERVICES INDIANA ""
  },
  { ""payer_id"" : ""MCAA"",
    ""payer_name"" : ""Maricopa Care Advantage (Arizona) MARICOPA CARE ADVANTAGE (ARIZONA) ""
  },
  { ""payer_id"" : ""MHPA"",
    ""payer_name"" : ""Maricopa Health Plan (Arizona) MARICOPA HEALTH PLAN (ARIZONA) ""
  },
  { ""payer_id"" : ""404"",
    ""payer_name"" : ""Medica MEDICA""
  },
  { ""payer_id"" : ""211"",
    ""payer_name"" : ""Medical Mutual of Ohio MEDICAL MUTUAL OF OHIO ""
  },
  { ""payer_id"" : ""365"",
    ""payer_name"" : ""Mega Life - Oklahoma City MEGALIFE - OKC""
  },
  { ""payer_id"" : ""248"",
    ""payer_name"" : ""Mega Life and Health Insurance Company (HealthMarkets) MEGA LIFE AND HEALTH""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Memorial Clinical Associates/SelectCare of Texas (MCA) TEXANPLUS SOUTHEAST TEXAS AREA""
  },
  { ""payer_id"" : ""206"",
    ""payer_name"" : ""Mid-West National Life Insurance (HealthMarkets) MID WEST NATIONAL LIFE INSURANCE ""
  },
  { ""payer_id"" : ""222"",
    ""payer_name"" : ""Molina Healthcare of California MOLINA HEALTHCARE OF CALIFORNIA ""
  },
  { ""payer_id"" : ""506"",
    ""payer_name"" : ""Molina Healthcare of Florida MOLINA HEALTHCARE OF FLORIDA ""
  },
  { ""payer_id"" : ""226"",
    ""payer_name"" : ""Molina Healthcare of Michigan MOLINA HEALTHCARE OF MICHIGAN ""
  },
  { ""payer_id"" : ""513"",
    ""payer_name"" : ""Molina Healthcare of Missouri MOLINA HEALTHCARE OF MISSOURI ""
  },
  { ""payer_id"" : ""445"",
    ""payer_name"" : ""Molina Healthcare of Ohio MOLINA HEALTHCARE OF OHIO""
  },
  { ""payer_id"" : ""451"",
    ""payer_name"" : ""Molina Healthcare of Texas MOLINA HEALTHCARE OF TEXAS ""
  },
  { ""payer_id"" : ""227"",
    ""payer_name"" : ""Molina Healthcare of Utah MOLINA HEALTHCARE OF UTAH""
  },
  { ""payer_id"" : ""228"",
    ""payer_name"" : ""Molina Healthcare of Washington MOLINA HEALTHCARE OF WASHINGTON ""
  },
  { ""payer_id"" : ""MOONE"",
    ""payer_name"" : ""Mutual of Omaha MUTUAL OF OMAHA ""
  },
  { ""payer_id"" : ""214"",
    ""payer_name"" : ""National Association of Letter Carriers NALC ""
  },
  { ""payer_id"" : ""86"",
    ""payer_name"" : ""Nationwide Specialty Health aka Nationwide Health Plan NATIONWIDE ""
  },
  { ""payer_id"" : ""NIPON"",
    ""payer_name"" : ""Nippon Life Benefits NIPPON LIFE BENEFITS ""
  },
  { ""payer_id"" : ""144"",
    ""payer_name"" : ""Nippon Life Insurance Company of America NIPPON LIFE INSURANCE CO OF AMERICA ""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Northwest Diagnostic Clinic/SelectCare of Texas (NWDC) NWDC""
  },
  { ""payer_id"" : ""NOVAS"",
    ""payer_name"" : ""Novasys Health NOVASYS HEALTH ""
  },
  { ""payer_id"" : ""284"",
    ""payer_name"" : ""Omnicare Health Plan of Michigan OMNICARE (MICHIGAN) ""
  },
  { ""payer_id"" : ""16"",
    ""payer_name"" : ""Oxford Health Plans OXFORD HEALTH PLANS""
  },
  { ""payer_id"" : ""PHCSS"",
    ""payer_name"" : ""PHCS Savility Payers PHCS SAVILITY PAYERS ""
  },
  { ""payer_id"" : ""10"",
    ""payer_name"" : ""PacifiCare of California PACIFICARE OF CALIFORNIA ""
  },
  { ""payer_id"" : ""35"",
    ""payer_name"" : ""PacifiCare of Oklahoma PACIFICARE OF OKLAHOMA ""
  },
  { ""payer_id"" : ""34"",
    ""payer_name"" : ""PacifiCare of Oregon PACIFICARE OF OREGON ""
  },
  { ""payer_id"" : ""36"",
    ""payer_name"" : ""PacifiCare of Texas PACIFICARE OF TEXAS ""
  },
  { ""payer_id"" : ""49"",
    ""payer_name"" : ""PacifiCare of Washington PACIFICARE OF WASHINGTON ""
  },
  { ""payer_id"" : ""PPADV"",
    ""payer_name"" : ""Passport Advantage PASSPORT ADVANTAGE ""
  },
  { ""payer_id"" : ""PPHPC"",
    ""payer_name"" : ""Passport Health Plan PASSPORT HEALTH PLAN ""
  },
  { ""payer_id"" : ""PIANC"",
    ""payer_name"" : ""Personal Insurance Administrators (PIA) PERSONAL INSURANCE ADMIN""
  },
  { ""payer_id"" : ""179"",
    ""payer_name"" : ""PersonalCare/Coventry Health of Illinois PERSONALCARE/COVENTRY HEALTH OF ILLINOIS""
  },
  { ""payer_id"" : ""287"",
    ""payer_name"" : ""Physicians Mutual PHYSICIANS MUTUAL""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Pinnacle Physician Management Org TEXANPLUS SOUTHEAST TEXAS AREA""
  },
  { ""payer_id"" : ""454"",
    ""payer_name"" : ""Pittman and Associates PITTMAN AND ASSOCIATES""
  },
  { ""payer_id"" : ""244"",
    ""payer_name"" : ""Poly-America Medical & Dental Benefits Plan AMC POLY AMERICA""
  },
  { ""payer_id"" : ""263"",
    ""payer_name"" : ""Preferred Health Systems PERFERRED HEALTH SYSTEMS""
  },
  { ""payer_id"" : ""143"",
    ""payer_name"" : ""Principal Financial Group PRINCIPAL LIFE INSURANCE COMPANY""
  },
  { ""payer_id"" : ""143"",
    ""payer_name"" : ""Principal Life Insurance Company PRINCIPAL LIFE INSURANCE COMPANY""
  },
  { ""payer_id"" : ""PRHTH"",
    ""payer_name"" : ""Priority Health PRIORITY HEALTH""
  },
  { ""payer_id"" : ""193"",
    ""payer_name"" : ""Promina ASO PROMINA ASO""
  },
  { ""payer_id"" : ""QKTRP"",
    ""payer_name"" : ""QuikTrip Corporation QUIKTRIP""
  },
  { ""payer_id"" : ""347"",
    ""payer_name"" : ""Rocky Mountain Health Plan ROCKY MOUNTAIN HEALTH PLAN""
  },
  { ""payer_id"" : ""SAMBA"",
    ""payer_name"" : ""SAMBA Health Benefit Plan SPECIAL AGENTS MUTUAL BENEFIT""
  },
  { ""payer_id"" : ""34"",
    ""payer_name"" : ""Secure Horisons Oregon PACIFICARE OF OREGON""
  },
  { ""payer_id"" : ""10"",
    ""payer_name"" : ""Secure Horizons California PACIFICARE OF CALIFORNIA""
  },
  { ""payer_id"" : ""35"",
    ""payer_name"" : ""Secure Horizons Oklahoma PACIFICARE OF OKLAHOMA""
  },
  { ""payer_id"" : ""36"",
    ""payer_name"" : ""Secure Horizons Texas PACIFICARE OF TEXAS""
  },
  { ""payer_id"" : ""49"",
    ""payer_name"" : ""Secure Horizons Washington PACIFICARE OF WASHINGTON""
  },
  { ""payer_id"" : ""SHSC"",
    ""payer_name"" : ""Select Health of South Carolina SELECT HEALTH OF SOUTH CAROLINA""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Select Senior Clinic TEXANPLUS SOUTHEAST TEXAS AREA""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""SelectCare of Texas (Kelsey-Seybold) TEXANPLUS SOUTHEAST TEXAS AREA""
  },
  { ""payer_id"" : ""191"",
    ""payer_name"" : ""Significa Benefit Services Inc. SIGNIFICA""
  },
  { ""payer_id"" : ""156"",
    ""payer_name"" : ""Southern Health Services Inc. SOUTHERN HEALTH SERVICES (SHS)""
  },
  { ""payer_id"" : ""232"",
    ""payer_name"" : ""Spina Bifida - VA HAC DEPT OF VA HEALTH ADMIN CENTER""
  },
  { ""payer_id"" : ""SLAIC"",
    ""payer_name"" : ""Standard Life and Accident Insurance Company STD LIFE AND ACCIDENT INSURANCE""
  },
  { ""payer_id"" : ""WCSWA"",
    ""payer_name"" : ""StayWell STAYWELL""
  },
  { ""payer_id"" : ""WCSWK"",
    ""payer_name"" : ""StayWell Kids STAYWELL KIDS""
  },
  { ""payer_id"" : ""TXNNT"",
    ""payer_name"" : ""Texan Plus (North Texas Area) TEXANPLUS NORTH TEXAS AREA""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Texan Plus (Southeast Texas Area) TEXANPLUS SOUTHEAST TEXAS AREA""
  },
  { ""payer_id"" : ""TXNNT"",
    ""payer_name"" : ""Texas First Health Plan (TOPA) TEXANPLUS NORTH TEXAS AREA""
  },
  { ""payer_id"" : ""198"",
    ""payer_name"" : ""Three Rivers Health Plans (Unison Health Plan) THREE RIVERS HEALTH PLANS""
  },
  { ""payer_id"" : ""252"",
    ""payer_name"" : ""Time Insurance Company ASSURANT HEALTH-TIME INSURANCE""
  },
  { ""payer_id"" : ""TDHLT"",
    ""payer_name"" : ""Today's Health TODAYS HEALTH""
  },
  { ""payer_id"" : ""TDOPT"",
    ""payer_name"" : ""Today's Options TODAYS OPTIONS""
  },
  { ""payer_id"" : ""78"",
    ""payer_name"" : ""Touchstone Health PSO AMC TOUCHSTONE PSO""
  },
  { ""payer_id"" : ""265"",
    ""payer_name"" : ""Touchstone Health/Health Net SmartChoice AMC TOUCHSTONE""
  },
  { ""payer_id"" : ""208"",
    ""payer_name"" : ""TransAmerica Life Insurance (HealthMarkets) TRANSAMERICA LIFE""
  },
  { ""payer_id"" : ""TSCOK"",
    ""payer_name"" : ""Tribute/SelectCare of Oklahoma TRIBUTE SELECTCARE OF OKLAHOMA""
  },
  { ""payer_id"" : ""80"",
    ""payer_name"" : ""Tricare (CHAMPUS) TRICARE""
  },
  { ""payer_id"" : ""233"",
    ""payer_name"" : ""Trustmark TRUSTMARK""
  },
  { ""payer_id"" : ""114"",
    ""payer_name"" : ""Tufts Health Plan TUFTS""
  },
  { ""payer_id"" : ""USAA"",
    ""payer_name"" : ""USAA Life Insurance Company USAA""
  },
  { ""payer_id"" : ""UNICR"",
    ""payer_name"" : ""UniCare UNICARE""
  },
  { ""payer_id"" : ""UPREH"",
    ""payer_name"" : ""Union Pacific Railroad Employes Health System UNION PACIFIC RAILROAD EMPLOYES HEALTH""
  },
  { ""payer_id"" : ""253"",
    ""payer_name"" : ""Union Security Insurance Company ASSURANT HEALTH-UNION SECURITY""
  },
  { ""payer_id"" : ""199"",
    ""payer_name"" : ""Unison Health Plan / Better Health Plans BETTER HEALTH PLANS""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare Plans of Puerto Rico UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Alabama UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Arizona Inc. UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Arkansas UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of California-Northern California UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of California-Southern California UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Colorado Inc. UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Florida UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Georgia UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Illinois UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Kentucky UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Louisiana UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Mississippi UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of New England UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of New York (includes NY & NJ) UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of North Carolina Inc. UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Ohio UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Tennessee UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Texas - Dallas UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Texas - Houston UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Upstate New York UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Utah UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of Virginia UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of the Midlands - HMO (Choice Select) UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of the Midlands - PPO (Choice Plus Select Plus Self Fund UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of the Midwest-Choice Choice Plus Select Select Plus UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""112"",
    ""payer_name"" : ""UnitedHealthcare of the Midwest-Medicare Complete (f. PHP of Midwest PHP o UNITED HEALTH CARE""
  },
  { ""payer_id"" : ""UPCAA"",
    ""payer_name"" : ""University Physicians Care Advantage (Arizona) UNIVERSITY PHYSICIANS CARE ADV""
  },
  { ""payer_id"" : ""UPHGA"",
    ""payer_name"" : ""University Physicians Healthcare Group (Arizona) UNIVERSITY PHYSICIANS HEALTHCARE GRP""
  },
  { ""payer_id"" : ""COVUM"",
    ""payer_name"" : ""University of Missouri UNIVERSITY OF MISSOURI""
  },
  { ""payer_id"" : ""231"",
    ""payer_name"" : ""VA Fee Basis Programs VA FEE BASIS PROGRAM""
  },
  { ""payer_id"" : ""232"",
    ""payer_name"" : ""VA Health Admin Ctr (CHAMPVA/Spina Bifida/Children of Women Vietnam Vets) DEPT OF VA HEALTH ADMIN CENTER""
  },
  { ""payer_id"" : ""508"",
    ""payer_name"" : ""VISTA (Medicaid Florida Health Kids Long Term Care products only) VISTA (MCD\\FHK\\LTC)""
  },
  { ""payer_id"" : ""43"",
    ""payer_name"" : ""Vanderbilt VANDERBILT""
  },
  { ""payer_id"" : ""VHPLA"",
    ""payer_name"" : ""Vantage Health Plan Inc. VANTAGE HEALTH""
  },
  { ""payer_id"" : ""TXNSE"",
    ""payer_name"" : ""Village Family Practice TEXANPLUS SOUTHEAST TEXAS AREA""
  },
  { ""payer_id"" : ""VYTRA"",
    ""payer_name"" : ""Vytra HEALTH PLAN OF NEW YORK""
  },
  { ""payer_id"" : ""WBTPA"",
    ""payer_name"" : ""WEB-TPA Inc WEB-TPA""
  },
  { ""payer_id"" : ""WCHP"",
    ""payer_name"" : ""WellCare Health Plans (WellCare of FL GA NY CT NJ LA OH TX) WELLCARE HEALTH PLANS""
  },
  { ""payer_id"" : ""164"",
    ""payer_name"" : ""Wellpath WELLPATH SELECT (CAROLINAS)""
  },
  { ""payer_id"" : ""81"",
    ""payer_name"" : ""World Insurance Company WORLD INSURANCE""
  },
  { ""payer_id"" : ""260"",
    ""payer_name"" : ""Writers Guild - Industry Health Plan WRITER’S GUILD""
  },
  { ""payer_id"" : ""39"",
    ""payer_name"" : ""Anthem Blue Cross California BLUE CROSS OF CALIFORNIA""
  },
  { ""payer_id"" : ""423"",
    ""payer_name"" : ""BCBS of Alabama - Medicare Part B BLUE CROSS BLUE SHIELD OF ALABAMA""
  },
  { ""payer_id"" : ""266"",
    ""payer_name"" : ""Blue Cross Blue Shield of Alabama BLUE CROSS BLUE SHIELD OF ALABAMA""
  },
  { ""payer_id"" : ""BCAKC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Alaska (Premera) BCBS ALASKA""
  },
  { ""payer_id"" : ""90"",
    ""payer_name"" : ""Blue Cross Blue Shield of Arizona BLUE CROSS BLUE SHIELD AZ""
  },
  { ""payer_id"" : ""BCARC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Arkansas BLUE CROSS BLUE SHIELD AR""
  },
  { ""payer_id"" : ""BCCOC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Colorado BLUE CROSS BLUE SHIELD CO""
  },
  { ""payer_id"" : ""BCCTC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Connecticut BLUE CROSS BLUE SHIELD CT""
  },
  { ""payer_id"" : ""BCDCC"",
    ""payer_name"" : ""Blue Cross Blue Shield of District of Columbia (CareFirst) BCBS OF DC""
  },
  { ""payer_id"" : ""267"",
    ""payer_name"" : ""Blue Cross Blue Shield of Florida BCBS OF FL""
  },
  { ""payer_id"" : ""151"",
    ""payer_name"" : ""Blue Cross Blue Shield of Georgia BCBS OF GEORGIA""
  },
  { ""payer_id"" : ""268"",
    ""payer_name"" : ""Blue Cross Blue Shield of Illinois BLUE CROSS BLUE SHIELD OF ILLINOIS""
  },
  { ""payer_id"" : ""BCINC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Indiana BLUE CROSS BLUE SHIELD INDIANA""
  },
  { ""payer_id"" : ""BCIAC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Iowa BLUE CROSS BLUE SHEILD IA""
  },
  { ""payer_id"" : ""BCKSC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Kansas BCBS KANSAS""
  },
  { ""payer_id"" : ""BCKCC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Kansas City BCBS KS CITY""
  },
  { ""payer_id"" : ""BCKYC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Kentucky BCBS OF KY""
  },
  { ""payer_id"" : ""83"",
    ""payer_name"" : ""Blue Cross Blue Shield of Louisiana BLUE CROSS BLUE SHIELD LA""
  },
  { ""payer_id"" : ""BCMEC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Maine BLUE CROSS BLUE SHIELD ME""
  },
  { ""payer_id"" : ""BCMDC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Maryland (CareFirst) BCBS OF MD""
  },
  { ""payer_id"" : ""139"",
    ""payer_name"" : ""Blue Cross Blue Shield of Massachusetts BLUE CROSS BLUE SHEILD MA""
  },
  { ""payer_id"" : ""BCMID"",
    ""payer_name"" : ""Blue Cross Blue Shield of Michigan (Dental) BLUE CROSS BLUE SHIELD MI""
  },
  { ""payer_id"" : ""BCMII"",
    ""payer_name"" : ""Blue Cross Blue Shield of Michigan (Institutional) BLUE CROSS BLUE SHIELD MI""
  },
  { ""payer_id"" : ""BCMIP"",
    ""payer_name"" : ""Blue Cross Blue Shield of Michigan (Professional) BLUE CROSS BLUE SHIELD MI""
  },
  { ""payer_id"" : ""269"",
    ""payer_name"" : ""Blue Cross Blue Shield of Minnesota BCBS OF MN""
  },
  { ""payer_id"" : ""75"",
    ""payer_name"" : ""Blue Cross Blue Shield of Mississippi BLUE CROSS BLUE SHIELD MISSISSIPPI""
  },
  { ""payer_id"" : ""BCMOC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Missouri BLUE CROSS BLUE SHIELD MO""
  },
  { ""payer_id"" : ""BCNEC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Nebraska BLUE CROSS BLUE SHIELD OF NEBRASKA""
  },
  { ""payer_id"" : ""BCNVC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Nevada BLUE CROSS BLUE SHIELD NV""
  },
  { ""payer_id"" : ""BCNHC"",
    ""payer_name"" : ""Blue Cross Blue Shield of New Hampshire BLUE CROSS BLUE SHIELD NH""
  },
  { ""payer_id"" : ""270"",
    ""payer_name"" : ""Blue Cross Blue Shield of New Mexico BLUE CROSS BLUE SHIELD NEW MEXICO""
  },
  { ""payer_id"" : ""44"",
    ""payer_name"" : ""Blue Cross Blue Shield of New York (Empire) EMPIRE HEALTH CHOICE ASSURANCE INC""
  },
  { ""payer_id"" : ""BCNCC"",
    ""payer_name"" : ""Blue Cross Blue Shield of North Carolina BCBS NC""
  },
  { ""payer_id"" : ""BCNDC"",
    ""payer_name"" : ""Blue Cross Blue Shield of North Dakota BCBS ND""
  },
  { ""payer_id"" : ""BCOHC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Ohio BLUE CROSS BLUE SHIELD OH""
  },
  { ""payer_id"" : ""BCORC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Oregon (Regence) REGENCE BLUECROSS BLUESHIELD OF OR""
  },
  { ""payer_id"" : ""440"",
    ""payer_name"" : ""Blue Cross Blue Shield of Pennsylvania - Highmark BLUE CROSS BLUE SHIELD PA""
  },
  { ""payer_id"" : ""BCRIC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Rhode Island BLUE CROSS BLUE SHIELD RI""
  },
  { ""payer_id"" : ""BCSCC"",
    ""payer_name"" : ""Blue Cross Blue Shield of South Carolina BCBS SC""
  },
  { ""payer_id"" : ""BCSDC"",
    ""payer_name"" : ""Blue Cross Blue Shield of South Dakota BLUE CROSS BLUE SHEILD SD""
  },
  { ""payer_id"" : ""BCTNC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Tennessee BLUE CROSS BLUE 2100A SHIELD OF TENNESSEE""
  },
  { ""payer_id"" : ""271"",
    ""payer_name"" : ""Blue Cross Blue Shield of Texas BLUE CROSS BLUE SHIELD TEXAS""
  },
  { ""payer_id"" : ""BCVAC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Virginia BLUE CROSS BLUE SHIELD VA""
  },
  { ""payer_id"" : ""BCWIC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Wisconsin (Anthem) BLUE CROSS BLUE SHIELD WI""
  },
  { ""payer_id"" : ""BCWYC"",
    ""payer_name"" : ""Blue Cross Blue Shield of Wyoming BCBS WY""
  },
  { ""payer_id"" : ""BCIDC"",
    ""payer_name"" : ""Blue Cross of Idaho BLUE CROSS IDAHO""
  },
  { ""payer_id"" : ""BCNPC"",
    ""payer_name"" : ""Blue Cross of Northeastern Pennsylvania BCOFNEPA""
  },
  { ""payer_id"" : ""BCWAC"",
    ""payer_name"" : ""Blue Cross of Washington (Premera) BC WASHINGTON""
  },
  { ""payer_id"" : ""BSWAC"",
    ""payer_name"" : ""Blue Shield of Washington (Regence) REGENCE BLUE SHIELD""
  },
  { ""payer_id"" : ""BCCBC"",
    ""payer_name"" : ""Capital Blue Cross (Pennsylvania) CAPITAL BLUE CROSS""
  },
  { ""payer_id"" : ""44"",
    ""payer_name"" : ""Empire Blue Cross and Blue Shield EMPIRE HEALTH CHOICE ASSURANCE INC""
  },
  { ""payer_id"" : ""FRBLU"",
    ""payer_name"" : ""Freedom Blue FREEDOM BLUE""
  },
  { ""payer_id"" : ""87"",
    ""payer_name"" : ""Horizon Blue Cross Blue Shield of New Jersey BLUE CROSS BLUE SHIELD NJ""
  },
  { ""payer_id"" : ""87"",
    ""payer_name"" : ""Horizon Healthcare of NY BLUE CROSS BLUE SHIELD NJ""
  },
  { ""payer_id"" : ""BCIBC"",
    ""payer_name"" : ""Independence Blue Cross INDEPENDENCE BLUE CROSS""
  },
  { ""payer_id"" : ""82"",
    ""payer_name"" : ""Mississippi State Employees and Teachers Health Plan MS SEHP""
  },
  { ""payer_id"" : ""MTNST"",
    ""payer_name"" : ""Mountain State MOUNTAIN STATE""
  },
  { ""payer_id"" : ""44"",
    ""payer_name"" : ""Wellchoice of NJ EMPIRE HEALTH CHOICE ASSURANCE INC""
  },
  { ""payer_id"" : ""CTOTL"",
    ""payer_name"" : ""Absolute Total Care ABSOLUTE TOTAL CARE""
  },
  { ""payer_id"" : ""AFNTY"",
    ""payer_name"" : ""Affinity Health Plan AFFINITY HEALTH PLAN""
  },
  { ""payer_id"" : ""72"",
    ""payer_name"" : ""Alabama Medicaid ALABAMA MEDICAID""
  },
  { ""payer_id"" : ""AID40"",
    ""payer_name"" : ""Alabama Medicaid ALABAMA MEDICAID""
  },
  { ""payer_id"" : ""69"",
    ""payer_name"" : ""Arizona Medicaid AZ MEDICAID""
  },
  { ""payer_id"" : ""AID37"",
    ""payer_name"" : ""Arizona Medicaid AZ MEDICAID""
  },
  { ""payer_id"" : ""54"",
    ""payer_name"" : ""Arkansas Medicaid ARKANSAS MEDICAID""
  },
  { ""payer_id"" : ""AID26"",
    ""payer_name"" : ""Arkansas Medicaid ARKANSAS MEDICAID""
  },
  { ""payer_id"" : ""403"",
    ""payer_name"" : ""Blue Choice Medicaid Managed Care MI MICHILD""
  },
  { ""payer_id"" : ""CBRID"",
    ""payer_name"" : ""Bridgeway Arizona Eligibility Host BRIDGEWAY ARIZONA""
  },
  { ""payer_id"" : ""CBUCK"",
    ""payer_name"" : ""Buckeye Community Health BUCKEYE COMMUNITY HEALTH""
  },
  { ""payer_id"" : ""25"",
    ""payer_name"" : ""California Medicaid CA MEDICAID""
  },
  { ""payer_id"" : ""AID11"",
    ""payer_name"" : ""California Medicaid - Medi-Cal CA MEDICAID""
  },
  { ""payer_id"" : ""CBHGA"",
    ""payer_name"" : ""Cenpatico Behavioral Health CENPATICO - GEORGIA""
  },
  { ""payer_id"" : ""CBHAZ"",
    ""payer_name"" : ""Cenpatico Behavioral Health (Arizona) CENPATICO - ARIZONA""
  },
  { ""payer_id"" : ""CBHFL"",
    ""payer_name"" : ""Cenpatico Behavioral Health (Florida) CENPATICO - FLORIDA""
  },
  { ""payer_id"" : ""CBHKS"",
    ""payer_name"" : ""Cenpatico Behavioral Health (Kansas) CENPATICO - KANSAS""
  },
  { ""payer_id"" : ""CBHOH"",
    ""payer_name"" : ""Cenpatico Behavioral Health (Ohio) CENPATICO - OHIO""
  },
  { ""payer_id"" : ""CBHSC"",
    ""payer_name"" : ""Cenpatico Behavioral Health (South Carolina) CENPATICO - SOUTH CAROLINA""
  },
  { ""payer_id"" : ""CBHAZ"",
    ""payer_name"" : ""Cenpatico-Arizona CENPATICO - ARIZONA""
  },
  { ""payer_id"" : ""CBHFL"",
    ""payer_name"" : ""Cenpatico-Florida CENPATICO - FLORIDA""
  },
  { ""payer_id"" : ""CBHGA"",
    ""payer_name"" : ""Cenpatico-Georgia CENPATICO - GEORGIA""
  },
  { ""payer_id"" : ""CBHKS"",
    ""payer_name"" : ""Cenpatico-Kansas CENPATICO - KANSAS""
  },
  { ""payer_id"" : ""CBHOH"",
    ""payer_name"" : ""Cenpatico-Ohio CENPATICO - OHIO""
  },
  { ""payer_id"" : ""CBHSC"",
    ""payer_name"" : ""Cenpatico-South Carolina CENPATICO - SOUTH CAROLINA""
  },
  { ""payer_id"" : ""27"",
    ""payer_name"" : ""Colorado Medicaid COLORADO MEDICAID""
  },
  { ""payer_id"" : ""AID14"",
    ""payer_name"" : ""Colorado Medicaid COLORADO MEDICAID""
  },
  { ""payer_id"" : ""52"",
    ""payer_name"" : ""Connecticut Medicaid CONNECTICUT MEDICAID""
  },
  { ""payer_id"" : ""AID24"",
    ""payer_name"" : ""Connecticut Medicaid CONNECTICUT MEDICAID""
  },
  { ""payer_id"" : ""511"",
    ""payer_name"" : ""Coventry Nebraska Medicaid COVENTRY NEBRASKA MEDICAID""
  },
  { ""payer_id"" : ""23"",
    ""payer_name"" : ""Florida Medicaid FLORIDA MEDICAID""
  },
  { ""payer_id"" : ""AID01"",
    ""payer_name"" : ""Florida Medicaid FLORIDA MEDICAID""
  },
  { ""payer_id"" : ""28"",
    ""payer_name"" : ""Georgia Medicaid GEORGIA MEDICAID""
  },
  { ""payer_id"" : ""AID15"",
    ""payer_name"" : ""Georgia Medicaid GEORGIA MEDICAID""
  },
  { ""payer_id"" : ""CGRPR"",
    ""payer_name"" : ""Group Practice Affiliates GROUP PRACTICE AFFILIATES""
  },
  { ""payer_id"" : ""AID53"",
    ""payer_name"" : ""Hawaii Medicaid HAWAII MEDICAID""
  },
  { ""payer_id"" : ""67"",
    ""payer_name"" : ""Idaho Medicaid IDAHO MEDICAID""
  },
  { ""payer_id"" : ""AID35"",
    ""payer_name"" : ""Idaho Medicaid IDAHO MEDICAID ""
  },
  { ""payer_id"" : ""53"",
    ""payer_name"" : ""Illinois Medicaid (IDPA) ILLINOIS MEDICAID""
  },
  { ""payer_id"" : ""AID25"",
    ""payer_name"" : ""Illinois Medicaid (IDPA) ILLINOIS MEDICAID""
  },
  { ""payer_id"" : ""30"",
    ""payer_name"" : ""Indiana Medicaid INDIANA MEDICAID""
  },
  { ""payer_id"" : ""AID16"",
    ""payer_name"" : ""Indiana Medicaid INDIANA MEDICAID""
  },
  { ""payer_id"" : ""CBHTX"",
    ""payer_name"" : ""Integrated Mental Health Services INTEGRATED MENTAL HEALTH SERVICES""
  },
  { ""payer_id"" : ""68"",
    ""payer_name"" : ""Iowa Medicaid IOWA MEDICAID""
  },
  { ""payer_id"" : ""AID36"",
    ""payer_name"" : ""Iowa Medicaid IOWA MEDICAID""
  },
  { ""payer_id"" : ""50"",
    ""payer_name"" : ""Kansas Medicaid KANSAS MEDICAID""
  },
  { ""payer_id"" : ""AID22"",
    ""payer_name"" : ""Kansas Medicaid KANSAS MEDICAID""
  },
  { ""payer_id"" : ""AID31"",
    ""payer_name"" : ""Kentucky Medicaid KENTUCKY MEDICAID""
  },
  { ""payer_id"" : ""74"",
    ""payer_name"" : ""Louisiana Medicaid LOUISIANA MEDICAID""
  },
  { ""payer_id"" : ""AID42"",
    ""payer_name"" : ""Louisiana Medicaid LOUISIANA MEDICAID""
  },
  { ""payer_id"" : ""CMHWI"",
    ""payer_name"" : ""Managed Health Services Wisconsin MANAGED HEALTH SERVICES WISCONSIN""
  },
  { ""payer_id"" : ""145"",
    ""payer_name"" : ""Massachusetts Medicaid MASS MEDICAID""
  },
  { ""payer_id"" : ""AID45"",
    ""payer_name"" : ""Massachusetts Medicaid MASS MEDICAID""
  },
  { ""payer_id"" : ""AID55"",
    ""payer_name"" : ""Michigan Medicaid - Dept of Community Health - Medical Services Admin MICHIGAN MEDICAID""
  },
  { ""payer_id"" : ""70"",
    ""payer_name"" : ""Minnesota Medicaid MINNESOTA MEDICAID""
  },
  { ""payer_id"" : ""AID38"",
    ""payer_name"" : ""Minnesota Medicaid MINNESOTA MEDICAID""
  },
  { ""payer_id"" : ""46"",
    ""payer_name"" : ""Mississippi Medicaid MISSISSIPPI MEDICAID""
  },
  { ""payer_id"" : ""AID20"",
    ""payer_name"" : ""Mississippi Medicaid MISSISSIPPI MEDICAID""
  },
  { ""payer_id"" : ""21"",
    ""payer_name"" : ""Missouri Medicaid MO MEDICAID""
  },
  { ""payer_id"" : ""AID03"",
    ""payer_name"" : ""Missouri Medicaid MO MEDICAID""
  },
  { ""payer_id"" : ""AID57"",
    ""payer_name"" : ""Montana Medicaid - DPHHS/Health Policy Services Division MONTANA MEDICAID""
  },
  { ""payer_id"" : ""AID58"",
    ""payer_name"" : ""Nevada Medicaid - First Health Services Corp NEVADA MEDICAID""
  },
  { ""payer_id"" : ""147"",
    ""payer_name"" : ""New Hampshire Medicaid NEW HAMPSHIRE MEDICAID""
  },
  { ""payer_id"" : ""AID47"",
    ""payer_name"" : ""New Hampshire Medicaid NEW HAMPSHIRE MEDICAID ""
  },
  { ""payer_id"" : ""40"",
    ""payer_name"" : ""New Jersey Medicaid NEW JERSEY MEDICAID""
  },
  { ""payer_id"" : ""AID19"",
    ""payer_name"" : ""New Jersey Medicaid NEW JERSEY MEDICAID ""
  },
  { ""payer_id"" : ""58"",
    ""payer_name"" : ""New Mexico Medicaid NEW MEXICO MEDICAID""
  },
  { ""payer_id"" : ""AID27"",
    ""payer_name"" : ""New Mexico Medicaid NEW MEXICO MEDICAID""
  },
  { ""payer_id"" : ""32"",
    ""payer_name"" : ""New York Medicaid NEW YORK MEDICAID ""
  },
  { ""payer_id"" : ""AID18"",
    ""payer_name"" : ""New York Medicaid NEW YORK MEDICAID ""
  },
  { ""payer_id"" : ""47"",
    ""payer_name"" : ""North Carolina Medicaid NORTH CAROLINA MEDICAID""
  },
  { ""payer_id"" : ""AID21"",
    ""payer_name"" : ""North Carolina Medicaid NORTH CAROLINA MEDICAID""
  },
  { ""payer_id"" : ""AID59"",
    ""payer_name"" : ""North Dakota Medicaid NORTH DAKOTA MEDICAID""
  },
  { ""payer_id"" : ""14"",
    ""payer_name"" : ""Ohio Medicaid OHIO MEDICAID""
  },
  { ""payer_id"" : ""AID09"",
    ""payer_name"" : ""Ohio Medicaid OHIO MEDICAID""
  },
  { ""payer_id"" : ""64"",
    ""payer_name"" : ""Oklahoma Medicaid OKLAHOMA MEDICAID""
  },
  { ""payer_id"" : ""AID32"",
    ""payer_name"" : ""Oklahoma Medicaid OKLAHOMA MEDICAID""
  },
  { ""payer_id"" : ""77"",
    ""payer_name"" : ""Oregon Medicaid OREGON MEDICAID""
  },
  { ""payer_id"" : ""AID44"",
    ""payer_name"" : ""Oregon Medicaid OREGON MEDICAID""
  },
  { ""payer_id"" : ""CPSHP"",
    ""payer_name"" : ""Peach State Health Plan PEACH STATE HEALTH PLAN""
  },
  { ""payer_id"" : ""61"",
    ""payer_name"" : ""Pennsylvania Medicaid PA MEDICAID""
  },
  { ""payer_id"" : ""AID29"",
    ""payer_name"" : ""Pennsylvania Medicaid PA MEDICAID""
  },
  { ""payer_id"" : ""59"",
    ""payer_name"" : ""South Dakota Medicaid SOUTH DAKOTA MEDICAID""
  },
  { ""payer_id"" : ""AID28"",
    ""payer_name"" : ""South Dakota Medicaid SOUTH DAKOTA MEDICAID""
  },
  { ""payer_id"" : ""CSSHP"",
    ""payer_name"" : ""Sunshine State Health Plan SUNSHINE STATE HEALTH PLAN ""
  },
  { ""payer_id"" : ""CSHPT"",
    ""payer_name"" : ""Superior HealthPlan SUPERIOR HEALTHPLAN TEXAS""
  },
  { ""payer_id"" : ""26"",
    ""payer_name"" : ""Tennessee Medicaid TENNCARE""
  },
  { ""payer_id"" : ""AID13"",
    ""payer_name"" : ""Tennessee Medicaid (TennCare) TENNCARE""
  },
  { ""payer_id"" : ""22"",
    ""payer_name"" : ""Texas Medicaid TEXAS MEDICAID""
  },
  { ""payer_id"" : ""AID05"",
    ""payer_name"" : ""Texas Medicaid TEXAS MEDICAID""
  },
  { ""payer_id"" : ""62"",
    ""payer_name"" : ""Vermont Medicaid VERMONT MEDICAID""
  },
  { ""payer_id"" : ""AID30"",
    ""payer_name"" : ""Vermont Medicaid VERMONT MEDICAID""
  },
  { ""payer_id"" : ""51"",
    ""payer_name"" : ""Virginia Medicaid VIRGINIA MEDICAID""
  },
  { ""payer_id"" : ""AID23"",
    ""payer_name"" : ""Virginia Medicaid VIRGINIA MEDICAID""
  },
  { ""payer_id"" : ""20"",
    ""payer_name"" : ""Washington Medicaid WASHINGTON MEDICAID""
  },
  { ""payer_id"" : ""AID07"",
    ""payer_name"" : ""Washington Medicaid WASHINGTON MEDICAID""
  },
  { ""payer_id"" : ""65"",
    ""payer_name"" : ""West Virginia Medicaid WV MEDICAID""
  },
  { ""payer_id"" : ""AID33"",
    ""payer_name"" : ""West Virginia Medicaid WV MEDICAID""
  },
  { ""payer_id"" : ""WICDP"",
    ""payer_name"" : ""Wisconsin Chronic Disease Program WI MEDICAID CHRONIC DISEASE PROGRAM""
  },
  { ""payer_id"" : ""73"",
    ""payer_name"" : ""Wisconsin Medicaid WISCONSIN MEDICAID""
  },
  { ""payer_id"" : ""AID41"",
    ""payer_name"" : ""Wisconsin Medicaid WISCONSIN MEDICAID""
  },
  { ""payer_id"" : ""WIWWP"",
    ""payer_name"" : ""Wisconsin Well Woman Program WI MEDICAID WELL WOMAN PROGRAM""
  },
  { ""payer_id"" : ""66"",
    ""payer_name"" : ""Wyoming Medicaid WYOMING MEDICAID""
  },
  { ""payer_id"" : ""AID34"",
    ""payer_name"" : ""Wyoming Medicaid WYOMING MEDICAID""
  },
  { ""payer_id"" : ""CBRIA"",
    ""payer_name"" : ""Advantage by Bridgeway Health Solutions ADVANTAGE BY BRIDGEWAY HEALTH SOLTN""
  },
  { ""payer_id"" : ""CBUCA"",
    ""payer_name"" : ""Advantage by Buckeye Community Health Plan ADVANTAGE BY BUCKEYE COMMUNITY HPLN""
  },
  { ""payer_id"" : ""CMHSA"",
    ""payer_name"" : ""Advantage by Managed Health Services ADVANTAGE BY MANAGED HEALTH SERVICES""
  },
  { ""payer_id"" : ""CSHPA"",
    ""payer_name"" : ""Advantage by Superior HealthPlan Services ADVANTAGE BY SUPERIOR HEALTHPLAN""
  },
  { ""payer_id"" : ""CSAMS"",
    ""payer_name"" : ""CSA Fraternal Life - Medicare Supplement CSA FRATERNAL MEDICARE SUPPLEMENT""
  },
  { ""payer_id"" : ""CHWSL"",
    ""payer_name"" : ""Carpenters' Health and Welfare Trust Fund of St. Louis CARPENTER’S HEALTH AND WELFARE""
  },
  { ""payer_id"" : ""CRLMS"",
    ""payer_name"" : ""Central Reserve Life Insurance Company - Medicare Supplement CENTRAL RESERVE MEDICARE SUPPLEMENT""
  },
  { ""payer_id"" : ""CGIMS"",
    ""payer_name"" : ""Continental General Insurance Company - Medicare Supplement CONTINENTAL GENERAL MEDICARE SUPP""
  },
  { ""payer_id"" : ""ESSNC"",
    ""payer_name"" : ""Essence Healthcare ESSENCE HEALTHCARE""
  },
  { ""payer_id"" : ""GAIMS"",
    ""payer_name"" : ""Great American Life Insurance Company - Medicare Supplement GREAT AMERICAN INS MEDICARE SUPP""
  },
  { ""payer_id"" : ""LALMS"",
    ""payer_name"" : ""Loyal American Life Insurance Company - Medicare Supplement LOYAL AMERICAN MEDICARE SUPPLEMENT""
  },
  { ""payer_id"" : ""431"",
    ""payer_name"" : ""Medicare Part A & B - All States MEDICARE""
  },
  { ""payer_id"" : ""PRVMS"",
    ""payer_name"" : ""Provident American Life & Health Insurance Company - Medicare Supplement PROVIDENT AMERICAN  MEDICARE SUPP""
  },
  { ""payer_id"" : ""SPJMS"",
    ""payer_name"" : ""SPJST - Medicare Supplement SPJST MEDICARE SUPPLEMENT""
  },
  { ""payer_id"" : ""UTAMS"",
    ""payer_name"" : ""United Teacher Associates Insurance Company - Medicare Supplement UNITED TEACHER ASSOC MEDICARE SUPP""
  },
  { ""payer_id"" : ""VNSNY"",
    ""payer_name"" : ""VNS CHOICE Medicare VISITING NURSE SERVICE OF NY""
  }
]";

        #endregion Providers

    }
}
