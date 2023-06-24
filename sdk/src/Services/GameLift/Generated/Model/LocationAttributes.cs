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
    /// Details about a location in a multi-location fleet.
    /// </summary>
    public partial class LocationAttributes
    {
        private LocationState _locationState;
        private List<string> _stoppedActions = new List<string>();
        private LocationUpdateStatus _updateStatus;

        /// <summary>
        /// Gets and sets the property LocationState. 
        /// <para>
        /// A fleet location and its current life-cycle state.
        /// </para>
        /// </summary>
        public LocationState LocationState
        {
            get { return this._locationState; }
            set { this._locationState = value; }
        }

        // Check to see if LocationState property is set
        internal bool IsSetLocationState()
        {
            return this._locationState != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedActions. 
        /// <para>
        /// A list of fleet actions that have been suspended in the fleet location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> StoppedActions
        {
            get { return this._stoppedActions; }
            set { this._stoppedActions = value; }
        }

        // Check to see if StoppedActions property is set
        internal bool IsSetStoppedActions()
        {
            return this._stoppedActions != null && this._stoppedActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The status of fleet activity updates to the location. The status <code>PENDING_UPDATE</code>
        /// indicates that <code>StopFleetActions</code> or <code>StartFleetActions</code> has
        /// been requested but the update has not yet been completed for the location.
        /// </para>
        /// </summary>
        public LocationUpdateStatus UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

    }
}