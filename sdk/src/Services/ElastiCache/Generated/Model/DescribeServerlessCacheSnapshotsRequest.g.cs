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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServerlessCacheSnapshots operation. Returns
    /// information about serverless cache snapshots. By default, this API lists all of the
    /// customer’s serverless cache snapshots. It can also describe a single serverless cache
    /// snapshot, or the snapshots associated with a particular serverless cache. Available
    /// for Valkey, Redis OSS and Serverless Memcached only.
    /// </summary>
    public partial class DescribeServerlessCacheSnapshotsRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified max-results value, a market is included in the response so that remaining
        /// results can be retrieved. Available for Valkey, Redis OSS and Serverless Memcached
        /// only.The default is 50. The Validation Constraints are a maximum of 50.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional marker returned from a prior request to support pagination of results
        /// from this operation. If this parameter is specified, the response includes only records
        /// beyond the marker, up to the value specified by max-results. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// The identifier of serverless cache. If this parameter is specified, only snapshots
        /// associated with that specific serverless cache are described. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string ServerlessCacheName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheName() => this.ServerlessCacheName != null;

        /// <summary>
        /// Gets and sets the property ServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier of the serverless cache’s snapshot. If this parameter is specified,
        /// only this snapshot is described. Available for Valkey, Redis OSS and Serverless Memcached
        /// only.
        /// </para>
        /// </summary>
        public string ServerlessCacheSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheSnapshotName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheSnapshotName() => this.ServerlessCacheSnapshotName != null;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of snapshot that is being described. Available for Valkey, Redis OSS and
        /// Serverless Memcached only.
        /// </para>
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;
    }
}
