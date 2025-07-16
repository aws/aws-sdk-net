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
    /// Container for the parameters to the VerifyMac operation.
    /// Verifies a Message Authentication Code (MAC). 
    /// 
    ///  
    /// <para>
    /// You can use this operation to verify MAC for message data authentication such as .
    /// In this operation, you must use the same message data, secret encryption key and MAC
    /// algorithm that was used to generate MAC. You can use this operation to verify a DUPKT,
    /// CMAC, HMAC or EMV MAC by setting generation attributes and algorithm to the associated
    /// values. 
    /// </para>
    ///  
    /// <para>
    /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
    /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
    /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
    /// User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GenerateMac</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class VerifyMacRequest : AmazonPaymentCryptographyDataRequest
    {
        private string _keyIdentifier;
        private string _mac;
        private int? _macLength;
        private string _messageData;
        private MacAttributes _verificationAttributes;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the encryption key that Amazon Web Services Payment Cryptography
        /// uses to verify MAC data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string KeyIdentifier
        {
            get { return this._keyIdentifier; }
            set { this._keyIdentifier = value; }
        }

        // Check to see if KeyIdentifier property is set
        internal bool IsSetKeyIdentifier()
        {
            return this._keyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Mac. 
        /// <para>
        /// The MAC being verified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=4, Max=128)]
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
        /// Gets and sets the property MacLength. 
        /// <para>
        /// The length of the MAC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=16)]
        public int? MacLength
        {
            get { return this._macLength; }
            set { this._macLength = value; }
        }

        // Check to see if MacLength property is set
        internal bool IsSetMacLength()
        {
            return this._macLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageData. 
        /// <para>
        /// The data on for which MAC is under verification. This value must be hexBinary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=8192)]
        public string MessageData
        {
            get { return this._messageData; }
            set { this._messageData = value; }
        }

        // Check to see if MessageData property is set
        internal bool IsSetMessageData()
        {
            return this._messageData != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationAttributes. 
        /// <para>
        /// The attributes and data values to use for MAC verification within Amazon Web Services
        /// Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MacAttributes VerificationAttributes
        {
            get { return this._verificationAttributes; }
            set { this._verificationAttributes = value; }
        }

        // Check to see if VerificationAttributes property is set
        internal bool IsSetVerificationAttributes()
        {
            return this._verificationAttributes != null;
        }

    }
}