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
    /// Container for the parameters to the GenerateMac operation.
    /// Generates a Message Authentication Code (MAC) cryptogram within Amazon Web Services
    /// Payment Cryptography. 
    /// 
    ///  
    /// <para>
    /// You can use this operation to authenticate card-related data by using known data values
    /// to generate MAC for data validation between the sending and receiving parties. This
    /// operation uses message data, a secret encryption key and MAC algorithm to generate
    /// a unique MAC value for transmission. The receiving party of the MAC must use the same
    /// message data, secret encryption key and MAC algorithm to reproduce another MAC value
    /// for comparision.
    /// </para>
    ///  
    /// <para>
    /// You can use this operation to generate a DUPKT, CMAC, HMAC or EMV MAC by setting generation
    /// attributes and algorithm to the associated values. The MAC generation encryption key
    /// must have valid values for <c>KeyUsage</c> such as <c>TR31_M7_HMAC_KEY</c> for HMAC
    /// generation, and they key must have <c>KeyModesOfUse</c> set to <c>Generate</c> and
    /// <c>Verify</c>.
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
    ///  <a>VerifyMac</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GenerateMacRequest : AmazonPaymentCryptographyDataRequest
    {
        private MacAttributes _generationAttributes;
        private string _keyIdentifier;
        private int? _macLength;
        private string _messageData;

        /// <summary>
        /// Gets and sets the property GenerationAttributes. 
        /// <para>
        /// The attributes and data values to use for MAC generation within Amazon Web Services
        /// Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MacAttributes GenerationAttributes
        {
            get { return this._generationAttributes; }
            set { this._generationAttributes = value; }
        }

        // Check to see if GenerationAttributes property is set
        internal bool IsSetGenerationAttributes()
        {
            return this._generationAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the MAC generation encryption key.
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
        /// Gets and sets the property MacLength. 
        /// <para>
        /// The length of a MAC under generation.
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
        /// The data for which a MAC is under generation. This value must be hexBinary.
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

    }
}