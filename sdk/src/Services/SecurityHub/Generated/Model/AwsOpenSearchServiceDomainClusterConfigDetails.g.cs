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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about the configuration of an OpenSearch cluster.
    /// </summary>
    public partial class AwsOpenSearchServiceDomainClusterConfigDetails
    {
        /// <summary>
        /// Gets and sets the property DedicatedMasterCount. 
        /// <para>
        /// The number of instances to use for the master node. If this attribute is specified,
        /// then <c>DedicatedMasterEnabled</c> must be <c>true</c>.
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
        /// Whether to use a dedicated master node for the OpenSearch domain. A dedicated master
        /// node performs cluster management tasks, but does not hold data or respond to data
        /// upload requests.
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
        /// The hardware configuration of the computer that hosts the dedicated master node.
        /// </para>
        ///  
        /// <para>
        /// If this attribute is specified, then <c>DedicatedMasterEnabled</c> must be <c>true</c>.
        /// 
        /// </para>
        /// </summary>
        public string DedicatedMasterType { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedMasterType property is set.
        /// </summary>
        internal bool IsSetDedicatedMasterType() => this.DedicatedMasterType != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of data nodes to use in the OpenSearch domain.
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
        /// The instance type for your data nodes.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid values, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/supported-instance-types.html">Supported
        /// instance types in Amazon OpenSearch Service</a> in the <i>Amazon OpenSearch Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property WarmCount. 
        /// <para>
        /// The number of UltraWarm instances.
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
        /// Whether UltraWarm is enabled.
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
        /// The type of UltraWarm instance.
        /// </para>
        /// </summary>
        public string WarmType { get; set; }

        /// <summary>
        /// Checks to see if the WarmType property is set.
        /// </summary>
        internal bool IsSetWarmType() => this.WarmType != null;

        /// <summary>
        /// Gets and sets the property ZoneAwarenessConfig. 
        /// <para>
        /// Configuration options for zone awareness. Provided if <c>ZoneAwarenessEnabled</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainClusterConfigZoneAwarenessConfigDetails ZoneAwarenessConfig { get; set; }

        /// <summary>
        /// Checks to see if the ZoneAwarenessConfig property is set.
        /// </summary>
        internal bool IsSetZoneAwarenessConfig() => this.ZoneAwarenessConfig != null;

        /// <summary>
        /// Gets and sets the property ZoneAwarenessEnabled. 
        /// <para>
        /// Whether to enable zone awareness for the OpenSearch domain. When zone awareness is
        /// enabled, OpenSearch Service allocates the cluster's nodes and replica index shards
        /// across Availability Zones (AZs) in the same Region. This prevents data loss and minimizes
        /// downtime if a node or data center fails.
        /// </para>
        /// </summary>
        public bool? ZoneAwarenessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ZoneAwarenessEnabled property is set.
        /// </summary>
        internal bool IsSetZoneAwarenessEnabled() => this.ZoneAwarenessEnabled.HasValue;
    }
}
