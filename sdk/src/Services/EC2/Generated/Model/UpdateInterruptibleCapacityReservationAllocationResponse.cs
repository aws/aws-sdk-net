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
    /// This is the response object from the UpdateInterruptibleCapacityReservationAllocation operation.
    /// </summary>
    public partial class UpdateInterruptibleCapacityReservationAllocationResponse : AmazonWebServiceResponse
    {
        private int? _instanceCount;
        private string _interruptibleCapacityReservationId;
        private InterruptionType _interruptionType;
        private string _sourceCapacityReservationId;
        private InterruptibleCapacityReservationAllocationStatus _status;
        private int? _targetInstanceCount;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        ///  The current number of instances allocated to the interruptible reservation. 
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
        /// Gets and sets the property InterruptibleCapacityReservationId. 
        /// <para>
        ///  The ID of the interruptible Capacity Reservation that was modified. 
        /// </para>
        /// </summary>
        public string InterruptibleCapacityReservationId
        {
            get { return this._interruptibleCapacityReservationId; }
            set { this._interruptibleCapacityReservationId = value; }
        }

        // Check to see if InterruptibleCapacityReservationId property is set
        internal bool IsSetInterruptibleCapacityReservationId()
        {
            return this._interruptibleCapacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property InterruptionType. 
        /// <para>
        ///  The interruption type for the interruptible reservation. 
        /// </para>
        /// </summary>
        public InterruptionType InterruptionType
        {
            get { return this._interruptionType; }
            set { this._interruptionType = value; }
        }

        // Check to see if InterruptionType property is set
        internal bool IsSetInterruptionType()
        {
            return this._interruptionType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCapacityReservationId. 
        /// <para>
        ///  The ID of the source Capacity Reservation to which capacity was reclaimed or from
        /// which capacity was allocated. 
        /// </para>
        /// </summary>
        public string SourceCapacityReservationId
        {
            get { return this._sourceCapacityReservationId; }
            set { this._sourceCapacityReservationId = value; }
        }

        // Check to see if SourceCapacityReservationId property is set
        internal bool IsSetSourceCapacityReservationId()
        {
            return this._sourceCapacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the allocation (updating during reclamation, active when complete).
        /// 
        /// </para>
        /// </summary>
        public InterruptibleCapacityReservationAllocationStatus Status
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
        /// Gets and sets the property TargetInstanceCount. 
        /// <para>
        ///  The requested number of instances for the interruptible Capacity Reservation. 
        /// </para>
        /// </summary>
        public int? TargetInstanceCount
        {
            get { return this._targetInstanceCount; }
            set { this._targetInstanceCount = value; }
        }

        // Check to see if TargetInstanceCount property is set
        internal bool IsSetTargetInstanceCount()
        {
            return this._targetInstanceCount.HasValue; 
        }

    }
}