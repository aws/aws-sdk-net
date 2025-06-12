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
    /// This is the response object from the CalculateRoutes operation.
    /// </summary>
    public partial class CalculateRoutesResponse : AmazonWebServiceResponse
    {
        private GeometryFormat _legGeometryFormat;
        private List<RouteResponseNotice> _notices = AWSConfigs.InitializeCollections ? new List<RouteResponseNotice>() : null;
        private string _pricingBucket;
        private List<Route> _routes = AWSConfigs.InitializeCollections ? new List<Route>() : null;

        /// <summary>
        /// Gets and sets the property LegGeometryFormat. 
        /// <para>
        /// Specifies the format of the geometry returned for each leg of the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeometryFormat LegGeometryFormat
        {
            get { return this._legGeometryFormat; }
            set { this._legGeometryFormat = value; }
        }

        // Check to see if LegGeometryFormat property is set
        internal bool IsSetLegGeometryFormat()
        {
            return this._legGeometryFormat != null;
        }

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
        public List<RouteResponseNotice> Notices
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
        /// Gets and sets the property Routes. 
        /// <para>
        /// The path from the origin to the destination.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Route> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && (this._routes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}