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
    /// Updates the current runtime configuration for the specified fleet, which tells GameLift
    /// how to launch server processes on all instances in the fleet. You can update a fleet's
    /// runtime configuration at any time after the fleet is created; it does not need to
    /// be in <code>ACTIVE</code> status.
    /// 
    ///  
    /// <para>
    /// To update runtime configuration, specify the fleet ID and provide a <code>RuntimeConfiguration</code>
    /// with an updated set of server process configurations.
    /// </para>
    ///  
    /// <para>
    /// If successful, the fleet's runtime configuration settings are updated. Each instance
    /// in the fleet regularly checks for and retrieves updated runtime configurations. Instances
    /// immediately begin complying with the new configuration by launching new server processes
    /// or not replacing existing processes when they shut down. Updating a fleet's runtime
    /// configuration never affects existing server processes.
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
        /// Instructions for alaunching server processes on each instance in the fleet. Server
        /// processes run either a custom game build executable or a Realtime Servers script.
        /// The runtime configuration lists the types of server processes to run on an instance,
        /// how to launch them, and the number of processes to run concurrently.
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