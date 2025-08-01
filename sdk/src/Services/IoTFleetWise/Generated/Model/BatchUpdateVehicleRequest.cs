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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateVehicle operation.
    /// Updates a group, or batch, of vehicles.
    /// 
    ///  <note> 
    /// <para>
    ///  You must specify a decoder manifest and a vehicle model (model manifest) for each
    /// vehicle. 
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/update-vehicles-cli.html">Update
    /// multiple vehicles (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer
    /// Guide</i>. 
    /// </para>
    /// </summary>
    public partial class BatchUpdateVehicleRequest : AmazonIoTFleetWiseRequest
    {
        private List<UpdateVehicleRequestItem> _vehicles = AWSConfigs.InitializeCollections ? new List<UpdateVehicleRequestItem>() : null;

        /// <summary>
        /// Gets and sets the property Vehicles. 
        /// <para>
        ///  A list of information about the vehicles to update. For more information, see the
        /// API data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<UpdateVehicleRequestItem> Vehicles
        {
            get { return this._vehicles; }
            set { this._vehicles = value; }
        }

        // Check to see if Vehicles property is set
        internal bool IsSetVehicles()
        {
            return this._vehicles != null && (this._vehicles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}