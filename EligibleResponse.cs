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
    /// <summary>
    /// The root response for an eligible request. All response objects
    /// should extend from this base class - it has all the "common" properties
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EligibleResponse
    {
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonProperty(PropertyName = "eligible_id")]
        public string EligibleID { get; set; }

        [JsonProperty(PropertyName = "mapping_version")]
        public string MappingVersion { get; set; }

        [JsonProperty(PropertyName = "error")]
        public EligibleError Error { get; set; }

        /// <summary>
        /// Did the response have an error?
        /// </summary>
        public bool HadError { get { return Error != null; } }

        /// <summary>
        /// The JSON for the response
        /// </summary>
        /// <remarks>
        /// I absolutely hate it when APIs hide the response data
        /// so, with this, you can get at the raw data if you want.
        /// </remarks>
        public string JSON { get; set; }

        /// <summary>
        /// The URL which was invoked
        /// </summary>
        public string RequestedURL { get; set; }

    }
}
