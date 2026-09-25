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
    /// Describes the automated branch creation configuration.
    /// </summary>
    public partial class AutoBranchCreationConfig
    {
        /// <summary>
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        /// The basic authorization credentials for the autocreated branch. You must base64-encode
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
        /// The build specification (build spec) for the autocreated branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 25000)]
        public string BuildSpec { get; set; }

        /// <summary>
        /// Checks to see if the BuildSpec property is set.
        /// </summary>
        internal bool IsSetBuildSpec() => this.BuildSpec != null;

        /// <summary>
        /// Gets and sets the property EnableAutoBuild. 
        /// <para>
        /// Enables auto building for the autocreated branch. 
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
        /// Enables basic authorization for the autocreated branch. 
        /// </para>
        /// </summary>
        public bool? EnableBasicAuth { get; set; }

        /// <summary>
        /// Checks to see if the EnableBasicAuth property is set.
        /// </summary>
        internal bool IsSetEnableBasicAuth() => this.EnableBasicAuth.HasValue;

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
        /// Enables pull request previews for the autocreated branch. 
        /// </para>
        /// </summary>
        public bool? EnablePullRequestPreview { get; set; }

        /// <summary>
        /// Checks to see if the EnablePullRequestPreview property is set.
        /// </summary>
        internal bool IsSetEnablePullRequestPreview() => this.EnablePullRequestPreview.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables for the autocreated branch. 
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
        /// The framework for the autocreated branch. 
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
        /// The Amplify environment name for the pull request. 
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
        /// Describes the current stage for the autocreated branch. 
        /// </para>
        /// </summary>
        public Stage Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}
