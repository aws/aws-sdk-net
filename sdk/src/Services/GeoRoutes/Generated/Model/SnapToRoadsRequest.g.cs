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
    /// Container for the parameters to the SnapToRoads operation. <c>SnapToRoads</c> matches
    /// GPS trace to roads most likely traveled on. <para> For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/snap-to-roads.html">Snap
    /// to Roads</a> in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class SnapToRoadsRequest : AmazonGeoRoutesRequest
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1000)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property SnapRadius. 
        /// <para>
        /// The radius around the provided tracepoint that is considered for snapping.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>meters</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>300</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 10000)]
        public long? SnapRadius { get; set; }

        /// <summary>
        /// Checks to see if the SnapRadius property is set.
        /// </summary>
        internal bool IsSetSnapRadius() => this.SnapRadius.HasValue;

        /// <summary>
        /// Gets and sets the property SnappedGeometryFormat. 
        /// <para>
        /// Chooses what the returned SnappedGeometry format should be.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>FlexiblePolyline</c> 
        /// </para>
        /// </summary>
        public GeometryFormat SnappedGeometryFormat { get; set; }

        /// <summary>
        /// Checks to see if the SnappedGeometryFormat property is set.
        /// </summary>
        internal bool IsSetSnappedGeometryFormat() => this.SnappedGeometryFormat != null;

        /// <summary>
        /// Gets and sets the property TracePoints. 
        /// <para>
        /// List of trace points to be snapped onto the road network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 5000)]
        public List<RoadSnapTracePoint> TracePoints { get; set; } = AWSConfigs.InitializeCollections ? new List<RoadSnapTracePoint>() : null;

        /// <summary>
        /// Checks to see if the TracePoints property is set.
        /// </summary>
        internal bool IsSetTracePoints() => this.TracePoints != null && (this.TracePoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Car</c> 
        /// </para>
        /// </summary>
        public RoadSnapTravelMode TravelMode { get; set; }

        /// <summary>
        /// Checks to see if the TravelMode property is set.
        /// </summary>
        internal bool IsSetTravelMode() => this.TravelMode != null;

        /// <summary>
        /// Gets and sets the property TravelModeOptions. 
        /// <para>
        /// Travel mode related options for the provided travel mode.
        /// </para>
        /// </summary>
        public RoadSnapTravelModeOptions TravelModeOptions { get; set; }

        /// <summary>
        /// Checks to see if the TravelModeOptions property is set.
        /// </summary>
        internal bool IsSetTravelModeOptions() => this.TravelModeOptions != null;
    }
}
