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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property FleetAttributes. 
        /// <para>
        /// The properties for the new fleet, including the current status. All fleets are placed
        /// in <c>NEW</c> status on creation. 
        /// </para>
        /// </summary>
        public FleetAttributes FleetAttributes { get; set; }

        /// <summary>
        /// Checks to see if the FleetAttributes property is set.
        /// </summary>
        internal bool IsSetFleetAttributes() => this.FleetAttributes != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocationState> LocationStates { get; set; } = AWSConfigs.InitializeCollections ? new List<LocationState>() : null;

        /// <summary>
        /// Checks to see if the LocationStates property is set.
        /// </summary>
        internal bool IsSetLocationStates() => this.LocationStates != null && (this.LocationStates.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
