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
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eligible
{
    /// <summary>
    /// Defines the configuration section for the Eligible API
    /// </summary>
    /// <remarks>
    /// The Configuration is a .NET configuration section for the Eligible API. 
    /// This will allow the Eligible API configuration properties to be stored 
    /// within the .config file for the Application
    /// 
    /// In the .config file, you will add, within your configSections:
    ///     <configSections>
    ///         <section name="eligibleConfiguration" type="DrRounds.Cloud.Eligible.EligibleConfiguration, DrRounds.Cloud.Eligible"/>
    ///     </configSections>
    ///     
    /// Within your config file, you will then add the configuration section:
    ///     <eligibleConfiguration apiKey="00000000-0000-0000-0000-000000000000" />
    ///     
    /// At this time, there is only one setting, the API key - which must be set. Once this
    /// is set, it will automatically be pulled by the EligibleAPI.
    /// </remarks>
    public class EligibleConfiguration : ConfigurationSection
    {
        public const string CONFIGURATION_SECTION_NAME = "eligibleConfiguration";

        /// <summary>
        /// Retrieves the instance of the configuration
        /// </summary>
        public static EligibleConfiguration Instance
        {
            get
            {
                // Web check
                EligibleConfiguration _Instance = ConfigurationManager.GetSection(CONFIGURATION_SECTION_NAME) as EligibleConfiguration;

                // Console/Windows App Check
                if (_Instance == null)
                    return (EligibleConfiguration)ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).GetSection(CONFIGURATION_SECTION_NAME);

                return _Instance;
            }
        }

        /// <summary>
        /// This really shouldn't be the key...
        /// </summary>
        [ConfigurationProperty("apiKey", IsKey = true, IsRequired = true)]
        public string APIKey
        {
            get { return (string)(base["apiKey"]); }
            set { base["apiKey"] = value; }
        }
        // 
    }
}
