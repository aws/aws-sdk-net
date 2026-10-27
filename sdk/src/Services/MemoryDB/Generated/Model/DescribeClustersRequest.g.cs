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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusters operation. Returns information
    /// about all provisioned clusters if no cluster identifier is specified, or about a specific
    /// cluster if a cluster name is supplied.
    /// </summary>
    public partial class DescribeClustersRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified MaxResults value, a token is included in the response so that the remaining
        /// results can be retrieved.
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
        /// An optional argument to pass in case the total number of records exceeds the value
        /// of MaxResults. If nextToken is returned, there are more results available. The value
        /// of nextToken is a unique pagination token for each page. Make the call again using
        /// the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ShowShardDetails. 
        /// <para>
        /// An optional flag that can be included in the request to retrieve information about
        /// the individual shard(s).
        /// </para>
        /// </summary>
        public bool? ShowShardDetails { get; set; }

        /// <summary>
        /// Checks to see if the ShowShardDetails property is set.
        /// </summary>
        internal bool IsSetShowShardDetails() => this.ShowShardDetails.HasValue;
    }
}
