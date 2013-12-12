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
    /// Container for the parameters to the UpdateEnvironment operation.
    /// <para> Updates the environment description, deploys a new application version, updates the configuration settings to an entirely new
    /// configuration template, or updates select configuration option values in the running environment. </para> <para> Attempting to update both
    /// the release and configuration is not allowed and AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. </para> <para>
    /// When updating the configuration settings to a new template or individual settings, a draft configuration is created and
    /// DescribeConfigurationSettings for this environment returns two setting descriptions with different <c>DeploymentStatus</c> values. </para>
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        private string environmentId;
        private string environmentName;
        private string description;
        private EnvironmentTier tier;
        private string versionLabel;
        private string templateName;
        private List<ConfigurationOptionSetting> optionSettings = new List<ConfigurationOptionSetting>();
        private List<OptionSpecification> optionsToRemove = new List<OptionSpecification>();


        /// <summary>
        /// The ID of the environment to update. If no environment with this ID exists, AWS Elastic Beanstalk returns an <c>InvalidParameterValue</c>
        /// error. Condition: You must specify either this or an EnvironmentName, or both. If you do not specify either, AWS Elastic Beanstalk returns
        /// <c>MissingRequiredParameter</c> error.
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
        /// The name of the environment to update. If no environment with this name exists, AWS Elastic Beanstalk returns an
        /// <c>InvalidParameterValue</c> error. Condition: You must specify either this or an EnvironmentId, or both. If you do not specify either, AWS
        /// Elastic Beanstalk returns <c>MissingRequiredParameter</c> error.
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
        /// If this parameter is specified, AWS Elastic Beanstalk updates the description of this environment.
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
        /// This specifies the tier to use to update the environment. Condition: You can only update the tier version for an environment. If you change
        /// the name of the type, AWS Elastic Beanstalk returns <c>InvalidParameterValue</c> error.
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
        /// If this parameter is specified, AWS Elastic Beanstalk deploys the named application version to the environment. If no such application
        /// version is found, returns an <c>InvalidParameterValue</c> error.
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
        /// If this parameter is specified, AWS Elastic Beanstalk deploys this configuration template to the environment. If no such configuration
        /// template is found, AWS Elastic Beanstalk returns an <c>InvalidParameterValue</c> error.
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
        /// If specified, AWS Elastic Beanstalk updates the configuration set associated with the running environment and sets the specified
        /// configuration options to the requested value.
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
        /// A list of custom user-defined configuration options to remove from the configuration set for this environment.
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
    
