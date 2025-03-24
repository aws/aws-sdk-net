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
    /// A filter used to determine which webhooks trigger a build.
    /// </summary>
    public partial class WebhookFilter
    {
        private bool? _excludeMatchedPattern;
        private string _pattern;
        private WebhookFilterType _type;

        /// <summary>
        /// Gets and sets the property ExcludeMatchedPattern. 
        /// <para>
        ///  Used to indicate that the <c>pattern</c> determines which webhook events do not trigger
        /// a build. If true, then a webhook event that does not match the <c>pattern</c> triggers
        /// a build. If false, then a webhook event that matches the <c>pattern</c> triggers a
        /// build. 
        /// </para>
        /// </summary>
        public bool? ExcludeMatchedPattern
        {
            get { return this._excludeMatchedPattern; }
            set { this._excludeMatchedPattern = value; }
        }

        // Check to see if ExcludeMatchedPattern property is set
        internal bool IsSetExcludeMatchedPattern()
        {
            return this._excludeMatchedPattern.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        ///  For a <c>WebHookFilter</c> that uses <c>EVENT</c> type, a comma-separated string
        /// that specifies one or more events. For example, the webhook filter <c>PUSH, PULL_REQUEST_CREATED,
        /// PULL_REQUEST_UPDATED</c> allows all push, pull request created, and pull request updated
        /// events to trigger a build. 
        /// </para>
        ///  
        /// <para>
        ///  For a <c>WebHookFilter</c> that uses any of the other filter types, a regular expression
        /// pattern. For example, a <c>WebHookFilter</c> that uses <c>HEAD_REF</c> for its <c>type</c>
        /// and the pattern <c>^refs/heads/</c> triggers a build when the head reference is a
        /// branch with a reference name <c>refs/heads/branch-name</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of webhook filter. There are 11 webhook filter types: <c>EVENT</c>, <c>ACTOR_ACCOUNT_ID</c>,
        /// <c>HEAD_REF</c>, <c>BASE_REF</c>, <c>FILE_PATH</c>, <c>COMMIT_MESSAGE</c>, <c>TAG_NAME</c>,
        /// <c>RELEASE_NAME</c>, <c>REPOSITORY_NAME</c>, <c>ORGANIZATION_NAME</c>, and <c>WORKFLOW_NAME</c>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  EVENT 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A webhook event triggers a build when the provided <c>pattern</c> matches one of
        /// nine event types: <c>PUSH</c>, <c>PULL_REQUEST_CREATED</c>, <c>PULL_REQUEST_UPDATED</c>,
        /// <c>PULL_REQUEST_CLOSED</c>, <c>PULL_REQUEST_REOPENED</c>, <c>PULL_REQUEST_MERGED</c>,
        /// <c>RELEASED</c>, <c>PRERELEASED</c>, and <c>WORKFLOW_JOB_QUEUED</c>. The <c>EVENT</c>
        /// patterns are specified as a comma-separated string. For example, <c>PUSH, PULL_REQUEST_CREATED,
        /// PULL_REQUEST_UPDATED</c> filters all push, pull request created, and pull request
        /// updated events. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Types <c>PULL_REQUEST_REOPENED</c> and <c>WORKFLOW_JOB_QUEUED</c> work with GitHub
        /// and GitHub Enterprise only. Types <c>RELEASED</c> and <c>PRERELEASED</c> work with
        /// GitHub only.
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// ACTOR_ACCOUNT_ID
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A webhook event triggers a build when a GitHub, GitHub Enterprise, or Bitbucket account
        /// ID matches the regular expression <c>pattern</c>. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// HEAD_REF
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A webhook event triggers a build when the head reference matches the regular expression
        /// <c>pattern</c>. For example, <c>refs/heads/branch-name</c> and <c>refs/tags/tag-name</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with GitHub and GitHub Enterprise push, GitHub and GitHub Enterprise pull request,
        /// Bitbucket push, and Bitbucket pull request events.
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// BASE_REF
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A webhook event triggers a build when the base reference matches the regular expression
        /// <c>pattern</c>. For example, <c>refs/heads/branch-name</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with pull request events only. 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// FILE_PATH
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A webhook triggers a build when the path of a changed file matches the regular expression
        /// <c>pattern</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with push and pull request events only. 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// COMMIT_MESSAGE
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A webhook triggers a build when the head commit message matches the regular expression
        /// <c>pattern</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with push and pull request events only. 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// TAG_NAME
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A webhook triggers a build when the tag name of the release matches the regular expression
        /// <c>pattern</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with <c>RELEASED</c> and <c>PRERELEASED</c> events only. 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// RELEASE_NAME
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A webhook triggers a build when the release name matches the regular expression <c>pattern</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with <c>RELEASED</c> and <c>PRERELEASED</c> events only. 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// REPOSITORY_NAME
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A webhook triggers a build when the repository name matches the regular expression
        /// <c>pattern</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with GitHub global or organization webhooks only. 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// ORGANIZATION_NAME
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A webhook triggers a build when the organization name matches the regular expression
        /// <c>pattern</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with GitHub global webhooks only. 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        /// WORKFLOW_NAME
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A webhook triggers a build when the workflow name matches the regular expression <c>pattern</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with <c>WORKFLOW_JOB_QUEUED</c> events only. 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// For CodeBuild-hosted Buildkite runner builds, WORKFLOW_NAME filters will filter by
        /// pipeline name.
        /// </para>
        ///  </note> </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WebhookFilterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}