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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The configuration for creating a GitLab integration.
    /// </summary>
    public partial class GitLabIntegrationInput
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The GitLab access token used to authenticate. This can be a personal access token
        /// or a group access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of the GitLab group. Required when tokenType is group and ignored for
        /// personal tokens.
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
        /// The HTTPS URL of a self-managed GitLab instance. Omit this value for GitLab SaaS (gitlab.com).
        /// </para>
        /// </summary>
        public string TargetUrl { get; set; }

        /// <summary>
        /// Checks to see if the TargetUrl property is set.
        /// </summary>
        internal bool IsSetTargetUrl() => this.TargetUrl != null;

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// The type of GitLab access token provided in accessToken.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GitLabTokenType TokenType { get; set; }

        /// <summary>
        /// Checks to see if the TokenType property is set.
        /// </summary>
        internal bool IsSetTokenType() => this.TokenType != null;
    }
}
