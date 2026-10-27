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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Kinesis Data Streams invocation parameters for subscribers. Values are forwarded to
    /// the Kinesis PutRecords API. All scalar values accept a literal or a JSONata expression
    /// (e.g. "{% $events.Data.partitionKey %}").
    /// </summary>
    public partial class KinesisParameters
    {
        /// <summary>
        /// Gets and sets the property ExplicitHashKey. Explicit hash key forwarded to PutRecords
        /// unchanged. Accepts JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string ExplicitHashKey { get; set; }

        /// <summary>
        /// Checks to see if the ExplicitHashKey property is set.
        /// </summary>
        internal bool IsSetExplicitHashKey() => this.ExplicitHashKey != null;

        /// <summary>
        /// Gets and sets the property PartitionKey. Required by PutRecords even when an explicit
        /// hash key is supplied. Accepts JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string PartitionKey { get; set; }

        /// <summary>
        /// Checks to see if the PartitionKey property is set.
        /// </summary>
        internal bool IsSetPartitionKey() => this.PartitionKey != null;
    }
}
