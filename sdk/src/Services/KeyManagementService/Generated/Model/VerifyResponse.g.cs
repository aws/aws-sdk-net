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
    /// This is the response object from the Verify operation.
    /// </summary>
    public partial class VerifyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the asymmetric KMS key that was used to verify the signature.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property SignatureValid. 
        /// <para>
        /// A Boolean value that indicates whether the signature was verified. A value of <c>True</c>
        /// indicates that the <c>Signature</c> was produced by signing the <c>Message</c> with
        /// the specified <c>KeyID</c> and <c>SigningAlgorithm.</c> If the signature is not verified,
        /// the <c>Verify</c> operation fails with a <c>KMSInvalidSignatureException</c> exception.
        /// 
        /// </para>
        /// </summary>
        public bool? SignatureValid { get; set; }

        /// <summary>
        /// Checks to see if the SignatureValid property is set.
        /// </summary>
        internal bool IsSetSignatureValid() => this.SignatureValid.HasValue;

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The signing algorithm that was used to verify the signature.
        /// </para>
        /// </summary>
        public SigningAlgorithmSpec SigningAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithm property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithm() => this.SigningAlgorithm != null;
    }
}
