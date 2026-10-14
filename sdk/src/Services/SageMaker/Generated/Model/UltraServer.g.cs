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
    /// Represents a high-performance compute server used for distributed training in SageMaker
    /// AI. An UltraServer consists of multiple instances within a shared NVLink interconnect
    /// domain.
    /// </summary>
    public partial class UltraServer
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone where the UltraServer is provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances currently available for use in this UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AvailableInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableInstanceCount() => this.AvailableInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableSpareInstanceCount. 
        /// <para>
        /// The number of available spare instances in the UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AvailableSpareInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableSpareInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableSpareInstanceCount() => this.AvailableSpareInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ConfiguredSpareInstanceCount. 
        /// <para>
        /// The number of spare instances configured for this UltraServer to provide enhanced
        /// resiliency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ConfiguredSpareInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredSpareInstanceCount property is set.
        /// </summary>
        internal bool IsSetConfiguredSpareInstanceCount() => this.ConfiguredSpareInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The overall health status of the UltraServer.
        /// </para>
        /// </summary>
        public UltraServerHealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property InUseInstanceCount. 
        /// <para>
        /// The number of instances currently in use in this UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? InUseInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InUseInstanceCount property is set.
        /// </summary>
        internal bool IsSetInUseInstanceCount() => this.InUseInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type used in the UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReservedCapacityInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The total number of instances in this UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property UltraServerId. 
        /// <para>
        /// The unique identifier for the UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string UltraServerId { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerId property is set.
        /// </summary>
        internal bool IsSetUltraServerId() => this.UltraServerId != null;

        /// <summary>
        /// Gets and sets the property UltraServerType. 
        /// <para>
        /// The type of UltraServer, such as ml.u-p6e-gb200x72.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UltraServerType { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerType property is set.
        /// </summary>
        internal bool IsSetUltraServerType() => this.UltraServerType != null;

        /// <summary>
        /// Gets and sets the property UnhealthyInstanceCount. 
        /// <para>
        /// The number of instances in this UltraServer that are currently in an unhealthy state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? UnhealthyInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyInstanceCount property is set.
        /// </summary>
        internal bool IsSetUnhealthyInstanceCount() => this.UnhealthyInstanceCount.HasValue;
    }
}
