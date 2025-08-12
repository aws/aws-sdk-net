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
    /// Information about a webhook that connects repository events to a build project in
    /// CodeBuild.
    /// </summary>
    public partial class Webhook
    {
        private string _branchFilter;
        private WebhookBuildType _buildType;
        private List<List<WebhookFilter>> _filterGroups = AWSConfigs.InitializeCollections ? new List<List<WebhookFilter>>() : null;
        private DateTime? _lastModifiedSecret;
        private bool? _manualCreation;
        private string _payloadUrl;
        private PullRequestBuildPolicy _pullRequestBuildPolicy;
        private ScopeConfiguration _scopeConfiguration;
        private string _secret;
        private WebhookStatus _status;
        private string _statusMessage;
        private string _url;

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
        /// Gets and sets the property LastModifiedSecret. 
        /// <para>
        /// A timestamp that indicates the last time a repository's secret token was modified.
        /// 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedSecret
        {
            get { return this._lastModifiedSecret; }
            set { this._lastModifiedSecret = value; }
        }

        // Check to see if LastModifiedSecret property is set
        internal bool IsSetLastModifiedSecret()
        {
            return this._lastModifiedSecret.HasValue; 
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
        /// manualCreation is only available for GitHub webhooks.
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
        /// Gets and sets the property PayloadUrl. 
        /// <para>
        /// The CodeBuild endpoint where webhook events are sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PayloadUrl
        {
            get { return this._payloadUrl; }
            set { this._payloadUrl = value; }
        }

        // Check to see if PayloadUrl property is set
        internal bool IsSetPayloadUrl()
        {
            return this._payloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestBuildPolicy.
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
        [AWSProperty(Min=1)]
        public string Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret != null;
        }

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
        public WebhookStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message associated with the status of a webhook.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to the webhook.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}