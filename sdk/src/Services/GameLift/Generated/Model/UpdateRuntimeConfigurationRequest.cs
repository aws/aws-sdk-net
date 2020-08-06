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
    /// Container for the parameters to the UpdateRuntimeConfiguration operation.
    /// Updates the current runtime configuration for the specified fleet, which tells Amazon
    /// GameLift how to launch server processes on instances in the fleet. You can update
    /// a fleet's runtime configuration at any time after the fleet is created; it does not
    /// need to be in an <code>ACTIVE</code> status.
    /// 
    ///  
    /// <para>
    /// To update runtime configuration, specify the fleet ID and provide a <code>RuntimeConfiguration</code>
    /// object with an updated set of server process configurations.
    /// </para>
    ///  
    /// <para>
    /// Each instance in a Amazon GameLift fleet checks regularly for an updated runtime configuration
    /// and changes how it launches server processes to comply with the latest version. Existing
    /// server processes are not affected by the update; runtime configuration changes are
    /// applied gradually as existing processes shut down and new processes are launched during
    /// Amazon GameLift's normal process recycling activity.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up GameLift Fleets</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFleets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>UpdateFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRuntimeConfiguration</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateRuntimeConfigurationRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private RuntimeConfiguration _runtimeConfiguration;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for a fleet to update runtime configuration for. You can use either
        /// the fleet ID or ARN value.
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
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// Instructions for launching server processes on each instance in the fleet. Server
        /// processes run either a custom game build executable or a Realtime Servers script.
        /// The runtime configuration lists the types of server processes to run on an instance
        /// and includes the following configuration settings: the server executable or launch
        /// script file, launch parameters, and the number of processes to run concurrently on
        /// each instance. A CreateFleet request must include a runtime configuration with at
        /// least one server process configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeConfiguration RuntimeConfiguration
        {
            get { return this._runtimeConfiguration; }
            set { this._runtimeConfiguration = value; }
        }

        // Check to see if RuntimeConfiguration property is set
        internal bool IsSetRuntimeConfiguration()
        {
            return this._runtimeConfiguration != null;
        }

    }
}