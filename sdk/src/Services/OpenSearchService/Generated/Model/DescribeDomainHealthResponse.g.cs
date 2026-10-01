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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the DescribeDomainHealth operation.
    /// </summary>
    public partial class DescribeDomainHealthResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActiveAvailabilityZoneCount. 
        /// <para>
        /// The number of active Availability Zones configured for the domain. If the service
        /// is unable to fetch this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string ActiveAvailabilityZoneCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveAvailabilityZoneCount property is set.
        /// </summary>
        internal bool IsSetActiveAvailabilityZoneCount() => this.ActiveAvailabilityZoneCount != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneCount. 
        /// <para>
        /// The number of Availability Zones configured for the domain. If the service is unable
        /// to fetch this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string AvailabilityZoneCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneCount property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneCount() => this.AvailabilityZoneCount != null;

        /// <summary>
        /// Gets and sets the property ClusterHealth. 
        /// <para>
        /// The current health status of your cluster.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Red</c> - At least one primary shard is not allocated to any node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Yellow</c> - All primary shards are allocated to nodes, but some replicas aren’t.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Green</c> - All primary shards and their replicas are allocated to nodes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NotAvailable</c> - Unable to retrieve cluster health.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DomainHealth ClusterHealth { get; set; }

        /// <summary>
        /// Checks to see if the ClusterHealth property is set.
        /// </summary>
        internal bool IsSetClusterHealth() => this.ClusterHealth != null;

        /// <summary>
        /// Gets and sets the property DataNodeCount. 
        /// <para>
        /// The number of data nodes configured for the domain. If the service is unable to fetch
        /// this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string DataNodeCount { get; set; }

        /// <summary>
        /// Checks to see if the DataNodeCount property is set.
        /// </summary>
        internal bool IsSetDataNodeCount() => this.DataNodeCount != null;

        /// <summary>
        /// Gets and sets the property DedicatedMaster. 
        /// <para>
        /// A boolean that indicates if dedicated master nodes are activated for the domain.
        /// </para>
        /// </summary>
        public bool? DedicatedMaster { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedMaster property is set.
        /// </summary>
        internal bool IsSetDedicatedMaster() => this.DedicatedMaster.HasValue;

        /// <summary>
        /// Gets and sets the property DomainState. 
        /// <para>
        /// The current state of the domain.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Processing</c> - The domain has updates in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - Requested changes have been processed and deployed to the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DomainState DomainState { get; set; }

        /// <summary>
        /// Checks to see if the DomainState property is set.
        /// </summary>
        internal bool IsSetDomainState() => this.DomainState != null;

        /// <summary>
        /// Gets and sets the property EnvironmentInformation. 
        /// <para>
        /// A list of <c>EnvironmentInfo</c> for the domain. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentInfo> EnvironmentInformation { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentInfo>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentInformation property is set.
        /// </summary>
        internal bool IsSetEnvironmentInformation() => this.EnvironmentInformation != null && (this.EnvironmentInformation.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MasterEligibleNodeCount. 
        /// <para>
        /// The number of nodes that can be elected as a master node. If dedicated master nodes
        /// is turned on, this value is the number of dedicated master nodes configured for the
        /// domain. If the service is unable to fetch this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string MasterEligibleNodeCount { get; set; }

        /// <summary>
        /// Checks to see if the MasterEligibleNodeCount property is set.
        /// </summary>
        internal bool IsSetMasterEligibleNodeCount() => this.MasterEligibleNodeCount != null;

        /// <summary>
        /// Gets and sets the property MasterNode. 
        /// <para>
        /// Indicates whether the domain has an elected master node.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Available</b> - The domain has an elected master node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnAvailable</b> - The master node hasn't yet been elected, and a quorum to elect
        /// a new master node hasn't been reached.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MasterNodeStatus MasterNode { get; set; }

        /// <summary>
        /// Checks to see if the MasterNode property is set.
        /// </summary>
        internal bool IsSetMasterNode() => this.MasterNode != null;

        /// <summary>
        /// Gets and sets the property StandByAvailabilityZoneCount. 
        /// <para>
        /// The number of standby Availability Zones configured for the domain. If the service
        /// is unable to fetch this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string StandByAvailabilityZoneCount { get; set; }

        /// <summary>
        /// Checks to see if the StandByAvailabilityZoneCount property is set.
        /// </summary>
        internal bool IsSetStandByAvailabilityZoneCount() => this.StandByAvailabilityZoneCount != null;

        /// <summary>
        /// Gets and sets the property TotalShards. 
        /// <para>
        /// The total number of primary and replica shards for the domain.
        /// </para>
        /// </summary>
        public string TotalShards { get; set; }

        /// <summary>
        /// Checks to see if the TotalShards property is set.
        /// </summary>
        internal bool IsSetTotalShards() => this.TotalShards != null;

        /// <summary>
        /// Gets and sets the property TotalUnAssignedShards. 
        /// <para>
        /// The total number of primary and replica shards not allocated to any of the nodes for
        /// the cluster.
        /// </para>
        /// </summary>
        public string TotalUnAssignedShards { get; set; }

        /// <summary>
        /// Checks to see if the TotalUnAssignedShards property is set.
        /// </summary>
        internal bool IsSetTotalUnAssignedShards() => this.TotalUnAssignedShards != null;

        /// <summary>
        /// Gets and sets the property WarmNodeCount. 
        /// <para>
        /// The number of warm nodes configured for the domain.
        /// </para>
        /// </summary>
        public string WarmNodeCount { get; set; }

        /// <summary>
        /// Checks to see if the WarmNodeCount property is set.
        /// </summary>
        internal bool IsSetWarmNodeCount() => this.WarmNodeCount != null;
    }
}
