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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Resource capacity settings. Fleet capacity is measured in Amazon EC2 instances. Pending
    /// and terminating counts are non-zero when the fleet capacity is adjusting to a scaling
    /// event or if access to resources is temporarily affected.
    /// </summary>
    public partial class EC2InstanceCounts
    {
        private int? _active;
        private int? _desired;
        private int? _idle;
        private int? _maximum;
        private int? _minimum;
        private int? _pending;
        private int? _terminating;

        /// <summary>
        /// Gets and sets the property ACTIVE. 
        /// <para>
        /// Actual number of instances that are ready to host game sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Ideal number of active instances. GameLift will always try to maintain the desired
        /// number of instances. Capacity is scaled up or down by changing the desired instances.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property IDLE. 
        /// <para>
        /// Number of active instances that are not currently hosting a game session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int IDLE
        {
            get { return this._idle.GetValueOrDefault(); }
            set { this._idle = value; }
        }

        // Check to see if IDLE property is set
        internal bool IsSetIDLE()
        {
            return this._idle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MAXIMUM. 
        /// <para>
        /// The maximum instance count value allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MAXIMUM
        {
            get { return this._maximum.GetValueOrDefault(); }
            set { this._maximum = value; }
        }

        // Check to see if MAXIMUM property is set
        internal bool IsSetMAXIMUM()
        {
            return this._maximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MINIMUM. 
        /// <para>
        /// The minimum instance count value allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MINIMUM
        {
            get { return this._minimum.GetValueOrDefault(); }
            set { this._minimum = value; }
        }

        // Check to see if MINIMUM property is set
        internal bool IsSetMINIMUM()
        {
            return this._minimum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PENDING. 
        /// <para>
        /// Number of instances that are starting but not yet active.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Number of instances that are no longer active but haven't yet been terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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