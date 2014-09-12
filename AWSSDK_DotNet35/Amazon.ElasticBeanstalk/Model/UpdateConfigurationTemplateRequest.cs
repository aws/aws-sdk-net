/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfigurationTemplate operation.
    /// Updates the specified configuration template to have the specified properties or
    /// configuration option values. 
    /// 
    ///  
    /// <para>
    /// Related Topics
    /// </para>
    ///  <ul> <li> <a>DescribeConfigurationOptions</a> </li> </ul>
    /// </summary>
    public partial class UpdateConfigurationTemplateRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _description;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private List<OptionSpecification> _optionsToRemove = new List<OptionSpecification>();
        private string _templateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateConfigurationTemplateRequest() { }

        /// <summary>
        /// Instantiates UpdateConfigurationTemplateRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application associated with the configuration template to update.  If no application is found with this name, <code>UpdateConfigurationTemplate</code> returns an <code>InvalidParameterValue</code> error. </param>
        /// <param name="templateName">The name of the configuration template to update.  If no configuration template is found with this name, <code>UpdateConfigurationTemplate</code> returns an <code>InvalidParameterValue</code> error. </param>
        public UpdateConfigurationTemplateRequest(string applicationName, string templateName)
        {
            _applicationName = applicationName;
            _templateName = templateName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application associated with the configuration template to update.
        /// </para>
        ///  
        /// <para>
        ///  If no application is found with this name, <code>UpdateConfigurationTemplate</code>
        /// returns an <code>InvalidParameterValue</code> error. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the configuration.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        ///  A list of configuration option settings to update with the new specified option value.
        /// 
        /// </para>
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && this._optionSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OptionsToRemove. 
        /// <para>
        ///  A list of configuration options to remove from the configuration set. 
        /// </para>
        ///  
        /// <para>
        ///  Constraint: You can remove only <code>UserDefined</code> configuration options. 
        /// </para>
        /// </summary>
        public List<OptionSpecification> OptionsToRemove
        {
            get { return this._optionsToRemove; }
            set { this._optionsToRemove = value; }
        }

        // Check to see if OptionsToRemove property is set
        internal bool IsSetOptionsToRemove()
        {
            return this._optionsToRemove != null && this._optionsToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template to update.
        /// </para>
        ///  
        /// <para>
        ///  If no configuration template is found with this name, <code>UpdateConfigurationTemplate</code>
        /// returns an <code>InvalidParameterValue</code> error. 
        /// </para>
        /// </summary>
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