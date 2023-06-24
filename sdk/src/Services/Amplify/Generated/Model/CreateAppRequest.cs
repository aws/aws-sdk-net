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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApp operation.
    /// Creates a new Amplify app.
    /// </summary>
    public partial class CreateAppRequest : AmazonAmplifyRequest
    {
        private string _accessToken;
        private AutoBranchCreationConfig _autoBranchCreationConfig;
        private List<string> _autoBranchCreationPatterns = new List<string>();
        private string _basicAuthCredentials;
        private string _buildSpec;
        private string _customHeaders;
        private List<CustomRule> _customRules = new List<CustomRule>();
        private string _description;
        private bool? _enableAutoBranchCreation;
        private bool? _enableBasicAuth;
        private bool? _enableBranchAutoBuild;
        private bool? _enableBranchAutoDeletion;
        private Dictionary<string, string> _environmentVariables = new Dictionary<string, string>();
        private string _iamServiceRoleArn;
        private string _name;
        private string _oauthToken;
        private Platform _platform;
        private string _repository;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The personal access token for a GitHub repository for an Amplify app. The personal
        /// access token is used to authorize access to a GitHub repository using the Amplify
        /// GitHub App. The token is not stored.
        /// </para>
        ///  
        /// <para>
        /// Use <code>accessToken</code> for GitHub repositories only. To authorize access to
        /// a repository provider such as Bitbucket or CodeCommit, use <code>oauthToken</code>.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>accessToken</code> or <code>oauthToken</code> when you
        /// create a new app.
        /// </para>
        ///  
        /// <para>
        /// Existing Amplify apps deployed from a GitHub repository using OAuth continue to work
        /// with CI/CD. However, we strongly recommend that you migrate these apps to use the
        /// GitHub App. For more information, see <a href="https://docs.aws.amazon.com/amplify/latest/UserGuide/setting-up-GitHub-access.html#migrating-to-github-app-auth">Migrating
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
        /// Gets and sets the property AutoBranchCreationConfig. 
        /// <para>
        ///  The automated branch creation configuration for an Amplify app. 
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
        ///  The automated branch creation glob patterns for an Amplify app. 
        /// </para>
        /// </summary>
        public List<string> AutoBranchCreationPatterns
        {
            get { return this._autoBranchCreationPatterns; }
            set { this._autoBranchCreationPatterns = value; }
        }

        // Check to see if AutoBranchCreationPatterns property is set
        internal bool IsSetAutoBranchCreationPatterns()
        {
            return this._autoBranchCreationPatterns != null && this._autoBranchCreationPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        ///  The credentials for basic authorization for an Amplify app. You must base64-encode
        /// the authorization credentials and provide them in the format <code>user:password</code>.
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
        ///  The build specification (build spec) for an Amplify app. 
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
        ///  The custom rewrite and redirect rules for an Amplify app. 
        /// </para>
        /// </summary>
        public List<CustomRule> CustomRules
        {
            get { return this._customRules; }
            set { this._customRules = value; }
        }

        // Check to see if CustomRules property is set
        internal bool IsSetCustomRules()
        {
            return this._customRules != null && this._customRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for an Amplify app. 
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
        ///  Enables automated branch creation for an Amplify app. 
        /// </para>
        /// </summary>
        public bool EnableAutoBranchCreation
        {
            get { return this._enableAutoBranchCreation.GetValueOrDefault(); }
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
        ///  Enables basic authorization for an Amplify app. This will apply to all branches that
        /// are part of this app. 
        /// </para>
        /// </summary>
        public bool EnableBasicAuth
        {
            get { return this._enableBasicAuth.GetValueOrDefault(); }
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
        ///  Enables the auto building of branches for an Amplify app. 
        /// </para>
        /// </summary>
        public bool EnableBranchAutoBuild
        {
            get { return this._enableBranchAutoBuild.GetValueOrDefault(); }
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
        ///  Automatically disconnects a branch in the Amplify Console when you delete a branch
        /// from your Git repository. 
        /// </para>
        /// </summary>
        public bool EnableBranchAutoDeletion
        {
            get { return this._enableBranchAutoDeletion.GetValueOrDefault(); }
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
        ///  The environment variables map for an Amplify app. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && this._environmentVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IamServiceRoleArn. 
        /// <para>
        ///  The AWS Identity and Access Management (IAM) service role for an Amplify app. 
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name for an Amplify app. 
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
        /// Gets and sets the property OauthToken. 
        /// <para>
        /// The OAuth token for a third-party source control system for an Amplify app. The OAuth
        /// token is used to create a webhook and a read-only deploy key using SSH cloning. The
        /// OAuth token is not stored.
        /// </para>
        ///  
        /// <para>
        /// Use <code>oauthToken</code> for repository providers other than GitHub, such as Bitbucket
        /// or CodeCommit. To authorize access to GitHub as your repository provider, use <code>accessToken</code>.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>oauthToken</code> or <code>accessToken</code> when you
        /// create a new app.
        /// </para>
        ///  
        /// <para>
        /// Existing Amplify apps deployed from a GitHub repository using OAuth continue to work
        /// with CI/CD. However, we strongly recommend that you migrate these apps to use the
        /// GitHub App. For more information, see <a href="https://docs.aws.amazon.com/amplify/latest/UserGuide/setting-up-GitHub-access.html#migrating-to-github-app-auth">Migrating
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
        ///  The platform for the Amplify app. For a static app, set the platform type to <code>WEB</code>.
        /// For a dynamic server-side rendered (SSR) app, set the platform type to <code>WEB_COMPUTE</code>.
        /// For an app requiring Amplify Hosting's original SSR support only, set the platform
        /// type to <code>WEB_DYNAMIC</code>.
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
        ///  The repository for an Amplify app. 
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tag for an Amplify app. 
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}