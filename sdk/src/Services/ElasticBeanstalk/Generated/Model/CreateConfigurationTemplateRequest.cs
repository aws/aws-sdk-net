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
    /// Container for the parameters to the CreateConfigurationTemplate operation.
    /// Creates a configuration template. Templates are associated with a specific application
    /// and are used to deploy different versions of the application with the same configuration
    /// settings.
    /// 
    ///  
    /// <para>
    /// Templates aren't associated with any environment. The <code>EnvironmentName</code>
    /// response element is always <code>null</code>.
    /// </para>
    ///  
    /// <para>
    /// Related Topics
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeConfigurationOptions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeConfigurationSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAvailableSolutionStacks</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateConfigurationTemplateRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _description;
        private string _environmentId;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private string _platformArn;
        private string _solutionStackName;
        private SourceConfiguration _sourceConfiguration;
        private string _templateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateConfigurationTemplateRequest() { }

        /// <summary>
        /// Instantiates CreateConfigurationTemplateRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application to associate with this configuration template. If no application is found with this name, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code> error. </param>
        /// <param name="templateName">The name of the configuration template. Constraint: This name must be unique per application. Default: If a configuration template already exists with this name, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code> error. </param>
        public CreateConfigurationTemplateRequest(string applicationName, string templateName)
        {
            _applicationName = applicationName;
            _templateName = templateName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to associate with this configuration template. If no application
        /// is found with this name, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code>
        /// error. 
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
        /// Describes this configuration.
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment used with this configuration template.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk sets the specified configuration option to the
        /// requested value. The new value overrides the value obtained from the solution stack
        /// or the source configuration template.
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
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of the custom platform.
        /// </para>
        /// </summary>
        public string PlatformArn
        {
            get { return this._platformArn; }
            set { this._platformArn = value; }
        }

        // Check to see if PlatformArn property is set
        internal bool IsSetPlatformArn()
        {
            return this._platformArn != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        /// The name of the solution stack used by this configuration. The solution stack specifies
        /// the operating system, architecture, and application server for a configuration template.
        /// It determines the set of configuration options as well as the possible and default
        /// values.
        /// </para>
        ///  
        /// <para>
        ///  Use <a>ListAvailableSolutionStacks</a> to obtain a list of available solution stacks.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  A solution stack name or a source configuration parameter must be specified, otherwise
        /// AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code> error. 
        /// </para>
        ///  
        /// <para>
        /// If a solution stack name is not specified and the source configuration parameter is
        /// specified, AWS Elastic Beanstalk uses the same solution stack as the source configuration
        /// template.
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this._solutionStackName; }
            set { this._solutionStackName = value; }
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this._solutionStackName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk uses the configuration values from the specified
        /// configuration template to create a new configuration.
        /// </para>
        ///  
        /// <para>
        ///  Values specified in the <code>OptionSettings</code> parameter of this call overrides
        /// any values obtained from the <code>SourceConfiguration</code>. 
        /// </para>
        ///  
        /// <para>
        ///  If no configuration template is found, returns an <code>InvalidParameterValue</code>
        /// error. 
        /// </para>
        ///  
        /// <para>
        ///  Constraint: If both the solution stack name parameter and the source configuration
        /// parameters are specified, the solution stack of the source configuration template
        /// must match the specified solution stack name or else AWS Elastic Beanstalk returns
        /// an <code>InvalidParameterCombination</code> error. 
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template.
        /// </para>
        ///  
        /// <para>
        /// Constraint: This name must be unique per application.
        /// </para>
        ///  
        /// <para>
        /// Default: If a configuration template already exists with this name, AWS Elastic Beanstalk
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