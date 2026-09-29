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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Service details for GitLab integration.
    /// </summary>
    public partial class GitLabDetails
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// Optional GitLab group ID for group-level access tokens
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property TargetUrl. 
        /// <para>
        /// GitLab instance URL (e.g., https://gitlab.com or self-hosted instance).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetUrl { get; set; }

        /// <summary>
        /// Checks to see if the TargetUrl property is set.
        /// </summary>
        internal bool IsSetTargetUrl() => this.TargetUrl != null;

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// Type of GitLab access token
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GitLabTokenType TokenType { get; set; }

        /// <summary>
        /// Checks to see if the TokenType property is set.
        /// </summary>
        internal bool IsSetTokenType() => this.TokenType != null;

        /// <summary>
        /// Gets and sets the property TokenValue. 
        /// <para>
        /// GitLab access token value
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string TokenValue { get; set; }

        /// <summary>
        /// Checks to see if the TokenValue property is set.
        /// </summary>
        internal bool IsSetTokenValue() => this.TokenValue != null;
    }
}
