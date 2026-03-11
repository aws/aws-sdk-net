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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private string _availabilityZone;
        private int? _availableInstanceCount;
        private int? _availableSpareInstanceCount;
        private int? _configuredSpareInstanceCount;
        private UltraServerHealthStatus _healthStatus;
        private ReservedCapacityInstanceType _instanceType;
        private int? _inUseInstanceCount;
        private int? _totalInstanceCount;
        private string _ultraServerId;
        private string _ultraServerType;
        private int? _unhealthyInstanceCount;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone where the UltraServer is provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances currently available for use in this UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AvailableInstanceCount
        {
            get { return this._availableInstanceCount; }
            set { this._availableInstanceCount = value; }
        }

        // Check to see if AvailableInstanceCount property is set
        internal bool IsSetAvailableInstanceCount()
        {
            return this._availableInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableSpareInstanceCount. 
        /// <para>
        /// The number of available spare instances in the UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AvailableSpareInstanceCount
        {
            get { return this._availableSpareInstanceCount; }
            set { this._availableSpareInstanceCount = value; }
        }

        // Check to see if AvailableSpareInstanceCount property is set
        internal bool IsSetAvailableSpareInstanceCount()
        {
            return this._availableSpareInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfiguredSpareInstanceCount. 
        /// <para>
        /// The number of spare instances configured for this UltraServer to provide enhanced
        /// resiliency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ConfiguredSpareInstanceCount
        {
            get { return this._configuredSpareInstanceCount; }
            set { this._configuredSpareInstanceCount = value; }
        }

        // Check to see if ConfiguredSpareInstanceCount property is set
        internal bool IsSetConfiguredSpareInstanceCount()
        {
            return this._configuredSpareInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The overall health status of the UltraServer.
        /// </para>
        /// </summary>
        public UltraServerHealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type used in the UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReservedCapacityInstanceType InstanceType
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
        /// Gets and sets the property InUseInstanceCount. 
        /// <para>
        /// The number of instances currently in use in this UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? InUseInstanceCount
        {
            get { return this._inUseInstanceCount; }
            set { this._inUseInstanceCount = value; }
        }

        // Check to see if InUseInstanceCount property is set
        internal bool IsSetInUseInstanceCount()
        {
            return this._inUseInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The total number of instances in this UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? TotalInstanceCount
        {
            get { return this._totalInstanceCount; }
            set { this._totalInstanceCount = value; }
        }

        // Check to see if TotalInstanceCount property is set
        internal bool IsSetTotalInstanceCount()
        {
            return this._totalInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UltraServerId. 
        /// <para>
        /// The unique identifier for the UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string UltraServerId
        {
            get { return this._ultraServerId; }
            set { this._ultraServerId = value; }
        }

        // Check to see if UltraServerId property is set
        internal bool IsSetUltraServerId()
        {
            return this._ultraServerId != null;
        }

        /// <summary>
        /// Gets and sets the property UltraServerType. 
        /// <para>
        /// The type of UltraServer, such as ml.u-p6e-gb200x72.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UltraServerType
        {
            get { return this._ultraServerType; }
            set { this._ultraServerType = value; }
        }

        // Check to see if UltraServerType property is set
        internal bool IsSetUltraServerType()
        {
            return this._ultraServerType != null;
        }

        /// <summary>
        /// Gets and sets the property UnhealthyInstanceCount. 
        /// <para>
        /// The number of instances in this UltraServer that are currently in an unhealthy state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? UnhealthyInstanceCount
        {
            get { return this._unhealthyInstanceCount; }
            set { this._unhealthyInstanceCount = value; }
        }

        // Check to see if UnhealthyInstanceCount property is set
        internal bool IsSetUnhealthyInstanceCount()
        {
            return this._unhealthyInstanceCount.HasValue; 
        }

    }
}