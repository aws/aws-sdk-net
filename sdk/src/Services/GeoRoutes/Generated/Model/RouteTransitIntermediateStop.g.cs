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
    /// An intermediate stop between departure and destination of the transit route.
    /// </summary>
    public partial class RouteTransitIntermediateStop
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Attributes of the intermediate stop.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2)]
        public List<string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Departure. 
        /// <para>
        /// Departure details for the intermediate stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteTransitDeparture Departure { get; set; }

        /// <summary>
        /// Checks to see if the Departure property is set.
        /// </summary>
        internal bool IsSetDeparture() => this.Departure != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration of the stop.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Offset in the leg geometry corresponding to the start of this stop.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? GeometryOffset { get; set; }

        /// <summary>
        /// Checks to see if the GeometryOffset property is set.
        /// </summary>
        internal bool IsSetGeometryOffset() => this.GeometryOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Transport. 
        /// <para>
        /// Transport mode details at the intermediate stop.
        /// </para>
        /// </summary>
        public RouteTransitTransportModeDetails Transport { get; set; }

        /// <summary>
        /// Checks to see if the Transport property is set.
        /// </summary>
        internal bool IsSetTransport() => this.Transport != null;
    }
}
