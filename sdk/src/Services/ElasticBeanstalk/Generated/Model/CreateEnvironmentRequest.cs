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
    /// Container for the parameters to the CreateEnvironment operation.
    /// Launches an environment for the specified application using the specified configuration.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _cnamePrefix;
        private string _description;
        private string _environmentName;
        private string _groupName;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private List<OptionSpecification> _optionsToRemove = new List<OptionSpecification>();
        private string _solutionStackName;
        private List<Tag> _tags = new List<Tag>();
        private string _templateName;
        private EnvironmentTier _tier;
        private string _versionLabel;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateEnvironmentRequest() { }

        /// <summary>
        /// Instantiates CreateEnvironmentRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName"> The name of the application that contains the version to be deployed.   If no application is found with this name, <code>CreateEnvironment</code> returns an <code>InvalidParameterValue</code> error. </param>
        /// <param name="environmentName"> A unique name for the deployment environment. Used in the application URL.  Constraint: Must be from 4 to 23 characters in length. The name can contain only letters, numbers, and hyphens. It cannot start or end with a hyphen. This name must be unique in your account. If the specified name already exists, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code> error.  Default: If the CNAME parameter is not specified, the environment name becomes part of the CNAME, and therefore part of the visible URL for your application.</param>
        public CreateEnvironmentRequest(string applicationName, string environmentName)
        {
            _applicationName = applicationName;
            _environmentName = environmentName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///  The name of the application that contains the version to be deployed. 
        /// </para>
        ///  
        /// <para>
        ///  If no application is found with this name, <code>CreateEnvironment</code> returns
        /// an <code>InvalidParameterValue</code> error. 
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
        /// Gets and sets the property CNAMEPrefix. 
        /// <para>
        ///  If specified, the environment attempts to use this value as the prefix for the CNAME.
        /// If not specified, the CNAME is generated automatically by appending a random alphanumeric
        /// string to the environment name. 
        /// </para>
        /// </summary>
        public string CNAMEPrefix
        {
            get { return this._cnamePrefix; }
            set { this._cnamePrefix = value; }
        }

        // Check to see if CNAMEPrefix property is set
        internal bool IsSetCNAMEPrefix()
        {
            return this._cnamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes this environment.
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        ///  A unique name for the deployment environment. Used in the application URL. 
        /// </para>
        ///  
        /// <para>
        /// Constraint: Must be from 4 to 23 characters in length. The name can contain only letters,
        /// numbers, and hyphens. It cannot start or end with a hyphen. This name must be unique
        /// in your account. If the specified name already exists, AWS Elastic Beanstalk returns
        /// an <code>InvalidParameterValue</code> error. 
        /// </para>
        ///  
        /// <para>
        /// Default: If the CNAME parameter is not specified, the environment name becomes part
        /// of the CNAME, and therefore part of the visible URL for your application.
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group to which the target environment belongs. Specify a group name
        /// only if the environment's name is specified in an environment manifest and not with
        /// the environment name parameter. See <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-mgmt-compose.html#environment-mgmt-compose-envyaml">Environment
        /// Manifest (env.yaml)</a> for details.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        ///  If specified, AWS Elastic Beanstalk sets the specified configuration options to the
        /// requested value in the configuration set for the new environment. These override the
        /// values obtained from the solution stack or the configuration template. 
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
        /// set for this new environment. 
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
        ///  This is an alternative to specifying a template name. If specified, AWS Elastic Beanstalk
        /// sets the configuration values to the default values associated with the specified
        /// solution stack. 
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this or a <code>TemplateName</code>, but not both.
        /// If you specify both, AWS Elastic Beanstalk returns an <code>InvalidParameterCombination</code>
        /// error. If you do not specify either, AWS Elastic Beanstalk returns a <code>MissingRequiredParameter</code>
        /// error. 
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  This specifies the tags applied to resources in the environment. 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///  The name of the configuration template to use in deployment. If no configuration
        /// template is found with this name, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code>
        /// error. 
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this parameter or a <code>SolutionStackName</code>,
        /// but not both. If you specify both, AWS Elastic Beanstalk returns an <code>InvalidParameterCombination</code>
        /// error. If you do not specify either, AWS Elastic Beanstalk returns a <code>MissingRequiredParameter</code>
        /// error. 
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
        ///  This specifies the tier to use for creating this environment. 
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
        /// The name of the application version to deploy.
        /// </para>
        ///  
        /// <para>
        ///  If the specified application has no associated application versions, AWS Elastic
        /// Beanstalk <code>UpdateEnvironment</code> returns an <code>InvalidParameterValue</code>
        /// error. 
        /// </para>
        ///  
        /// <para>
        ///  Default: If not specified, AWS Elastic Beanstalk attempts to launch the sample application
        /// in the container. 
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