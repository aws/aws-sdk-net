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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebhook operation. Updates the webhook associated
    /// with an CodeBuild build project. <note> <para> If you use Bitbucket for your repository,
    /// <c>rotateSecret</c> is ignored. </para> </note>
    /// </summary>
    public partial class UpdateWebhookRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property BranchFilter. 
        /// <para>
        /// A regular expression used to determine which repository branches are built when a
        /// webhook is triggered. If the name of a branch matches the regular expression, then
        /// it is built. If <c>branchFilter</c> is empty, then all branches are built.
        /// </para>
        ///  <note> 
        /// <para>
        ///  It is recommended that you use <c>filterGroups</c> instead of <c>branchFilter</c>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public string BranchFilter { get; set; }

        /// <summary>
        /// Checks to see if the BranchFilter property is set.
        /// </summary>
        internal bool IsSetBranchFilter() => this.BranchFilter != null;

        /// <summary>
        /// Gets and sets the property BuildType. 
        /// <para>
        /// Specifies the type of build this webhook will trigger.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>RUNNER_BUILDKITE_BUILD</c> is only available for <c>NO_SOURCE</c> source type
        /// projects configured for Buildkite runner builds. For more information about CodeBuild-hosted
        /// Buildkite runner builds, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/sample-runner-buildkite.html">Tutorial:
        /// Configure a CodeBuild-hosted Buildkite runner</a> in the <i>CodeBuild user guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public WebhookBuildType BuildType { get; set; }

        /// <summary>
        /// Checks to see if the BuildType property is set.
        /// </summary>
        internal bool IsSetBuildType() => this.BuildType != null;

        /// <summary>
        /// Gets and sets the property FilterGroups. 
        /// <para>
        ///  An array of arrays of <c>WebhookFilter</c> objects used to determine if a webhook
        /// event can trigger a build. A filter group must contain at least one <c>EVENT</c> <c>WebhookFilter</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<WebhookFilter>> FilterGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<List<WebhookFilter>>() : null;

        /// <summary>
        /// Checks to see if the FilterGroups property is set.
        /// </summary>
        internal bool IsSetFilterGroups() => this.FilterGroups != null && (this.FilterGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the CodeBuild project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 150)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property PullRequestBuildPolicy. 
        /// <para>
        /// A PullRequestBuildPolicy object that defines comment-based approval requirements for
        /// triggering builds on pull requests. This policy helps control when automated builds
        /// are executed based on contributor permissions and approval workflows.
        /// </para>
        /// </summary>
        public PullRequestBuildPolicy PullRequestBuildPolicy { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestBuildPolicy property is set.
        /// </summary>
        internal bool IsSetPullRequestBuildPolicy() => this.PullRequestBuildPolicy != null;

        /// <summary>
        /// Gets and sets the property RotateSecret. 
        /// <para>
        ///  A boolean value that specifies whether the associated GitHub repository's secret
        /// token should be updated. If you use Bitbucket for your repository, <c>rotateSecret</c>
        /// is ignored. 
        /// </para>
        /// </summary>
        public bool? RotateSecret { get; set; }

        /// <summary>
        /// Checks to see if the RotateSecret property is set.
        /// </summary>
        internal bool IsSetRotateSecret() => this.RotateSecret.HasValue;
    }
}
