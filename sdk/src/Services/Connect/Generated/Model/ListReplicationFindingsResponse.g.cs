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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListReplicationFindings operation.
    /// </summary>
    public partial class ListReplicationFindingsResponse : AmazonWebServiceResponse
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<ApproximateDriftedResourceCount> ApproximateDriftedResourceCounts { get; set; } = AWSConfigs.InitializeCollections ? new List<ApproximateDriftedResourceCount>() : null;

        /// <summary>
        /// Checks to see if the ApproximateDriftedResourceCounts property is set.
        /// </summary>
        internal bool IsSetApproximateDriftedResourceCounts() => this.ApproximateDriftedResourceCounts != null && (this.ApproximateDriftedResourceCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for retrieving the next page of
        /// <c>ReplicationFindingsList</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ReplicationFindingsList. 
        /// <para>
        /// A list of replication findings for the requested resource type. Only findings that
        /// require your action are returned, so this list can be empty even when a drift count
        /// is nonzero. Results are paginated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ReplicationFinding> ReplicationFindingsList { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationFinding>() : null;

        /// <summary>
        /// Checks to see if the ReplicationFindingsList property is set.
        /// </summary>
        internal bool IsSetReplicationFindingsList() => this.ReplicationFindingsList != null && (this.ReplicationFindingsList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<ResourceReplicationStatus> ResourceReplicationStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceReplicationStatus>() : null;

        /// <summary>
        /// Checks to see if the ResourceReplicationStatuses property is set.
        /// </summary>
        internal bool IsSetResourceReplicationStatuses() => this.ResourceReplicationStatuses != null && (this.ResourceReplicationStatuses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
