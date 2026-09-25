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
    /// Container for the parameters to the UpdateBranch operation. Updates a branch for an
    /// Amplify app.
    /// </summary>
    public partial class UpdateBranchRequest : AmazonAmplifyRequest
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property Backend. 
        /// <para>
        /// The backend for a <c>Branch</c> of an Amplify app. Use for a backend created from
        /// an CloudFormation stack.
        /// </para>
        ///  
        /// <para>
        /// This field is available to Amplify Gen 2 apps only. When you deploy an application
        /// with Amplify Gen 2, you provision the app's backend infrastructure using Typescript
        /// code.
        /// </para>
        /// </summary>
        public Backend Backend { get; set; }

        /// <summary>
        /// Checks to see if the Backend property is set.
        /// </summary>
        internal bool IsSetBackend() => this.Backend != null;

        /// <summary>
        /// Gets and sets the property BackendEnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a backend environment that is part of a Gen 1 Amplify
        /// app. 
        /// </para>
        ///  
        /// <para>
        /// This field is available to Amplify Gen 1 apps only where the backend is created using
        /// Amplify Studio or the Amplify command line interface (CLI).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string BackendEnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the BackendEnvironmentArn property is set.
        /// </summary>
        internal bool IsSetBackendEnvironmentArn() => this.BackendEnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        ///  The basic authorization credentials for the branch. You must base64-encode the authorization
        /// credentials and provide them in the format <c>user:password</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2000)]
        public string BasicAuthCredentials { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuthCredentials property is set.
        /// </summary>
        internal bool IsSetBasicAuthCredentials() => this.BasicAuthCredentials != null;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string BranchName { get; set; }

        /// <summary>
        /// Checks to see if the BranchName property is set.
        /// </summary>
        internal bool IsSetBranchName() => this.BranchName != null;

        /// <summary>
        /// Gets and sets the property BuildSpec. 
        /// <para>
        ///  The build specification (build spec) for the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 25000)]
        public string BuildSpec { get; set; }

        /// <summary>
        /// Checks to see if the BuildSpec property is set.
        /// </summary>
        internal bool IsSetBuildSpec() => this.BuildSpec != null;

        /// <summary>
        /// Gets and sets the property ComputeRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to assign to a branch of an SSR app.
        /// The SSR Compute role allows the Amplify Hosting compute service to securely access
        /// specific Amazon Web Services resources based on the role's permissions. For more information
        /// about the SSR Compute role, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/amplify-SSR-compute-role.html">Adding
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The display name for a branch. This is used as the default domain prefix. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EnableAutoBuild. 
        /// <para>
        ///  Enables auto building for the branch. 
        /// </para>
        /// </summary>
        public bool? EnableAutoBuild { get; set; }

        /// <summary>
        /// Checks to see if the EnableAutoBuild property is set.
        /// </summary>
        internal bool IsSetEnableAutoBuild() => this.EnableAutoBuild.HasValue;

        /// <summary>
        /// Gets and sets the property EnableBasicAuth. 
        /// <para>
        ///  Enables basic authorization for the branch. 
        /// </para>
        /// </summary>
        public bool? EnableBasicAuth { get; set; }

        /// <summary>
        /// Checks to see if the EnableBasicAuth property is set.
        /// </summary>
        internal bool IsSetEnableBasicAuth() => this.EnableBasicAuth.HasValue;

        /// <summary>
        /// Gets and sets the property EnableNotification. 
        /// <para>
        ///  Enables notifications for the branch. 
        /// </para>
        /// </summary>
        public bool? EnableNotification { get; set; }

        /// <summary>
        /// Checks to see if the EnableNotification property is set.
        /// </summary>
        internal bool IsSetEnableNotification() => this.EnableNotification.HasValue;

        /// <summary>
        /// Gets and sets the property EnablePerformanceMode. 
        /// <para>
        /// Enables performance mode for the branch.
        /// </para>
        ///  
        /// <para>
        /// Performance mode optimizes for faster hosting performance by keeping content cached
        /// at the edge for a longer interval. When performance mode is enabled, hosting configuration
        /// or code changes can take up to 10 minutes to roll out. 
        /// </para>
        /// </summary>
        public bool? EnablePerformanceMode { get; set; }

        /// <summary>
        /// Checks to see if the EnablePerformanceMode property is set.
        /// </summary>
        internal bool IsSetEnablePerformanceMode() => this.EnablePerformanceMode.HasValue;

        /// <summary>
        /// Gets and sets the property EnablePullRequestPreview. 
        /// <para>
        ///  Enables pull request previews for this branch. 
        /// </para>
        /// </summary>
        public bool? EnablePullRequestPreview { get; set; }

        /// <summary>
        /// Checks to see if the EnablePullRequestPreview property is set.
        /// </summary>
        internal bool IsSetEnablePullRequestPreview() => this.EnablePullRequestPreview.HasValue;

        /// <summary>
        /// Gets and sets the property EnableSkewProtection. 
        /// <para>
        /// Specifies whether the skew protection feature is enabled for the branch.
        /// </para>
        ///  
        /// <para>
        /// Deployment skew protection is available to Amplify applications to eliminate version
        /// skew issues between client and servers in web applications. When you apply skew protection
        /// to a branch, you can ensure that your clients always interact with the correct version
        /// of server-side assets, regardless of when a deployment occurs. For more information
        /// about skew protection, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/skew-protection.html">Skew
        /// protection for Amplify deployments</a> in the <i>Amplify User Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableSkewProtection { get; set; }

        /// <summary>
        /// Checks to see if the EnableSkewProtection property is set.
        /// </summary>
        internal bool IsSetEnableSkewProtection() => this.EnableSkewProtection.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        ///  The environment variables for the branch. 
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
        /// Gets and sets the property Framework. 
        /// <para>
        ///  The framework for the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Framework { get; set; }

        /// <summary>
        /// Checks to see if the Framework property is set.
        /// </summary>
        internal bool IsSetFramework() => this.Framework != null;

        /// <summary>
        /// Gets and sets the property PullRequestEnvironmentName. 
        /// <para>
        ///  The Amplify environment name for the pull request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public string PullRequestEnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestEnvironmentName property is set.
        /// </summary>
        internal bool IsSetPullRequestEnvironmentName() => this.PullRequestEnvironmentName != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        ///  Describes the current stage for the branch. 
        /// </para>
        /// </summary>
        public Stage Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        ///  The content Time to Live (TTL) for the website in seconds. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string Ttl { get; set; }

        /// <summary>
        /// Checks to see if the Ttl property is set.
        /// </summary>
        internal bool IsSetTtl() => this.Ttl != null;
    }
}
