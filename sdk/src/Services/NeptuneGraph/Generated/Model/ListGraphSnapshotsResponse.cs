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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// This is the response object from the ListGraphSnapshots operation.
    /// </summary>
    public partial class ListGraphSnapshotsResponse : AmazonWebServiceResponse
    {
        private List<GraphSnapshotSummary> _graphSnapshots = AWSConfigs.InitializeCollections ? new List<GraphSnapshotSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GraphSnapshots. 
        /// <para>
        /// The requested list of snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GraphSnapshotSummary> GraphSnapshots
        {
            get { return this._graphSnapshots; }
            set { this._graphSnapshots = value; }
        }

        // Check to see if GraphSnapshots property is set
        internal bool IsSetGraphSnapshots()
        {
            return this._graphSnapshots != null && (this._graphSnapshots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token used to paginate output.
        /// </para>
        ///  
        /// <para>
        /// When this value is provided as input, the service returns results from where the previous
        /// response left off. When this value is present in output, it indicates that there are
        /// more results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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

    }
}