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
    /// This is the response object from the BatchUpdateVehicle operation.
    /// </summary>
    public partial class BatchUpdateVehicleResponse : AmazonWebServiceResponse
    {
        private List<UpdateVehicleError> _errors = AWSConfigs.InitializeCollections ? new List<UpdateVehicleError>() : null;
        private List<UpdateVehicleResponseItem> _vehicles = AWSConfigs.InitializeCollections ? new List<UpdateVehicleResponseItem>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of information about errors returned while updating a batch of vehicles, or,
        /// if there aren't any errors, an empty list.
        /// </para>
        /// </summary>
        public List<UpdateVehicleError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Vehicles. 
        /// <para>
        ///  A list of information about the batch of updated vehicles. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This list contains only unique IDs for the vehicles that were updated.
        /// </para>
        ///  </note>
        /// </summary>
        public List<UpdateVehicleResponseItem> Vehicles
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