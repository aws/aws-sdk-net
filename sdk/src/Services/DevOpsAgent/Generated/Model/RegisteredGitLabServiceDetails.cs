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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Details specific to a registered GitLab instance.
    /// </summary>
    public partial class RegisteredGitLabServiceDetails
    {
        private string _groupId;
        private string _targetUrl;
        private GitLabTokenType _tokenType;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// Optional GitLab group ID for group-level access tokens
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetUrl. 
        /// <para>
        /// The GitLab instance URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetUrl
        {
            get { return this._targetUrl; }
            set { this._targetUrl = value; }
        }

        // Check to see if TargetUrl property is set
        internal bool IsSetTargetUrl()
        {
            return this._targetUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// Type of GitLab access token
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GitLabTokenType TokenType
        {
            get { return this._tokenType; }
            set { this._tokenType = value; }
        }

        // Check to see if TokenType property is set
        internal bool IsSetTokenType()
        {
            return this._tokenType != null;
        }

    }
}