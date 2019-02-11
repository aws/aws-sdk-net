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
    /// Information about a webhook that connects repository events to a build project in
    /// AWS CodeBuild.
    /// </summary>
    public partial class Webhook
    {
        private string _branchFilter;
        private List<List<WebhookFilter>> _filterGroups = new List<List<WebhookFilter>>();
        private DateTime? _lastModifiedSecret;
        private string _payloadUrl;
        private string _secret;
        private string _url;

        /// <summary>
        /// Gets and sets the property BranchFilter. 
        /// <para>
        /// A regular expression used to determine which repository branches are built when a
        /// webhook is triggered. If the name of a branch matches the regular expression, then
        /// it is built. If <code>branchFilter</code> is empty, then all branches are built.
        /// </para>
        ///  <note> 
        /// <para>
        ///  It is recommended that you use <code>filterGroups</code> instead of <code>branchFilter</code>.
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
        /// Gets and sets the property FilterGroups. 
        /// <para>
        ///  An array of arrays of <code>WebhookFilter</code> objects used to determine which
        /// webhooks are triggered. At least one <code>WebhookFilter</code> in the array must
        /// specify <code>EVENT</code> as its <code>type</code>. 
        /// </para>
        ///  
        /// <para>
        ///  For a build to be triggered, at least one filter group in the <code>filterGroups</code>
        /// array must pass. For a filter group to pass, each of its filters must pass. 
        /// </para>
        /// </summary>
        public List<List<WebhookFilter>> FilterGroups
        {
            get { return this._filterGroups; }
            set { this._filterGroups = value; }
        }

        // Check to see if FilterGroups property is set
        internal bool IsSetFilterGroups()
        {
            return this._filterGroups != null && this._filterGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedSecret. 
        /// <para>
        ///  A timestamp that indicates the last time a repository's secret token was modified.
        /// 
        /// </para>
        /// </summary>
        public DateTime LastModifiedSecret
        {
            get { return this._lastModifiedSecret.GetValueOrDefault(); }
            set { this._lastModifiedSecret = value; }
        }

        // Check to see if LastModifiedSecret property is set
        internal bool IsSetLastModifiedSecret()
        {
            return this._lastModifiedSecret.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PayloadUrl. 
        /// <para>
        ///  The AWS CodeBuild endpoint where webhook events are sent.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Secret. 
        /// <para>
        ///  The secret token of the associated repository. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  A Bitbucket webhook does not support <code>secret</code>. 
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to the webhook.
        /// </para>
        /// </summary>
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