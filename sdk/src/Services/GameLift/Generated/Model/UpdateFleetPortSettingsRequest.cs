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
    /// Container for the parameters to the UpdateFleetPortSettings operation.
    /// Updates port settings for a fleet. To update settings, specify the fleet ID to be
    /// updated and list the permissions you want to update. List the permissions you want
    /// to add in <code>InboundPermissionAuthorizations</code>, and permissions you want to
    /// remove in <code>InboundPermissionRevocations</code>. Permissions to be removed must
    /// match existing fleet permissions. If successful, the fleet ID for the updated fleet
    /// is returned.
    /// 
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
    public partial class UpdateFleetPortSettingsRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private List<IpPermission> _inboundPermissionAuthorizations = new List<IpPermission>();
        private List<IpPermission> _inboundPermissionRevocations = new List<IpPermission>();

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for a fleet to update port settings for. You can use either the
        /// fleet ID or ARN value.
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
        /// Gets and sets the property InboundPermissionAuthorizations. 
        /// <para>
        /// A collection of port settings to be added to the fleet resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<IpPermission> InboundPermissionAuthorizations
        {
            get { return this._inboundPermissionAuthorizations; }
            set { this._inboundPermissionAuthorizations = value; }
        }

        // Check to see if InboundPermissionAuthorizations property is set
        internal bool IsSetInboundPermissionAuthorizations()
        {
            return this._inboundPermissionAuthorizations != null && this._inboundPermissionAuthorizations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InboundPermissionRevocations. 
        /// <para>
        /// A collection of port settings to be removed from the fleet resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<IpPermission> InboundPermissionRevocations
        {
            get { return this._inboundPermissionRevocations; }
            set { this._inboundPermissionRevocations = value; }
        }

        // Check to see if InboundPermissionRevocations property is set
        internal bool IsSetInboundPermissionRevocations()
        {
            return this._inboundPermissionRevocations != null && this._inboundPermissionRevocations.Count > 0; 
        }

    }
}