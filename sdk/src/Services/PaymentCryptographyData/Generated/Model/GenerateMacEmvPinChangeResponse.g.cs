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
    /// This is the response object from the GenerateMacEmvPinChange operation.
    /// </summary>
    public partial class GenerateMacEmvPinChangeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EncryptedPinBlock. 
        /// <para>
        /// Returns the incoming new encrpted PIN block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 32)]
        public string EncryptedPinBlock { get; set; }

        /// <summary>
        /// Checks to see if the EncryptedPinBlock property is set.
        /// </summary>
        internal bool IsSetEncryptedPinBlock() => this.EncryptedPinBlock != null;

        /// <summary>
        /// Gets and sets the property Mac. 
        /// <para>
        /// Returns the mac of the issuer script containing message data and appended target encrypted
        /// pin block in ISO2 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 8, Max = 16)]
        public string Mac { get; set; }

        /// <summary>
        /// Checks to see if the Mac property is set.
        /// </summary>
        internal bool IsSetMac() => this.Mac != null;

        /// <summary>
        /// Gets and sets the property NewPinPekArn. 
        /// <para>
        /// Returns the <c>keyArn</c> of the PEK protecting the incoming new encrypted PIN block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string NewPinPekArn { get; set; }

        /// <summary>
        /// Checks to see if the NewPinPekArn property is set.
        /// </summary>
        internal bool IsSetNewPinPekArn() => this.NewPinPekArn != null;

        /// <summary>
        /// Gets and sets the property NewPinPekKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the PEK uprotecting the incoming new encrypted PIN block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string NewPinPekKeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the NewPinPekKeyCheckValue property is set.
        /// </summary>
        internal bool IsSetNewPinPekKeyCheckValue() => this.NewPinPekKeyCheckValue != null;

        /// <summary>
        /// Gets and sets the property SecureMessagingConfidentialityKeyArn. 
        /// <para>
        /// Returns the <c>keyArn</c> of the IMK-SMC used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string SecureMessagingConfidentialityKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the SecureMessagingConfidentialityKeyArn property is set.
        /// </summary>
        internal bool IsSetSecureMessagingConfidentialityKeyArn() => this.SecureMessagingConfidentialityKeyArn != null;

        /// <summary>
        /// Gets and sets the property SecureMessagingConfidentialityKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the SMC issuer master key used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string SecureMessagingConfidentialityKeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the SecureMessagingConfidentialityKeyCheckValue property is set.
        /// </summary>
        internal bool IsSetSecureMessagingConfidentialityKeyCheckValue() => this.SecureMessagingConfidentialityKeyCheckValue != null;

        /// <summary>
        /// Gets and sets the property SecureMessagingIntegrityKeyArn. 
        /// <para>
        /// Returns the <c>keyArn</c> of the IMK-SMI used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string SecureMessagingIntegrityKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the SecureMessagingIntegrityKeyArn property is set.
        /// </summary>
        internal bool IsSetSecureMessagingIntegrityKeyArn() => this.SecureMessagingIntegrityKeyArn != null;

        /// <summary>
        /// Gets and sets the property SecureMessagingIntegrityKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the SMI issuer master key used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string SecureMessagingIntegrityKeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the SecureMessagingIntegrityKeyCheckValue property is set.
        /// </summary>
        internal bool IsSetSecureMessagingIntegrityKeyCheckValue() => this.SecureMessagingIntegrityKeyCheckValue != null;

        /// <summary>
        /// Gets and sets the property VisaAmexDerivationOutputs. 
        /// <para>
        /// The attribute values used for Amex and Visa derivation methods.
        /// </para>
        /// </summary>
        public VisaAmexDerivationOutputs VisaAmexDerivationOutputs { get; set; }

        /// <summary>
        /// Checks to see if the VisaAmexDerivationOutputs property is set.
        /// </summary>
        internal bool IsSetVisaAmexDerivationOutputs() => this.VisaAmexDerivationOutputs != null;
    }
}
