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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// An OAuth 2.0 authorization that waits for a user's approval. The user opens <c>authorizationUrl</c>
    /// and approves access on GitHub. Amazon Bedrock AgentCore Identity then redirects the
    /// browser to the source's <c>returnUrl</c>. There, your application completes the authorization
    /// by calling the AgentCore Identity <c>CompleteResourceTokenAuth</c> operation with
    /// <c>userId</c>. If the source has no <c>returnUrl</c>, the user returns to the Amazon
    /// Web Services Agent Registry console, which completes the authorization. After the
    /// authorization completes, the registry synchronizes the record without another request.
    /// If the user doesn't approve access before <c>expiresAt</c>, the record moves to <c>CREATE_FAILED</c>
    /// or <c>UPDATE_FAILED</c>. To start again, call <c>UpdateRegistryRecord</c> with <c>triggerSynchronization</c>.
    /// </summary>
    public partial class OAuth2AuthorizationData
    {
        /// <summary>
        /// Gets and sets the property AuthorizationAttemptId. 
        /// <para>
        /// The identifier of this authorization attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AuthorizationAttemptId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationAttemptId property is set.
        /// </summary>
        internal bool IsSetAuthorizationAttemptId() => this.AuthorizationAttemptId != null;

        /// <summary>
        /// Gets and sets the property AuthorizationUrl. 
        /// <para>
        /// The URL that the user opens to approve access. The link is valid for up to 10 minutes.
        /// Treat it as sensitive and give it only to the user who approves access.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationUrl property is set.
        /// </summary>
        internal bool IsSetAuthorizationUrl() => this.AuthorizationUrl != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the authorization link expires, 10 minutes after the authorization
        /// started. A request that joins an authorization in progress gets less time, and the
        /// link might stop working shortly before this time.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The AgentCore Identity user ID that the authorization is for. Store it with your signed-in
        /// user and pass it as <c>userIdentifier.userId</c> when your application calls <c>CompleteResourceTokenAuth</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
