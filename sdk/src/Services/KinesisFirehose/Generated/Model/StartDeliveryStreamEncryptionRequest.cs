/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the StartDeliveryStreamEncryption operation.
    /// Enables server-side encryption (SSE) for the delivery stream. 
    /// 
    ///  
    /// <para>
    /// This operation is asynchronous. It returns immediately. When you invoke it, Kinesis
    /// Data Firehose first sets the encryption status of the stream to <code>ENABLING</code>,
    /// and then to <code>ENABLED</code>. The encryption status of a delivery stream is the
    /// <code>Status</code> property in <a>DeliveryStreamEncryptionConfiguration</a>. If the
    /// operation fails, the encryption status changes to <code>ENABLING_FAILED</code>. You
    /// can continue to read and write data to your delivery stream while the encryption status
    /// is <code>ENABLING</code>, but the data is not encrypted. It can take up to 5 seconds
    /// after the encryption status changes to <code>ENABLED</code> before all records written
    /// to the delivery stream are encrypted. To find out whether a record or a batch of records
    /// was encrypted, check the response elements <a>PutRecordOutput$Encrypted</a> and <a>PutRecordBatchOutput$Encrypted</a>,
    /// respectively.
    /// </para>
    ///  
    /// <para>
    /// To check the encryption status of a delivery stream, use <a>DescribeDeliveryStream</a>.
    /// </para>
    ///  
    /// <para>
    /// Even if encryption is currently enabled for a delivery stream, you can still invoke
    /// this operation on it to change the ARN of the CMK or both its type and ARN. If you
    /// invoke this method to change the CMK, and the old CMK is of type <code>CUSTOMER_MANAGED_CMK</code>,
    /// Kinesis Data Firehose schedules the grant it had on the old CMK for retirement. If
    /// the new CMK is of type <code>CUSTOMER_MANAGED_CMK</code>, Kinesis Data Firehose creates
    /// a grant that enables it to use the new CMK to encrypt and decrypt data and to manage
    /// the grant.
    /// </para>
    ///  
    /// <para>
    /// If a delivery stream already has encryption enabled and then you invoke this operation
    /// to change the ARN of the CMK or both its type and ARN and you get <code>ENABLING_FAILED</code>,
    /// this only means that the attempt to change the CMK failed. In this case, encryption
    /// remains enabled with the old CMK.
    /// </para>
    ///  
    /// <para>
    /// If the encryption status of your delivery stream is <code>ENABLING_FAILED</code>,
    /// you can invoke this operation again with a valid CMK. The CMK must be enabled and
    /// the key policy mustn't explicitly deny the permission for Kinesis Data Firehose to
    /// invoke KMS encrypt and decrypt operations.
    /// </para>
    ///  
    /// <para>
    /// You can enable SSE for a delivery stream only if it's a delivery stream that uses
    /// <code>DirectPut</code> as its source. 
    /// </para>
    ///  
    /// <para>
    /// The <code>StartDeliveryStreamEncryption</code> and <code>StopDeliveryStreamEncryption</code>
    /// operations have a combined limit of 25 calls per delivery stream per 24 hours. For
    /// example, you reach the limit if you call <code>StartDeliveryStreamEncryption</code>
    /// 13 times and <code>StopDeliveryStreamEncryption</code> 12 times for the same delivery
    /// stream in a 24-hour period.
    /// </para>
    /// </summary>
    public partial class StartDeliveryStreamEncryptionRequest : AmazonKinesisFirehoseRequest
    {
        private DeliveryStreamEncryptionConfigurationInput _deliveryStreamEncryptionConfigurationInput;
        private string _deliveryStreamName;

        /// <summary>
        /// Gets and sets the property DeliveryStreamEncryptionConfigurationInput. 
        /// <para>
        /// Used to specify the type and Amazon Resource Name (ARN) of the KMS key needed for
        /// Server-Side Encryption (SSE).
        /// </para>
        /// </summary>
        public DeliveryStreamEncryptionConfigurationInput DeliveryStreamEncryptionConfigurationInput
        {
            get { return this._deliveryStreamEncryptionConfigurationInput; }
            set { this._deliveryStreamEncryptionConfigurationInput = value; }
        }

        // Check to see if DeliveryStreamEncryptionConfigurationInput property is set
        internal bool IsSetDeliveryStreamEncryptionConfigurationInput()
        {
            return this._deliveryStreamEncryptionConfigurationInput != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream for which you want to enable server-side encryption
        /// (SSE).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

    }
}