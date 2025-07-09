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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRuntimeConfiguration operation.
    /// Updates the runtime configuration for the specified fleet. The runtime configuration
    /// tells Amazon GameLift Servers how to launch server processes on computes in managed
    /// EC2 and Anywhere fleets. You can update a fleet's runtime configuration at any time
    /// after the fleet is created; it does not need to be in <c>ACTIVE</c> status.
    /// 
    ///  
    /// <para>
    /// To update runtime configuration, specify the fleet ID and provide a <c>RuntimeConfiguration</c>
    /// with an updated set of server process configurations.
    /// </para>
    ///  
    /// <para>
    /// If successful, the fleet's runtime configuration settings are updated. Fleet computes
    /// that run game server processes regularly check for and receive updated runtime configurations.
    /// The computes immediately take action to comply with the new configuration by launching
    /// new server processes or by not replacing existing processes when they shut down. Updating
    /// a fleet's runtime configuration never affects existing server processes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up Amazon GameLift Servers fleets</a> 
    /// </para>
    /// </summary>
    public partial class UpdateRuntimeConfigurationRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private RuntimeConfiguration _runtimeConfiguration;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to update runtime configuration for. You can use
        /// either the fleet ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Instructions for launching server processes on fleet computes. Server processes run
        /// either a custom game build executable or a Amazon GameLift Servers Realtime script.
        /// The runtime configuration lists the types of server processes to run, how to launch
        /// them, and the number of processes to run concurrently.
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