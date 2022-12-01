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
    /// Container for the parameters to the DeleteFleetLocations operation.
    /// Removes locations from a multi-location fleet. When deleting a location, all game
    /// server process and all instances that are still active in the location are shut down.
    /// 
    /// 
    ///  
    /// <para>
    /// To delete fleet locations, identify the fleet ID and provide a list of the locations
    /// to be deleted. 
    /// </para>
    ///  
    /// <para>
    /// If successful, GameLift sets the location status to <code>DELETING</code>, and begins
    /// to shut down existing server processes and terminate instances in each location being
    /// deleted. When completed, the location status changes to <code>TERMINATED</code>.
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
    public partial class DeleteFleetLocationsRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private List<string> _locations = new List<string>();

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to delete locations for. You can use either the
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
        /// Gets and sets the property Locations. 
        /// <para>
        /// The list of fleet locations to delete. Specify locations in the form of an Amazon
        /// Web Services Region code, such as <code>us-west-2</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && this._locations.Count > 0; 
        }

    }
}