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
    /// This is the response object from the CalculateIsolines operation.
    /// </summary>
    public partial class CalculateIsolinesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ArrivalTime. 
        /// <para>
        /// Time of arrival at the destination, used for traffic calculations. This attribute
        /// is returned only if the <c>Destination</c> and <c>ArrivalTime</c> attributes were
        /// provided in the request.
        /// </para>
        ///  
        /// <para>
        /// Time format: <c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24Z</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24+02:00</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// Checks to see if the ArrivalTime property is set.
        /// </summary>
        internal bool IsSetArrivalTime() => this.ArrivalTime != null;

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Time of departure from the origin, used for traffic calculations. This attribute is
        /// returned when <c>Origin</c> was provided in the request and either a specific departure
        /// time was requested (<c>DepartureTime</c>) or <c>DepartNow</c> was set to true.
        /// </para>
        ///  
        /// <para>
        /// Time format: <c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24Z</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24+02:00</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Checks to see if the DepartureTime property is set.
        /// </summary>
        internal bool IsSetDepartureTime() => this.DepartureTime != null;

        /// <summary>
        /// Gets and sets the property IsolineGeometryFormat. 
        /// <para>
        /// The format of the returned geometries, matching the format specified in the request.
        /// Either <c> FlexiblePolyline</c> for compact encoding or <c>Simple</c> for GeoJSON-compatible
        /// coordinates.
        /// </para>
        ///  
        /// <para>
        /// Default value:<c>FlexiblePolyline</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeometryFormat IsolineGeometryFormat { get; set; }

        /// <summary>
        /// Checks to see if the IsolineGeometryFormat property is set.
        /// </summary>
        internal bool IsSetIsolineGeometryFormat() => this.IsolineGeometryFormat != null;

        /// <summary>
        /// Gets and sets the property Isolines. 
        /// <para>
        /// Reachable areas, or isolines, for each threshold specified in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<Isoline> Isolines { get; set; } = AWSConfigs.InitializeCollections ? new List<Isoline>() : null;

        /// <summary>
        /// Checks to see if the Isolines property is set.
        /// </summary>
        internal bool IsSetIsolines() => this.Isolines != null && (this.Isolines.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PricingBucket. 
        /// <para>
        /// The pricing bucket applied to this calculation. Different buckets apply based on the
        /// travel mode and thresholds used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PricingBucket { get; set; }

        /// <summary>
        /// Checks to see if the PricingBucket property is set.
        /// </summary>
        internal bool IsSetPricingBucket() => this.PricingBucket != null;

        /// <summary>
        /// Gets and sets the property SnappedDestination. 
        /// <para>
        /// The actual point on the road network used for calculations, which may differ from
        /// the requested destination if <c>Destination</c> was not directly on a road.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 2)]
        public List<double> SnappedDestination { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the SnappedDestination property is set.
        /// </summary>
        internal bool IsSetSnappedDestination() => this.SnappedDestination != null && (this.SnappedDestination.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnappedOrigin. 
        /// <para>
        /// The actual point on the road network used for calculations, which may differ from
        /// the requested origin if <c>Origin</c> was not directly on a road.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 2)]
        public List<double> SnappedOrigin { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the SnappedOrigin property is set.
        /// </summary>
        internal bool IsSetSnappedOrigin() => this.SnappedOrigin != null && (this.SnappedOrigin.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
