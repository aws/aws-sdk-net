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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// An elliptic curve public key in JSON Web Key (JWK) format, as described in RFC 7518
    /// section 6.2, used to bind a payment token to the agent.
    /// </summary>
    public partial class DpopJwk
    {
        /// <summary>
        /// Gets and sets the property Crv. 
        /// <para>
        /// The elliptic curve of the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JwkEllipticCurve Crv { get; set; }

        /// <summary>
        /// Checks to see if the Crv property is set.
        /// </summary>
        internal bool IsSetCrv() => this.Crv != null;

        /// <summary>
        /// Gets and sets the property Kty. 
        /// <para>
        /// The key type. The only valid value is <c>EC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JwkKeyType Kty { get; set; }

        /// <summary>
        /// Checks to see if the Kty property is set.
        /// </summary>
        internal bool IsSetKty() => this.Kty != null;

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The x-coordinate of the elliptic curve point, base64url-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 43, Max = 128)]
        public string X { get; set; }

        /// <summary>
        /// Checks to see if the X property is set.
        /// </summary>
        internal bool IsSetX() => this.X != null;

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// The y-coordinate of the elliptic curve point, base64url-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 43, Max = 128)]
        public string Y { get; set; }

        /// <summary>
        /// Checks to see if the Y property is set.
        /// </summary>
        internal bool IsSetY() => this.Y != null;
    }
}
