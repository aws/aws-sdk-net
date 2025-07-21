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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Container for the parameters to the GetStream operation.
    /// Returns detailed information about a specific data capture stream for an Amazon Keyspaces
    /// table. The information includes the stream's Amazon Resource Name (ARN), creation
    /// time, current status, retention period, shard composition, and associated table details.
    /// This operation helps you monitor and manage the configuration of your Amazon Keyspaces
    /// data streams.
    /// </summary>
    public partial class GetStreamRequest : AmazonKeyspacesStreamsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private ShardFilter _shardFilter;
        private string _streamArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of shard objects to return in a single <c>GetStream</c> request.
        /// Default value is 100. The minimum value is 1 and the maximum value is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        ///  An optional pagination token provided by a previous <c>GetStream</c> operation. If
        /// this parameter is specified, the response includes only records beyond the token,
        /// up to the value specified by <c>maxResults</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=80, Max=3000)]
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
        /// Gets and sets the property ShardFilter. 
        /// <para>
        ///  Optional filter criteria to apply when retrieving shards. You can filter shards based
        /// on their state or other attributes to narrow down the results returned by the <c>GetStream</c>
        /// operation. 
        /// </para>
        /// </summary>
        public ShardFilter ShardFilter
        {
            get { return this._shardFilter; }
            set { this._shardFilter = value; }
        }

        // Check to see if ShardFilter property is set
        internal bool IsSetShardFilter()
        {
            return this._shardFilter != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the stream for which detailed information is requested.
        /// This uniquely identifies the specific stream you want to get information about. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=37, Max=1024)]
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

    }
}