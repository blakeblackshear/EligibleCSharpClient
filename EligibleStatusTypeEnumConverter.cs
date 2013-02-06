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
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Eligible
{
    public class EligibleStatusTypeEnumConverter : JsonConverter
    {
        public EligibleStatusTypeEnumConverter()
        {
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(EligibleServiceStatusCodeEnum);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
                return null;

            var name = reader.Value as string;

            switch (name)
            {
                case @"1": return EligibleServiceStatusCodeEnum.ActiveCoverage;
                case @"2": return EligibleServiceStatusCodeEnum.ActiveFullRiskCapitation;
                case @"3": return EligibleServiceStatusCodeEnum.ActiveServicesCapitated;
                case @"4": return EligibleServiceStatusCodeEnum.ActiveServicesCapitatedToPrimaryCarePhysician;
                case @"5": return EligibleServiceStatusCodeEnum.ActivePendingInvestigation;
                case @"6": return EligibleServiceStatusCodeEnum.Inactive;
                case @"7": return EligibleServiceStatusCodeEnum.InactivePendingEligibilityUpdate;
                case @"8": return EligibleServiceStatusCodeEnum.InactivePendingInvestigation;
                case @"I": return EligibleServiceStatusCodeEnum.NotCovered;
                case @"V": return EligibleServiceStatusCodeEnum.CannotProcess;
            }

            return EligibleServiceStatusCodeEnum.Unknown;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            EligibleServiceStatusCodeEnum val = (EligibleServiceStatusCodeEnum)value;
            string result = @"";

            switch (val)
            {
                case EligibleServiceStatusCodeEnum.ActiveCoverage: result = @"1"; break;
                case EligibleServiceStatusCodeEnum.ActiveFullRiskCapitation: result = @"2"; break;
                case EligibleServiceStatusCodeEnum.ActiveServicesCapitated: result = @"3"; break;
                case EligibleServiceStatusCodeEnum.ActiveServicesCapitatedToPrimaryCarePhysician: result = @"4"; break;
                case EligibleServiceStatusCodeEnum.ActivePendingInvestigation: result = @"5"; break;
                case EligibleServiceStatusCodeEnum.Inactive: result = @"6"; break;
                case EligibleServiceStatusCodeEnum.InactivePendingEligibilityUpdate: result = @"7"; break;
                case EligibleServiceStatusCodeEnum.InactivePendingInvestigation: result = @"8"; break;
                case EligibleServiceStatusCodeEnum.NotCovered: result = @"I"; break;
                case EligibleServiceStatusCodeEnum.CannotProcess: result = @"V"; break;
                default:
                    result = @""; break;

            }

            writer.WriteValue(result);
        }
    }
}
