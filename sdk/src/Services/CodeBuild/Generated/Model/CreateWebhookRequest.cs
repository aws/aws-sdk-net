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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
    /// Container for the parameters to the CreateWebhook operation.
    /// For an existing CodeBuild build project that has its source code stored in a GitHub
    /// or Bitbucket repository, enables CodeBuild to start rebuilding the source code every
    /// time a code change is pushed to the repository.
    /// 
    ///  <important> 
    /// <para>
    /// If you enable webhooks for an CodeBuild project, and the project is used as a build
    /// step in CodePipeline, then two identical builds are created for each commit. One build
    /// is triggered through webhooks, and one through CodePipeline. Because billing is on
    /// a per-build basis, you are billed for both builds. Therefore, if you are using CodePipeline,
    /// we recommend that you disable webhooks in CodeBuild. In the CodeBuild console, clear
    /// the Webhook box. For more information, see step 5 in <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/change-project.html#change-project-console">Change
    /// a Build Project's Settings</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateWebhookRequest : AmazonCodeBuildRequest
    {
        private string _branchFilter;
        private WebhookBuildType _buildType;
        private List<List<WebhookFilter>> _filterGroups = AWSConfigs.InitializeCollections ? new List<List<WebhookFilter>>() : null;
        private bool? _manualCreation;
        private string _projectName;
        private PullRequestBuildPolicy _pullRequestBuildPolicy;
        private ScopeConfiguration _scopeConfiguration;

        /// <summary>
        /// Gets and sets the property BranchFilter. 
        /// <para>
        /// A regular expression used to determine which repository branches are built when a
        /// webhook is triggered. If the name of a branch matches the regular expression, then
        /// it is built. If <c>branchFilter</c> is empty, then all branches are built.
        /// </para>
        ///  <note> 
        /// <para>
        /// It is recommended that you use <c>filterGroups</c> instead of <c>branchFilter</c>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public string BranchFilter
        {
            get { return this._branchFilter; }
            set { this._branchFilter = value; }
        }

        // Check to see if BranchFilter property is set
        internal bool IsSetBranchFilter()
        {
            return this._branchFilter != null;
        }

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
        public WebhookBuildType BuildType
        {
            get { return this._buildType; }
            set { this._buildType = value; }
        }

        // Check to see if BuildType property is set
        internal bool IsSetBuildType()
        {
            return this._buildType != null;
        }

        /// <summary>
        /// Gets and sets the property FilterGroups. 
        /// <para>
        /// An array of arrays of <c>WebhookFilter</c> objects used to determine which webhooks
        /// are triggered. At least one <c>WebhookFilter</c> in the array must specify <c>EVENT</c>
        /// as its <c>type</c>. 
        /// </para>
        ///  
        /// <para>
        /// For a build to be triggered, at least one filter group in the <c>filterGroups</c>
        /// array must pass. For a filter group to pass, each of its filters must pass. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<WebhookFilter>> FilterGroups
        {
            get { return this._filterGroups; }
            set { this._filterGroups = value; }
        }

        // Check to see if FilterGroups property is set
        internal bool IsSetFilterGroups()
        {
            return this._filterGroups != null && (this._filterGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManualCreation. 
        /// <para>
        /// If manualCreation is true, CodeBuild doesn't create a webhook in GitHub and instead
        /// returns <c>payloadUrl</c> and <c>secret</c> values for the webhook. The <c>payloadUrl</c>
        /// and <c>secret</c> values in the output can be used to manually create a webhook within
        /// GitHub.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>manualCreation</c> is only available for GitHub webhooks.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ManualCreation
        {
            get { return this._manualCreation; }
            set { this._manualCreation = value; }
        }

        // Check to see if ManualCreation property is set
        internal bool IsSetManualCreation()
        {
            return this._manualCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the CodeBuild project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=150)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestBuildPolicy. 
        /// <para>
        /// A PullRequestBuildPolicy object that defines comment-based approval requirements for
        /// triggering builds on pull requests. This policy helps control when automated builds
        /// are executed based on contributor permissions and approval workflows.
        /// </para>
        /// </summary>
        public PullRequestBuildPolicy PullRequestBuildPolicy
        {
            get { return this._pullRequestBuildPolicy; }
            set { this._pullRequestBuildPolicy = value; }
        }

        // Check to see if PullRequestBuildPolicy property is set
        internal bool IsSetPullRequestBuildPolicy()
        {
            return this._pullRequestBuildPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The scope configuration for global or organization webhooks.
        /// </para>
        ///  <note> 
        /// <para>
        /// Global or organization webhooks are only available for GitHub and Github Enterprise
        /// webhooks.
        /// </para>
        ///  </note>
        /// </summary>
        public ScopeConfiguration ScopeConfiguration
        {
            get { return this._scopeConfiguration; }
            set { this._scopeConfiguration = value; }
        }

        // Check to see if ScopeConfiguration property is set
        internal bool IsSetScopeConfiguration()
        {
            return this._scopeConfiguration != null;
        }

    }
}