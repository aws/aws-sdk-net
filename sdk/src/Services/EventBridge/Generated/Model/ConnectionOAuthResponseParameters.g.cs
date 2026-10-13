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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// The response parameters when OAuth is specified as the authorization type.
    /// </summary>
    public partial class ConnectionOAuthResponseParameters
    {
        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The URL to the HTTP endpoint that authorized the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationEndpoint property is set.
        /// </summary>
        internal bool IsSetAuthorizationEndpoint() => this.AuthorizationEndpoint != null;

        /// <summary>
        /// Gets and sets the property ClientParameters. 
        /// <para>
        /// Details about the client parameters returned when OAuth is specified as the authorization
        /// type.
        /// </para>
        /// </summary>
        public ConnectionOAuthClientResponseParameters ClientParameters { get; set; }

        /// <summary>
        /// Checks to see if the ClientParameters property is set.
        /// </summary>
        internal bool IsSetClientParameters() => this.ClientParameters != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The method used to connect to the HTTP endpoint.
        /// </para>
        /// </summary>
        public ConnectionOAuthHttpMethod HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property OAuthHttpParameters. 
        /// <para>
        /// The additional HTTP parameters used for the OAuth authorization request.
        /// </para>
        /// </summary>
        public ConnectionHttpParameters OAuthHttpParameters { get; set; }

        /// <summary>
        /// Checks to see if the OAuthHttpParameters property is set.
        /// </summary>
        internal bool IsSetOAuthHttpParameters() => this.OAuthHttpParameters != null;
    }
}
