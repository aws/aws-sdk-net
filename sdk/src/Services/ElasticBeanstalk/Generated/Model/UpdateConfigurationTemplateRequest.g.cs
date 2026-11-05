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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateConfigurationTemplate operation. Updates
    /// the specified configuration template to have the specified properties or configuration
    /// option values. <note> <para> If a property (for example, <c>ApplicationName</c>) is
    /// not provided, its value remains unchanged. To clear such properties, specify an empty
    /// string. </para> </note> <para> Related Topics </para> <ul> <li> <para> <a>DescribeConfigurationOptions</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class UpdateConfigurationTemplateRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public UpdateConfigurationTemplateRequest() { }

        /// <summary>
        /// Instantiates UpdateConfigurationTemplateRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application associated with the configuration template to   update.    If no application is found with this name, <c>UpdateConfigurationTemplate</c>   returns an <c>InvalidParameterValue</c> error. </param>
        /// <param name="templateName">The name of the configuration template to update.    If no configuration template is found with this name,  <c>UpdateConfigurationTemplate</c> returns an <c>InvalidParameterValue</c>   error. </param>
        public UpdateConfigurationTemplateRequest(string applicationName, string templateName)
        {
            this.ApplicationName = applicationName;
            this.TemplateName = templateName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application associated with the configuration template to update.
        /// </para>
        ///  
        /// <para>
        ///  If no application is found with this name, <c>UpdateConfigurationTemplate</c> returns
        /// an <c>InvalidParameterValue</c> error. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// A list of configuration option settings to update with the new specified option value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationOptionSetting>() : null;

        /// <summary>
        /// Checks to see if the OptionSettings property is set.
        /// </summary>
        internal bool IsSetOptionSettings() => this.OptionSettings != null && (this.OptionSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptionsToRemove. 
        /// <para>
        /// A list of configuration options to remove from the configuration set.
        /// </para>
        ///  
        /// <para>
        ///  Constraint: You can remove only <c>UserDefined</c> configuration options. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionSpecification> OptionsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<OptionSpecification>() : null;

        /// <summary>
        /// Checks to see if the OptionsToRemove property is set.
        /// </summary>
        internal bool IsSetOptionsToRemove() => this.OptionsToRemove != null && (this.OptionsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template to update.
        /// </para>
        ///  
        /// <para>
        ///  If no configuration template is found with this name, <c>UpdateConfigurationTemplate</c>
        /// returns an <c>InvalidParameterValue</c> error. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
