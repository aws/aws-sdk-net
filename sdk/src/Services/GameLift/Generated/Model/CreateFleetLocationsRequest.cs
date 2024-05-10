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
    /// Container for the parameters to the CreateFleetLocations operation.
    /// <b>This operation has been expanded to use with the Amazon GameLift containers feature,
    /// which is currently in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// Adds remote locations to an EC2 or container fleet and begins populating the new locations
    /// with instances. The new instances conform to the fleet's instance type, auto-scaling,
    /// and other configuration settings.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't add remote locations to a fleet that resides in an Amazon Web Services Region
    /// that doesn't support multiple locations. Fleets created prior to March 2021 can't
    /// support multiple locations.
    /// </para>
    ///  </note> 
    /// <para>
    /// To add fleet locations, specify the fleet to be updated and provide a list of one
    /// or more locations. 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns the list of added locations with their status
    /// set to <c>NEW</c>. Amazon GameLift initiates the process of starting an instance in
    /// each added location. You can track the status of each new location by monitoring location
    /// creation events using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetEvents.html">DescribeFleetEvents</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up fleets</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Multi-location
    /// fleets</a> 
    /// </para>
    /// </summary>
    public partial class CreateFleetLocationsRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private List<LocationConfiguration> _locations = AWSConfigs.InitializeCollections ? new List<LocationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to add locations to. You can use either the fleet
        /// ID or ARN value.
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
        /// A list of locations to deploy additional instances to and manage as part of the fleet.
        /// You can add any Amazon GameLift-supported Amazon Web Services Region as a remote location,
        /// in the form of an Amazon Web Services Region code such as <c>us-west-2</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<LocationConfiguration> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}