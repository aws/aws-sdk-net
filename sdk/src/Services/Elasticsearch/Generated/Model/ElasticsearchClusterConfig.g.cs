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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies the configuration for the domain cluster, such as the type and number of
    /// instances.
    /// </summary>
    public partial class ElasticsearchClusterConfig
    {
        /// <summary>
        /// Gets and sets the property ColdStorageOptions. 
        /// <para>
        /// Specifies the <c>ColdStorageOptions</c> config for Elasticsearch Domain
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
        /// Total number of dedicated master nodes, active and on standby, for the cluster.
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
        /// A boolean value to indicate whether a dedicated master node is enabled. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-dedicatedmasternodes"
        /// target="_blank">About Dedicated Master Nodes</a> for more information.
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
        /// The instance type for a dedicated master node.
        /// </para>
        /// </summary>
        public ESPartitionInstanceType DedicatedMasterType { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedMasterType property is set.
        /// </summary>
        internal bool IsSetDedicatedMasterType() => this.DedicatedMasterType != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the specified domain cluster.
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
        /// The instance type for an Elasticsearch cluster. UltraWarm instance types are not supported
        /// for data instances.
        /// </para>
        /// </summary>
        public ESPartitionInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

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
        /// True to enable warm storage.
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
        /// The instance type for the Elasticsearch cluster's warm nodes.
        /// </para>
        /// </summary>
        public ESWarmPartitionInstanceType WarmType { get; set; }

        /// <summary>
        /// Checks to see if the WarmType property is set.
        /// </summary>
        internal bool IsSetWarmType() => this.WarmType != null;

        /// <summary>
        /// Gets and sets the property ZoneAwarenessConfig. 
        /// <para>
        /// Specifies the zone awareness configuration for a domain when zone awareness is enabled.
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
        /// A boolean value to indicate whether zone awareness is enabled. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-zoneawareness"
        /// target="_blank">About Zone Awareness</a> for more information.
        /// </para>
        /// </summary>
        public bool? ZoneAwarenessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ZoneAwarenessEnabled property is set.
        /// </summary>
        internal bool IsSetZoneAwarenessEnabled() => this.ZoneAwarenessEnabled.HasValue;
    }
}
