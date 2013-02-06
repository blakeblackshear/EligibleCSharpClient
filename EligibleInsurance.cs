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
    public class EligibleInsurance
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "group_name")]
        public string GroupName { get; set; }

        [JsonProperty(PropertyName = "plan_begins")]
        public string PlanBegins { get; set; }

        [JsonProperty(PropertyName = "plan_ends")]
        public string PlanEnds { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<string> Comments { get; set; }
        
    }
}
