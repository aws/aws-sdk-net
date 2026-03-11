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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
    /// Container for the parameters to the SnapToRoads operation.
    /// <c>SnapToRoads</c> matches GPS trace to roads most likely traveled on.
    /// </summary>
    public partial class SnapToRoadsRequest : AmazonGeoRoutesRequest
    {
        private string _key;
        private GeometryFormat _snappedGeometryFormat;
        private long? _snapRadius;
        private List<RoadSnapTracePoint> _tracePoints = AWSConfigs.InitializeCollections ? new List<RoadSnapTracePoint>() : null;
        private RoadSnapTravelMode _travelMode;
        private RoadSnapTravelModeOptions _travelModeOptions;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property SnappedGeometryFormat. 
        /// <para>
        /// Chooses what the returned SnappedGeometry format should be.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>FlexiblePolyline</c> 
        /// </para>
        /// </summary>
        public GeometryFormat SnappedGeometryFormat
        {
            get { return this._snappedGeometryFormat; }
            set { this._snappedGeometryFormat = value; }
        }

        // Check to see if SnappedGeometryFormat property is set
        internal bool IsSetSnappedGeometryFormat()
        {
            return this._snappedGeometryFormat != null;
        }

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
        [AWSProperty(Sensitive=true, Min=0, Max=10000)]
        public long? SnapRadius
        {
            get { return this._snapRadius; }
            set { this._snapRadius = value; }
        }

        // Check to see if SnapRadius property is set
        internal bool IsSetSnapRadius()
        {
            return this._snapRadius.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TracePoints. 
        /// <para>
        /// List of trace points to be snapped onto the road network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=5000)]
        public List<RoadSnapTracePoint> TracePoints
        {
            get { return this._tracePoints; }
            set { this._tracePoints = value; }
        }

        // Check to see if TracePoints property is set
        internal bool IsSetTracePoints()
        {
            return this._tracePoints != null && (this._tracePoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>Car</c> 
        /// </para>
        /// </summary>
        public RoadSnapTravelMode TravelMode
        {
            get { return this._travelMode; }
            set { this._travelMode = value; }
        }

        // Check to see if TravelMode property is set
        internal bool IsSetTravelMode()
        {
            return this._travelMode != null;
        }

        /// <summary>
        /// Gets and sets the property TravelModeOptions. 
        /// <para>
        /// Travel mode related options for the provided travel mode.
        /// </para>
        /// </summary>
        public RoadSnapTravelModeOptions TravelModeOptions
        {
            get { return this._travelModeOptions; }
            set { this._travelModeOptions = value; }
        }

        // Check to see if TravelModeOptions property is set
        internal bool IsSetTravelModeOptions()
        {
            return this._travelModeOptions != null;
        }

    }
}