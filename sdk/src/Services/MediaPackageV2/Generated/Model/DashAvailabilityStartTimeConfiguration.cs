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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The configuration for the DASH <c>availabilityStartTime</c> attribute of the Media
    /// Presentation Description (MPD). Use this configuration to set a custom availability
    /// start time for your DASH manifest.
    /// </summary>
    public partial class DashAvailabilityStartTimeConfiguration
    {
        private DateTime? _fixedAvailabilityStartTime;

        /// <summary>
        /// Gets and sets the property FixedAvailabilityStartTime. 
        /// <para>
        /// The fixed availability start time for the DASH manifest, in ISO 8601 date-time format.
        /// The value must have hourly granularity, meaning that the minutes, seconds, and fractional
        /// seconds must be zero. The value must be on or after <c>2024-01-01T00:00:00Z</c> and
        /// must be at least 14 days before the current time.
        /// </para>
        /// </summary>
        public DateTime? FixedAvailabilityStartTime
        {
            get { return this._fixedAvailabilityStartTime; }
            set { this._fixedAvailabilityStartTime = value; }
        }

        // Check to see if FixedAvailabilityStartTime property is set
        internal bool IsSetFixedAvailabilityStartTime()
        {
            return this._fixedAvailabilityStartTime.HasValue; 
        }

    }
}