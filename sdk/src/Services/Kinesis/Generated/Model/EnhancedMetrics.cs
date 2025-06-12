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
    /// Represents enhanced metrics types.
    /// </summary>
    public partial class EnhancedMetrics
    {
        private List<string> _shardLevelMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ShardLevelMetrics. 
        /// <para>
        /// List of shard-level metrics.
        /// </para>
        ///  
        /// <para>
        /// The following are the valid shard-level metrics. The value "<c>ALL</c>" enhances every
        /// metric.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IncomingBytes</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IncomingRecords</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OutgoingBytes</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OutgoingRecords</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WriteProvisionedThroughputExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReadProvisionedThroughputExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IteratorAgeMilliseconds</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/monitoring-with-cloudwatch.html">Monitoring
        /// the Amazon Kinesis Data Streams Service with Amazon CloudWatch</a> in the <i>Amazon
        /// Kinesis Data Streams Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public List<string> ShardLevelMetrics
        {
            get { return this._shardLevelMetrics; }
            set { this._shardLevelMetrics = value; }
        }

        // Check to see if ShardLevelMetrics property is set
        internal bool IsSetShardLevelMetrics()
        {
            return this._shardLevelMetrics != null && (this._shardLevelMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}