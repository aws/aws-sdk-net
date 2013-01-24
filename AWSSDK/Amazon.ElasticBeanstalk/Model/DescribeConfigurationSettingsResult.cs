/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>The results from a request to change the configuration settings of an environment.</para>
    /// </summary>
    public class DescribeConfigurationSettingsResult  
    {
        
        private List<ConfigurationSettingsDescription> configurationSettings = new List<ConfigurationSettingsDescription>();

        /// <summary>
        /// A list of <a>ConfigurationSettingsDescription</a>.
        ///  
        /// </summary>
        public List<ConfigurationSettingsDescription> ConfigurationSettings
        {
            get { return this.configurationSettings; }
            set { this.configurationSettings = value; }
        }
        /// <summary>
        /// Adds elements to the ConfigurationSettings collection
        /// </summary>
        /// <param name="configurationSettings">The values to add to the ConfigurationSettings collection </param>
        /// <returns>this instance</returns>
        public DescribeConfigurationSettingsResult WithConfigurationSettings(params ConfigurationSettingsDescription[] configurationSettings)
        {
            foreach (ConfigurationSettingsDescription element in configurationSettings)
            {
                this.configurationSettings.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ConfigurationSettings collection
        /// </summary>
        /// <param name="configurationSettings">The values to add to the ConfigurationSettings collection </param>
        /// <returns>this instance</returns>
        public DescribeConfigurationSettingsResult WithConfigurationSettings(IEnumerable<ConfigurationSettingsDescription> configurationSettings)
        {
            foreach (ConfigurationSettingsDescription element in configurationSettings)
            {
                this.configurationSettings.Add(element);
            }

            return this;
        }

        // Check to see if ConfigurationSettings property is set
        internal bool IsSetConfigurationSettings()
        {
            return this.configurationSettings.Count > 0;       
        }
    }
}
