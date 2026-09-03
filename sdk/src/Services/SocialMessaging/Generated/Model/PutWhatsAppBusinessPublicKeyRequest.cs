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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
    /// Container for the parameters to the PutWhatsAppBusinessPublicKey operation.
    /// Sets the business public key used to encrypt the data exchanged with the endpoint
    /// of a data exchange Flow.
    /// </summary>
    public partial class PutWhatsAppBusinessPublicKeyRequest : AmazonSocialMessagingRequest
    {
        private string _businessPublicKey;
        private string _kmsKeyArn;
        private string _originationPhoneNumberId;

        /// <summary>
        /// Gets and sets the property BusinessPublicKey. 
        /// <para>
        /// PEM-encoded RSA public key. Mutually exclusive with kmsKeyArn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string BusinessPublicKey
        {
            get { return this._businessPublicKey; }
            set { this._businessPublicKey = value; }
        }

        // Check to see if BusinessPublicKey property is set
        internal bool IsSetBusinessPublicKey()
        {
            return this._businessPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// Customer-managed KMS asymmetric RSA key ARN. Mutually exclusive with businessPublicKey.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumberId. 
        /// <para>
        /// The unique identifier of the phone number to associate with the business public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=115)]
        public string OriginationPhoneNumberId
        {
            get { return this._originationPhoneNumberId; }
            set { this._originationPhoneNumberId = value; }
        }

        // Check to see if OriginationPhoneNumberId property is set
        internal bool IsSetOriginationPhoneNumberId()
        {
            return this._originationPhoneNumberId != null;
        }

    }
}