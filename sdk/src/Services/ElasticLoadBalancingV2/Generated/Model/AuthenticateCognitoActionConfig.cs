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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Request parameters to use when integrating with Amazon Cognito to authenticate users.
    /// </summary>
    public partial class AuthenticateCognitoActionConfig
    {
        private Dictionary<string, string> _authenticationRequestExtraParams = new Dictionary<string, string>();
        private AuthenticateCognitoActionConditionalBehaviorEnum _onUnauthenticatedRequest;
        private string _scope;
        private string _sessionCookieName;
        private long? _sessionTimeout;
        private string _userPoolArn;
        private string _userPoolClientId;
        private string _userPoolDomain;

        /// <summary>
        /// Gets and sets the property AuthenticationRequestExtraParams. 
        /// <para>
        /// The query parameters (up to 10) to include in the redirect request to the authorization
        /// endpoint.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AuthenticationRequestExtraParams
        {
            get { return this._authenticationRequestExtraParams; }
            set { this._authenticationRequestExtraParams = value; }
        }

        // Check to see if AuthenticationRequestExtraParams property is set
        internal bool IsSetAuthenticationRequestExtraParams()
        {
            return this._authenticationRequestExtraParams != null && this._authenticationRequestExtraParams.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OnUnauthenticatedRequest. 
        /// <para>
        /// The behavior if the user is not authenticated. The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// deny<code/> - Return an HTTP 401 Unauthorized error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// allow<code/> - Allow the request to be forwarded to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authenticate<code/> - Redirect the request to the IdP authorization endpoint. This
        /// is the default value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthenticateCognitoActionConditionalBehaviorEnum OnUnauthenticatedRequest
        {
            get { return this._onUnauthenticatedRequest; }
            set { this._onUnauthenticatedRequest = value; }
        }

        // Check to see if OnUnauthenticatedRequest property is set
        internal bool IsSetOnUnauthenticatedRequest()
        {
            return this._onUnauthenticatedRequest != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The set of user claims to be requested from the IdP. The default is <code>openid</code>.
        /// </para>
        ///  
        /// <para>
        /// To verify which scope values your IdP supports and how to separate multiple values,
        /// see the documentation for your IdP.
        /// </para>
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property SessionCookieName. 
        /// <para>
        /// The name of the cookie used to maintain session information. The default is AWSELBAuthSessionCookie.
        /// </para>
        /// </summary>
        public string SessionCookieName
        {
            get { return this._sessionCookieName; }
            set { this._sessionCookieName = value; }
        }

        // Check to see if SessionCookieName property is set
        internal bool IsSetSessionCookieName()
        {
            return this._sessionCookieName != null;
        }

        /// <summary>
        /// Gets and sets the property SessionTimeout. 
        /// <para>
        /// The maximum duration of the authentication session, in seconds. The default is 604800
        /// seconds (7 days).
        /// </para>
        /// </summary>
        public long SessionTimeout
        {
            get { return this._sessionTimeout.GetValueOrDefault(); }
            set { this._sessionTimeout = value; }
        }

        // Check to see if SessionTimeout property is set
        internal bool IsSetSessionTimeout()
        {
            return this._sessionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserPoolArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Cognito user pool.
        /// </para>
        /// </summary>
        public string UserPoolArn
        {
            get { return this._userPoolArn; }
            set { this._userPoolArn = value; }
        }

        // Check to see if UserPoolArn property is set
        internal bool IsSetUserPoolArn()
        {
            return this._userPoolArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolClientId. 
        /// <para>
        /// The ID of the Amazon Cognito user pool client.
        /// </para>
        /// </summary>
        public string UserPoolClientId
        {
            get { return this._userPoolClientId; }
            set { this._userPoolClientId = value; }
        }

        // Check to see if UserPoolClientId property is set
        internal bool IsSetUserPoolClientId()
        {
            return this._userPoolClientId != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolDomain. 
        /// <para>
        /// The domain prefix or fully-qualified domain name of the Amazon Cognito user pool.
        /// </para>
        /// </summary>
        public string UserPoolDomain
        {
            get { return this._userPoolDomain; }
            set { this._userPoolDomain = value; }
        }

        // Check to see if UserPoolDomain property is set
        internal bool IsSetUserPoolDomain()
        {
            return this._userPoolDomain != null;
        }

    }
}