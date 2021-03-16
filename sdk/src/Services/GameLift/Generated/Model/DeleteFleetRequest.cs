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
    /// Container for the parameters to the DeleteFleet operation.
    /// Deletes all resources and information related a fleet. Any current fleet instances,
    /// including those in remote locations, are shut down. You don't need to call <code>DeleteFleetLocations</code>
    /// separately.
    /// 
    ///  <note> 
    /// <para>
    /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
    /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
    /// You do not need to explicitly delete the VPC peering connection--this is done as part
    /// of the delete fleet process.
    /// </para>
    ///  </note> 
    /// <para>
    /// To delete a fleet, specify the fleet ID to be terminated. During the deletion process
    /// the fleet status is changed to <code>DELETING</code>. When completed, the status switches
    /// to <code>TERMINATED</code> and the fleet event <code>FLEET_DELETED</code> is sent.
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
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a>CreateFleetLocations</a> | <a>UpdateFleetAttributes</a> | <a>UpdateFleetCapacity</a>
    /// | <a>UpdateFleetPortSettings</a> | <a>UpdateRuntimeConfiguration</a> | <a>StopFleetActions</a>
    /// | <a>StartFleetActions</a> | <a>PutScalingPolicy</a> | <a>DeleteFleet</a> | <a>DeleteFleetLocations</a>
    /// | <a>DeleteScalingPolicy</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class DeleteFleetRequest : AmazonGameLiftRequest
    {
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to be deleted. You can use either the fleet ID or
        /// ARN value.
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

    }
}