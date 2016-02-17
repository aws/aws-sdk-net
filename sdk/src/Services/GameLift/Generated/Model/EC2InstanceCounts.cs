/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Current status of fleet capacity. The number of active instances should match or be
    /// in the process of matching the number of desired instances. Pending and terminating
    /// counts are non-zero only if fleet capacity is adjusting to an <a>UpdateFleetCapacity</a>
    /// request, or if access to resources is temporarily affected.
    /// </summary>
    public partial class EC2InstanceCounts
    {
        private int? _active;
        private int? _desired;
        private int? _pending;
        private int? _terminating;

        /// <summary>
        /// Gets and sets the property ACTIVE. 
        /// <para>
        /// Actual number of active instances in the fleet.
        /// </para>
        /// </summary>
        public int ACTIVE
        {
            get { return this._active.GetValueOrDefault(); }
            set { this._active = value; }
        }

        // Check to see if ACTIVE property is set
        internal bool IsSetACTIVE()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DESIRED. 
        /// <para>
        /// Ideal number of active instances in the fleet.
        /// </para>
        /// </summary>
        public int DESIRED
        {
            get { return this._desired.GetValueOrDefault(); }
            set { this._desired = value; }
        }

        // Check to see if DESIRED property is set
        internal bool IsSetDESIRED()
        {
            return this._desired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PENDING. 
        /// <para>
        /// Number of instances in the fleet that are starting but not yet active.
        /// </para>
        /// </summary>
        public int PENDING
        {
            get { return this._pending.GetValueOrDefault(); }
            set { this._pending = value; }
        }

        // Check to see if PENDING property is set
        internal bool IsSetPENDING()
        {
            return this._pending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TERMINATING. 
        /// <para>
        /// Number of instances in the fleet that are no longer active but haven't yet been terminated.
        /// 
        /// </para>
        /// </summary>
        public int TERMINATING
        {
            get { return this._terminating.GetValueOrDefault(); }
            set { this._terminating = value; }
        }

        // Check to see if TERMINATING property is set
        internal bool IsSetTERMINATING()
        {
            return this._terminating.HasValue; 
        }

    }
}