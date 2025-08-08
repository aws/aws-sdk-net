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
    /// This is the response object from the DescribeReservedCapacity operation.
    /// </summary>
    public partial class DescribeReservedCapacityResponse : AmazonWebServiceResponse
    {
        private string _availabilityZone;
        private int? _availableInstanceCount;
        private long? _durationHours;
        private long? _durationMinutes;
        private DateTime? _endTime;
        private ReservedCapacityInstanceType _instanceType;
        private int? _inUseInstanceCount;
        private string _reservedCapacityArn;
        private ReservedCapacityType _reservedCapacityType;
        private DateTime? _startTime;
        private ReservedCapacityStatus _status;
        private int? _totalInstanceCount;
        private UltraServerSummary _ultraServerSummary;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the reserved capacity is provisioned.
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
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances currently available for use in this reserved capacity.
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
        /// Gets and sets the property DurationHours. 
        /// <para>
        /// The total duration of the reserved capacity in hours.
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
        /// The number of minutes for the duration of the reserved capacity. For example, if a
        /// reserved capacity starts at 08:55 and ends at 11:30, the minutes field would be 35.
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
        /// The timestamp when the reserved capacity expires.
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type used in the reserved capacity.
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
        /// The number of instances currently in use from this reserved capacity.
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
        /// Gets and sets the property ReservedCapacityArn. 
        /// <para>
        /// ARN of the reserved capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=2048)]
        public string ReservedCapacityArn
        {
            get { return this._reservedCapacityArn; }
            set { this._reservedCapacityArn = value; }
        }

        // Check to see if ReservedCapacityArn property is set
        internal bool IsSetReservedCapacityArn()
        {
            return this._reservedCapacityArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedCapacityType. 
        /// <para>
        /// The type of reserved capacity.
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
        /// The timestamp when the reserved capacity becomes active.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the reserved capacity.
        /// </para>
        /// </summary>
        public ReservedCapacityStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The total number of instances allocated to this reserved capacity.
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
        /// Gets and sets the property UltraServerSummary. 
        /// <para>
        /// A summary of the UltraServer associated with this reserved capacity.
        /// </para>
        /// </summary>
        public UltraServerSummary UltraServerSummary
        {
            get { return this._ultraServerSummary; }
            set { this._ultraServerSummary = value; }
        }

        // Check to see if UltraServerSummary property is set
        internal bool IsSetUltraServerSummary()
        {
            return this._ultraServerSummary != null;
        }

    }
}