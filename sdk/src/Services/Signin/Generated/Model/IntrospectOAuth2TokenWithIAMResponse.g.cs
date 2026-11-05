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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// This is the response object from the IntrospectOAuth2TokenWithIAM operation.
    /// </summary>
    public partial class IntrospectOAuth2TokenWithIAMResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 12-digit AWS account ID of the token's subject
        /// principal.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Active. Indicates whether the token is currently active.
        /// Returns "true" only when the token is valid, has not expired, has not been revoked,
        /// and belongs to the caller's account.
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property Aud. The OAuth resource the token is scoped to. Omitted
        /// for refresh tokens. Example: "aws-mcp.amazonaws.com".
        /// </summary>
        public string Aud { get; set; }

        /// <summary>
        /// Checks to see if the Aud property is set.
        /// </summary>
        internal bool IsSetAud() => this.Aud != null;

        /// <summary>
        /// Gets and sets the property ClientId. Client identifier for the OAuth 2.0 client that
        /// requested the token.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property Exp. Token expiration time as a NumericDate (Unix epoch
        /// seconds).
        /// </summary>
        public long? Exp { get; set; }

        /// <summary>
        /// Checks to see if the Exp property is set.
        /// </summary>
        internal bool IsSetExp() => this.Exp.HasValue;

        /// <summary>
        /// Gets and sets the property Iat. Token issuance time as a NumericDate (Unix epoch seconds).
        /// </summary>
        public long? Iat { get; set; }

        /// <summary>
        /// Checks to see if the Iat property is set.
        /// </summary>
        internal bool IsSetIat() => this.Iat.HasValue;

        /// <summary>
        /// Gets and sets the property Iss. Issuer of the token. Always "signin.amazonaws.com"
        /// for AWS Sign-In.
        /// </summary>
        public string Iss { get; set; }

        /// <summary>
        /// Checks to see if the Iss property is set.
        /// </summary>
        internal bool IsSetIss() => this.Iss != null;

        /// <summary>
        /// Gets and sets the property Jti. Unique identifier for the token.
        /// </summary>
        public string Jti { get; set; }

        /// <summary>
        /// Checks to see if the Jti property is set.
        /// </summary>
        internal bool IsSetJti() => this.Jti != null;

        /// <summary>
        /// Gets and sets the property Nbf. Token "not before" time as a NumericDate (Unix epoch
        /// seconds).
        /// </summary>
        public long? Nbf { get; set; }

        /// <summary>
        /// Checks to see if the Nbf property is set.
        /// </summary>
        internal bool IsSetNbf() => this.Nbf.HasValue;

        /// <summary>
        /// Gets and sets the property Resource. The OAuth resource the token is scoped to. Only
        /// present for refresh token introspection.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property SigninSession. AWS Sign-In session ARN bound to the token,
        /// of the form arn:aws:signin:{region}:{account}:session/{uuid}.
        /// </summary>
        public string SigninSession { get; set; }

        /// <summary>
        /// Checks to see if the SigninSession property is set.
        /// </summary>
        internal bool IsSetSigninSession() => this.SigninSession != null;

        /// <summary>
        /// Gets and sets the property Sub. The IAM principal Amazon Resource Name (ARN). For
        /// assumed-role sessions, this is the session ARN.
        /// </summary>
        public string Sub { get; set; }

        /// <summary>
        /// Checks to see if the Sub property is set.
        /// </summary>
        internal bool IsSetSub() => this.Sub != null;

        /// <summary>
        /// Gets and sets the property TokenType. Indicates which kind of token was introspected.
        /// One of "access_token" or "refresh_token".
        /// </summary>
        public string TokenType { get; set; }

        /// <summary>
        /// Checks to see if the TokenType property is set.
        /// </summary>
        internal bool IsSetTokenType() => this.TokenType != null;

        /// <summary>
        /// Gets and sets the property UserId. User identifier matching the "UserId" field from
        /// "sts:GetCallerIdentity" for the token's subject principal.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
