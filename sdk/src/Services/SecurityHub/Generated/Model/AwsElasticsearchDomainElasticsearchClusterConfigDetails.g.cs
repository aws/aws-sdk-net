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
    /// details about the configuration of an OpenSearch cluster.
    /// </summary>
    public partial class AwsElasticsearchDomainElasticsearchClusterConfigDetails
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
        /// Whether to use a dedicated master node for the Elasticsearch domain. A dedicated master
        /// node performs cluster management tasks, but doesn't hold data or respond to data upload
        /// requests.
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
        /// The hardware configuration of the computer that hosts the dedicated master node. A
        /// sample value is <c>m3.medium.elasticsearch</c>. If this attribute is specified, then
        /// <c>DedicatedMasterEnabled</c> must be <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid values, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/supported-instance-types.html">Supported
        /// instance types in Amazon OpenSearch Service</a> in the <i>Amazon OpenSearch Service
        /// Developer Guide</i>.
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
        /// The number of data nodes to use in the Elasticsearch domain.
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
        /// The instance type for your data nodes. For example, <c>m3.medium.elasticsearch</c>.
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
        /// Gets and sets the property ZoneAwarenessConfig. 
        /// <para>
        /// Configuration options for zone awareness. Provided if <c>ZoneAwarenessEnabled</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainElasticsearchClusterConfigZoneAwarenessConfigDetails ZoneAwarenessConfig { get; set; }

        /// <summary>
        /// Checks to see if the ZoneAwarenessConfig property is set.
        /// </summary>
        internal bool IsSetZoneAwarenessConfig() => this.ZoneAwarenessConfig != null;

        /// <summary>
        /// Gets and sets the property ZoneAwarenessEnabled. 
        /// <para>
        /// Whether to enable zone awareness for the Elasticsearch domain. When zone awareness
        /// is enabled, OpenSearch allocates the cluster's nodes and replica index shards across
        /// Availability Zones in the same Region. This prevents data loss and minimizes downtime
        /// if a node or data center fails.
        /// </para>
        /// </summary>
        public bool? ZoneAwarenessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ZoneAwarenessEnabled property is set.
        /// </summary>
        internal bool IsSetZoneAwarenessEnabled() => this.ZoneAwarenessEnabled.HasValue;
    }
}
