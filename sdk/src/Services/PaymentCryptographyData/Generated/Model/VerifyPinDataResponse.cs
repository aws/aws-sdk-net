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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
        private string _encryptionKeyArn;
        private string _encryptionKeyCheckValue;
        private string _verificationKeyArn;
        private string _verificationKeyCheckValue;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The <c>keyARN</c> of the PEK that Amazon Web Services Payment Cryptography uses for
        /// encrypted pin block generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

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
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string EncryptionKeyCheckValue
        {
            get { return this._encryptionKeyCheckValue; }
            set { this._encryptionKeyCheckValue = value; }
        }

        // Check to see if EncryptionKeyCheckValue property is set
        internal bool IsSetEncryptionKeyCheckValue()
        {
            return this._encryptionKeyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationKeyArn. 
        /// <para>
        /// The <c>keyARN</c> of the PIN encryption key that Amazon Web Services Payment Cryptography
        /// uses for PIN or PIN Offset verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string VerificationKeyArn
        {
            get { return this._verificationKeyArn; }
            set { this._verificationKeyArn = value; }
        }

        // Check to see if VerificationKeyArn property is set
        internal bool IsSetVerificationKeyArn()
        {
            return this._verificationKeyArn != null;
        }

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
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string VerificationKeyCheckValue
        {
            get { return this._verificationKeyCheckValue; }
            set { this._verificationKeyCheckValue = value; }
        }

        // Check to see if VerificationKeyCheckValue property is set
        internal bool IsSetVerificationKeyCheckValue()
        {
            return this._verificationKeyCheckValue != null;
        }

    }
}