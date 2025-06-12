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
    /// Container for the parameters to the UpdateApp operation.
    /// Updates an existing Amplify app.
    /// </summary>
    public partial class UpdateAppRequest : AmazonAmplifyRequest
    {
        private string _accessToken;
        private string _appId;
        private AutoBranchCreationConfig _autoBranchCreationConfig;
        private List<string> _autoBranchCreationPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _basicAuthCredentials;
        private string _buildSpec;
        private CacheConfig _cacheConfig;
        private string _computeRoleArn;
        private string _customHeaders;
        private List<CustomRule> _customRules = AWSConfigs.InitializeCollections ? new List<CustomRule>() : null;
        private string _description;
        private bool? _enableAutoBranchCreation;
        private bool? _enableBasicAuth;
        private bool? _enableBranchAutoBuild;
        private bool? _enableBranchAutoDeletion;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _iamServiceRoleArn;
        private JobConfig _jobConfig;
        private string _name;
        private string _oauthToken;
        private Platform _platform;
        private string _repository;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The personal access token for a GitHub repository for an Amplify app. The personal
        /// access token is used to authorize access to a GitHub repository using the Amplify
        /// GitHub App. The token is not stored.
        /// </para>
        ///  
        /// <para>
        /// Use <c>accessToken</c> for GitHub repositories only. To authorize access to a repository
        /// provider such as Bitbucket or CodeCommit, use <c>oauthToken</c>.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>accessToken</c> or <c>oauthToken</c> when you update an
        /// app.
        /// </para>
        ///  
        /// <para>
        /// Existing Amplify apps deployed from a GitHub repository using OAuth continue to work
        /// with CI/CD. However, we strongly recommend that you migrate these apps to use the
        /// GitHub App. For more information, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/setting-up-GitHub-access.html#migrating-to-github-app-auth">Migrating
        /// an existing OAuth app to the Amplify GitHub App</a> in the <i>Amplify User Guide</i>
        /// .
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID for an Amplify app. 
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
        /// The automated branch creation configuration for an Amplify app. 
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
        /// Describes the automated branch creation glob patterns for an Amplify app. 
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
        /// The basic authorization credentials for an Amplify app. You must base64-encode the
        /// authorization credentials and provide them in the format <c>user:password</c>.
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
        /// The build specification (build spec) for an Amplify app. 
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
        /// The cache configuration for the Amplify app.
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
        /// The Amazon Resource Name (ARN) of the IAM role to assign to an SSR app. The SSR Compute
        /// role allows the Amplify Hosting compute service to securely access specific Amazon
        /// Web Services resources based on the role's permissions. For more information about
        /// the SSR Compute role, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/amplify-SSR-compute-role.html">Adding
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
        /// Gets and sets the property CustomHeaders. 
        /// <para>
        /// The custom HTTP headers for an Amplify app.
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
        /// The custom redirect and rewrite rules for an Amplify app. 
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        /// Enables automated branch creation for an Amplify app. 
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
        /// Enables basic authorization for an Amplify app. 
        /// </para>
        /// </summary>
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
        /// Enables branch auto-building for an Amplify app. 
        /// </para>
        /// </summary>
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
        /// Automatically disconnects a branch in the Amplify console when you delete a branch
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
        /// The environment variables for an Amplify app. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Describes the configuration details that apply to the jobs for an Amplify app.
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
        /// The name for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property OauthToken. 
        /// <para>
        /// The OAuth token for a third-party source control system for an Amplify app. The OAuth
        /// token is used to create a webhook and a read-only deploy key using SSH cloning. The
        /// OAuth token is not stored.
        /// </para>
        ///  
        /// <para>
        /// Use <c>oauthToken</c> for repository providers other than GitHub, such as Bitbucket
        /// or CodeCommit.
        /// </para>
        ///  
        /// <para>
        /// To authorize access to GitHub as your repository provider, use <c>accessToken</c>.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>oauthToken</c> or <c>accessToken</c> when you update an
        /// app.
        /// </para>
        ///  
        /// <para>
        /// Existing Amplify apps deployed from a GitHub repository using OAuth continue to work
        /// with CI/CD. However, we strongly recommend that you migrate these apps to use the
        /// GitHub App. For more information, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/setting-up-GitHub-access.html#migrating-to-github-app-auth">Migrating
        /// an existing OAuth app to the Amplify GitHub App</a> in the <i>Amplify User Guide</i>
        /// .
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1000)]
        public string OauthToken
        {
            get { return this._oauthToken; }
            set { this._oauthToken = value; }
        }

        // Check to see if OauthToken property is set
        internal bool IsSetOauthToken()
        {
            return this._oauthToken != null;
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
        /// If you are deploying an SSG only app with Next.js version 14 or later, you must set
        /// the platform type to <c>WEB_COMPUTE</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the Git repository for an Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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

    }
}