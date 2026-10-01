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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Two-line element set (TLE) data.
    /// </summary>
    public partial class TLEData
    {
        /// <summary>
        /// Gets and sets the property TleLine1. 
        /// <para>
        /// First line of two-line element set (TLE) data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 69, Max = 69)]
        public string TleLine1 { get; set; }

        /// <summary>
        /// Checks to see if the TleLine1 property is set.
        /// </summary>
        internal bool IsSetTleLine1() => this.TleLine1 != null;

        /// <summary>
        /// Gets and sets the property TleLine2. 
        /// <para>
        /// Second line of two-line element set (TLE) data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 69, Max = 69)]
        public string TleLine2 { get; set; }

        /// <summary>
        /// Checks to see if the TleLine2 property is set.
        /// </summary>
        internal bool IsSetTleLine2() => this.TleLine2 != null;

        /// <summary>
        /// Gets and sets the property ValidTimeRange. 
        /// <para>
        /// The valid time range for the TLE. Time ranges must be continuous without gaps or overlaps.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeRange ValidTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the ValidTimeRange property is set.
        /// </summary>
        internal bool IsSetValidTimeRange() => this.ValidTimeRange != null;
    }
}
