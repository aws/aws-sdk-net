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
    /// Container for the parameters to the UpdateFleet operation.
    /// Updates the description of an existing fleet. 
    /// 
    ///  <note> 
    /// <para>
    /// If the fleet is successfully updated, Amazon Web Services IoT FleetWise sends back
    /// an HTTP 200 response with an empty HTTP body.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateFleetRequest : AmazonIoTFleetWiseRequest
    {
        private string _description;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  An updated description of the fleet. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        ///  The ID of the fleet to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

    }
}