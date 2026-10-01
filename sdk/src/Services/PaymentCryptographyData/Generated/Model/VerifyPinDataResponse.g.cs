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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// This is the response object from the VerifyPinData operation.
    /// </summary>
    public partial class VerifyPinDataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The <c>keyARN</c> of the PEK that Amazon Web Services Payment Cryptography uses for
        /// encrypted pin block generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the encryption key. The KCV is used to check if all parties
        /// holding a given key have the same key or to detect that a key has changed.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography computes the KCV according to the CMAC specification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string EncryptionKeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyCheckValue property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyCheckValue() => this.EncryptionKeyCheckValue != null;

        /// <summary>
        /// Gets and sets the property VerificationKeyArn. 
        /// <para>
        /// The <c>keyARN</c> of the PIN encryption key that Amazon Web Services Payment Cryptography
        /// uses for PIN or PIN Offset verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string VerificationKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the VerificationKeyArn property is set.
        /// </summary>
        internal bool IsSetVerificationKeyArn() => this.VerificationKeyArn != null;

        /// <summary>
        /// Gets and sets the property VerificationKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the encryption key. The KCV is used to check if all parties
        /// holding a given key have the same key or to detect that a key has changed.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography computes the KCV according to the CMAC specification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string VerificationKeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the VerificationKeyCheckValue property is set.
        /// </summary>
        internal bool IsSetVerificationKeyCheckValue() => this.VerificationKeyCheckValue != null;
    }
}
