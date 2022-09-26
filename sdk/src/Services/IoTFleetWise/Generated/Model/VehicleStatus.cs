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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about the state of a vehicle and how it relates to the status of a campaign.
    /// </summary>
    public partial class VehicleStatus
    {
        private string _campaignName;
        private VehicleState _status;
        private string _vehicleName;

        /// <summary>
        /// Gets and sets the property CampaignName. 
        /// <para>
        /// The name of a campaign.
        /// </para>
        /// </summary>
        public string CampaignName
        {
            get { return this._campaignName; }
            set { this._campaignName = value; }
        }

        // Check to see if CampaignName property is set
        internal bool IsSetCampaignName()
        {
            return this._campaignName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of a vehicle, which can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATED</code> - Amazon Web Services IoT FleetWise sucessfully created the
        /// vehicle. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>READY</code> - The vehicle is ready to receive a campaign deployment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HEALTHY</code> - A campaign deployment was delivered to the vehicle. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUSPENDED</code> - A campaign associated with the vehicle was suspended and
        /// data collection was paused. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - Amazon Web Services IoT FleetWise is removing a campaign
        /// from the vehicle. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VehicleState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VehicleName. 
        /// <para>
        /// The unique ID of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string VehicleName
        {
            get { return this._vehicleName; }
            set { this._vehicleName = value; }
        }

        // Check to see if VehicleName property is set
        internal bool IsSetVehicleName()
        {
            return this._vehicleName != null;
        }

    }
}