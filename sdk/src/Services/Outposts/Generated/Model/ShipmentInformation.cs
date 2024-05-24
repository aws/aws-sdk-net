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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about a line item shipment.
    /// </summary>
    public partial class ShipmentInformation
    {
        private ShipmentCarrier _shipmentCarrier;
        private string _shipmentTrackingNumber;

        /// <summary>
        /// Gets and sets the property ShipmentCarrier. 
        /// <para>
        ///  The carrier of the shipment. 
        /// </para>
        /// </summary>
        public ShipmentCarrier ShipmentCarrier
        {
            get { return this._shipmentCarrier; }
            set { this._shipmentCarrier = value; }
        }

        // Check to see if ShipmentCarrier property is set
        internal bool IsSetShipmentCarrier()
        {
            return this._shipmentCarrier != null;
        }

        /// <summary>
        /// Gets and sets the property ShipmentTrackingNumber. 
        /// <para>
        ///  The tracking number of the shipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=42)]
        public string ShipmentTrackingNumber
        {
            get { return this._shipmentTrackingNumber; }
            set { this._shipmentTrackingNumber = value; }
        }

        // Check to see if ShipmentTrackingNumber property is set
        internal bool IsSetShipmentTrackingNumber()
        {
            return this._shipmentTrackingNumber != null;
        }

    }
}