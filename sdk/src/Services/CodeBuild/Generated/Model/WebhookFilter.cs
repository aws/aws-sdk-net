/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        ///  Used to indicate that the <code>pattern</code> determines which webhook events do
        /// not trigger a build. If true, then a webhook event that does not match the <code>pattern</code>
        /// triggers a build. If false, then a webhook event that matches the <code>pattern</code>
        /// triggers a build. 
        /// </para>
        /// </summary>
        public bool ExcludeMatchedPattern
        {
            get { return this._excludeMatchedPattern.GetValueOrDefault(); }
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
        ///  For a <code>WebHookFilter</code> that uses <code>EVENT</code> type, a comma-separated
        /// string that specifies one or more events. For example, the webhook filter <code>PUSH,
        /// PULL_REQUEST_CREATED, PULL_REQUEST_UPDATED</code> allows all push, pull request created,
        /// and pull request updated events to trigger a build. 
        /// </para>
        ///  
        /// <para>
        ///  For a <code>WebHookFilter</code> that uses any of the other filter types, a regular
        /// expression pattern. For example, a <code>WebHookFilter</code> that uses <code>HEAD_REF</code>
        /// for its <code>type</code> and the pattern <code>^refs/heads/</code> triggers a build
        /// when the head reference is a branch with a reference name <code>refs/heads/branch-name</code>.
        /// 
        /// </para>
        /// </summary>
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
        ///  The type of webhook filter. There are five webhook filter types: <code>EVENT</code>,
        /// <code>ACTOR_ACCOUNT_ID</code>, <code>HEAD_REF</code>, <code>BASE_REF</code>, and <code>FILE_PATH</code>.
        /// 
        /// </para>
        ///  <dl> <dt> EVENT </dt> <dd> 
        /// <para>
        ///  A webhook event triggers a build when the provided <code>pattern</code> matches one
        /// of four event types: <code>PUSH</code>, <code>PULL_REQUEST_CREATED</code>, <code>PULL_REQUEST_UPDATED</code>,
        /// and <code>PULL_REQUEST_REOPENED</code>. The <code>EVENT</code> patterns are specified
        /// as a comma-separated string. For example, <code>PUSH, PULL_REQUEST_CREATED, PULL_REQUEST_UPDATED</code>
        /// filters all push, pull request created, and pull request updated events. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  The <code>PULL_REQUEST_REOPENED</code> works with GitHub and GitHub Enterprise only.
        /// 
        /// </para>
        ///  </note> </dd> <dt> ACTOR_ACCOUNT_ID </dt> <dd> 
        /// <para>
        ///  A webhook event triggers a build when a GitHub, GitHub Enterprise, or Bitbucket account
        /// ID matches the regular expression <code>pattern</code>. 
        /// </para>
        ///  </dd> <dt> HEAD_REF </dt> <dd> 
        /// <para>
        ///  A webhook event triggers a build when the head reference matches the regular expression
        /// <code>pattern</code>. For example, <code>refs/heads/branch-name</code> and <code>refs/tags/tag-name</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Works with GitHub and GitHub Enterprise push, GitHub and GitHub Enterprise pull request,
        /// Bitbucket push, and Bitbucket pull request events. 
        /// </para>
        ///  </dd> <dt> BASE_REF </dt> <dd> 
        /// <para>
        ///  A webhook event triggers a build when the base reference matches the regular expression
        /// <code>pattern</code>. For example, <code>refs/heads/branch-name</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with pull request events only. 
        /// </para>
        ///  </note> </dd> <dt> FILE_PATH </dt> <dd> 
        /// <para>
        ///  A webhook triggers a build when the path of a changed file matches the regular expression
        /// <code>pattern</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Works with GitHub and GitHub Enterprise push events only. 
        /// </para>
        ///  </note> </dd> </dl>
        /// </summary>
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