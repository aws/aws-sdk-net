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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateApp operation. Updates an existing Amplify
    /// app.
    /// </summary>
    public partial class UpdateAppRequest : AmazonAmplifyRequest
    {
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
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property AutoBranchCreationConfig. 
        /// <para>
        /// The automated branch creation configuration for an Amplify app. 
        /// </para>
        /// </summary>
        public AutoBranchCreationConfig AutoBranchCreationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AutoBranchCreationConfig property is set.
        /// </summary>
        internal bool IsSetAutoBranchCreationConfig() => this.AutoBranchCreationConfig != null;

        /// <summary>
        /// Gets and sets the property AutoBranchCreationPatterns. 
        /// <para>
        /// Describes the automated branch creation glob patterns for an Amplify app. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoBranchCreationPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoBranchCreationPatterns property is set.
        /// </summary>
        internal bool IsSetAutoBranchCreationPatterns() => this.AutoBranchCreationPatterns != null && (this.AutoBranchCreationPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        /// The basic authorization credentials for an Amplify app. You must base64-encode the
        /// authorization credentials and provide them in the format <c>user:password</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2000)]
        public string BasicAuthCredentials { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuthCredentials property is set.
        /// </summary>
        internal bool IsSetBasicAuthCredentials() => this.BasicAuthCredentials != null;

        /// <summary>
        /// Gets and sets the property BuildSpec. 
        /// <para>
        /// The build specification (build spec) for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 25000)]
        public string BuildSpec { get; set; }

        /// <summary>
        /// Checks to see if the BuildSpec property is set.
        /// </summary>
        internal bool IsSetBuildSpec() => this.BuildSpec != null;

        /// <summary>
        /// Gets and sets the property CacheConfig. 
        /// <para>
        /// The cache configuration for the Amplify app.
        /// </para>
        /// </summary>
        public CacheConfig CacheConfig { get; set; }

        /// <summary>
        /// Checks to see if the CacheConfig property is set.
        /// </summary>
        internal bool IsSetCacheConfig() => this.CacheConfig != null;

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
        [AWSProperty(Min = 0, Max = 1000)]
        public string ComputeRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ComputeRoleArn property is set.
        /// </summary>
        internal bool IsSetComputeRoleArn() => this.ComputeRoleArn != null;

        /// <summary>
        /// Gets and sets the property CustomHeaders. 
        /// <para>
        /// The custom HTTP headers for an Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25000)]
        public string CustomHeaders { get; set; }

        /// <summary>
        /// Checks to see if the CustomHeaders property is set.
        /// </summary>
        internal bool IsSetCustomHeaders() => this.CustomHeaders != null;

        /// <summary>
        /// Gets and sets the property CustomRules. 
        /// <para>
        /// The custom redirect and rewrite rules for an Amplify app. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomRule> CustomRules { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomRule>() : null;

        /// <summary>
        /// Checks to see if the CustomRules property is set.
        /// </summary>
        internal bool IsSetCustomRules() => this.CustomRules != null && (this.CustomRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnableAutoBranchCreation. 
        /// <para>
        /// Enables automated branch creation for an Amplify app. 
        /// </para>
        /// </summary>
        public bool? EnableAutoBranchCreation { get; set; }

        /// <summary>
        /// Checks to see if the EnableAutoBranchCreation property is set.
        /// </summary>
        internal bool IsSetEnableAutoBranchCreation() => this.EnableAutoBranchCreation.HasValue;

        /// <summary>
        /// Gets and sets the property EnableBasicAuth. 
        /// <para>
        /// Enables basic authorization for an Amplify app. 
        /// </para>
        /// </summary>
        public bool? EnableBasicAuth { get; set; }

        /// <summary>
        /// Checks to see if the EnableBasicAuth property is set.
        /// </summary>
        internal bool IsSetEnableBasicAuth() => this.EnableBasicAuth.HasValue;

        /// <summary>
        /// Gets and sets the property EnableBranchAutoBuild. 
        /// <para>
        /// Enables branch auto-building for an Amplify app. 
        /// </para>
        /// </summary>
        public bool? EnableBranchAutoBuild { get; set; }

        /// <summary>
        /// Checks to see if the EnableBranchAutoBuild property is set.
        /// </summary>
        internal bool IsSetEnableBranchAutoBuild() => this.EnableBranchAutoBuild.HasValue;

        /// <summary>
        /// Gets and sets the property EnableBranchAutoDeletion. 
        /// <para>
        /// Automatically disconnects a branch in the Amplify console when you delete a branch
        /// from your Git repository. 
        /// </para>
        /// </summary>
        public bool? EnableBranchAutoDeletion { get; set; }

        /// <summary>
        /// Checks to see if the EnableBranchAutoDeletion property is set.
        /// </summary>
        internal bool IsSetEnableBranchAutoDeletion() => this.EnableBranchAutoDeletion.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables for an Amplify app. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IamServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role for the Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string IamServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetIamServiceRoleArn() => this.IamServiceRoleArn != null;

        /// <summary>
        /// Gets and sets the property JobConfig. 
        /// <para>
        /// Describes the configuration details that apply to the jobs for an Amplify app.
        /// </para>
        /// </summary>
        public JobConfig JobConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobConfig property is set.
        /// </summary>
        internal bool IsSetJobConfig() => this.JobConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string OauthToken { get; set; }

        /// <summary>
        /// Checks to see if the OauthToken property is set.
        /// </summary>
        internal bool IsSetOauthToken() => this.OauthToken != null;

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
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the Git repository for an Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}
