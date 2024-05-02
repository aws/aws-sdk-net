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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateJobShipmentState operation.
    /// Updates the state when a shipment state changes to a different state.
    /// </summary>
    public partial class UpdateJobShipmentStateRequest : AmazonSnowballRequest
    {
        private string _jobId;
        private ShipmentState _shipmentState;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID of the job whose shipment date you want to update, for example <c>JID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=39, Max=39)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property ShipmentState. 
        /// <para>
        /// The state of a device when it is being shipped. 
        /// </para>
        ///  
        /// <para>
        /// Set to <c>RECEIVED</c> when the device arrives at your location.
        /// </para>
        ///  
        /// <para>
        /// Set to <c>RETURNED</c> when you have returned the device to Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ShipmentState ShipmentState
        {
            get { return this._shipmentState; }
            set { this._shipmentState = value; }
        }

        // Check to see if ShipmentState property is set
        internal bool IsSetShipmentState()
        {
            return this._shipmentState != null;
        }

    }
}