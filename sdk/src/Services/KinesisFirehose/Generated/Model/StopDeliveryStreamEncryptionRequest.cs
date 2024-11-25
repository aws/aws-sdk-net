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
    /// Container for the parameters to the StopDeliveryStreamEncryption operation.
    /// Disables server-side encryption (SSE) for the Firehose stream. 
    /// 
    ///  
    /// <para>
    /// This operation is asynchronous. It returns immediately. When you invoke it, Firehose
    /// first sets the encryption status of the stream to <c>DISABLING</c>, and then to <c>DISABLED</c>.
    /// You can continue to read and write data to your stream while its status is <c>DISABLING</c>.
    /// It can take up to 5 seconds after the encryption status changes to <c>DISABLED</c>
    /// before all records written to the Firehose stream are no longer subject to encryption.
    /// To find out whether a record or a batch of records was encrypted, check the response
    /// elements <a>PutRecordOutput$Encrypted</a> and <a>PutRecordBatchOutput$Encrypted</a>,
    /// respectively.
    /// </para>
    ///  
    /// <para>
    /// To check the encryption state of a Firehose stream, use <a>DescribeDeliveryStream</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// If SSE is enabled using a customer managed CMK and then you invoke <c>StopDeliveryStreamEncryption</c>,
    /// Firehose schedules the related KMS grant for retirement and then retires it after
    /// it ensures that it is finished delivering records to the destination.
    /// </para>
    ///  
    /// <para>
    /// The <c>StartDeliveryStreamEncryption</c> and <c>StopDeliveryStreamEncryption</c> operations
    /// have a combined limit of 25 calls per Firehose stream per 24 hours. For example, you
    /// reach the limit if you call <c>StartDeliveryStreamEncryption</c> 13 times and <c>StopDeliveryStreamEncryption</c>
    /// 12 times for the same Firehose stream in a 24-hour period.
    /// </para>
    /// </summary>
    public partial class StopDeliveryStreamEncryptionRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the Firehose stream for which you want to disable server-side encryption
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