/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the ValidateConfigurationSettings operation.
    /// Takes a set of configuration settings and either a configuration template or environment,
    /// and determines whether those values are valid.
    /// 
    ///  
    /// <para>
    /// This action returns a list of messages indicating any errors or warnings associated
    /// with the selection of option values.
    /// </para>
    /// </summary>
    public partial class ValidateConfigurationSettingsRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _environmentName;
        private List<ConfigurationOptionSetting> _optionSettings = AWSConfigs.InitializeCollections ? new List<ConfigurationOptionSetting>() : null;
        private string _templateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ValidateConfigurationSettingsRequest() { }

        /// <summary>
        /// Instantiates ValidateConfigurationSettingsRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application that the configuration template or environment belongs to.</param>
        /// <param name="optionSettings">A list of the options and desired values to evaluate.</param>
        public ValidateConfigurationSettingsRequest(string applicationName, List<ConfigurationOptionSetting> optionSettings)
        {
            _applicationName = applicationName;
            _optionSettings = optionSettings;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application that the configuration template or environment belongs
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to validate the settings against.
        /// </para>
        ///  
        /// <para>
        /// Condition: You cannot specify both this and a configuration template name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// A list of the options and desired values to evaluate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && (this._optionSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template to validate the settings against.
        /// </para>
        ///  
        /// <para>
        /// Condition: You cannot specify both this and an environment name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}