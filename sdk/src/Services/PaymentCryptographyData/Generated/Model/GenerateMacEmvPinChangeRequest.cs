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
    /// Container for the parameters to the GenerateMacEmvPinChange operation.
    /// Generates an issuer script mac for EMV payment cards that use offline PINs as the
    /// cardholder verification method (CVM).
    /// 
    ///  
    /// <para>
    /// This operation generates an authenticated issuer script response by appending the
    /// incoming message data (APDU command) with the target encrypted PIN block in ISO2 format.
    /// The command structure and method to send the issuer script update to the card is not
    /// defined by this operation and is typically determined by the applicable payment card
    /// scheme.
    /// </para>
    ///  
    /// <para>
    /// The primary inputs to this operation include the incoming new encrypted pinblock,
    /// PIN encryption key (PEK), issuer master key (IMK), primary account number (PAN), and
    /// the payment card derivation method.
    /// </para>
    ///  
    /// <para>
    /// The operation uses two issuer master keys - secure messaging for confidentiality (IMK-SMC)
    /// and secure messaging for integrity (IMK-SMI). The SMC key is used to internally derive
    /// a key to secure the pin, while SMI key is used to internally derive a key to authenticate
    /// the script reponse as per the <a href="https://www.emvco.com/specifications/">EMV
    /// 4.4 - Book 2 - Security and Key Management</a> specification. 
    /// </para>
    ///  
    /// <para>
    /// This operation supports Amex, EMV2000, EMVCommon, Mastercard and Visa derivation methods,
    /// each requiring specific input parameters. Users must follow the specific derivation
    /// method and input parameters defined by the respective payment card scheme.
    /// </para>
    ///  <note> 
    /// <para>
    /// Use <a>GenerateMac</a> operation when sending a script update to an EMV card that
    /// does not involve PIN change. When assigning IAM permissions, it is important to understand
    /// that <a>EncryptData</a> using EMV keys and <a>GenerateMac</a> perform similar functions
    /// to this command.
    /// </para>
    ///  </note> 
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
    ///  <a>EncryptData</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateMac</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GenerateMacEmvPinChangeRequest : AmazonPaymentCryptographyDataRequest
    {
        private DerivationMethodAttributes _derivationMethodAttributes;
        private string _messageData;
        private string _newEncryptedPinBlock;
        private string _newPinPekIdentifier;
        private PinBlockFormatForEmvPinChange _pinBlockFormat;
        private string _secureMessagingConfidentialityKeyIdentifier;
        private string _secureMessagingIntegrityKeyIdentifier;

        /// <summary>
        /// Gets and sets the property DerivationMethodAttributes. 
        /// <para>
        /// The attributes and data values to derive payment card specific confidentiality and
        /// integrity keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DerivationMethodAttributes DerivationMethodAttributes
        {
            get { return this._derivationMethodAttributes; }
            set { this._derivationMethodAttributes = value; }
        }

        // Check to see if DerivationMethodAttributes property is set
        internal bool IsSetDerivationMethodAttributes()
        {
            return this._derivationMethodAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property MessageData. 
        /// <para>
        /// The message data is the APDU command from the card reader or terminal. The target
        /// encrypted PIN block, after translation to ISO2 format, is appended to this message
        /// data to generate an issuer script response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=1024)]
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
        /// Gets and sets the property NewEncryptedPinBlock. 
        /// <para>
        /// The incoming new encrypted PIN block data for offline pin change on an EMV card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=16)]
        public string NewEncryptedPinBlock
        {
            get { return this._newEncryptedPinBlock; }
            set { this._newEncryptedPinBlock = value; }
        }

        // Check to see if NewEncryptedPinBlock property is set
        internal bool IsSetNewEncryptedPinBlock()
        {
            return this._newEncryptedPinBlock != null;
        }

        /// <summary>
        /// Gets and sets the property NewPinPekIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the PEK protecting the incoming new encrypted PIN block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string NewPinPekIdentifier
        {
            get { return this._newPinPekIdentifier; }
            set { this._newPinPekIdentifier = value; }
        }

        // Check to see if NewPinPekIdentifier property is set
        internal bool IsSetNewPinPekIdentifier()
        {
            return this._newPinPekIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PinBlockFormat. 
        /// <para>
        /// The PIN encoding format of the incoming new encrypted PIN block as specified in ISO
        /// 9564.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PinBlockFormatForEmvPinChange PinBlockFormat
        {
            get { return this._pinBlockFormat; }
            set { this._pinBlockFormat = value; }
        }

        // Check to see if PinBlockFormat property is set
        internal bool IsSetPinBlockFormat()
        {
            return this._pinBlockFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SecureMessagingConfidentialityKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the issuer master key (IMK-SMC) used to protect the PIN block
        /// data in the issuer script response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string SecureMessagingConfidentialityKeyIdentifier
        {
            get { return this._secureMessagingConfidentialityKeyIdentifier; }
            set { this._secureMessagingConfidentialityKeyIdentifier = value; }
        }

        // Check to see if SecureMessagingConfidentialityKeyIdentifier property is set
        internal bool IsSetSecureMessagingConfidentialityKeyIdentifier()
        {
            return this._secureMessagingConfidentialityKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SecureMessagingIntegrityKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the issuer master key (IMK-SMI) used to authenticate the issuer
        /// script response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string SecureMessagingIntegrityKeyIdentifier
        {
            get { return this._secureMessagingIntegrityKeyIdentifier; }
            set { this._secureMessagingIntegrityKeyIdentifier = value; }
        }

        // Check to see if SecureMessagingIntegrityKeyIdentifier property is set
        internal bool IsSetSecureMessagingIntegrityKeyIdentifier()
        {
            return this._secureMessagingIntegrityKeyIdentifier != null;
        }

    }
}