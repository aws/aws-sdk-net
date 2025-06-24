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
    /// This is the response object from the CreateFleet operation.
    /// </summary>
    public partial class CreateFleetResponse : AmazonWebServiceResponse
    {
        private FleetAttributes _fleetAttributes;
        private List<LocationState> _locationStates = AWSConfigs.InitializeCollections ? new List<LocationState>() : null;

        /// <summary>
        /// Gets and sets the property FleetAttributes. 
        /// <para>
        /// The properties for the new fleet, including the current status. All fleets are placed
        /// in <c>NEW</c> status on creation. 
        /// </para>
        /// </summary>
        public FleetAttributes FleetAttributes
        {
            get { return this._fleetAttributes; }
            set { this._fleetAttributes = value; }
        }

        // Check to see if FleetAttributes property is set
        internal bool IsSetFleetAttributes()
        {
            return this._fleetAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property LocationStates. 
        /// <para>
        /// The fleet's locations and life-cycle status of each location. For new fleets, the
        /// status of all locations is set to <c>NEW</c>. During fleet creation, Amazon GameLift
        /// Servers updates each location status as instances are deployed there and prepared
        /// for game hosting. This list includes an entry for the fleet's home Region. For fleets
        /// with no remote locations, only one entry, representing the home Region, is returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocationState> LocationStates
        {
            get { return this._locationStates; }
            set { this._locationStates = value; }
        }

        // Check to see if LocationStates property is set
        internal bool IsSetLocationStates()
        {
            return this._locationStates != null && (this._locationStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}