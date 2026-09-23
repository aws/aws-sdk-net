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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides geographic coordinates that indicate where a specified IP address originated
    /// from.
    /// </summary>
    public partial class IpGeoLocation
    {
        /// <summary>
        /// Gets and sets the property Lat. 
        /// <para>
        /// The latitude coordinate of the location, rounded to four decimal places.
        /// </para>
        /// </summary>
        public double? Lat { get; set; }

        /// <summary>
        /// Checks to see if the Lat property is set.
        /// </summary>
        internal bool IsSetLat() => this.Lat.HasValue;

        /// <summary>
        /// Gets and sets the property Lon. 
        /// <para>
        /// The longitude coordinate of the location, rounded to four decimal places.
        /// </para>
        /// </summary>
        public double? Lon { get; set; }

        /// <summary>
        /// Checks to see if the Lon property is set.
        /// </summary>
        internal bool IsSetLon() => this.Lon.HasValue;
    }
}
