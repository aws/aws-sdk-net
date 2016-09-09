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
    /// Container for the parameters to the UpdateRuntimeConfiguration operation.
    /// Updates the current runtime configuration for the specified fleet, which tells GameLift
    /// how to launch server processes on instances in the fleet. You can update a fleet's
    /// runtime configuration at any time after the fleet is created; it does not need to
    /// be in an <code>ACTIVE</code> status.
    /// 
    ///  
    /// <para>
    /// To update runtime configuration, specify the fleet ID and provide a <code>RuntimeConfiguration</code>
    /// object with the updated collection of server process configurations.
    /// </para>
    ///  
    /// <para>
    /// Each instance in a GameLift fleet checks regularly for an updated runtime configuration
    /// and changes how it launches server processes to comply with the latest version. Existing
    /// server processes are not affected by the update; they continue to run until they end,
    /// while GameLift simply adds new server processes to fit the current runtime configuration.
    /// As a result, the runtime configuration changes are applied gradually as existing processes
    /// shut down and new processes are launched in GameLift's normal process recycling activity.
    /// </para>
    /// </summary>
    public partial class UpdateRuntimeConfigurationRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private RuntimeConfiguration _runtimeConfiguration;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier of the fleet to update runtime configuration for.
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

        /// <summary>
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// Instructions for launching server processes on each instance in the fleet. The runtime
        /// configuration for a fleet has a collection of server process configurations, one for
        /// each type of server process to run on an instance. A server process configuration
        /// specifies the location of the server executable, launch parameters, and the number
        /// of concurrent processes with that configuration to maintain on each instance.
        /// </para>
        /// </summary>
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