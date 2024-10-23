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
    /// This is the response object from the GeneratePinData operation.
    /// </summary>
    public partial class GeneratePinDataResponse : AmazonWebServiceResponse
    {
        private string _encryptedPinBlock;
        private string _encryptionKeyArn;
        private string _encryptionKeyCheckValue;
        private string _generationKeyArn;
        private string _generationKeyCheckValue;
        private PinData _pinData;

        /// <summary>
        /// Gets and sets the property EncryptedPinBlock. 
        /// <para>
        /// The PIN block encrypted under PEK from Amazon Web Services Payment Cryptography. The
        /// encrypted PIN block is a composite of PAN (Primary Account Number) and PIN (Personal
        /// Identification Number), generated in accordance with ISO 9564 standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=32)]
        public string EncryptedPinBlock
        {
            get { return this._encryptedPinBlock; }
            set { this._encryptedPinBlock = value; }
        }

        // Check to see if EncryptedPinBlock property is set
        internal bool IsSetEncryptedPinBlock()
        {
            return this._encryptedPinBlock != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The <c>keyARN</c> of the PEK that Amazon Web Services Payment Cryptography uses for
        /// encrypted pin block generation. For ECDH, it is the <c>keyARN</c> of the asymmetric
        /// ECC key.
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
        /// Gets and sets the property GenerationKeyArn. 
        /// <para>
        /// The <c>keyARN</c> of the pin data generation key that Amazon Web Services Payment
        /// Cryptography uses for PIN, PVV or PIN Offset generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string GenerationKeyArn
        {
            get { return this._generationKeyArn; }
            set { this._generationKeyArn = value; }
        }

        // Check to see if GenerationKeyArn property is set
        internal bool IsSetGenerationKeyArn()
        {
            return this._generationKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationKeyCheckValue. 
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
        public string GenerationKeyCheckValue
        {
            get { return this._generationKeyCheckValue; }
            set { this._generationKeyCheckValue = value; }
        }

        // Check to see if GenerationKeyCheckValue property is set
        internal bool IsSetGenerationKeyCheckValue()
        {
            return this._generationKeyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property PinData. 
        /// <para>
        /// The attributes and values Amazon Web Services Payment Cryptography uses for pin data
        /// generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PinData PinData
        {
            get { return this._pinData; }
            set { this._pinData = value; }
        }

        // Check to see if PinData property is set
        internal bool IsSetPinData()
        {
            return this._pinData != null;
        }

    }
}