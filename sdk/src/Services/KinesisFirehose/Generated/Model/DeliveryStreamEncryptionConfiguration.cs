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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Contains information about the server-side encryption (SSE) status for the delivery
    /// stream, the type customer master key (CMK) in use, if any, and the ARN of the CMK.
    /// You can get <code>DeliveryStreamEncryptionConfiguration</code> by invoking the <a>DescribeDeliveryStream</a>
    /// operation.
    /// </summary>
    public partial class DeliveryStreamEncryptionConfiguration
    {
        private FailureDescription _failureDescription;
        private string _keyARN;
        private KeyType _keyType;
        private DeliveryStreamEncryptionStatus _status;

        /// <summary>
        /// Gets and sets the property FailureDescription. 
        /// <para>
        /// Provides details in case one of the following operations fails due to an error related
        /// to KMS: <a>CreateDeliveryStream</a>, <a>DeleteDeliveryStream</a>, <a>StartDeliveryStreamEncryption</a>,
        /// <a>StopDeliveryStreamEncryption</a>.
        /// </para>
        /// </summary>
        public FailureDescription FailureDescription
        {
            get { return this._failureDescription; }
            set { this._failureDescription = value; }
        }

        // Check to see if FailureDescription property is set
        internal bool IsSetFailureDescription()
        {
            return this._failureDescription != null;
        }

        /// <summary>
        /// Gets and sets the property KeyARN. 
        /// <para>
        /// If <code>KeyType</code> is <code>CUSTOMER_MANAGED_CMK</code>, this field contains
        /// the ARN of the customer managed CMK. If <code>KeyType</code> is <code>Amazon Web Services_OWNED_CMK</code>,
        /// <code>DeliveryStreamEncryptionConfiguration</code> doesn't contain a value for <code>KeyARN</code>.
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
        /// Indicates the type of customer master key (CMK) that is used for encryption. The default
        /// setting is <code>Amazon Web Services_OWNED_CMK</code>. For more information about
        /// CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">Customer
        /// Master Keys (CMKs)</a>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This is the server-side encryption (SSE) status for the delivery stream. For a full
        /// description of the different values of this status, see <a>StartDeliveryStreamEncryption</a>
        /// and <a>StopDeliveryStreamEncryption</a>. If this status is <code>ENABLING_FAILED</code>
        /// or <code>DISABLING_FAILED</code>, it is the status of the most recent attempt to enable
        /// or disable SSE, respectively.
        /// </para>
        /// </summary>
        public DeliveryStreamEncryptionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}