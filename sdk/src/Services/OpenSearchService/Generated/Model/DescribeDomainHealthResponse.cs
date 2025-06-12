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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
    /// The result of a <c>DescribeDomainHealth</c> request. Contains health information for
    /// the requested domain.
    /// </summary>
    public partial class DescribeDomainHealthResponse : AmazonWebServiceResponse
    {
        private string _activeAvailabilityZoneCount;
        private string _availabilityZoneCount;
        private DomainHealth _clusterHealth;
        private string _dataNodeCount;
        private bool? _dedicatedMaster;
        private DomainState _domainState;
        private List<EnvironmentInfo> _environmentInformation = AWSConfigs.InitializeCollections ? new List<EnvironmentInfo>() : null;
        private string _masterEligibleNodeCount;
        private MasterNodeStatus _masterNode;
        private string _standByAvailabilityZoneCount;
        private string _totalShards;
        private string _totalUnAssignedShards;
        private string _warmNodeCount;

        /// <summary>
        /// Gets and sets the property ActiveAvailabilityZoneCount. 
        /// <para>
        /// The number of active Availability Zones configured for the domain. If the service
        /// is unable to fetch this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string ActiveAvailabilityZoneCount
        {
            get { return this._activeAvailabilityZoneCount; }
            set { this._activeAvailabilityZoneCount = value; }
        }

        // Check to see if ActiveAvailabilityZoneCount property is set
        internal bool IsSetActiveAvailabilityZoneCount()
        {
            return this._activeAvailabilityZoneCount != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneCount. 
        /// <para>
        /// The number of Availability Zones configured for the domain. If the service is unable
        /// to fetch this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string AvailabilityZoneCount
        {
            get { return this._availabilityZoneCount; }
            set { this._availabilityZoneCount = value; }
        }

        // Check to see if AvailabilityZoneCount property is set
        internal bool IsSetAvailabilityZoneCount()
        {
            return this._availabilityZoneCount != null;
        }

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
        public DomainHealth ClusterHealth
        {
            get { return this._clusterHealth; }
            set { this._clusterHealth = value; }
        }

        // Check to see if ClusterHealth property is set
        internal bool IsSetClusterHealth()
        {
            return this._clusterHealth != null;
        }

        /// <summary>
        /// Gets and sets the property DataNodeCount. 
        /// <para>
        /// The number of data nodes configured for the domain. If the service is unable to fetch
        /// this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string DataNodeCount
        {
            get { return this._dataNodeCount; }
            set { this._dataNodeCount = value; }
        }

        // Check to see if DataNodeCount property is set
        internal bool IsSetDataNodeCount()
        {
            return this._dataNodeCount != null;
        }

        /// <summary>
        /// Gets and sets the property DedicatedMaster. 
        /// <para>
        /// A boolean that indicates if dedicated master nodes are activated for the domain.
        /// </para>
        /// </summary>
        public bool? DedicatedMaster
        {
            get { return this._dedicatedMaster; }
            set { this._dedicatedMaster = value; }
        }

        // Check to see if DedicatedMaster property is set
        internal bool IsSetDedicatedMaster()
        {
            return this._dedicatedMaster.HasValue; 
        }

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
        public DomainState DomainState
        {
            get { return this._domainState; }
            set { this._domainState = value; }
        }

        // Check to see if DomainState property is set
        internal bool IsSetDomainState()
        {
            return this._domainState != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentInformation. 
        /// <para>
        /// A list of <c>EnvironmentInfo</c> for the domain. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentInfo> EnvironmentInformation
        {
            get { return this._environmentInformation; }
            set { this._environmentInformation = value; }
        }

        // Check to see if EnvironmentInformation property is set
        internal bool IsSetEnvironmentInformation()
        {
            return this._environmentInformation != null && (this._environmentInformation.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MasterEligibleNodeCount. 
        /// <para>
        /// The number of nodes that can be elected as a master node. If dedicated master nodes
        /// is turned on, this value is the number of dedicated master nodes configured for the
        /// domain. If the service is unable to fetch this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string MasterEligibleNodeCount
        {
            get { return this._masterEligibleNodeCount; }
            set { this._masterEligibleNodeCount = value; }
        }

        // Check to see if MasterEligibleNodeCount property is set
        internal bool IsSetMasterEligibleNodeCount()
        {
            return this._masterEligibleNodeCount != null;
        }

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
        public MasterNodeStatus MasterNode
        {
            get { return this._masterNode; }
            set { this._masterNode = value; }
        }

        // Check to see if MasterNode property is set
        internal bool IsSetMasterNode()
        {
            return this._masterNode != null;
        }

        /// <summary>
        /// Gets and sets the property StandByAvailabilityZoneCount. 
        /// <para>
        /// The number of standby Availability Zones configured for the domain. If the service
        /// is unable to fetch this information, it will return <c>NotAvailable</c>.
        /// </para>
        /// </summary>
        public string StandByAvailabilityZoneCount
        {
            get { return this._standByAvailabilityZoneCount; }
            set { this._standByAvailabilityZoneCount = value; }
        }

        // Check to see if StandByAvailabilityZoneCount property is set
        internal bool IsSetStandByAvailabilityZoneCount()
        {
            return this._standByAvailabilityZoneCount != null;
        }

        /// <summary>
        /// Gets and sets the property TotalShards. 
        /// <para>
        /// The total number of primary and replica shards for the domain.
        /// </para>
        /// </summary>
        public string TotalShards
        {
            get { return this._totalShards; }
            set { this._totalShards = value; }
        }

        // Check to see if TotalShards property is set
        internal bool IsSetTotalShards()
        {
            return this._totalShards != null;
        }

        /// <summary>
        /// Gets and sets the property TotalUnAssignedShards. 
        /// <para>
        /// The total number of primary and replica shards not allocated to any of the nodes for
        /// the cluster.
        /// </para>
        /// </summary>
        public string TotalUnAssignedShards
        {
            get { return this._totalUnAssignedShards; }
            set { this._totalUnAssignedShards = value; }
        }

        // Check to see if TotalUnAssignedShards property is set
        internal bool IsSetTotalUnAssignedShards()
        {
            return this._totalUnAssignedShards != null;
        }

        /// <summary>
        /// Gets and sets the property WarmNodeCount. 
        /// <para>
        /// The number of warm nodes configured for the domain.
        /// </para>
        /// </summary>
        public string WarmNodeCount
        {
            get { return this._warmNodeCount; }
            set { this._warmNodeCount = value; }
        }

        // Check to see if WarmNodeCount property is set
        internal bool IsSetWarmNodeCount()
        {
            return this._warmNodeCount != null;
        }

    }
}