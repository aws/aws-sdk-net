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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// This is the response object from the UpdateShardCount operation.
    /// </summary>
    public partial class UpdateShardCountResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CurrentShardCount. 
        /// <para>
        /// The current number of shards.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? CurrentShardCount { get; set; }

        /// <summary>
        /// Checks to see if the CurrentShardCount property is set.
        /// </summary>
        internal bool IsSetCurrentShardCount() => this.CurrentShardCount.HasValue;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property TargetShardCount. 
        /// <para>
        /// The updated number of shards.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TargetShardCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetShardCount property is set.
        /// </summary>
        internal bool IsSetTargetShardCount() => this.TargetShardCount.HasValue;
    }
}
