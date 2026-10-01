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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Details about the station.
    /// </summary>
    public partial class RouteStationDetails
    {
        /// <summary>
        /// Gets and sets the property Accessibility. 
        /// <para>
        /// Wheelchair accessibility information for the station.
        /// </para>
        /// </summary>
        public RouteAccessibilityAvailabilityDetails Accessibility { get; set; }

        /// <summary>
        /// Checks to see if the Accessibility property is set.
        /// </summary>
        internal bool IsSetAccessibility() => this.Accessibility != null;

        /// <summary>
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// Platform name or number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PlatformName { get; set; }

        /// <summary>
        /// Checks to see if the PlatformName property is set.
        /// </summary>
        internal bool IsSetPlatformName() => this.PlatformName != null;

        /// <summary>
        /// Gets and sets the property ShortName. 
        /// <para>
        /// Short text or a number that identifies the station.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ShortName { get; set; }

        /// <summary>
        /// Checks to see if the ShortName property is set.
        /// </summary>
        internal bool IsSetShortName() => this.ShortName != null;
    }
}
