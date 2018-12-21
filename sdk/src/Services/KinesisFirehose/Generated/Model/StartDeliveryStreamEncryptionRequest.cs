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
    /// Data Firehose first sets the status of the stream to <code>ENABLING</code>, and then
    /// to <code>ENABLED</code>. You can continue to read and write data to your stream while
    /// its status is <code>ENABLING</code>, but the data is not encrypted. It can take up
    /// to 5 seconds after the encryption status changes to <code>ENABLED</code> before all
    /// records written to the delivery stream are encrypted. To find out whether a record
    /// or a batch of records was encrypted, check the response elements <a>PutRecordOutput$Encrypted</a>
    /// and <a>PutRecordBatchOutput$Encrypted</a>, respectively.
    /// </para>
    ///  
    /// <para>
    /// To check the encryption state of a delivery stream, use <a>DescribeDeliveryStream</a>.
    /// </para>
    ///  
    /// <para>
    /// You can only enable SSE for a delivery stream that uses <code>DirectPut</code> as
    /// its source. 
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
        private string _deliveryStreamName;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream for which you want to enable server-side encryption
        /// (SSE).
        /// </para>
        /// </summary>
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