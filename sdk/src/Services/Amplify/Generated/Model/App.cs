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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Represents the different branches of a repository for building, deploying, and hosting
    /// an Amplify app.
    /// </summary>
    public partial class App
    {
        private string _appArn;
        private string _appId;
        private AutoBranchCreationConfig _autoBranchCreationConfig;
        private List<string> _autoBranchCreationPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _basicAuthCredentials;
        private string _buildSpec;
        private CacheConfig _cacheConfig;
        private string _computeRoleArn;
        private DateTime? _createTime;
        private string _customHeaders;
        private List<CustomRule> _customRules = AWSConfigs.InitializeCollections ? new List<CustomRule>() : null;
        private string _defaultDomain;
        private string _description;
        private bool? _enableAutoBranchCreation;
        private bool? _enableBasicAuth;
        private bool? _enableBranchAutoBuild;
        private bool? _enableBranchAutoDeletion;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _iamServiceRoleArn;
        private JobConfig _jobConfig;
        private string _name;
        private Platform _platform;
        private ProductionBranch _productionBranch;
        private string _repository;
        private RepositoryCloneMethod _repositoryCloneMethod;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updateTime;
        private WafConfiguration _wafConfiguration;
        private DateTime? _webhookCreateTime;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID of the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AutoBranchCreationConfig. 
        /// <para>
        /// Describes the automated branch creation configuration for the Amplify app. 
        /// </para>
        /// </summary>
        public AutoBranchCreationConfig AutoBranchCreationConfig
        {
            get { return this._autoBranchCreationConfig; }
            set { this._autoBranchCreationConfig = value; }
        }

        // Check to see if AutoBranchCreationConfig property is set
        internal bool IsSetAutoBranchCreationConfig()
        {
            return this._autoBranchCreationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AutoBranchCreationPatterns. 
        /// <para>
        /// Describes the automated branch creation glob patterns for the Amplify app. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoBranchCreationPatterns
        {
            get { return this._autoBranchCreationPatterns; }
            set { this._autoBranchCreationPatterns = value; }
        }

        // Check to see if AutoBranchCreationPatterns property is set
        internal bool IsSetAutoBranchCreationPatterns()
        {
            return this._autoBranchCreationPatterns != null && (this._autoBranchCreationPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        /// The basic authorization credentials for branches for the Amplify app. You must base64-encode
        /// the authorization credentials and provide them in the format <c>user:password</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=2000)]
        public string BasicAuthCredentials
        {
            get { return this._basicAuthCredentials; }
            set { this._basicAuthCredentials = value; }
        }

        // Check to see if BasicAuthCredentials property is set
        internal bool IsSetBasicAuthCredentials()
        {
            return this._basicAuthCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property BuildSpec. 
        /// <para>
        /// Describes the content of the build specification (build spec) for the Amplify app.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=25000)]
        public string BuildSpec
        {
            get { return this._buildSpec; }
            set { this._buildSpec = value; }
        }

        // Check to see if BuildSpec property is set
        internal bool IsSetBuildSpec()
        {
            return this._buildSpec != null;
        }

        /// <summary>
        /// Gets and sets the property CacheConfig. 
        /// <para>
        /// The cache configuration for the Amplify app. If you don't specify the cache configuration
        /// <c>type</c>, Amplify uses the default <c>AMPLIFY_MANAGED</c> setting.
        /// </para>
        /// </summary>
        public CacheConfig CacheConfig
        {
            get { return this._cacheConfig; }
            set { this._cacheConfig = value; }
        }

        // Check to see if CacheConfig property is set
        internal bool IsSetCacheConfig()
        {
            return this._cacheConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role for an SSR app. The Compute role allows
        /// the Amplify Hosting compute service to securely access specific Amazon Web Services
        /// resources based on the role's permissions. For more information about the SSR Compute
        /// role, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/amplify-SSR-compute-role.html">Adding
        /// an SSR Compute role</a> in the <i>Amplify User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ComputeRoleArn
        {
            get { return this._computeRoleArn; }
            set { this._computeRoleArn = value; }
        }

        // Check to see if ComputeRoleArn property is set
        internal bool IsSetComputeRoleArn()
        {
            return this._computeRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// A timestamp of when Amplify created the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomHeaders. 
        /// <para>
        /// Describes the custom HTTP headers for the Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25000)]
        public string CustomHeaders
        {
            get { return this._customHeaders; }
            set { this._customHeaders = value; }
        }

        // Check to see if CustomHeaders property is set
        internal bool IsSetCustomHeaders()
        {
            return this._customHeaders != null;
        }

        /// <summary>
        /// Gets and sets the property CustomRules. 
        /// <para>
        /// Describes the custom redirect and rewrite rules for the Amplify app. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomRule> CustomRules
        {
            get { return this._customRules; }
            set { this._customRules = value; }
        }

        // Check to see if CustomRules property is set
        internal bool IsSetCustomRules()
        {
            return this._customRules != null && (this._customRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultDomain. 
        /// <para>
        /// The default domain for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string DefaultDomain
        {
            get { return this._defaultDomain; }
            set { this._defaultDomain = value; }
        }

        // Check to see if DefaultDomain property is set
        internal bool IsSetDefaultDomain()
        {
            return this._defaultDomain != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
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
        /// Gets and sets the property EnableAutoBranchCreation. 
        /// <para>
        /// Enables automated branch creation for the Amplify app. 
        /// </para>
        /// </summary>
        public bool? EnableAutoBranchCreation
        {
            get { return this._enableAutoBranchCreation; }
            set { this._enableAutoBranchCreation = value; }
        }

        // Check to see if EnableAutoBranchCreation property is set
        internal bool IsSetEnableAutoBranchCreation()
        {
            return this._enableAutoBranchCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableBasicAuth. 
        /// <para>
        /// Enables basic authorization for the Amplify app's branches. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnableBasicAuth
        {
            get { return this._enableBasicAuth; }
            set { this._enableBasicAuth = value; }
        }

        // Check to see if EnableBasicAuth property is set
        internal bool IsSetEnableBasicAuth()
        {
            return this._enableBasicAuth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableBranchAutoBuild. 
        /// <para>
        /// Enables the auto-building of branches for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnableBranchAutoBuild
        {
            get { return this._enableBranchAutoBuild; }
            set { this._enableBranchAutoBuild = value; }
        }

        // Check to see if EnableBranchAutoBuild property is set
        internal bool IsSetEnableBranchAutoBuild()
        {
            return this._enableBranchAutoBuild.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableBranchAutoDeletion. 
        /// <para>
        /// Automatically disconnect a branch in the Amplify console when you delete a branch
        /// from your Git repository.
        /// </para>
        /// </summary>
        public bool? EnableBranchAutoDeletion
        {
            get { return this._enableBranchAutoDeletion; }
            set { this._enableBranchAutoDeletion = value; }
        }

        // Check to see if EnableBranchAutoDeletion property is set
        internal bool IsSetEnableBranchAutoDeletion()
        {
            return this._enableBranchAutoDeletion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables for the Amplify app. 
        /// </para>
        ///  
        /// <para>
        /// For a list of the environment variables that are accessible to Amplify by default,
        /// see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/amplify-console-environment-variables.html">Amplify
        /// Environment variables</a> in the <i>Amplify Hosting User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IamServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role for the Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string IamServiceRoleArn
        {
            get { return this._iamServiceRoleArn; }
            set { this._iamServiceRoleArn = value; }
        }

        // Check to see if IamServiceRoleArn property is set
        internal bool IsSetIamServiceRoleArn()
        {
            return this._iamServiceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobConfig. 
        /// <para>
        /// The configuration details that apply to the jobs for an Amplify app.
        /// </para>
        /// </summary>
        public JobConfig JobConfig
        {
            get { return this._jobConfig; }
            set { this._jobConfig = value; }
        }

        // Check to see if JobConfig property is set
        internal bool IsSetJobConfig()
        {
            return this._jobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform for the Amplify app. For a static app, set the platform type to <c>WEB</c>.
        /// For a dynamic server-side rendered (SSR) app, set the platform type to <c>WEB_COMPUTE</c>.
        /// For an app requiring Amplify Hosting's original SSR support only, set the platform
        /// type to <c>WEB_DYNAMIC</c>.
        /// </para>
        ///  
        /// <para>
        /// If you are deploying an SSG only app with Next.js 14 or later, you must use the platform
        /// type <c>WEB_COMPUTE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Platform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property ProductionBranch. 
        /// <para>
        /// Describes the information about a production branch of the Amplify app. 
        /// </para>
        /// </summary>
        public ProductionBranch ProductionBranch
        {
            get { return this._productionBranch; }
            set { this._productionBranch = value; }
        }

        // Check to see if ProductionBranch property is set
        internal bool IsSetProductionBranch()
        {
            return this._productionBranch != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The Git repository for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryCloneMethod. <note> 
        /// <para>
        /// This is for internal use.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amplify service uses this parameter to specify the authentication protocol to
        /// use to access the Git repository for an Amplify app. Amplify specifies <c>TOKEN</c>
        /// for a GitHub repository, <c>SIGV4</c> for an Amazon Web Services CodeCommit repository,
        /// and <c>SSH</c> for GitLab and Bitbucket repositories.
        /// </para>
        /// </summary>
        public RepositoryCloneMethod RepositoryCloneMethod
        {
            get { return this._repositoryCloneMethod; }
            set { this._repositoryCloneMethod = value; }
        }

        // Check to see if RepositoryCloneMethod property is set
        internal bool IsSetRepositoryCloneMethod()
        {
            return this._repositoryCloneMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag for the Amplify app. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// A timestamp of when Amplify updated the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WafConfiguration. 
        /// <para>
        /// Describes the Firewall configuration for the Amplify app. Firewall support enables
        /// you to protect your hosted applications with a direct integration with WAF.
        /// </para>
        /// </summary>
        public WafConfiguration WafConfiguration
        {
            get { return this._wafConfiguration; }
            set { this._wafConfiguration = value; }
        }

        // Check to see if WafConfiguration property is set
        internal bool IsSetWafConfiguration()
        {
            return this._wafConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WebhookCreateTime. 
        /// <para>
        /// A timestamp of when Amplify created the webhook in your Git repository.
        /// </para>
        /// </summary>
        public DateTime? WebhookCreateTime
        {
            get { return this._webhookCreateTime; }
            set { this._webhookCreateTime = value; }
        }

        // Check to see if WebhookCreateTime property is set
        internal bool IsSetWebhookCreateTime()
        {
            return this._webhookCreateTime.HasValue; 
        }

    }
}