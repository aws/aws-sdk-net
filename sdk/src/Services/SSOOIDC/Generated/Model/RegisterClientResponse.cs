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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
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
namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// This is the response object from the RegisterClient operation.
    /// </summary>
    public partial class RegisterClientResponse : AmazonWebServiceResponse
    {
        private string _authorizationEndpoint;
        private string _clientId;
        private long? _clientIdIssuedAt;
        private string _clientSecret;
        private long? _clientSecretExpiresAt;
        private string _tokenEndpoint;

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// An endpoint that the client can use to request authorization.
        /// </para>
        /// </summary>
        public string AuthorizationEndpoint
        {
            get { return this._authorizationEndpoint; }
            set { this._authorizationEndpoint = value; }
        }

        // Check to see if AuthorizationEndpoint property is set
        internal bool IsSetAuthorizationEndpoint()
        {
            return this._authorizationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier string for each client. This client uses this identifier to
        /// get authenticated by the service in subsequent calls.
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
        /// Gets and sets the property ClientIdIssuedAt. 
        /// <para>
        /// Indicates the time at which the <c>clientId</c> and <c>clientSecret</c> were issued.
        /// </para>
        /// </summary>
        public long? ClientIdIssuedAt
        {
            get { return this._clientIdIssuedAt; }
            set { this._clientIdIssuedAt = value; }
        }

        // Check to see if ClientIdIssuedAt property is set
        internal bool IsSetClientIdIssuedAt()
        {
            return this._clientIdIssuedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// A secret string generated for the client. The client will use this string to get authenticated
        /// by the service in subsequent calls.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSecretExpiresAt. 
        /// <para>
        /// Indicates the time at which the <c>clientId</c> and <c>clientSecret</c> will become
        /// invalid.
        /// </para>
        /// </summary>
        public long? ClientSecretExpiresAt
        {
            get { return this._clientSecretExpiresAt; }
            set { this._clientSecretExpiresAt = value; }
        }

        // Check to see if ClientSecretExpiresAt property is set
        internal bool IsSetClientSecretExpiresAt()
        {
            return this._clientSecretExpiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// An endpoint that the client can use to create tokens.
        /// </para>
        /// </summary>
        public string TokenEndpoint
        {
            get { return this._tokenEndpoint; }
            set { this._tokenEndpoint = value; }
        }

        // Check to see if TokenEndpoint property is set
        internal bool IsSetTokenEndpoint()
        {
            return this._tokenEndpoint != null;
        }

    }
}