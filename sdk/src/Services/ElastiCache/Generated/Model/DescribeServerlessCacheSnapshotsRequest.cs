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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
    /// Container for the parameters to the DescribeServerlessCacheSnapshots operation.
    /// Returns information about serverless cache snapshots. By default, this API lists all
    /// of the customer’s serverless cache snapshots. It can also describe a single serverless
    /// cache snapshot, or the snapshots associated with a particular serverless cache. Available
    /// for Valkey, Redis OSS and Serverless Memcached only.
    /// </summary>
    public partial class DescribeServerlessCacheSnapshotsRequest : AmazonElastiCacheRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _serverlessCacheName;
        private string _serverlessCacheSnapshotName;
        private string _snapshotType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified max-results value, a market is included in the response so that remaining
        /// results can be retrieved. Available for Valkey, Redis OSS and Serverless Memcached
        /// only.The default is 50. The Validation Constraints are a maximum of 50.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional marker returned from a prior request to support pagination of results
        /// from this operation. If this parameter is specified, the response includes only records
        /// beyond the marker, up to the value specified by max-results. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// The identifier of serverless cache. If this parameter is specified, only snapshots
        /// associated with that specific serverless cache are described. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string ServerlessCacheName
        {
            get { return this._serverlessCacheName; }
            set { this._serverlessCacheName = value; }
        }

        // Check to see if ServerlessCacheName property is set
        internal bool IsSetServerlessCacheName()
        {
            return this._serverlessCacheName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier of the serverless cache’s snapshot. If this parameter is specified,
        /// only this snapshot is described. Available for Valkey, Redis OSS and Serverless Memcached
        /// only.
        /// </para>
        /// </summary>
        public string ServerlessCacheSnapshotName
        {
            get { return this._serverlessCacheSnapshotName; }
            set { this._serverlessCacheSnapshotName = value; }
        }

        // Check to see if ServerlessCacheSnapshotName property is set
        internal bool IsSetServerlessCacheSnapshotName()
        {
            return this._serverlessCacheSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of snapshot that is being described. Available for Valkey, Redis OSS and
        /// Serverless Memcached only.
        /// </para>
        /// </summary>
        public string SnapshotType
        {
            get { return this._snapshotType; }
            set { this._snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this._snapshotType != null;
        }

    }
}