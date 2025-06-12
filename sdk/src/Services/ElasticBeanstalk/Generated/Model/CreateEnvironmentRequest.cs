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
    /// Container for the parameters to the CreateEnvironment operation.
    /// Launches an AWS Elastic Beanstalk environment for the specified application using
    /// the specified configuration.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _cnamePrefix;
        private string _description;
        private string _environmentName;
        private string _groupName;
        private string _operationsRole;
        private List<ConfigurationOptionSetting> _optionSettings = AWSConfigs.InitializeCollections ? new List<ConfigurationOptionSetting>() : null;
        private List<OptionSpecification> _optionsToRemove = AWSConfigs.InitializeCollections ? new List<OptionSpecification>() : null;
        private string _platformArn;
        private string _solutionStackName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
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
        /// <param name="applicationName">The name of the application that is associated with this environment.</param>
        /// <param name="environmentName">A unique name for the environment. Constraint: Must be from 4 to 40 characters in length. The name can contain only letters, numbers, and hyphens. It can't start or end with a hyphen. This name must be unique within a region in your account. If the specified name already exists in the region, Elastic Beanstalk returns an <c>InvalidParameterValue</c> error.  If you don't specify the <c>CNAMEPrefix</c> parameter, the environment name becomes part of the CNAME, and therefore part of the visible URL for your application.</param>
        public CreateEnvironmentRequest(string applicationName, string environmentName)
        {
            _applicationName = applicationName;
            _environmentName = environmentName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application that is associated with this environment.
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
        /// Gets and sets the property CNAMEPrefix. 
        /// <para>
        /// If specified, the environment attempts to use this value as the prefix for the CNAME
        /// in your Elastic Beanstalk environment URL. If not specified, the CNAME is generated
        /// automatically by appending a random alphanumeric string to the environment name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=63)]
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
        /// Your description for this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
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
        /// A unique name for the environment.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Must be from 4 to 40 characters in length. The name can contain only letters,
        /// numbers, and hyphens. It can't start or end with a hyphen. This name must be unique
        /// within a region in your account. If the specified name already exists in the region,
        /// Elastic Beanstalk returns an <c>InvalidParameterValue</c> error. 
        /// </para>
        ///  
        /// <para>
        /// If you don't specify the <c>CNAMEPrefix</c> parameter, the environment name becomes
        /// part of the CNAME, and therefore part of the visible URL for your application.
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group to which the target environment belongs. Specify a group name
        /// only if the environment's name is specified in an environment manifest and not with
        /// the environment name parameter. See <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-cfg-manifest.html">Environment
        /// Manifest (env.yaml)</a> for details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
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
        /// Gets and sets the property OperationsRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an existing IAM role to be used as the environment's
        /// operations role. If specified, Elastic Beanstalk uses the operations role for permissions
        /// to downstream services during this call and during subsequent calls acting on this
        /// environment. To specify an operations role, you must have the <c>iam:PassRole</c>
        /// permission for the role. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/iam-operationsrole.html">Operations
        /// roles</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OperationsRole
        {
            get { return this._operationsRole; }
            set { this._operationsRole = value; }
        }

        // Check to see if OperationsRole property is set
        internal bool IsSetOperationsRole()
        {
            return this._operationsRole != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk sets the specified configuration options to the
        /// requested value in the configuration set for the new environment. These override the
        /// values obtained from the solution stack or the configuration template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property OptionsToRemove. 
        /// <para>
        /// A list of custom user-defined configuration options to remove from the configuration
        /// set for this new environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionSpecification> OptionsToRemove
        {
            get { return this._optionsToRemove; }
            set { this._optionsToRemove = value; }
        }

        // Check to see if OptionsToRemove property is set
        internal bool IsSetOptionsToRemove()
        {
            return this._optionsToRemove != null && (this._optionsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom platform to use with the environment.
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/custom-platforms.html">Custom
        /// Platforms</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>PlatformArn</c>, don't specify <c>SolutionStackName</c>.
        /// </para>
        ///  </note>
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
        /// The name of an Elastic Beanstalk solution stack (platform version) to use with the
        /// environment. If specified, Elastic Beanstalk sets the configuration values to the
        /// default values associated with the specified solution stack. For a list of current
        /// solution stacks, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/platforms/platforms-supported.html">Elastic
        /// Beanstalk Supported Platforms</a> in the <i>AWS Elastic Beanstalk Platforms</i> guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>SolutionStackName</c>, don't specify <c>PlatformArn</c> or <c>TemplateName</c>.
        /// </para>
        ///  </note>
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
        /// Specifies the tags applied to resources in the environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the Elastic Beanstalk configuration template to use with the environment.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>TemplateName</c>, then don't specify <c>SolutionStackName</c>.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// Specifies the tier to use in creating this environment. The environment tier that
        /// you choose determines whether Elastic Beanstalk provisions resources to support a
        /// web application that handles HTTP(S) requests or a web application that handles background-processing
        /// tasks.
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
        /// Default: If not specified, Elastic Beanstalk attempts to deploy the sample application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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