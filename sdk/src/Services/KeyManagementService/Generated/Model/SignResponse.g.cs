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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the Sign operation.
    /// </summary>
    public partial class SignResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the asymmetric KMS key that was used to sign the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// The cryptographic signature that was generated for the message. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When used with the supported RSA signing algorithms, the encoding of this value is
        /// defined by <a href="https://tools.ietf.org/html/rfc8017">PKCS #1 in RFC 8017</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When used with the <c>ECDSA_SHA_256</c>, <c>ECDSA_SHA_384</c>, or <c>ECDSA_SHA_512</c>
        /// signing algorithms, this value is a DER-encoded object as defined by ANSI X9.62–2005
        /// and <a href="https://tools.ietf.org/html/rfc3279#section-2.2.3">RFC 3279 Section 2.2.3</a>.
        /// This is the most commonly used signature format and is appropriate for most uses.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you use the HTTP API or the Amazon Web Services CLI, the value is Base64-encoded.
        /// Otherwise, it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6144)]
        public MemoryStream Signature { get; set; }

        /// <summary>
        /// Checks to see if the Signature property is set.
        /// </summary>
        internal bool IsSetSignature() => this.Signature != null;

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The signing algorithm that was used to sign the message.
        /// </para>
        /// </summary>
        public SigningAlgorithmSpec SigningAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithm property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithm() => this.SigningAlgorithm != null;
    }
}
