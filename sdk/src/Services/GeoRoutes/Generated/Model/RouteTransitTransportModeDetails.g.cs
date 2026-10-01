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
    /// Transport mode details for the transit leg.
    /// </summary>
    public partial class RouteTransitTransportModeDetails
    {
        /// <summary>
        /// Gets and sets the property Accessibility. 
        /// <para>
        /// Wheelchair accessibility information for the transit vehicle.
        /// </para>
        /// </summary>
        public RouteAccessibilityAvailabilityDetails Accessibility { get; set; }

        /// <summary>
        /// Checks to see if the Accessibility property is set.
        /// </summary>
        internal bool IsSetAccessibility() => this.Accessibility != null;

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// Color of the transport polyline and background for the transport name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property Headsign. 
        /// <para>
        /// Transit route headsign.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Headsign { get; set; }

        /// <summary>
        /// Checks to see if the Headsign property is set.
        /// </summary>
        internal bool IsSetHeadsign() => this.Headsign != null;

        /// <summary>
        /// Gets and sets the property LongRouteName. 
        /// <para>
        /// Long name of the transit route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LongRouteName { get; set; }

        /// <summary>
        /// Checks to see if the LongRouteName property is set.
        /// </summary>
        internal bool IsSetLongRouteName() => this.LongRouteName != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Mode of the transit transport.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RouteTransitMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property RouteName. 
        /// <para>
        /// Transit route name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string RouteName { get; set; }

        /// <summary>
        /// Checks to see if the RouteName property is set.
        /// </summary>
        internal bool IsSetRouteName() => this.RouteName != null;

        /// <summary>
        /// Gets and sets the property ShortRouteName. 
        /// <para>
        /// Short name of the transit route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ShortRouteName { get; set; }

        /// <summary>
        /// Checks to see if the ShortRouteName property is set.
        /// </summary>
        internal bool IsSetShortRouteName() => this.ShortRouteName != null;

        /// <summary>
        /// Gets and sets the property TextColor. 
        /// <para>
        /// Color of the transport name text.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string TextColor { get; set; }

        /// <summary>
        /// Checks to see if the TextColor property is set.
        /// </summary>
        internal bool IsSetTextColor() => this.TextColor != null;
    }
}
