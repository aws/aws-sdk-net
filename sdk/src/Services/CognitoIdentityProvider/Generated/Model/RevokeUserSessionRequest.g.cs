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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeUserSession operation. Revokes a specific
    /// session for the currently signed-in user. Amazon Cognito authorizes this operation
    /// with the user's access token, revokes all refresh and access tokens that are associated
    /// with the session, and deletes the session record. You can't revoke the session that
    /// the calling access token belongs to.
    /// </summary>
    public partial class RevokeUserSessionRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user. Amazon Cognito uses this
        /// token to authorize the request and to identify the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property RevokeAssociatedSessions. 
        /// <para>
        /// Specifies whether to also revoke the sessions that are linked to the targeted session.
        /// <c>NONE</c>, the default, revokes only the targeted session. <c>LINKED</c> also revokes
        /// the directly linked session or sessions, interpreted relative to the type of the targeted
        /// session: revoking a token session also revokes the parent SSO session it came through,
        /// and revoking an SSO session also revokes the token sessions that came through it.
        /// The set of linked sessions is eventually consistent, so associated sessions are typically
        /// revoked within a few seconds.
        /// </para>
        /// </summary>
        public RevokeAssociatedSessionsType RevokeAssociatedSessions { get; set; }

        /// <summary>
        /// Checks to see if the RevokeAssociatedSessions property is set.
        /// </summary>
        internal bool IsSetRevokeAssociatedSessions() => this.RevokeAssociatedSessions != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of the session to revoke. This is a 28-character string of lowercase letters
        /// and digits, prefixed with <c>tkn</c> for a token session or <c>sso</c> for an SSO
        /// session. This value can't identify the caller's own current session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 28, Max = 28)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
