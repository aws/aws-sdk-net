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
    /// The <c>Status</c> and <c>TrackingNumber</c> information for an inbound or outbound
    /// shipment.
    /// </summary>
    public partial class Shipment
    {
        private string _status;
        private string _trackingNumber;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status information for a shipment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Status
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
        /// Gets and sets the property TrackingNumber. 
        /// <para>
        /// The tracking number for this job. Using this tracking number with your region's carrier's
        /// website, you can track a Snow device as the carrier transports it.
        /// </para>
        ///  
        /// <para>
        /// For India, the carrier is Amazon Logistics. For all other regions, UPS is the carrier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TrackingNumber
        {
            get { return this._trackingNumber; }
            set { this._trackingNumber = value; }
        }

        // Check to see if TrackingNumber property is set
        internal bool IsSetTrackingNumber()
        {
            return this._trackingNumber != null;
        }

    }
}