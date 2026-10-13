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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about a node that was successfully added to the cluster.
    /// </summary>
    public partial class NodeAdditionResult
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The availability zones associated with the successfully added node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group to which the node was added.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupName property is set.
        /// </summary>
        internal bool IsSetInstanceGroupName() => this.InstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types associated with the successfully added node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> InstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypes property is set.
        /// </summary>
        internal bool IsSetInstanceTypes() => this.InstanceTypes != null && (this.InstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeLogicalId. 
        /// <para>
        /// A unique identifier assigned to the node that can be used to track its provisioning
        /// status through the <c>DescribeClusterNode</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string NodeLogicalId { get; set; }

        /// <summary>
        /// Checks to see if the NodeLogicalId property is set.
        /// </summary>
        internal bool IsSetNodeLogicalId() => this.NodeLogicalId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the node. Possible values include <c>Pending</c>, <c>Running</c>,
        /// <c>Failed</c>, <c>ShuttingDown</c>, <c>SystemUpdating</c>, <c>DeepHealthCheckInProgress</c>,
        /// and <c>NotFound</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterInstanceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
