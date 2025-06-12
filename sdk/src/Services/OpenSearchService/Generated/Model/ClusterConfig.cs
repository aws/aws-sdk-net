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
    /// Container for the cluster configuration of an OpenSearch Service domain. For more
    /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html">Creating
    /// and managing Amazon OpenSearch Service domains</a>.
    /// </summary>
    public partial class ClusterConfig
    {
        private ColdStorageOptions _coldStorageOptions;
        private int? _dedicatedMasterCount;
        private bool? _dedicatedMasterEnabled;
        private OpenSearchPartitionInstanceType _dedicatedMasterType;
        private int? _instanceCount;
        private OpenSearchPartitionInstanceType _instanceType;
        private bool? _multiAZWithStandbyEnabled;
        private List<NodeOption> _nodeOptions = AWSConfigs.InitializeCollections ? new List<NodeOption>() : null;
        private int? _warmCount;
        private bool? _warmEnabled;
        private OpenSearchWarmPartitionInstanceType _warmType;
        private ZoneAwarenessConfig _zoneAwarenessConfig;
        private bool? _zoneAwarenessEnabled;

        /// <summary>
        /// Gets and sets the property ColdStorageOptions. 
        /// <para>
        /// Container for cold storage configuration options.
        /// </para>
        /// </summary>
        public ColdStorageOptions ColdStorageOptions
        {
            get { return this._coldStorageOptions; }
            set { this._coldStorageOptions = value; }
        }

        // Check to see if ColdStorageOptions property is set
        internal bool IsSetColdStorageOptions()
        {
            return this._coldStorageOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DedicatedMasterCount. 
        /// <para>
        /// Number of dedicated master nodes in the cluster. This number must be greater than
        /// 2 and not 4, otherwise you receive a validation exception.
        /// </para>
        /// </summary>
        public int? DedicatedMasterCount
        {
            get { return this._dedicatedMasterCount; }
            set { this._dedicatedMasterCount = value; }
        }

        // Check to see if DedicatedMasterCount property is set
        internal bool IsSetDedicatedMasterCount()
        {
            return this._dedicatedMasterCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DedicatedMasterEnabled. 
        /// <para>
        /// Indicates whether dedicated master nodes are enabled for the cluster.<c>True</c> if
        /// the cluster will use a dedicated master node.<c>False</c> if the cluster will not.
        /// </para>
        /// </summary>
        public bool? DedicatedMasterEnabled
        {
            get { return this._dedicatedMasterEnabled; }
            set { this._dedicatedMasterEnabled = value; }
        }

        // Check to see if DedicatedMasterEnabled property is set
        internal bool IsSetDedicatedMasterEnabled()
        {
            return this._dedicatedMasterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DedicatedMasterType. 
        /// <para>
        /// OpenSearch Service instance type of the dedicated master nodes in the cluster.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType DedicatedMasterType
        {
            get { return this._dedicatedMasterType; }
            set { this._dedicatedMasterType = value; }
        }

        // Check to see if DedicatedMasterType property is set
        internal bool IsSetDedicatedMasterType()
        {
            return this._dedicatedMasterType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Number of data nodes in the cluster. This number must be greater than 1, otherwise
        /// you receive a validation exception.
        /// </para>
        /// </summary>
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Instance type of data nodes in the cluster.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZWithStandbyEnabled. 
        /// <para>
        /// A boolean that indicates whether a multi-AZ domain is turned on with a standby AZ.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-multiaz.html">Configuring
        /// a multi-AZ domain in Amazon OpenSearch Service</a>. 
        /// </para>
        /// </summary>
        public bool? MultiAZWithStandbyEnabled
        {
            get { return this._multiAZWithStandbyEnabled; }
            set { this._multiAZWithStandbyEnabled = value; }
        }

        // Check to see if MultiAZWithStandbyEnabled property is set
        internal bool IsSetMultiAZWithStandbyEnabled()
        {
            return this._multiAZWithStandbyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeOptions. 
        /// <para>
        /// List of node options for the domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeOption> NodeOptions
        {
            get { return this._nodeOptions; }
            set { this._nodeOptions = value; }
        }

        // Check to see if NodeOptions property is set
        internal bool IsSetNodeOptions()
        {
            return this._nodeOptions != null && (this._nodeOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WarmCount. 
        /// <para>
        /// The number of warm nodes in the cluster.
        /// </para>
        /// </summary>
        public int? WarmCount
        {
            get { return this._warmCount; }
            set { this._warmCount = value; }
        }

        // Check to see if WarmCount property is set
        internal bool IsSetWarmCount()
        {
            return this._warmCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarmEnabled. 
        /// <para>
        /// Whether to enable warm storage for the cluster.
        /// </para>
        /// </summary>
        public bool? WarmEnabled
        {
            get { return this._warmEnabled; }
            set { this._warmEnabled = value; }
        }

        // Check to see if WarmEnabled property is set
        internal bool IsSetWarmEnabled()
        {
            return this._warmEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarmType. 
        /// <para>
        /// The instance type for the cluster's warm nodes.
        /// </para>
        /// </summary>
        public OpenSearchWarmPartitionInstanceType WarmType
        {
            get { return this._warmType; }
            set { this._warmType = value; }
        }

        // Check to see if WarmType property is set
        internal bool IsSetWarmType()
        {
            return this._warmType != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneAwarenessConfig. 
        /// <para>
        /// Container for zone awareness configuration options. Only required if <c>ZoneAwarenessEnabled</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        public ZoneAwarenessConfig ZoneAwarenessConfig
        {
            get { return this._zoneAwarenessConfig; }
            set { this._zoneAwarenessConfig = value; }
        }

        // Check to see if ZoneAwarenessConfig property is set
        internal bool IsSetZoneAwarenessConfig()
        {
            return this._zoneAwarenessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneAwarenessEnabled. 
        /// <para>
        /// Indicates whether multiple Availability Zones are enabled. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-multiaz.html">Configuring
        /// a multi-AZ domain in Amazon OpenSearch Service</a>.
        /// </para>
        /// </summary>
        public bool? ZoneAwarenessEnabled
        {
            get { return this._zoneAwarenessEnabled; }
            set { this._zoneAwarenessEnabled = value; }
        }

        // Check to see if ZoneAwarenessEnabled property is set
        internal bool IsSetZoneAwarenessEnabled()
        {
            return this._zoneAwarenessEnabled.HasValue; 
        }

    }
}