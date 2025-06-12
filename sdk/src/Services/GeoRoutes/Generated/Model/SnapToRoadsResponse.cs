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
    /// This is the response object from the SnapToRoads operation.
    /// </summary>
    public partial class SnapToRoadsResponse : AmazonWebServiceResponse
    {
        private List<RoadSnapNotice> _notices = AWSConfigs.InitializeCollections ? new List<RoadSnapNotice>() : null;
        private string _pricingBucket;
        private RoadSnapSnappedGeometry _snappedGeometry;
        private GeometryFormat _snappedGeometryFormat;
        private List<RoadSnapSnappedTracePoint> _snappedTracePoints = AWSConfigs.InitializeCollections ? new List<RoadSnapSnappedTracePoint>() : null;

        /// <summary>
        /// Gets and sets the property Notices. 
        /// <para>
        /// Notices are additional information returned that indicate issues that occurred during
        /// route calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RoadSnapNotice> Notices
        {
            get { return this._notices; }
            set { this._notices = value; }
        }

        // Check to see if Notices property is set
        internal bool IsSetNotices()
        {
            return this._notices != null && (this._notices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PricingBucket. 
        /// <para>
        /// The pricing bucket for which the query is charged at.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PricingBucket
        {
            get { return this._pricingBucket; }
            set { this._pricingBucket = value; }
        }

        // Check to see if PricingBucket property is set
        internal bool IsSetPricingBucket()
        {
            return this._pricingBucket != null;
        }

        /// <summary>
        /// Gets and sets the property SnappedGeometry. 
        /// <para>
        /// The interpolated geometry for the snapped route onto the road network.
        /// </para>
        /// </summary>
        public RoadSnapSnappedGeometry SnappedGeometry
        {
            get { return this._snappedGeometry; }
            set { this._snappedGeometry = value; }
        }

        // Check to see if SnappedGeometry property is set
        internal bool IsSetSnappedGeometry()
        {
            return this._snappedGeometry != null;
        }

        /// <summary>
        /// Gets and sets the property SnappedGeometryFormat. 
        /// <para>
        /// Specifies the format of the geometry returned for each leg of the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SnappedTracePoints. 
        /// <para>
        /// The trace points snapped onto the road network. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RoadSnapSnappedTracePoint> SnappedTracePoints
        {
            get { return this._snappedTracePoints; }
            set { this._snappedTracePoints = value; }
        }

        // Check to see if SnappedTracePoints property is set
        internal bool IsSetSnappedTracePoints()
        {
            return this._snappedTracePoints != null && (this._snappedTracePoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}