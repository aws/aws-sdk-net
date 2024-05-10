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
    /// This is the response object from the DescribeServerlessCacheSnapshots operation.
    /// </summary>
    public partial class DescribeServerlessCacheSnapshotsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServerlessCacheSnapshot> _serverlessCacheSnapshots = AWSConfigs.InitializeCollections ? new List<ServerlessCacheSnapshot>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional marker returned from a prior request to support pagination of results
        /// from this operation. If this parameter is specified, the response includes only records
        /// beyond the marker, up to the value specified by max-results. Available for Redis only.
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
        /// Gets and sets the property ServerlessCacheSnapshots. 
        /// <para>
        /// The serverless caches snapshots associated with a given description request. Available
        /// for Redis only.
        /// </para>
        /// </summary>
        public List<ServerlessCacheSnapshot> ServerlessCacheSnapshots
        {
            get { return this._serverlessCacheSnapshots; }
            set { this._serverlessCacheSnapshots = value; }
        }

        // Check to see if ServerlessCacheSnapshots property is set
        internal bool IsSetServerlessCacheSnapshots()
        {
            return this._serverlessCacheSnapshots != null && (this._serverlessCacheSnapshots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}