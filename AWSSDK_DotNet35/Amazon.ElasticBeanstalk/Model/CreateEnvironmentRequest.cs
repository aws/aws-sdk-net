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
    /// Container for the parameters to the CreateEnvironment operation.
    /// <para> Launches an environment for the specified application using the specified configuration. </para>
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        private string applicationName;
        private string environmentName;
        private string description;
        private string cNAMEPrefix;
        private EnvironmentTier tier;
        private string versionLabel;
        private string templateName;
        private string solutionStackName;
        private List<ConfigurationOptionSetting> optionSettings = new List<ConfigurationOptionSetting>();
        private List<OptionSpecification> optionsToRemove = new List<OptionSpecification>();


        /// <summary>
        /// The name of the application that contains the version to be deployed. If no application is found with this name, <c>CreateEnvironment</c>
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
        /// A unique name for the deployment environment. Used in the application URL. Constraint: Must be from 4 to 23 characters in length. The name
        /// can contain only letters, numbers, and hyphens. It cannot start or end with a hyphen. This name must be unique in your account. If the
        /// specified name already exists, AWS Elastic Beanstalk returns an <c>InvalidParameterValue</c> error. Default: If the CNAME parameter is not
        /// specified, the environment name becomes part of the CNAME, and therefore part of the visible URL for your application.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this.environmentName; }
            set { this.environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;
        }

        /// <summary>
        /// Describes this environment.
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
        /// If specified, the environment attempts to use this value as the prefix for the CNAME. If not specified, the CNAME is generated automatically
        /// by appending a random alphanumeric string to the environment name.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 63</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CNAMEPrefix
        {
            get { return this.cNAMEPrefix; }
            set { this.cNAMEPrefix = value; }
        }

        // Check to see if CNAMEPrefix property is set
        internal bool IsSetCNAMEPrefix()
        {
            return this.cNAMEPrefix != null;
        }

        /// <summary>
        /// This specifies the tier to use for creating this environment.
        ///  
        /// </summary>
        public EnvironmentTier Tier
        {
            get { return this.tier; }
            set { this.tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this.tier != null;
        }

        /// <summary>
        /// The name of the application version to deploy. If the specified application has no associated application versions, AWS Elastic Beanstalk
        /// <c>UpdateEnvironment</c> returns an <c>InvalidParameterValue</c> error. Default: If not specified, AWS Elastic Beanstalk attempts to launch
        /// the sample application in the container.
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
        public string VersionLabel
        {
            get { return this.versionLabel; }
            set { this.versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this.versionLabel != null;
        }

        /// <summary>
        /// The name of the configuration template to use in deployment. If no configuration template is found with this name, AWS Elastic Beanstalk
        /// returns an <c>InvalidParameterValue</c> error. Condition: You must specify either this parameter or a <c>SolutionStackName</c>, but not
        /// both. If you specify both, AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. If you do not specify either, AWS
        /// Elastic Beanstalk returns a <c>MissingRequiredParameter</c> error.
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
        /// This is an alternative to specifying a configuration name. If specified, AWS Elastic Beanstalk sets the configuration values to the default
        /// values associated with the specified solution stack. Condition: You must specify either this or a <c>TemplateName</c>, but not both. If you
        /// specify both, AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. If you do not specify either, AWS Elastic Beanstalk
        /// returns a <c>MissingRequiredParameter</c> error.
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
        /// If specified, AWS Elastic Beanstalk sets the specified configuration options to the requested value in the configuration set for the new
        /// environment. These override the values obtained from the solution stack or the configuration template.
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

        /// <summary>
        /// A list of custom user-defined configuration options to remove from the configuration set for this new environment.
        ///  
        /// </summary>
        public List<OptionSpecification> OptionsToRemove
        {
            get { return this.optionsToRemove; }
            set { this.optionsToRemove = value; }
        }

        // Check to see if OptionsToRemove property is set
        internal bool IsSetOptionsToRemove()
        {
            return this.optionsToRemove.Count > 0;
        }

    }
}
    
