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
    /// Container for the cluster configuration of an OpenSearch Service domain. For more
    /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html">Creating
    /// and managing Amazon OpenSearch Service domains</a>.
    /// </summary>
    public partial class ClusterConfig
    {
        /// <summary>
        /// Gets and sets the property ColdStorageOptions. 
        /// <para>
        /// Container for cold storage configuration options.
        /// </para>
        /// </summary>
        public ColdStorageOptions ColdStorageOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColdStorageOptions property is set.
        /// </summary>
        internal bool IsSetColdStorageOptions() => this.ColdStorageOptions != null;

        /// <summary>
        /// Gets and sets the property DedicatedMasterCount. 
        /// <para>
        /// Number of dedicated master nodes in the cluster. This number must be greater than
        /// 2 and not 4, otherwise you receive a validation exception.
        /// </para>
        /// </summary>
        public int? DedicatedMasterCount { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedMasterCount property is set.
        /// </summary>
        internal bool IsSetDedicatedMasterCount() => this.DedicatedMasterCount.HasValue;

        /// <summary>
        /// Gets and sets the property DedicatedMasterEnabled. 
        /// <para>
        /// Indicates whether dedicated master nodes are enabled for the cluster.<c>True</c> if
        /// the cluster will use a dedicated master node.<c>False</c> if the cluster will not.
        /// </para>
        /// </summary>
        public bool? DedicatedMasterEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedMasterEnabled property is set.
        /// </summary>
        internal bool IsSetDedicatedMasterEnabled() => this.DedicatedMasterEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DedicatedMasterType. 
        /// <para>
        /// OpenSearch Service instance type of the dedicated master nodes in the cluster.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType DedicatedMasterType { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedMasterType property is set.
        /// </summary>
        internal bool IsSetDedicatedMasterType() => this.DedicatedMasterType != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Number of data nodes in the cluster. This number must be greater than 1, otherwise
        /// you receive a validation exception.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Instance type of data nodes in the cluster.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MultiAZWithStandbyEnabled. 
        /// <para>
        /// A boolean that indicates whether a multi-AZ domain is turned on with a standby AZ.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-multiaz.html">Configuring
        /// a multi-AZ domain in Amazon OpenSearch Service</a>. 
        /// </para>
        /// </summary>
        public bool? MultiAZWithStandbyEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZWithStandbyEnabled property is set.
        /// </summary>
        internal bool IsSetMultiAZWithStandbyEnabled() => this.MultiAZWithStandbyEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property NodeOptions. 
        /// <para>
        /// List of node options for the domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeOption> NodeOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeOption>() : null;

        /// <summary>
        /// Checks to see if the NodeOptions property is set.
        /// </summary>
        internal bool IsSetNodeOptions() => this.NodeOptions != null && (this.NodeOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WarmCount. 
        /// <para>
        /// The number of warm nodes in the cluster.
        /// </para>
        /// </summary>
        public int? WarmCount { get; set; }

        /// <summary>
        /// Checks to see if the WarmCount property is set.
        /// </summary>
        internal bool IsSetWarmCount() => this.WarmCount.HasValue;

        /// <summary>
        /// Gets and sets the property WarmEnabled. 
        /// <para>
        /// Whether to enable warm storage for the cluster.
        /// </para>
        /// </summary>
        public bool? WarmEnabled { get; set; }

        /// <summary>
        /// Checks to see if the WarmEnabled property is set.
        /// </summary>
        internal bool IsSetWarmEnabled() => this.WarmEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property WarmType. 
        /// <para>
        /// The instance type for the cluster's warm nodes.
        /// </para>
        /// </summary>
        public OpenSearchWarmPartitionInstanceType WarmType { get; set; }

        /// <summary>
        /// Checks to see if the WarmType property is set.
        /// </summary>
        internal bool IsSetWarmType() => this.WarmType != null;

        /// <summary>
        /// Gets and sets the property ZoneAwarenessConfig. 
        /// <para>
        /// Container for zone awareness configuration options. Only required if <c>ZoneAwarenessEnabled</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        public ZoneAwarenessConfig ZoneAwarenessConfig { get; set; }

        /// <summary>
        /// Checks to see if the ZoneAwarenessConfig property is set.
        /// </summary>
        internal bool IsSetZoneAwarenessConfig() => this.ZoneAwarenessConfig != null;

        /// <summary>
        /// Gets and sets the property ZoneAwarenessEnabled. 
        /// <para>
        /// Indicates whether multiple Availability Zones are enabled. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-multiaz.html">Configuring
        /// a multi-AZ domain in Amazon OpenSearch Service</a>.
        /// </para>
        /// </summary>
        public bool? ZoneAwarenessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ZoneAwarenessEnabled property is set.
        /// </summary>
        internal bool IsSetZoneAwarenessEnabled() => this.ZoneAwarenessEnabled.HasValue;
    }
}
