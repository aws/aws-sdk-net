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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// A reservation for a specified number of data processing units (DPUs). When a reservation
    /// is initially created, it has no DPUs. Athena allocates DPUs until the allocated amount
    /// equals the requested amount.
    /// </summary>
    public partial class CapacityReservation
    {
        private int? _allocatedDpus;
        private DateTime? _creationTime;
        private CapacityAllocation _lastAllocation;
        private DateTime? _lastSuccessfulAllocationTime;
        private string _name;
        private CapacityReservationStatus _status;
        private int? _targetDpus;

        /// <summary>
        /// Gets and sets the property AllocatedDpus. 
        /// <para>
        /// The number of data processing units currently allocated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? AllocatedDpus
        {
            get { return this._allocatedDpus; }
            set { this._allocatedDpus = value; }
        }

        // Check to see if AllocatedDpus property is set
        internal bool IsSetAllocatedDpus()
        {
            return this._allocatedDpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time in UTC epoch millis when the capacity reservation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastAllocation.
        /// </summary>
        public CapacityAllocation LastAllocation
        {
            get { return this._lastAllocation; }
            set { this._lastAllocation = value; }
        }

        // Check to see if LastAllocation property is set
        internal bool IsSetLastAllocation()
        {
            return this._lastAllocation != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulAllocationTime. 
        /// <para>
        /// The time of the most recent capacity allocation that succeeded.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulAllocationTime
        {
            get { return this._lastSuccessfulAllocationTime; }
            set { this._lastSuccessfulAllocationTime = value; }
        }

        // Check to see if LastSuccessfulAllocationTime property is set
        internal bool IsSetLastSuccessfulAllocationTime()
        {
            return this._lastSuccessfulAllocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityReservationStatus Status
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
        /// Gets and sets the property TargetDpus. 
        /// <para>
        /// The number of data processing units requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24)]
        public int? TargetDpus
        {
            get { return this._targetDpus; }
            set { this._targetDpus = value; }
        }

        // Check to see if TargetDpus property is set
        internal bool IsSetTargetDpus()
        {
            return this._targetDpus.HasValue; 
        }

    }
}