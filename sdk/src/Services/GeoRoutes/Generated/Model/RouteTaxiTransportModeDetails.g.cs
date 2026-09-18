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
    /// Transport mode details for the taxi leg.
    /// </summary>
    public partial class RouteTaxiTransportModeDetails
    {
        /// <summary>
        /// Gets and sets the property AvailableSeats. 
        /// <para>
        /// Number of available seats in the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public int? AvailableSeats { get; set; }

        /// <summary>
        /// Checks to see if the AvailableSeats property is set.
        /// </summary>
        internal bool IsSetAvailableSeats() => this.AvailableSeats.HasValue;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Human readable transport category.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

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
        /// Gets and sets the property Engine. 
        /// <para>
        /// Vehicle engine type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteEngineType Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property LicensePlate. 
        /// <para>
        /// Vehicle license plate number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LicensePlate { get; set; }

        /// <summary>
        /// Checks to see if the LicensePlate property is set.
        /// </summary>
        internal bool IsSetLicensePlate() => this.LicensePlate != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Mode of the taxi transport.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RouteTaxiMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// Vehicle model.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Vehicle name or mobility provider name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
