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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies geographical dimension settings for a segment.
    /// </summary>
    public partial class SegmentLocation
    {
        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country or region code, in ISO 3166-1 alpha-2 format, for the segment.
        /// </para>
        /// </summary>
        public SetDimension Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property GPSPoint. 
        /// <para>
        /// The GPS location and range for the segment.
        /// </para>
        /// </summary>
        public GPSPointDimension GPSPoint { get; set; }

        /// <summary>
        /// Checks to see if the GPSPoint property is set.
        /// </summary>
        internal bool IsSetGPSPoint() => this.GPSPoint != null;
    }
}
