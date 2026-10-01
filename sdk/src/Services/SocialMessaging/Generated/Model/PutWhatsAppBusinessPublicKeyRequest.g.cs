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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the PutWhatsAppBusinessPublicKey operation. Sets the
    /// business public key used to encrypt the data exchanged with the endpoint of a data
    /// exchange Flow.
    /// </summary>
    public partial class PutWhatsAppBusinessPublicKeyRequest : AmazonSocialMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property BusinessPublicKey. 
        /// <para>
        /// The PEM-encoded 2048-bit RSA public key to set. Mutually exclusive with <c>kmsKeyArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string BusinessPublicKey { get; set; }

        /// <summary>
        /// Checks to see if the BusinessPublicKey property is set.
        /// </summary>
        internal bool IsSetBusinessPublicKey() => this.BusinessPublicKey != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of a customer managed asymmetric RSA key in Amazon Web Services KMS. Mutually
        /// exclusive with <c>businessPublicKey</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumberId. 
        /// <para>
        /// The unique identifier of the phone number to associate with the business public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 115)]
        public string OriginationPhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the OriginationPhoneNumberId property is set.
        /// </summary>
        internal bool IsSetOriginationPhoneNumberId() => this.OriginationPhoneNumberId != null;
    }
}
