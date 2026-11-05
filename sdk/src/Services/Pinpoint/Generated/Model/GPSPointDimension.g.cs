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
    /// Specifies GPS-based criteria for including or excluding endpoints from a segment.
    /// </summary>
    public partial class GPSPointDimension
    {
        /// <summary>
        /// Gets and sets the property Coordinates. 
        /// <para>
        /// The GPS coordinates to measure distance from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GPSCoordinates Coordinates { get; set; }

        /// <summary>
        /// Checks to see if the Coordinates property is set.
        /// </summary>
        internal bool IsSetCoordinates() => this.Coordinates != null;

        /// <summary>
        /// Gets and sets the property RangeInKilometers. 
        /// <para>
        /// The range, in kilometers, from the GPS coordinates.
        /// </para>
        /// </summary>
        public double? RangeInKilometers { get; set; }

        /// <summary>
        /// Checks to see if the RangeInKilometers property is set.
        /// </summary>
        internal bool IsSetRangeInKilometers() => this.RangeInKilometers.HasValue;
    }
}
