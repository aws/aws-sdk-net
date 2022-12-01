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
    /// Container for the parameters to the StartFleetActions operation.
    /// Resumes certain types of activity on fleet instances that were suspended with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StopFleetActions.html">StopFleetActions</a>.
    /// For multi-location fleets, fleet actions are managed separately for each location.
    /// Currently, this operation is used to restart a fleet's auto-scaling activity.
    /// 
    ///  
    /// <para>
    /// This operation can be used in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To restart actions on instances in the fleet's home Region, provide a fleet ID and
    /// the type of actions to resume. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To restart actions on instances in one of the fleet's remote locations, provide a
    /// fleet ID, a location name, and the type of actions to resume. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, GameLift once again initiates scaling events as triggered by the fleet's
    /// scaling policies. If actions on the fleet location were never stopped, this operation
    /// will have no effect.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up GameLift fleets</a> 
    /// </para>
    /// </summary>
    public partial class StartFleetActionsRequest : AmazonGameLiftRequest
    {
        private List<string> _actions = new List<string>();
        private string _fleetId;
        private string _location;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// List of actions to restart on the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
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
        /// A unique identifier for the fleet to restart actions on. You can use either the fleet
        /// ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The fleet location to restart fleet actions for. Specify a location in the form of
        /// an Amazon Web Services Region code, such as <code>us-west-2</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}