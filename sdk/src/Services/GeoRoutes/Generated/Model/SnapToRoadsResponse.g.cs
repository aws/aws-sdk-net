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
    /// This is the response object from the SnapToRoads operation.
    /// </summary>
    public partial class SnapToRoadsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Notices. 
        /// <para>
        /// Notices are additional information returned that indicate issues that occurred during
        /// route calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RoadSnapNotice> Notices { get; set; } = AWSConfigs.InitializeCollections ? new List<RoadSnapNotice>() : null;

        /// <summary>
        /// Checks to see if the Notices property is set.
        /// </summary>
        internal bool IsSetNotices() => this.Notices != null && (this.Notices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PricingBucket. 
        /// <para>
        /// The pricing bucket for which the query is charged at.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PricingBucket { get; set; }

        /// <summary>
        /// Checks to see if the PricingBucket property is set.
        /// </summary>
        internal bool IsSetPricingBucket() => this.PricingBucket != null;

        /// <summary>
        /// Gets and sets the property SnappedGeometry. 
        /// <para>
        /// The interpolated geometry for the snapped route onto the road network.
        /// </para>
        /// </summary>
        public RoadSnapSnappedGeometry SnappedGeometry { get; set; }

        /// <summary>
        /// Checks to see if the SnappedGeometry property is set.
        /// </summary>
        internal bool IsSetSnappedGeometry() => this.SnappedGeometry != null;

        /// <summary>
        /// Gets and sets the property SnappedGeometryFormat. 
        /// <para>
        /// Specifies the format of the geometry returned for each leg of the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeometryFormat SnappedGeometryFormat { get; set; }

        /// <summary>
        /// Checks to see if the SnappedGeometryFormat property is set.
        /// </summary>
        internal bool IsSetSnappedGeometryFormat() => this.SnappedGeometryFormat != null;

        /// <summary>
        /// Gets and sets the property SnappedTracePoints. 
        /// <para>
        /// The trace points snapped onto the road network. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RoadSnapSnappedTracePoint> SnappedTracePoints { get; set; } = AWSConfigs.InitializeCollections ? new List<RoadSnapSnappedTracePoint>() : null;

        /// <summary>
        /// Checks to see if the SnappedTracePoints property is set.
        /// </summary>
        internal bool IsSetSnappedTracePoints() => this.SnappedTracePoints != null && (this.SnappedTracePoints.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
