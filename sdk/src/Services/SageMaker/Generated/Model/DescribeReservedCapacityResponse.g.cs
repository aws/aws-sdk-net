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
    /// This is the response object from the DescribeReservedCapacity operation.
    /// </summary>
    public partial class DescribeReservedCapacityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the reserved capacity is provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances currently available for use in this reserved capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AvailableInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableInstanceCount() => this.AvailableInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property DurationHours. 
        /// <para>
        /// The total duration of the reserved capacity in hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 87600)]
        public long? DurationHours { get; set; }

        /// <summary>
        /// Checks to see if the DurationHours property is set.
        /// </summary>
        internal bool IsSetDurationHours() => this.DurationHours.HasValue;

        /// <summary>
        /// Gets and sets the property DurationMinutes. 
        /// <para>
        /// The number of minutes for the duration of the reserved capacity. For example, if a
        /// reserved capacity starts at 08:55 and ends at 11:30, the minutes field would be 35.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 59)]
        public long? DurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DurationMinutes property is set.
        /// </summary>
        internal bool IsSetDurationMinutes() => this.DurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the reserved capacity expires.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InUseInstanceCount. 
        /// <para>
        /// The number of instances currently in use from this reserved capacity.
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
        /// The Amazon EC2 instance type used in the reserved capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReservedCapacityInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ReservedCapacityArn. 
        /// <para>
        /// ARN of the reserved capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 2048)]
        public string ReservedCapacityArn { get; set; }

        /// <summary>
        /// Checks to see if the ReservedCapacityArn property is set.
        /// </summary>
        internal bool IsSetReservedCapacityArn() => this.ReservedCapacityArn != null;

        /// <summary>
        /// Gets and sets the property ReservedCapacityType. 
        /// <para>
        /// The type of reserved capacity.
        /// </para>
        /// </summary>
        public ReservedCapacityType ReservedCapacityType { get; set; }

        /// <summary>
        /// Checks to see if the ReservedCapacityType property is set.
        /// </summary>
        internal bool IsSetReservedCapacityType() => this.ReservedCapacityType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the reserved capacity becomes active.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the reserved capacity.
        /// </para>
        /// </summary>
        public ReservedCapacityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The total number of instances allocated to this reserved capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property UltraServerSummary. 
        /// <para>
        /// A summary of the UltraServer associated with this reserved capacity.
        /// </para>
        /// </summary>
        public UltraServerSummary UltraServerSummary { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerSummary property is set.
        /// </summary>
        internal bool IsSetUltraServerSummary() => this.UltraServerSummary != null;
    }
}
