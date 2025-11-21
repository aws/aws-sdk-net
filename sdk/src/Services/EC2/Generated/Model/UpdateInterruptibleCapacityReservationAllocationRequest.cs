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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInterruptibleCapacityReservationAllocation operation.
    /// Modifies the number of instances allocated to an interruptible reservation, allowing
    /// you to add more capacity or reclaim capacity to your source Capacity Reservation.
    /// </summary>
    public partial class UpdateInterruptibleCapacityReservationAllocationRequest : AmazonEC2Request
    {
        private string _capacityReservationId;
        private int? _targetInstanceCount;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        ///  The ID of the source Capacity Reservation containing the interruptible allocation
        /// to modify. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetInstanceCount. 
        /// <para>
        ///  The new number of instances to allocate. Enter a higher number to add more capacity
        /// to share, or a lower number to reclaim capacity to your source Capacity Reservation.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int TargetInstanceCount
        {
            get { return this._targetInstanceCount.GetValueOrDefault(); }
            set { this._targetInstanceCount = value; }
        }

        // Check to see if TargetInstanceCount property is set
        internal bool IsSetTargetInstanceCount()
        {
            return this._targetInstanceCount.HasValue; 
        }

    }
}