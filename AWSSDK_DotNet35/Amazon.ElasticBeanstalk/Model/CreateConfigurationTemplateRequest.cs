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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfigurationTemplate operation.
    /// <para>Creates a configuration template. Templates are associated with a specific application and are used to deploy different versions of
    /// the application with the same configuration settings.</para> <para>Related Topics</para>
    /// <ul>
    /// <li> DescribeConfigurationOptions </li>
    /// <li> DescribeConfigurationSettings </li>
    /// <li> ListAvailableSolutionStacks </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class CreateConfigurationTemplateRequest : AmazonElasticBeanstalkRequest
    {
        private string applicationName;
        private string templateName;
        private string solutionStackName;
        private SourceConfiguration sourceConfiguration;
        private string environmentId;
        private string description;
        private List<ConfigurationOptionSetting> optionSettings = new List<ConfigurationOptionSetting>();


        /// <summary>
        /// The name of the application to associate with this configuration template. If no application is found with this name, AWS Elastic Beanstalk
        /// returns an <c>InvalidParameterValue</c> error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;
        }

        /// <summary>
        /// The name of the configuration template. Constraint: This name must be unique per application. Default: If a configuration template already
        /// exists with this name, AWS Elastic Beanstalk returns an <c>InvalidParameterValue</c> error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this.templateName; }
            set { this.templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this.templateName != null;
        }

        /// <summary>
        /// The name of the solution stack used by this configuration. The solution stack specifies the operating system, architecture, and application
        /// server for a configuration template. It determines the set of configuration options as well as the possible and default values. Use
        /// <a>ListAvailableSolutionStacks</a> to obtain a list of available solution stacks. A solution stack name or a source configuration parameter
        /// must be specified, otherwise AWS Elastic Beanstalk returns an <c>InvalidParameterValue</c> error. If a solution stack name is not specified
        /// and the source configuration parameter is specified, AWS Elastic Beanstalk uses the same solution stack as the source configuration
        /// template.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this.solutionStackName; }
            set { this.solutionStackName = value; }
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this.solutionStackName != null;
        }

        /// <summary>
        /// If specified, AWS Elastic Beanstalk uses the configuration values from the specified configuration template to create a new configuration.
        /// Values specified in the <c>OptionSettings</c> parameter of this call overrides any values obtained from the <c>SourceConfiguration</c>. If
        /// no configuration template is found, returns an <c>InvalidParameterValue</c> error. Constraint: If both the solution stack name parameter and
        /// the source configuration parameters are specified, the solution stack of the source configuration template must match the specified solution
        /// stack name or else AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error.
        ///  
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get { return this.sourceConfiguration; }
            set { this.sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this.sourceConfiguration != null;
        }

        /// <summary>
        /// The ID of the environment used with this configuration template.
        ///  
        /// </summary>
        public string EnvironmentId
        {
            get { return this.environmentId; }
            set { this.environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this.environmentId != null;
        }

        /// <summary>
        /// Describes this configuration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 200</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// If specified, AWS Elastic Beanstalk sets the specified configuration option to the requested value. The new value overrides the value
        /// obtained from the solution stack or the source configuration template.
        ///  
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this.optionSettings; }
            set { this.optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this.optionSettings.Count > 0;
        }

    }
}
    
