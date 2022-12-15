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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the DisableEnhancedMonitoring operation.
    /// Disables enhanced monitoring.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, it is recommended you use the <code>StreamARN</code> input
    /// parameter rather than the <code>StreamName</code> input parameter.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DisableEnhancedMonitoringRequest : AmazonKinesisRequest
    {
        private List<string> _shardLevelMetrics = new List<string>();
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ShardLevelMetrics. 
        /// <para>
        /// List of shard-level metrics to disable.
        /// </para>
        ///  
        /// <para>
        /// The following are the valid shard-level metrics. The value "<code>ALL</code>" disables
        /// every metric.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>IncomingBytes</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IncomingRecords</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OutgoingBytes</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OutgoingRecords</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WriteProvisionedThroughputExceeded</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReadProvisionedThroughputExceeded</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IteratorAgeMilliseconds</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALL</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/monitoring-with-cloudwatch.html">Monitoring
        /// the Amazon Kinesis Data Streams Service with Amazon CloudWatch</a> in the <i>Amazon
        /// Kinesis Data Streams Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=7)]
        public List<string> ShardLevelMetrics
        {
            get { return this._shardLevelMetrics; }
            set { this._shardLevelMetrics = value; }
        }

        // Check to see if ShardLevelMetrics property is set
        internal bool IsSetShardLevelMetrics()
        {
            return this._shardLevelMetrics != null && this._shardLevelMetrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
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
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the Kinesis data stream for which to disable enhanced monitoring.
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

    }
}