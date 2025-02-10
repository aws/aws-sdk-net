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
    /// This is the response object from the GenerateMacEmvPinChange operation.
    /// </summary>
    public partial class GenerateMacEmvPinChangeResponse : AmazonWebServiceResponse
    {
        private string _encryptedPinBlock;
        private string _mac;
        private string _newPinPekArn;
        private string _newPinPekKeyCheckValue;
        private string _secureMessagingConfidentialityKeyArn;
        private string _secureMessagingConfidentialityKeyCheckValue;
        private string _secureMessagingIntegrityKeyArn;
        private string _secureMessagingIntegrityKeyCheckValue;
        private VisaAmexDerivationOutputs _visaAmexDerivationOutputs;

        /// <summary>
        /// Gets and sets the property EncryptedPinBlock. 
        /// <para>
        /// Returns the incoming new encrpted PIN block.
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
        /// Gets and sets the property Mac. 
        /// <para>
        /// Returns the mac of the issuer script containing message data and appended target encrypted
        /// pin block in ISO2 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=8, Max=16)]
        public string Mac
        {
            get { return this._mac; }
            set { this._mac = value; }
        }

        // Check to see if Mac property is set
        internal bool IsSetMac()
        {
            return this._mac != null;
        }

        /// <summary>
        /// Gets and sets the property NewPinPekArn. 
        /// <para>
        /// Returns the <c>keyArn</c> of the PEK protecting the incoming new encrypted PIN block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string NewPinPekArn
        {
            get { return this._newPinPekArn; }
            set { this._newPinPekArn = value; }
        }

        // Check to see if NewPinPekArn property is set
        internal bool IsSetNewPinPekArn()
        {
            return this._newPinPekArn != null;
        }

        /// <summary>
        /// Gets and sets the property NewPinPekKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the PEK uprotecting the incoming new encrypted PIN block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string NewPinPekKeyCheckValue
        {
            get { return this._newPinPekKeyCheckValue; }
            set { this._newPinPekKeyCheckValue = value; }
        }

        // Check to see if NewPinPekKeyCheckValue property is set
        internal bool IsSetNewPinPekKeyCheckValue()
        {
            return this._newPinPekKeyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property SecureMessagingConfidentialityKeyArn. 
        /// <para>
        /// Returns the <c>keyArn</c> of the IMK-SMC used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string SecureMessagingConfidentialityKeyArn
        {
            get { return this._secureMessagingConfidentialityKeyArn; }
            set { this._secureMessagingConfidentialityKeyArn = value; }
        }

        // Check to see if SecureMessagingConfidentialityKeyArn property is set
        internal bool IsSetSecureMessagingConfidentialityKeyArn()
        {
            return this._secureMessagingConfidentialityKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecureMessagingConfidentialityKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the SMC issuer master key used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string SecureMessagingConfidentialityKeyCheckValue
        {
            get { return this._secureMessagingConfidentialityKeyCheckValue; }
            set { this._secureMessagingConfidentialityKeyCheckValue = value; }
        }

        // Check to see if SecureMessagingConfidentialityKeyCheckValue property is set
        internal bool IsSetSecureMessagingConfidentialityKeyCheckValue()
        {
            return this._secureMessagingConfidentialityKeyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property SecureMessagingIntegrityKeyArn. 
        /// <para>
        /// Returns the <c>keyArn</c> of the IMK-SMI used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string SecureMessagingIntegrityKeyArn
        {
            get { return this._secureMessagingIntegrityKeyArn; }
            set { this._secureMessagingIntegrityKeyArn = value; }
        }

        // Check to see if SecureMessagingIntegrityKeyArn property is set
        internal bool IsSetSecureMessagingIntegrityKeyArn()
        {
            return this._secureMessagingIntegrityKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecureMessagingIntegrityKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the SMI issuer master key used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string SecureMessagingIntegrityKeyCheckValue
        {
            get { return this._secureMessagingIntegrityKeyCheckValue; }
            set { this._secureMessagingIntegrityKeyCheckValue = value; }
        }

        // Check to see if SecureMessagingIntegrityKeyCheckValue property is set
        internal bool IsSetSecureMessagingIntegrityKeyCheckValue()
        {
            return this._secureMessagingIntegrityKeyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property VisaAmexDerivationOutputs. 
        /// <para>
        /// The attribute values used for Amex and Visa derivation methods.
        /// </para>
        /// </summary>
        public VisaAmexDerivationOutputs VisaAmexDerivationOutputs
        {
            get { return this._visaAmexDerivationOutputs; }
            set { this._visaAmexDerivationOutputs = value; }
        }

        // Check to see if VisaAmexDerivationOutputs property is set
        internal bool IsSetVisaAmexDerivationOutputs()
        {
            return this._visaAmexDerivationOutputs != null;
        }

    }
}