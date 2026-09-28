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
    /// Represents the different branches of a repository for building, deploying, and hosting
    /// an Amplify app.
    /// </summary>
    public partial class App
    {
        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID of the Amplify app. 
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
        /// Describes the automated branch creation configuration for the Amplify app. 
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
        /// Describes the automated branch creation glob patterns for the Amplify app. 
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
        /// The basic authorization credentials for branches for the Amplify app. You must base64-encode
        /// the authorization credentials and provide them in the format <c>user:password</c>.
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
        /// Describes the content of the build specification (build spec) for the Amplify app.
        /// 
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
        /// The cache configuration for the Amplify app. If you don't specify the cache configuration
        /// <c>type</c>, Amplify uses the default <c>AMPLIFY_MANAGED</c> setting.
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
        /// The Amazon Resource Name (ARN) of the IAM role for an SSR app. The Compute role allows
        /// the Amplify Hosting compute service to securely access specific Amazon Web Services
        /// resources based on the role's permissions. For more information about the SSR Compute
        /// role, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/amplify-SSR-compute-role.html">Adding
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// A timestamp of when Amplify created the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomHeaders. 
        /// <para>
        /// Describes the custom HTTP headers for the Amplify app.
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
        /// Describes the custom redirect and rewrite rules for the Amplify app. 
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
        /// Gets and sets the property DefaultDomain. 
        /// <para>
        /// The default domain for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string DefaultDomain { get; set; }

        /// <summary>
        /// Checks to see if the DefaultDomain property is set.
        /// </summary>
        internal bool IsSetDefaultDomain() => this.DefaultDomain != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnableAutoBranchCreation. 
        /// <para>
        /// Enables automated branch creation for the Amplify app. 
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
        /// Enables basic authorization for the Amplify app's branches. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EnableBasicAuth { get; set; }

        /// <summary>
        /// Checks to see if the EnableBasicAuth property is set.
        /// </summary>
        internal bool IsSetEnableBasicAuth() => this.EnableBasicAuth.HasValue;

        /// <summary>
        /// Gets and sets the property EnableBranchAutoBuild. 
        /// <para>
        /// Enables the auto-building of branches for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EnableBranchAutoBuild { get; set; }

        /// <summary>
        /// Checks to see if the EnableBranchAutoBuild property is set.
        /// </summary>
        internal bool IsSetEnableBranchAutoBuild() => this.EnableBranchAutoBuild.HasValue;

        /// <summary>
        /// Gets and sets the property EnableBranchAutoDeletion. 
        /// <para>
        /// Automatically disconnect a branch in the Amplify console when you delete a branch
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
        /// The environment variables for the Amplify app. 
        /// </para>
        ///  
        /// <para>
        /// For a list of the environment variables that are accessible to Amplify by default,
        /// see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/amplify-console-environment-variables.html">Amplify
        /// Environment variables</a> in the <i>Amplify Hosting User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// The configuration details that apply to the jobs for an Amplify app.
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
        /// The name for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        [AWSProperty(Required = true)]
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property ProductionBranch. 
        /// <para>
        /// Describes the information about a production branch of the Amplify app. 
        /// </para>
        /// </summary>
        public ProductionBranch ProductionBranch { get; set; }

        /// <summary>
        /// Checks to see if the ProductionBranch property is set.
        /// </summary>
        internal bool IsSetProductionBranch() => this.ProductionBranch != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The Git repository for the Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;

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
        public RepositoryCloneMethod RepositoryCloneMethod { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryCloneMethod property is set.
        /// </summary>
        internal bool IsSetRepositoryCloneMethod() => this.RepositoryCloneMethod != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag for the Amplify app. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// A timestamp of when Amplify updated the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property WafConfiguration. 
        /// <para>
        /// Describes the Firewall configuration for the Amplify app. Firewall support enables
        /// you to protect your hosted applications with a direct integration with WAF.
        /// </para>
        /// </summary>
        public WafConfiguration WafConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WafConfiguration property is set.
        /// </summary>
        internal bool IsSetWafConfiguration() => this.WafConfiguration != null;

        /// <summary>
        /// Gets and sets the property WebhookCreateTime. 
        /// <para>
        /// A timestamp of when Amplify created the webhook in your Git repository.
        /// </para>
        /// </summary>
        public DateTime? WebhookCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the WebhookCreateTime property is set.
        /// </summary>
        internal bool IsSetWebhookCreateTime() => this.WebhookCreateTime.HasValue;
    }
}
