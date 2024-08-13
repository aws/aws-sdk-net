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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about the configuration of an OpenSearch cluster.
    /// </summary>
    public partial class AwsOpenSearchServiceDomainClusterConfigDetails
    {
        private int? _dedicatedMasterCount;
        private bool? _dedicatedMasterEnabled;
        private string _dedicatedMasterType;
        private int? _instanceCount;
        private string _instanceType;
        private int? _warmCount;
        private bool? _warmEnabled;
        private string _warmType;
        private AwsOpenSearchServiceDomainClusterConfigZoneAwarenessConfigDetails _zoneAwarenessConfig;
        private bool? _zoneAwarenessEnabled;

        /// <summary>
        /// Gets and sets the property DedicatedMasterCount. 
        /// <para>
        /// The number of instances to use for the master node. If this attribute is specified,
        /// then <c>DedicatedMasterEnabled</c> must be <c>true</c>.
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
        /// Whether to use a dedicated master node for the OpenSearch domain. A dedicated master
        /// node performs cluster management tasks, but does not hold data or respond to data
        /// upload requests.
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
        /// The hardware configuration of the computer that hosts the dedicated master node.
        /// </para>
        ///  
        /// <para>
        /// If this attribute is specified, then <c>DedicatedMasterEnabled</c> must be <c>true</c>.
        /// 
        /// </para>
        /// </summary>
        public string DedicatedMasterType
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
        /// The number of data nodes to use in the OpenSearch domain.
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
        /// The instance type for your data nodes.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid values, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/supported-instance-types.html">Supported
        /// instance types in Amazon OpenSearch Service</a> in the <i>Amazon OpenSearch Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        public string InstanceType
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
        /// Gets and sets the property WarmCount. 
        /// <para>
        /// The number of UltraWarm instances.
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
        /// Whether UltraWarm is enabled.
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
        /// The type of UltraWarm instance.
        /// </para>
        /// </summary>
        public string WarmType
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
        /// Configuration options for zone awareness. Provided if <c>ZoneAwarenessEnabled</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainClusterConfigZoneAwarenessConfigDetails ZoneAwarenessConfig
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
        /// Whether to enable zone awareness for the OpenSearch domain. When zone awareness is
        /// enabled, OpenSearch Service allocates the cluster's nodes and replica index shards
        /// across Availability Zones (AZs) in the same Region. This prevents data loss and minimizes
        /// downtime if a node or data center fails.
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