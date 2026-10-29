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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action that writes data to an Amazon Kinesis Firehose stream.
    /// </summary>
    public partial class FirehoseAction
    {
        /// <summary>
        /// Gets and sets the property BatchMode. 
        /// <para>
        /// Whether to deliver the Kinesis Data Firehose stream as a batch by using <a href="https://docs.aws.amazon.com/firehose/latest/APIReference/API_PutRecordBatch.html">
        /// <c>PutRecordBatch</c> </a>. The default value is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// When <c>batchMode</c> is <c>true</c> and the rule's SQL statement evaluates to an
        /// Array, each Array element forms one record in the <a href="https://docs.aws.amazon.com/firehose/latest/APIReference/API_PutRecordBatch.html">
        /// <c>PutRecordBatch</c> </a> request. The resulting array can't have more than 500 records.
        /// </para>
        /// </summary>
        public bool? BatchMode { get; set; }

        /// <summary>
        /// Checks to see if the BatchMode property is set.
        /// </summary>
        internal bool IsSetBatchMode() => this.BatchMode.HasValue;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The delivery stream name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeliveryStreamName { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamName property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamName() => this.DeliveryStreamName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that grants access to the Amazon Kinesis Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Separator. 
        /// <para>
        /// A character separator that will be used to separate records written to the Firehose
        /// stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows newline), ','
        /// (comma).
        /// </para>
        /// </summary>
        public string Separator { get; set; }

        /// <summary>
        /// Checks to see if the Separator property is set.
        /// </summary>
        internal bool IsSetSeparator() => this.Separator != null;
    }
}
