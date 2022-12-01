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
    /// A fleet location and its life-cycle state. A location state object might be used to
    /// describe a fleet's remote location or home Region. Life-cycle state tracks the progress
    /// of launching the first instance in a new location and preparing it for game hosting,
    /// and then removing all instances and deleting the location from the fleet.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>NEW</b> -- A new fleet location has been defined and desired instances is set
    /// to 1. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>DOWNLOADING/VALIDATING/BUILDING/ACTIVATING</b> -- GameLift is setting up the new
    /// fleet location, creating new instances with the game build or Realtime script and
    /// starting server processes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ACTIVE</b> -- Hosts can now accept game sessions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ERROR</b> -- An error occurred when downloading, validating, building, or activating
    /// the fleet location.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>DELETING</b> -- Hosts are responding to a delete fleet location request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>TERMINATED</b> -- The fleet location no longer exists.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>NOT_FOUND</b> -- The fleet location was not found. This could be because the custom
    /// location was removed or not created. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LocationState
    {
        private string _location;
        private FleetStatus _status;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The fleet location, expressed as an Amazon Web Services Region code such as <code>us-west-2</code>.
        /// 
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The life-cycle status of a fleet location. 
        /// </para>
        /// </summary>
        public FleetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}