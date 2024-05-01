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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
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
namespace Amazon.Scheduler.Model
{
    /// <summary>
    /// The templated target type for the Amazon Kinesis <a href="kinesis/latest/APIReference/API_PutRecord.html">
    /// <c>PutRecord</c> </a> API operation.
    /// </summary>
    public partial class KinesisParameters
    {
        private string _partitionKey;

        /// <summary>
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// Specifies the shard to which EventBridge Scheduler sends the event. For more information,
        /// see <a href="https://docs.aws.amazon.com/streams/latest/dev/key-concepts.html">Amazon
        /// Kinesis Data Streams terminology and concepts</a> in the <i>Amazon Kinesis Streams
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PartitionKey
        {
            get { return this._partitionKey; }
            set { this._partitionKey = value; }
        }

        // Check to see if PartitionKey property is set
        internal bool IsSetPartitionKey()
        {
            return this._partitionKey != null;
        }

    }
}