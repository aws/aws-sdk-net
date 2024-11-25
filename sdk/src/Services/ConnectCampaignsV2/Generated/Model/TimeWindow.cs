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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Time window config
    /// </summary>
    public partial class TimeWindow
    {
        private OpenHours _openHours;
        private RestrictedPeriods _restrictedPeriods;

        /// <summary>
        /// Gets and sets the property OpenHours.
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenHours OpenHours
        {
            get { return this._openHours; }
            set { this._openHours = value; }
        }

        // Check to see if OpenHours property is set
        internal bool IsSetOpenHours()
        {
            return this._openHours != null;
        }

        /// <summary>
        /// Gets and sets the property RestrictedPeriods.
        /// </summary>
        public RestrictedPeriods RestrictedPeriods
        {
            get { return this._restrictedPeriods; }
            set { this._restrictedPeriods = value; }
        }

        // Check to see if RestrictedPeriods property is set
        internal bool IsSetRestrictedPeriods()
        {
            return this._restrictedPeriods != null;
        }

    }
}