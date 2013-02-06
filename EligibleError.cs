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
    public class EligibleError
    {
        [JsonProperty(PropertyName = "response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty(PropertyName = "response_description")]
        public string ResponseDescription { get; set; }

        [JsonProperty(PropertyName = "agency_qualifier_code")]
        public string ResponseQualifierRCode { get; set; }

        [JsonProperty(PropertyName = "agency_qualifier_description")]
        public string ResponseQualifierRescription { get; set; }

        [JsonProperty(PropertyName = "reject_reason_code")]
        public string RejectionReasonCode { get; set; }

        [JsonProperty(PropertyName = "reject_reason_description")]
        public string RejectionReasonDescription { get; set; }

        [JsonProperty(PropertyName = "follow-up_action_code")]
        public string FollowUpActionCode { get; set; }

        [JsonProperty(PropertyName = "follow-up_action_description")]
        public string FollowUpActionDescription { get; set; }

    }
}
