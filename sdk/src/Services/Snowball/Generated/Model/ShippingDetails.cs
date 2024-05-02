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
    /// A job's shipping information, including inbound and outbound tracking numbers and
    /// shipping speed options.
    /// </summary>
    public partial class ShippingDetails
    {
        private Shipment _inboundShipment;
        private Shipment _outboundShipment;
        private ShippingOption _shippingOption;

        /// <summary>
        /// Gets and sets the property InboundShipment. 
        /// <para>
        /// The <c>Status</c> and <c>TrackingNumber</c> values for a Snow device being returned
        /// to Amazon Web Services for a particular job.
        /// </para>
        /// </summary>
        public Shipment InboundShipment
        {
            get { return this._inboundShipment; }
            set { this._inboundShipment = value; }
        }

        // Check to see if InboundShipment property is set
        internal bool IsSetInboundShipment()
        {
            return this._inboundShipment != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundShipment. 
        /// <para>
        /// The <c>Status</c> and <c>TrackingNumber</c> values for a Snow device being delivered
        /// to the address that you specified for a particular job.
        /// </para>
        /// </summary>
        public Shipment OutboundShipment
        {
            get { return this._outboundShipment; }
            set { this._outboundShipment = value; }
        }

        // Check to see if OutboundShipment property is set
        internal bool IsSetOutboundShipment()
        {
            return this._outboundShipment != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingOption. 
        /// <para>
        /// The shipping speed for a particular job. This speed doesn't dictate how soon you'll
        /// get the Snow device from the job's creation date. This speed represents how quickly
        /// it moves to its destination while in transit. Regional shipping speeds are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In Australia, you have access to express shipping. Typically, Snow devices shipped
        /// express are delivered in about a day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the European Union (EU), you have access to express shipping. Typically, Snow devices
        /// shipped express are delivered in about a day. In addition, most countries in the EU
        /// have access to standard shipping, which typically takes less than a week, one way.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In India, Snow devices are delivered in one to seven days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the United States of America (US), you have access to one-day shipping and two-day
        /// shipping.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ShippingOption ShippingOption
        {
            get { return this._shippingOption; }
            set { this._shippingOption = value; }
        }

        // Check to see if ShippingOption property is set
        internal bool IsSetShippingOption()
        {
            return this._shippingOption != null;
        }

    }
}