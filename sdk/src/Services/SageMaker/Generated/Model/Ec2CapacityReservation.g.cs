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
    /// The EC2 capacity reservations that are shared to an ML capacity reservation.
    /// </summary>
    public partial class Ec2CapacityReservation
    {
        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances that are currently available in the EC2 capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AvailableInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableInstanceCount() => this.AvailableInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ec2CapacityReservationId. 
        /// <para>
        /// The unique identifier for an EC2 capacity reservation that's part of the ML capacity
        /// reservation.
        /// </para>
        /// </summary>
        public string Ec2CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetEc2CapacityReservationId() => this.Ec2CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The number of instances that you allocated to the EC2 capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property UsedByCurrentEndpoint. 
        /// <para>
        /// The number of instances from the EC2 capacity reservation that are being used by the
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? UsedByCurrentEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UsedByCurrentEndpoint property is set.
        /// </summary>
        internal bool IsSetUsedByCurrentEndpoint() => this.UsedByCurrentEndpoint.HasValue;
    }
}
