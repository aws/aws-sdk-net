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
    /// This is the response object from the CalculateRouteMatrix operation.
    /// </summary>
    public partial class CalculateRouteMatrixResponse : AmazonWebServiceResponse
    {
        private int? _errorCount;
        private string _pricingBucket;
        private List<List<RouteMatrixEntry>> _routeMatrix = AWSConfigs.InitializeCollections ? new List<List<RouteMatrixEntry>>() : null;
        private RouteMatrixBoundary _routingBoundary;

        /// <summary>
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The count of error results in the route matrix. If this number is 0, all routes were
        /// calculated successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? ErrorCount
        {
            get { return this._errorCount; }
            set { this._errorCount = value; }
        }

        // Check to see if ErrorCount property is set
        internal bool IsSetErrorCount()
        {
            return this._errorCount.HasValue; 
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
        /// Gets and sets the property RouteMatrix. 
        /// <para>
        /// The calculated route matrix containing the results for all pairs of Origins to Destination
        /// positions. Each row corresponds to one entry in Origins. Each entry in the row corresponds
        /// to the route from that entry in Origins to an entry in Destination positions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<List<RouteMatrixEntry>> RouteMatrix
        {
            get { return this._routeMatrix; }
            set { this._routeMatrix = value; }
        }

        // Check to see if RouteMatrix property is set
        internal bool IsSetRouteMatrix()
        {
            return this._routeMatrix != null && (this._routeMatrix.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingBoundary. 
        /// <para>
        /// Boundary within which the matrix is to be calculated. All data, origins and destinations
        /// outside the boundary are considered invalid.
        /// </para>
        ///  <note> 
        /// <para>
        /// When request routing boundary was set as AutoCircle, the response routing boundary
        /// will return Circle derived from the AutoCircle settings.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteMatrixBoundary RoutingBoundary
        {
            get { return this._routingBoundary; }
            set { this._routingBoundary = value; }
        }

        // Check to see if RoutingBoundary property is set
        internal bool IsSetRoutingBoundary()
        {
            return this._routingBoundary != null;
        }

    }
}