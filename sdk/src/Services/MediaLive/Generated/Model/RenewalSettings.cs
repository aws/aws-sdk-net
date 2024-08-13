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
    /// The Renewal settings for Reservations
    /// </summary>
    public partial class RenewalSettings
    {
        private ReservationAutomaticRenewal _automaticRenewal;
        private int? _renewalCount;

        /// <summary>
        /// Gets and sets the property AutomaticRenewal. Automatic renewal status for the reservation
        /// </summary>
        public ReservationAutomaticRenewal AutomaticRenewal
        {
            get { return this._automaticRenewal; }
            set { this._automaticRenewal = value; }
        }

        // Check to see if AutomaticRenewal property is set
        internal bool IsSetAutomaticRenewal()
        {
            return this._automaticRenewal != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalCount. Count for the reservation renewal
        /// </summary>
        [AWSProperty(Min=1)]
        public int? RenewalCount
        {
            get { return this._renewalCount; }
            set { this._renewalCount = value; }
        }

        // Check to see if RenewalCount property is set
        internal bool IsSetRenewalCount()
        {
            return this._renewalCount.HasValue; 
        }

    }
}