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
    /// Information about a webhook that connects repository events to a build project in
    /// CodeBuild.
    /// </summary>
    public partial class Webhook
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
        /// It is recommended that you use <c>filterGroups</c> instead of <c>branchFilter</c>.
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
        /// Gets and sets the property LastModifiedSecret. 
        /// <para>
        /// A timestamp that indicates the last time a repository's secret token was modified.
        /// 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedSecret { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedSecret property is set.
        /// </summary>
        internal bool IsSetLastModifiedSecret() => this.LastModifiedSecret.HasValue;

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
        /// manualCreation is only available for GitHub webhooks.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ManualCreation { get; set; }

        /// <summary>
        /// Checks to see if the ManualCreation property is set.
        /// </summary>
        internal bool IsSetManualCreation() => this.ManualCreation.HasValue;

        /// <summary>
        /// Gets and sets the property PayloadUrl. 
        /// <para>
        /// The CodeBuild endpoint where webhook events are sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string PayloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the PayloadUrl property is set.
        /// </summary>
        internal bool IsSetPayloadUrl() => this.PayloadUrl != null;

        /// <summary>
        /// Gets and sets the property PullRequestBuildPolicy.
        /// </summary>
        public PullRequestBuildPolicy PullRequestBuildPolicy { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestBuildPolicy property is set.
        /// </summary>
        internal bool IsSetPullRequestBuildPolicy() => this.PullRequestBuildPolicy != null;

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
        public ScopeConfiguration ScopeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScopeConfiguration property is set.
        /// </summary>
        internal bool IsSetScopeConfiguration() => this.ScopeConfiguration != null;

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// The secret token of the associated repository. 
        /// </para>
        ///  <note> 
        /// <para>
        /// A Bitbucket webhook does not support <c>secret</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Secret { get; set; }

        /// <summary>
        /// Checks to see if the Secret property is set.
        /// </summary>
        internal bool IsSetSecret() => this.Secret != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the webhook. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: The webhook is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c>: The webhook has failed to create.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The webhook has succeeded and is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: The webhook is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WebhookStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message associated with the status of a webhook.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to the webhook.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
