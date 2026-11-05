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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstances operation. Provides information
    /// for all active Amazon EC2 instances and Amazon EC2 instances terminated in the last
    /// 30 days, up to a maximum of 2,000. Amazon EC2 instances in any of the following states
    /// are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
    /// </summary>
    public partial class ListInstancesRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier of the cluster for which to list the instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property InstanceFleetId. 
        /// <para>
        /// The unique identifier of the instance fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InstanceFleetId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFleetId property is set.
        /// </summary>
        internal bool IsSetInstanceFleetId() => this.InstanceFleetId != null;

        /// <summary>
        /// Gets and sets the property InstanceFleetType. 
        /// <para>
        /// The node type of the instance fleet. For example MASTER, CORE, or TASK.
        /// </para>
        /// </summary>
        public InstanceFleetType InstanceFleetType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFleetType property is set.
        /// </summary>
        internal bool IsSetInstanceFleetType() => this.InstanceFleetType != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// The identifier of the instance group for which to list the instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupId property is set.
        /// </summary>
        internal bool IsSetInstanceGroupId() => this.InstanceGroupId != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupTypes. 
        /// <para>
        /// The type of instance group for which to list the instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceGroupTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroupTypes property is set.
        /// </summary>
        internal bool IsSetInstanceGroupTypes() => this.InstanceGroupTypes != null && (this.InstanceGroupTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceStates. 
        /// <para>
        /// A list of instance states that will filter the instances returned with this request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceStates { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceStates property is set.
        /// </summary>
        internal bool IsSetInstanceStates() => this.InstanceStates != null && (this.InstanceStates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;
    }
}
