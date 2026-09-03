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

namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// This is the response object from the RegisterClient operation.
    /// </summary>
    public partial class RegisterClientResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// An endpoint that the client can use to request authorization.
        /// </para>
        /// </summary>
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationEndpoint property is set.
        /// </summary>
        internal bool IsSetAuthorizationEndpoint() => this.AuthorizationEndpoint != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier string for each client. This client uses this identifier to
        /// get authenticated by the service in subsequent calls.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientIdIssuedAt. 
        /// <para>
        /// Indicates the time at which the <c>clientId</c> and <c>clientSecret</c> were issued.
        /// </para>
        /// </summary>
        public long? ClientIdIssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the ClientIdIssuedAt property is set.
        /// </summary>
        internal bool IsSetClientIdIssuedAt() => this.ClientIdIssuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// A secret string generated for the client. The client will use this string to get authenticated
        /// by the service in subsequent calls.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property ClientSecretExpiresAt. 
        /// <para>
        /// Indicates the time at which the <c>clientId</c> and <c>clientSecret</c> will become
        /// invalid.
        /// </para>
        /// </summary>
        public long? ClientSecretExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretExpiresAt property is set.
        /// </summary>
        internal bool IsSetClientSecretExpiresAt() => this.ClientSecretExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// An endpoint that the client can use to create tokens.
        /// </para>
        /// </summary>
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpoint property is set.
        /// </summary>
        internal bool IsSetTokenEndpoint() => this.TokenEndpoint != null;
    }
}
