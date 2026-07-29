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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
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
    /// Output structure for IntrospectOAuth2TokenWithIAM operation
    /// 
    ///  
    /// <para>
    /// RFC 7662 §2.2 introspection response. Only <c>active</c> is required; all other claims
    /// are omitted when the token is inactive.
    /// </para>
    /// </summary>
    public partial class IntrospectOAuth2TokenWithIAMResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private bool? _active;
        private string _aud;
        private string _clientId;
        private long? _exp;
        private long? _iat;
        private string _iss;
        private string _jti;
        private long? _nbf;
        private string _resource;
        private string _signinSession;
        private string _sub;
        private string _tokenType;
        private string _userId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// 12-digit AWS account ID of the token's subject principal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Indicates whether the token is currently active. <c>true</c> only when the token is
        /// valid, has not expired, has not been revoked, and belongs to the caller's account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Aud. 
        /// <para>
        /// Audience of the token: the OAuth resource the token is scoped to (for example, &quot;aws-mcp.amazonaws.com&quot;).
        /// Omitted for refresh tokens.
        /// </para>
        /// </summary>
        public string Aud
        {
            get { return this._aud; }
            set { this._aud = value; }
        }

        // Check to see if Aud property is set
        internal bool IsSetAud()
        {
            return this._aud != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// Client identifier for the OAuth 2.0 client that requested the token.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Exp. 
        /// <para>
        /// Token expiration time as a NumericDate (Unix epoch seconds).
        /// </para>
        /// </summary>
        public long? Exp
        {
            get { return this._exp; }
            set { this._exp = value; }
        }

        // Check to see if Exp property is set
        internal bool IsSetExp()
        {
            return this._exp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iat. 
        /// <para>
        /// Token issuance time as a NumericDate (Unix epoch seconds).
        /// </para>
        /// </summary>
        public long? Iat
        {
            get { return this._iat; }
            set { this._iat = value; }
        }

        // Check to see if Iat property is set
        internal bool IsSetIat()
        {
            return this._iat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iss. 
        /// <para>
        /// Issuer of the token. Always &quot;signin.amazonaws.com&quot; for AWS Sign-In.
        /// </para>
        /// </summary>
        public string Iss
        {
            get { return this._iss; }
            set { this._iss = value; }
        }

        // Check to see if Iss property is set
        internal bool IsSetIss()
        {
            return this._iss != null;
        }

        /// <summary>
        /// Gets and sets the property Jti. 
        /// <para>
        /// Unique identifier for the token.
        /// </para>
        /// </summary>
        public string Jti
        {
            get { return this._jti; }
            set { this._jti = value; }
        }

        // Check to see if Jti property is set
        internal bool IsSetJti()
        {
            return this._jti != null;
        }

        /// <summary>
        /// Gets and sets the property Nbf. 
        /// <para>
        /// Token &quot;not before&quot; time as a NumericDate (Unix epoch seconds).
        /// </para>
        /// </summary>
        public long? Nbf
        {
            get { return this._nbf; }
            set { this._nbf = value; }
        }

        // Check to see if Nbf property is set
        internal bool IsSetNbf()
        {
            return this._nbf.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The OAuth resource the token is scoped to during Human OAuth flow. Only present for
        /// refresh token introspection.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property SigninSession. 
        /// <para>
        /// AWS Sign-In session ARN bound to the token, of the form arn:aws:signin:{region}:{account}:session/{uuid}.
        /// </para>
        /// </summary>
        public string SigninSession
        {
            get { return this._signinSession; }
            set { this._signinSession = value; }
        }

        // Check to see if SigninSession property is set
        internal bool IsSetSigninSession()
        {
            return this._signinSession != null;
        }

        /// <summary>
        /// Gets and sets the property Sub. 
        /// <para>
        /// Subject of the token: the IAM principal ARN. For assumed-role sessions, this is the
        /// session ARN (matches sts:GetCallerIdentity's <c>Arn</c> field), e.g. arn:aws:sts::123456789012:assumed-role/MyRole/session-name.
        /// </para>
        /// </summary>
        public string Sub
        {
            get { return this._sub; }
            set { this._sub = value; }
        }

        // Check to see if Sub property is set
        internal bool IsSetSub()
        {
            return this._sub != null;
        }

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// Indicates which kind of token was introspected. One of &quot;access_token&quot; or
        /// &quot;refresh_token&quot;.
        /// </para>
        /// </summary>
        public string TokenType
        {
            get { return this._tokenType; }
            set { this._tokenType = value; }
        }

        // Check to see if TokenType property is set
        internal bool IsSetTokenType()
        {
            return this._tokenType != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// User identifier matching sts:GetCallerIdentity's <c>UserId</c> field for the token's
        /// subject principal (e.g. &quot;AIDAEXAMPLE&quot; for an IAM user, or &quot;AROAEXAMPLE:session-name&quot;
        /// for an assumed role).
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}