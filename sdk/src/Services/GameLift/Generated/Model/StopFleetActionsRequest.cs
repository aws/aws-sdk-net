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
    /// Container for the parameters to the StopFleetActions operation.
    /// Suspends activity on a fleet. Currently, this operation is used to stop a fleet's
    /// auto-scaling activity. It is used to temporarily stop scaling events triggered by
    /// the fleet's scaling policies. The policies can be retained and auto-scaling activity
    /// can be restarted using <a>StartFleetActions</a>. You can view a fleet's stopped actions
    /// using <a>DescribeFleetAttributes</a>.
    /// 
    ///  
    /// <para>
    /// To stop fleet actions, specify the fleet ID and the type of actions to suspend. When
    /// auto-scaling fleet actions are stopped, Amazon GameLift no longer initiates scaling
    /// events except to maintain the fleet's desired instances setting (<a>FleetCapacity</a>.
    /// Changes to the fleet's capacity must be done manually using <a>UpdateFleetCapacity</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class StopFleetActionsRequest : AmazonGameLiftRequest
    {
        private List<string> _actions = new List<string>();
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// List of actions to suspend on the fleet. 
        /// </para>
        /// </summary>
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

    }
}