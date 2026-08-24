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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Contains the monitoring configuration for a single cluster in a container association.
    /// Specifies the cluster ARN and optional attribute filters to narrow which containers
    /// are tracked.
    /// </summary>
    public partial class ContainerMonitoringConfiguration
    {
        private List<ContainerAttribute> _attributeFilters = AWSConfigs.InitializeCollections ? new List<ContainerAttribute>() : null;
        private string _clusterArn;

        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// Key-value pairs that filter which containers are tracked. For Amazon EKS, you can
        /// filter by namespace and Kubernetes labels. For Amazon ECS, you can filter by container
        /// instance attributes (EC2 launch type only).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerAttribute> AttributeFilters
        {
            get { return this._attributeFilters; }
            set { this._attributeFilters = value; }
        }

        // Check to see if AttributeFilters property is set
        internal bool IsSetAttributeFilters()
        {
            return this._attributeFilters != null && (this._attributeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN of the Amazon ECS or Amazon EKS cluster to monitor. The cluster must be in
        /// the same Region and account as the container association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

    }
}