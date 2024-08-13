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
    /// This is the response object from the DescribeLimits operation.
    /// </summary>
    public partial class DescribeLimitsResponse : AmazonWebServiceResponse
    {
        private int? _onDemandStreamCount;
        private int? _onDemandStreamCountLimit;
        private int? _openShardCount;
        private int? _shardLimit;

        /// <summary>
        /// Gets and sets the property OnDemandStreamCount. 
        /// <para>
        ///  Indicates the number of data streams with the on-demand capacity mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000000)]
        public int? OnDemandStreamCount
        {
            get { return this._onDemandStreamCount; }
            set { this._onDemandStreamCount = value; }
        }

        // Check to see if OnDemandStreamCount property is set
        internal bool IsSetOnDemandStreamCount()
        {
            return this._onDemandStreamCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnDemandStreamCountLimit. 
        /// <para>
        ///  The maximum number of data streams with the on-demand capacity mode. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000000)]
        public int? OnDemandStreamCountLimit
        {
            get { return this._onDemandStreamCountLimit; }
            set { this._onDemandStreamCountLimit = value; }
        }

        // Check to see if OnDemandStreamCountLimit property is set
        internal bool IsSetOnDemandStreamCountLimit()
        {
            return this._onDemandStreamCountLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenShardCount. 
        /// <para>
        /// The number of open shards.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000000)]
        public int? OpenShardCount
        {
            get { return this._openShardCount; }
            set { this._openShardCount = value; }
        }

        // Check to see if OpenShardCount property is set
        internal bool IsSetOpenShardCount()
        {
            return this._openShardCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShardLimit. 
        /// <para>
        /// The maximum number of shards.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000000)]
        public int? ShardLimit
        {
            get { return this._shardLimit; }
            set { this._shardLimit = value; }
        }

        // Check to see if ShardLimit property is set
        internal bool IsSetShardLimit()
        {
            return this._shardLimit.HasValue; 
        }

    }
}