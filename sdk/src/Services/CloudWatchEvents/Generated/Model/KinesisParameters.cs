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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// This object enables you to specify a JSON path to extract from the event and use as
    /// the partition key for the Amazon Kinesis data stream, so that you can control the
    /// shard to which the event goes. If you do not include this parameter, the default is
    /// to use the <c>eventId</c> as the partition key.
    /// </summary>
    public partial class KinesisParameters
    {
        private string _partitionKeyPath;

        /// <summary>
        /// Gets and sets the property PartitionKeyPath. 
        /// <para>
        /// The JSON path to be extracted from the event and used as the partition key. For more
        /// information, see <a href="https://docs.aws.amazon.com/streams/latest/dev/key-concepts.html#partition-key">Amazon
        /// Kinesis Streams Key Concepts</a> in the <i>Amazon Kinesis Streams Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string PartitionKeyPath
        {
            get { return this._partitionKeyPath; }
            set { this._partitionKeyPath = value; }
        }

        // Check to see if PartitionKeyPath property is set
        internal bool IsSetPartitionKeyPath()
        {
            return this._partitionKeyPath != null;
        }

    }
}