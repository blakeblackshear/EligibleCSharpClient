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
/// 
using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Eligible
{
    /// <summary>
    /// Converts the Eligible Date value for a birthdate to a C# Value
    /// </summary>
    public class DateOfBirthTimeConverter : DateTimeConverterBase
    {
        /// <summary>
        /// Defines our format for a date of birth
        /// </summary>
        public const string DATE_OF_BIRTH_FORMAT = @"yyyy-MM-dd";

        /// <summary>
        /// Determines if the requested type is nullable
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        static bool IsNullable(Type type)
        {
            if (!type.IsValueType)
                return true;

            if (Nullable.GetUnderlyingType(type) != null)
                return true;

            return false;
        }

        /// <summary>
        /// Parses out the JSON value
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool isNullable = IsNullable(objectType);

            Type inferredType = isNullable ? Nullable.GetUnderlyingType(objectType) : objectType;

            if (reader.TokenType == JsonToken.Null && isNullable)
                return null;
            else if (reader.TokenType == JsonToken.Null && !isNullable)
                throw new Exception(String.Format("Cannot convert null value to {0}.", objectType));

            // Pull the date out as a string value, since that is what it will be
            string datePulled = (string)reader.Value.ToString();

            return DateTime.ParseExact(datePulled, DateOfBirthTimeConverter.DATE_OF_BIRTH_FORMAT, null);

        } // ReadJson
        
        /// <summary>
        /// Converts the value
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is DateTime))
                throw new Exception("Invalid date value");

            DateTime dt = (DateTime)value;

            writer.WriteValue(dt.ToString(DateOfBirthTimeConverter.DATE_OF_BIRTH_FORMAT));

        } // WriteJson
    }
}
