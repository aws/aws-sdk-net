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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
    /// Container for the parameters to the UpdateStreamWarmThroughput operation.
    /// Updates the warm throughput configuration for the specified Amazon Kinesis Data Streams
    /// on-demand data stream. This operation allows you to proactively scale your on-demand
    /// data stream to a specified throughput level, enabling better performance for sudden
    /// traffic spikes. 
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
    /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
    /// when you invoke this API.
    /// </para>
    ///  </note> 
    /// <para>
    /// Updating the warm throughput is an asynchronous operation. Upon receiving the request,
    /// Kinesis Data Streams returns immediately and sets the status of the stream to <c>UPDATING</c>.
    /// After the update is complete, Kinesis Data Streams sets the status of the stream back
    /// to <c>ACTIVE</c>. Depending on the size of the stream, the scaling action could take
    /// a few minutes to complete. You can continue to read and write data to your stream
    /// while its status is <c>UPDATING</c>.
    /// </para>
    ///  
    /// <para>
    /// This operation is only supported for data streams with the on-demand capacity mode
    /// in accounts that have <c>MinimumThroughputBillingCommitment</c> enabled. Provisioned
    /// capacity mode streams do not support warm throughput configuration.
    /// </para>
    ///  
    /// <para>
    /// This operation has the following default limits. By default, you cannot do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Scale to more than 10 GiBps for an on-demand stream.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This API has a call limit of 5 transactions per second (TPS) for each Amazon Web Services
    /// account. TPS over 5 will initiate the <c>LimitExceededException</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the default limits for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
    /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>. To request an
    /// increase in the call rate limit, the shard limit for this API, or your overall shard
    /// limit, use the <a href="https://console.aws.amazon.com/support/v1#/case/create?issueType=service-limit-increase&amp;limitType=service-code-kinesis">limits
    /// form</a>.
    /// </para>
    /// </summary>
    public partial class UpdateStreamWarmThroughputRequest : AmazonKinesisRequest
    {
        private string _streamARN;
        private string _streamId;
        private string _streamName;
        private int? _warmThroughputMiBps;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// Not Implemented. Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

        /// <summary>
        /// Gets and sets the property WarmThroughputMiBps. 
        /// <para>
        /// The target warm throughput in MB/s that the stream should be scaled to handle. This
        /// represents the throughput capacity that will be immediately available for write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? WarmThroughputMiBps
        {
            get { return this._warmThroughputMiBps; }
            set { this._warmThroughputMiBps = value; }
        }

        // Check to see if WarmThroughputMiBps property is set
        internal bool IsSetWarmThroughputMiBps()
        {
            return this._warmThroughputMiBps.HasValue; 
        }

    }
}