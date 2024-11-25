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
    /// Details about a location in a multi-location container fleet.
    /// </summary>
    public partial class ContainerFleetLocationAttributes
    {
        private string _location;
        private ContainerFleetLocationStatus _status;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// A location identifier.
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
        /// The status of fleet activity in the location. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> -- A new container fleet has been requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> -- A new container fleet resource is being created. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATED</c> -- A new container fleet resource has been created. No fleet instances
        /// have been deployed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATING</c> -- New container fleet instances are being deployed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> -- The container fleet has been deployed and is ready to host game
        /// sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> -- Updates to the container fleet is being updated. A deployment
        /// is in progress.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContainerFleetLocationStatus Status
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