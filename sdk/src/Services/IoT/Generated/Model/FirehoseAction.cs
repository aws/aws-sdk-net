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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private bool? _batchMode;
        private string _deliveryStreamName;
        private string _roleArn;
        private string _separator;

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
        public bool? BatchMode
        {
            get { return this._batchMode; }
            set { this._batchMode = value; }
        }

        // Check to see if BatchMode property is set
        internal bool IsSetBatchMode()
        {
            return this._batchMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The delivery stream name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that grants access to the Amazon Kinesis Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Separator. 
        /// <para>
        /// A character separator that will be used to separate records written to the Firehose
        /// stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows newline), ','
        /// (comma).
        /// </para>
        /// </summary>
        public string Separator
        {
            get { return this._separator; }
            set { this._separator = value; }
        }

        // Check to see if Separator property is set
        internal bool IsSetSeparator()
        {
            return this._separator != null;
        }

    }
}