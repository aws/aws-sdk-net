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
    /// Container for the parameters to the DescribeFleetPortSettings operation.
    /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
    /// the range of IP addresses and port settings that incoming traffic can use to access
    /// server processes in the fleet. Game sessions that are running on instances in the
    /// fleet must use connections that fall in this range.
    /// 
    ///  
    /// <para>
    /// This operation can be used in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To retrieve the inbound connection permissions for a fleet, identify the fleet's unique
    /// identifier. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To check the status of recent updates to a fleet remote location, specify the fleet
    /// ID and a location. Port setting updates can take time to propagate across all locations.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, a set of <code>IpPermission</code> objects is returned for the requested
    /// fleet ID. When a location is specified, a pending status is included. If the requested
    /// fleet has been deleted, the result set is empty.
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
    public partial class DescribeFleetPortSettingsRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private string _location;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to retrieve port settings for. You can use either
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
        /// Gets and sets the property Location. 
        /// <para>
        /// A remote location to check for status of port setting updates. Use the Amazon Web
        /// Services Region code format, such as <code>us-west-2</code>.
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