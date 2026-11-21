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
    /// Summary information about a SageMaker Capacity Reservation.
    /// </summary>
    public partial class CapacityReservationSummary
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone of the reserved instances, for example <c>us-east-1a</c>.
        /// Availability Zone names can map to different physical zones in different accounts.
        /// To identify the same zone across accounts, use <c>AvailabilityZoneId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone of the reserved instances, for example <c>use1-az1</c>.
        /// An Availability Zone ID identifies the same physical zone in every account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the SageMaker Capacity Reservation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the SageMaker Capacity Reservation ends. This value is not returned
        /// if the reservation has no end time.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The SageMaker AI instance type of the reserved instances, for example <c>ml.p5.48xlarge</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the SageMaker Capacity Reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property SMCapacityReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker Capacity Reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SMCapacityReservationArn { get; set; }

        /// <summary>
        /// Checks to see if the SMCapacityReservationArn property is set.
        /// </summary>
        internal bool IsSetSMCapacityReservationArn() => this.SMCapacityReservationArn != null;

        /// <summary>
        /// Gets and sets the property SMCapacityReservationId. 
        /// <para>
        /// The ID of the SageMaker Capacity Reservation. The ID is the last part of the ARN and
        /// starts with <c>smcr-</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SMCapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the SMCapacityReservationId property is set.
        /// </summary>
        internal bool IsSetSMCapacityReservationId() => this.SMCapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the reserved instances become available.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SageMaker Capacity Reservation. SageMaker AI sets the status from
        /// the start and end times of the reservation. Valid values:
        /// </para>
        ///  <dl> <dt>Scheduled</dt> <dd> 
        /// <para>
        /// The current time is before <c>StartTime</c>.
        /// </para>
        ///  </dd> <dt>Active</dt> <dd> 
        /// <para>
        /// The current time is between <c>StartTime</c> and <c>EndTime</c>. You can use the reserved
        /// instances.
        /// </para>
        ///  </dd> <dt>Expired</dt> <dd> 
        /// <para>
        /// The current time is at or after <c>EndTime</c>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityReservationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The number of instances in the SageMaker Capacity Reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;
    }
}
