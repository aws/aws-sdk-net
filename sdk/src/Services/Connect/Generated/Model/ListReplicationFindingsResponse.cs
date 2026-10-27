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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListReplicationFindings operation.
    /// </summary>
    public partial class ListReplicationFindingsResponse : AmazonWebServiceResponse
    {
        private List<ApproximateDriftedResourceCount> _approximateDriftedResourceCounts = AWSConfigs.InitializeCollections ? new List<ApproximateDriftedResourceCount>() : null;
        private string _nextToken;
        private List<ReplicationFinding> _replicationFindingsList = AWSConfigs.InitializeCollections ? new List<ReplicationFinding>() : null;
        private List<ResourceReplicationStatus> _resourceReplicationStatuses = AWSConfigs.InitializeCollections ? new List<ResourceReplicationStatus>() : null;

        /// <summary>
        /// Gets and sets the property ApproximateDriftedResourceCounts. 
        /// <para>
        /// The approximate number of resources of the requested type that are not yet in sync,
        /// reported per Amazon Web Services Region. This count is independent of <c>ReplicationFindingsList</c>
        /// and can be higher than the number of findings returned. It is eventually consistent
        /// and can lag the current state of the instance. Each entry is the <c>ApproximateDriftedResourceCount</c>
        /// for one Region; a Region appears only when its count has been computed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<ApproximateDriftedResourceCount> ApproximateDriftedResourceCounts
        {
            get { return this._approximateDriftedResourceCounts; }
            set { this._approximateDriftedResourceCounts = value; }
        }

        // Check to see if ApproximateDriftedResourceCounts property is set
        internal bool IsSetApproximateDriftedResourceCounts()
        {
            return this._approximateDriftedResourceCounts != null && (this._approximateDriftedResourceCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for retrieving the next page of
        /// <c>ReplicationFindingsList</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
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
        /// Gets and sets the property ReplicationFindingsList. 
        /// <para>
        /// A list of replication findings for the requested resource type. Only findings that
        /// require your action are returned, so this list can be empty even when a drift count
        /// is nonzero. Results are paginated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReplicationFinding> ReplicationFindingsList
        {
            get { return this._replicationFindingsList; }
            set { this._replicationFindingsList = value; }
        }

        // Check to see if ReplicationFindingsList property is set
        internal bool IsSetReplicationFindingsList()
        {
            return this._replicationFindingsList != null && (this._replicationFindingsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceReplicationStatuses. 
        /// <para>
        /// The replication status of the requested resource type in each Amazon Web Services
        /// Region across which the Connect Customer instance is deployed for Global Resiliency,
        /// with one entry per Region. This set describes the overall replication state for the
        /// request and is returned in full on every page of results, so it does not change as
        /// you paginate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<ResourceReplicationStatus> ResourceReplicationStatuses
        {
            get { return this._resourceReplicationStatuses; }
            set { this._resourceReplicationStatuses = value; }
        }

        // Check to see if ResourceReplicationStatuses property is set
        internal bool IsSetResourceReplicationStatuses()
        {
            return this._resourceReplicationStatuses != null && (this._resourceReplicationStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}