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

namespace Eligible
{
    [JsonObject(MemberSerialization.OptIn)]
    public class EligibleService : EligibleResponse
    {
        [JsonConverter(typeof(EligibleStatusTypeEnumConverter))]
        [JsonProperty(PropertyName = "coverage_status")]
        public EligibleServiceStatusCodeEnum CoverageStatus { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "exclusions")]
        public string Exclusions { get; set; }

        [JsonProperty(PropertyName = "balance")]
        public string Balance { get; set; }

        [JsonProperty(PropertyName = "precertification_needed")]
        public string PrecertificationNeeded { get; set; }

        [JsonProperty(PropertyName = "not_covered")]
        public List<string> NotCovered { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<string> Comments { get; set; }

        [JsonProperty(PropertyName = "primary_insurance")]
        public EligibleInsurance PrimaryInsurance { get; set; }

        [JsonProperty(PropertyName = "deductible_in_network")]
        public EligibleServiceVisit DeductableInNetwork { get; set; }

        [JsonProperty(PropertyName = "deductible_out_network")]
        public EligibleServiceVisit DeductableOutOfNetwork { get; set; }

        [JsonProperty(PropertyName = "visits_in_network")]
        public EligibleServiceVisit VisitsInNetwork { get; set; }

        [JsonProperty(PropertyName = "visits_out_network")]
        public EligibleServiceVisit VisitsOutOfNetwork { get; set; }

        [JsonProperty(PropertyName = "additional_insurance")]
        public EligibleInsurance AdditionalInsurance { get; set; }

        [JsonProperty(PropertyName = "copayment_in_network")]
        public EligibleServiceVisit CopaymentInNetwork { get; set; }

        [JsonProperty(PropertyName = "copayment_out_network")]
        public EligibleServiceVisit CopaymentOutOfNetwork { get; set; }

        [JsonProperty(PropertyName = "coinsurance_in_network")]
        public EligibleServiceVisit CoinsuranceInNetwork { get; set; }

        [JsonProperty(PropertyName = "coinsurance_out_network")]
        public EligibleServiceVisit CoinsuranceOutOfNetwork { get; set; }

        [JsonProperty(PropertyName = "stop_loss_in_network")]
        public EligibleServiceVisit StopLossInNetwork { get; set; }

        [JsonProperty(PropertyName = "stop_loss_out_network")]
        public EligibleServiceVisit StopLossOutOfNetwork { get; set; }
        
        
    }
}
