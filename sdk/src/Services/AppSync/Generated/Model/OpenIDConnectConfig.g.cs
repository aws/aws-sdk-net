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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes an OpenID Connect (OIDC) configuration.
    /// </summary>
    public partial class OpenIDConnectConfig
    {
        /// <summary>
        /// Gets and sets the property AuthTTL. 
        /// <para>
        /// The number of milliseconds that a token is valid after being authenticated.
        /// </para>
        /// </summary>
        public long? AuthTTL { get; set; }

        /// <summary>
        /// Checks to see if the AuthTTL property is set.
        /// </summary>
        internal bool IsSetAuthTTL() => this.AuthTTL.HasValue;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client identifier of the relying party at the OpenID identity provider. This identifier
        /// is typically obtained when the relying party is registered with the OpenID identity
        /// provider. You can specify a regular expression so that AppSync can validate against
        /// multiple client identifiers at a time.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property IatTTL. 
        /// <para>
        /// The number of milliseconds that a token is valid after it's issued to a user.
        /// </para>
        /// </summary>
        public long? IatTTL { get; set; }

        /// <summary>
        /// Checks to see if the IatTTL property is set.
        /// </summary>
        internal bool IsSetIatTTL() => this.IatTTL.HasValue;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer for the OIDC configuration. The issuer returned by discovery must exactly
        /// match the value of <c>iss</c> in the ID token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;
    }
}
