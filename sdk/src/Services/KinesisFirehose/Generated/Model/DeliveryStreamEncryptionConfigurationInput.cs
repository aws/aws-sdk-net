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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Specifies the type and Amazon Resource Name (ARN) of the CMK to use for Server-Side
    /// Encryption (SSE).
    /// </summary>
    public partial class DeliveryStreamEncryptionConfigurationInput
    {
        private string _keyARN;
        private KeyType _keyType;

        /// <summary>
        /// Gets and sets the property KeyARN. 
        /// <para>
        /// If you set <c>KeyType</c> to <c>CUSTOMER_MANAGED_CMK</c>, you must specify the Amazon
        /// Resource Name (ARN) of the CMK. If you set <c>KeyType</c> to <c>Amazon Web Services_OWNED_CMK</c>,
        /// Firehose uses a service-account CMK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string KeyARN
        {
            get { return this._keyARN; }
            set { this._keyARN = value; }
        }

        // Check to see if KeyARN property is set
        internal bool IsSetKeyARN()
        {
            return this._keyARN != null;
        }

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// Indicates the type of customer master key (CMK) to use for encryption. The default
        /// setting is <c>Amazon Web Services_OWNED_CMK</c>. For more information about CMKs,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">Customer
        /// Master Keys (CMKs)</a>. When you invoke <a>CreateDeliveryStream</a> or <a>StartDeliveryStreamEncryption</a>
        /// with <c>KeyType</c> set to CUSTOMER_MANAGED_CMK, Firehose invokes the Amazon KMS operation
        /// <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateGrant.html">CreateGrant</a>
        /// to create a grant that allows the Firehose service to use the customer managed CMK
        /// to perform encryption and decryption. Firehose manages that grant. 
        /// </para>
        ///  
        /// <para>
        /// When you invoke <a>StartDeliveryStreamEncryption</a> to change the CMK for a Firehose
        /// stream that is encrypted with a customer managed CMK, Firehose schedules the grant
        /// it had on the old CMK for retirement.
        /// </para>
        ///  
        /// <para>
        /// You can use a CMK of type CUSTOMER_MANAGED_CMK to encrypt up to 500 Firehose streams.
        /// If a <a>CreateDeliveryStream</a> or <a>StartDeliveryStreamEncryption</a> operation
        /// exceeds this limit, Firehose throws a <c>LimitExceededException</c>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// To encrypt your Firehose stream, use symmetric CMKs. Firehose doesn't support asymmetric
        /// CMKs. For information about symmetric and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html">About
        /// Symmetric and Asymmetric CMKs</a> in the Amazon Web Services Key Management Service
        /// developer guide.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyType KeyType
        {
            get { return this._keyType; }
            set { this._keyType = value; }
        }

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this._keyType != null;
        }

    }
}