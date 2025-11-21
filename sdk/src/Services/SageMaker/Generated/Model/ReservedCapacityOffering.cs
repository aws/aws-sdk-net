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
    /// Details about a reserved capacity offering for a training plan offering.
    /// 
    ///  
    /// <para>
    /// For more information about how to reserve GPU capacity for your SageMaker HyperPod
    /// clusters using Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
    /// </c>.
    /// </para>
    /// </summary>
    public partial class ReservedCapacityOffering
    {
        private string _availabilityZone;
        private long? _durationHours;
        private long? _durationMinutes;
        private DateTime? _endTime;
        private int? _instanceCount;
        private ReservedCapacityInstanceType _instanceType;
        private ReservedCapacityType _reservedCapacityType;
        private DateTime? _startTime;
        private int? _ultraServerCount;
        private string _ultraServerType;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone for the reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property DurationHours. 
        /// <para>
        /// The number of whole hours in the total duration for this reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=87600)]
        public long? DurationHours
        {
            get { return this._durationHours; }
            set { this._durationHours = value; }
        }

        // Check to see if DurationHours property is set
        internal bool IsSetDurationHours()
        {
            return this._durationHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationMinutes. 
        /// <para>
        /// The additional minutes beyond whole hours in the total duration for this reserved
        /// capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=59)]
        public long? DurationMinutes
        {
            get { return this._durationMinutes; }
            set { this._durationMinutes = value; }
        }

        // Check to see if DurationMinutes property is set
        internal bool IsSetDurationMinutes()
        {
            return this._durationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the reserved capacity offering.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// The instance type for the reserved capacity offering.
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
        /// Gets and sets the property ReservedCapacityType. 
        /// <para>
        /// The type of reserved capacity offering.
        /// </para>
        /// </summary>
        public ReservedCapacityType ReservedCapacityType
        {
            get { return this._reservedCapacityType; }
            set { this._reservedCapacityType = value; }
        }

        // Check to see if ReservedCapacityType property is set
        internal bool IsSetReservedCapacityType()
        {
            return this._reservedCapacityType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the reserved capacity offering.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UltraServerCount. 
        /// <para>
        /// The number of UltraServers included in this reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? UltraServerCount
        {
            get { return this._ultraServerCount; }
            set { this._ultraServerCount = value; }
        }

        // Check to see if UltraServerCount property is set
        internal bool IsSetUltraServerCount()
        {
            return this._ultraServerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UltraServerType. 
        /// <para>
        /// The type of UltraServer included in this reserved capacity offering, such as ml.u-p6e-gb200x72.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

    }
}