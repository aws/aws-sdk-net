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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for TPS-based traffic shaping. This approach limits requests to
    /// the ad decision server (ADS) based on transactions per second and concurrent users,
    /// providing more intuitive capacity management compared to time-window based traffic
    /// shaping.
    /// </summary>
    public partial class TrafficShapingTpsConfiguration
    {
        private int? _peakConcurrentUsers;
        private int? _peakTps;

        /// <summary>
        /// Gets and sets the property PeakConcurrentUsers. 
        /// <para>
        /// The expected peak number of concurrent viewers for your content. MediaTailor uses
        /// this value along with peak TPS to determine how to distribute prefetch requests across
        /// the available capacity without exceeding your ADS limits.
        /// </para>
        /// </summary>
        public int? PeakConcurrentUsers
        {
            get { return this._peakConcurrentUsers; }
            set { this._peakConcurrentUsers = value; }
        }

        // Check to see if PeakConcurrentUsers property is set
        internal bool IsSetPeakConcurrentUsers()
        {
            return this._peakConcurrentUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeakTps. 
        /// <para>
        /// The maximum number of transactions per second (TPS) that your ad decision server (ADS)
        /// can handle. MediaTailor uses this value along with concurrent users and headroom multiplier
        /// to calculate optimal traffic distribution and prevent ADS overload.
        /// </para>
        /// </summary>
        public int? PeakTps
        {
            get { return this._peakTps; }
            set { this._peakTps = value; }
        }

        // Check to see if PeakTps property is set
        internal bool IsSetPeakTps()
        {
            return this._peakTps.HasValue; 
        }

    }
}