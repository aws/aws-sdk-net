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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// Status information about the simulation clock.
    /// </summary>
    public partial class SimulationClock
    {
        private ClockStatus _status;
        private ClockTargetStatus _targetStatus;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the simulation clock.
        /// </para>
        /// </summary>
        public ClockStatus Status
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
        /// Gets and sets the property TargetStatus. 
        /// <para>
        /// The desired status of the simulation clock.
        /// </para>
        /// </summary>
        public ClockTargetStatus TargetStatus
        {
            get { return this._targetStatus; }
            set { this._targetStatus = value; }
        }

        // Check to see if TargetStatus property is set
        internal bool IsSetTargetStatus()
        {
            return this._targetStatus != null;
        }

    }
}