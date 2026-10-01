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

namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// Container for the parameters to the ListClusterSnapshots operation. Returns information
    /// about snapshots for a specified elastic cluster.
    /// </summary>
    public partial class ListClusterSnapshotsRequest : AmazonDocDBElasticRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN identifier of the elastic cluster.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of elastic cluster snapshot results to receive in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token provided by a previous request. If this parameter is specified,
        /// the response includes only records beyond this token, up to the value specified by
        /// <c>max-results</c>.
        /// </para>
        ///  
        /// <para>
        /// If there is no more data in the responce, the <c>nextToken</c> will not be returned.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of cluster snapshots to be returned. You can specify one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>automated</c> - Return all cluster snapshots that Amazon DocumentDB has automatically
        /// created for your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>manual</c> - Return all cluster snapshots that you have manually created for your
        /// Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;
    }
}
