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
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Updates the environment description, deploys a new application version, updates the
    /// configuration settings to an entirely new configuration template, or updates select
    /// configuration option values in the running environment. 
    /// 
    ///  
    /// <para>
    ///  Attempting to update both the release and configuration is not allowed and AWS Elastic
    /// Beanstalk returns an <code>InvalidParameterCombination</code> error. 
    /// </para>
    ///  
    /// <para>
    ///  When updating the configuration settings to a new template or individual settings,
    /// a draft configuration is created and <a>DescribeConfigurationSettings</a> for this
    /// environment returns two setting descriptions with different <code>DeploymentStatus</code>
    /// values. 
    /// </para>
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        private string _description;
        private string _environmentId;
        private string _environmentName;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private List<OptionSpecification> _optionsToRemove = new List<OptionSpecification>();
        private string _solutionStackName;
        private string _templateName;
        private EnvironmentTier _tier;
        private string _versionLabel;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateEnvironmentRequest() { }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  If this parameter is specified, AWS Elastic Beanstalk updates the description of
        /// this environment. 
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
        /// The ID of the environment to update.
        /// </para>
        ///  
        /// <para>
        ///  If no environment with this ID exists, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code>
        /// error. 
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this or an EnvironmentName, or both. If you do
        /// not specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
        /// error. 
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to update. If no environment with this name exists, AWS
        /// Elastic Beanstalk returns an <code>InvalidParameterValue</code> error. 
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this or an EnvironmentId, or both. If you do not
        /// specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
        /// error. 
        /// </para>
        /// </summary>
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
        ///  If specified, AWS Elastic Beanstalk updates the configuration set associated with
        /// the running environment and sets the specified configuration options to the requested
        /// value. 
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
        ///  A list of custom user-defined configuration options to remove from the configuration
        /// set for this environment. 
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
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        ///  This specifies the platform version that the environment will run after the environment
        /// is updated. 
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///  If this parameter is specified, AWS Elastic Beanstalk deploys this configuration
        /// template to the environment. If no such configuration template is found, AWS Elastic
        /// Beanstalk returns an <code>InvalidParameterValue</code> error. 
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

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        ///  This specifies the tier to use to update the environment. 
        /// </para>
        ///  
        /// <para>
        ///  Condition: You can only update the tier version for an environment. If you change
        /// the name of the type, AWS Elastic Beanstalk returns <code>InvalidParameterValue</code>
        /// error. 
        /// </para>
        /// </summary>
        public EnvironmentTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        ///  If this parameter is specified, AWS Elastic Beanstalk deploys the named application
        /// version to the environment. If no such application version is found, returns an <code>InvalidParameterValue</code>
        /// error. 
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}