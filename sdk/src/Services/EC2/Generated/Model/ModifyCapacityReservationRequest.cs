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
    /// Container for the parameters to the ModifyCapacityReservation operation.
    /// Modifies a Capacity Reservation's capacity, instance eligibility, and the conditions
    /// under which it is to be released. You can't modify a Capacity Reservation's instance
    /// type, EBS optimization, platform, instance store settings, Availability Zone, or tenancy.
    /// If you need to modify any of these attributes, we recommend that you cancel the Capacity
    /// Reservation, and then create a new one with the required attributes. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/capacity-reservations-modify.html">
    /// Modify an active Capacity Reservation</a>.
    /// 
    ///  
    /// <para>
    /// The allowed modifications depend on the state of the Capacity Reservation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>assessing</c> or <c>scheduled</c> state - You can modify the tags only.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>pending</c> state - You can't modify the Capacity Reservation in any way.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>active</c> state but still within the commitment duration - You can't decrease
    /// the instance count or set an end date that is within the commitment duration. All
    /// other modifications are allowed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>active</c> state with no commitment duration or elapsed commitment duration -
    /// All modifications are allowed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>expired</c>, <c>cancelled</c>, <c>unsupported</c>, or <c>failed</c> state - You
    /// can't modify the Capacity Reservation in any way.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ModifyCapacityReservationRequest : AmazonEC2Request
    {
        private bool? _accept;
        private string _additionalInfo;
        private string _capacityReservationId;
        private bool? _dryRun;
        private DateTime? _endDate;
        private EndDateType _endDateType;
        private int? _instanceCount;
        private InstanceMatchCriteria _instanceMatchCriteria;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// Reserved. Capacity Reservations you have created are accepted by default.
        /// </para>
        /// </summary>
        public bool? Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation expires. When a Capacity Reservation
        /// expires, the reserved capacity is released and you can no longer launch instances
        /// into it. The Capacity Reservation's state changes to <c>expired</c> when it reaches
        /// its end date and time.
        /// </para>
        ///  
        /// <para>
        /// The Capacity Reservation is cancelled within an hour from the specified time. For
        /// example, if you specify 5/31/2019, 13:30:55, the Capacity Reservation is guaranteed
        /// to end between 13:30:55 and 14:30:55 on 5/31/2019.
        /// </para>
        ///  
        /// <para>
        /// You must provide an <c>EndDate</c> value if <c>EndDateType</c> is <c>limited</c>.
        /// Omit <c>EndDate</c> if <c>EndDateType</c> is <c>unlimited</c>.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDateType. 
        /// <para>
        /// Indicates the way in which the Capacity Reservation ends. A Capacity Reservation can
        /// have one of the following end types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>unlimited</c> - The Capacity Reservation remains active until you explicitly cancel
        /// it. Do not provide an <c>EndDate</c> value if <c>EndDateType</c> is <c>unlimited</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>limited</c> - The Capacity Reservation expires automatically at a specified date
        /// and time. You must provide an <c>EndDate</c> value if <c>EndDateType</c> is <c>limited</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndDateType EndDateType
        {
            get { return this._endDateType; }
            set { this._endDateType = value; }
        }

        // Check to see if EndDateType property is set
        internal bool IsSetEndDateType()
        {
            return this._endDateType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances for which to reserve capacity. The number of instances can't
        /// be increased or decreased by more than <c>1000</c> in a single request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        ///  The matching criteria (instance eligibility) that you want to use in the modified
        /// Capacity Reservation. If you change the instance eligibility of an existing Capacity
        /// Reservation from <c>targeted</c> to <c>open</c>, any running instances that match
        /// the attributes of the Capacity Reservation, have the <c>CapacityReservationPreference</c>
        /// set to <c>open</c>, and are not yet running in the Capacity Reservation, will automatically
        /// use the modified Capacity Reservation. 
        /// </para>
        ///  
        /// <para>
        /// To modify the instance eligibility, the Capacity Reservation must be completely idle
        /// (zero usage).
        /// </para>
        /// </summary>
        public InstanceMatchCriteria InstanceMatchCriteria
        {
            get { return this._instanceMatchCriteria; }
            set { this._instanceMatchCriteria = value; }
        }

        // Check to see if InstanceMatchCriteria property is set
        internal bool IsSetInstanceMatchCriteria()
        {
            return this._instanceMatchCriteria != null;
        }

    }
}