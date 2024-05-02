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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReservation operation.
    /// Update reservation.
    /// </summary>
    public partial class UpdateReservationRequest : AmazonMediaLiveRequest
    {
        private string _name;
        private RenewalSettings _renewalSettings;
        private string _reservationId;

        /// <summary>
        /// Gets and sets the property Name. Name of the reservation
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalSettings. Renewal settings for the reservation
        /// </summary>
        public RenewalSettings RenewalSettings
        {
            get { return this._renewalSettings; }
            set { this._renewalSettings = value; }
        }

        // Check to see if RenewalSettings property is set
        internal bool IsSetRenewalSettings()
        {
            return this._renewalSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationId. Unique reservation ID, e.g. '1234567'
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReservationId
        {
            get { return this._reservationId; }
            set { this._reservationId = value; }
        }

        // Check to see if ReservationId property is set
        internal bool IsSetReservationId()
        {
            return this._reservationId != null;
        }

    }
}