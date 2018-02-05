/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateShardCount operation.
    /// Updates the shard count of the specified stream to the specified number of shards.
    /// 
    ///  
    /// <para>
    /// Updating the shard count is an asynchronous operation. Upon receiving the request,
    /// Kinesis Data Streams returns immediately and sets the status of the stream to <code>UPDATING</code>.
    /// After the update is complete, Kinesis Data Streams sets the status of the stream back
    /// to <code>ACTIVE</code>. Depending on the size of the stream, the scaling action could
    /// take a few minutes to complete. You can continue to read and write data to your stream
    /// while its status is <code>UPDATING</code>.
    /// </para>
    ///  
    /// <para>
    /// To update the shard count, Kinesis Data Streams performs splits or merges on individual
    /// shards. This can cause short-lived shards to be created, in addition to the final
    /// shards. We recommend that you double or halve the shard count, as this results in
    /// the fewest number of splits or merges.
    /// </para>
    ///  
    /// <para>
    /// This operation has the following limits. You cannot do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Scale more than twice per rolling 24-hour period per stream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale up to more than double your current shard count for a stream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale down below half your current shard count for a stream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale up to more than 500 shards in a stream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale a stream with more than 500 shards down unless the result is less than 500 shards
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale up to more than the shard limit for your account
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the default limits for an AWS account, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
    /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>. To request an
    /// increase in the call rate limit, the shard limit for this API, or your overall shard
    /// limit, use the <a href="https://console.aws.amazon.com/support/v1#/case/create?issueType=service-limit-increase&amp;limitType=service-code-kinesis">limits
    /// form</a>.
    /// </para>
    /// </summary>
    public partial class UpdateShardCountRequest : AmazonKinesisRequest
    {
        private ScalingType _scalingType;
        private string _streamName;
        private int? _targetShardCount;

        /// <summary>
        /// Gets and sets the property ScalingType. 
        /// <para>
        /// The scaling type. Uniform scaling creates shards of equal size.
        /// </para>
        /// </summary>
        public ScalingType ScalingType
        {
            get { return this._scalingType; }
            set { this._scalingType = value; }
        }

        // Check to see if ScalingType property is set
        internal bool IsSetScalingType()
        {
            return this._scalingType != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TargetShardCount. 
        /// <para>
        /// The new number of shards.
        /// </para>
        /// </summary>
        public int TargetShardCount
        {
            get { return this._targetShardCount.GetValueOrDefault(); }
            set { this._targetShardCount = value; }
        }

        // Check to see if TargetShardCount property is set
        internal bool IsSetTargetShardCount()
        {
            return this._targetShardCount.HasValue; 
        }

    }
}