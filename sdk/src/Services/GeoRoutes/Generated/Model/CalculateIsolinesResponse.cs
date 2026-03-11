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
    /// This is the response object from the CalculateIsolines operation.
    /// </summary>
    public partial class CalculateIsolinesResponse : AmazonWebServiceResponse
    {
        private string _arrivalTime;
        private string _departureTime;
        private GeometryFormat _isolineGeometryFormat;
        private List<Isoline> _isolines = AWSConfigs.InitializeCollections ? new List<Isoline>() : null;
        private string _pricingBucket;
        private List<double> _snappedDestination = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<double> _snappedOrigin = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property ArrivalTime. 
        /// <para>
        /// Time of arrival at the destination. This parameter is returned only if the Destination
        /// parameters was provided in the request. 
        /// </para>
        ///  
        /// <para>
        /// Time format:<c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
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
        [AWSProperty(Sensitive=true)]
        public string ArrivalTime
        {
            get { return this._arrivalTime; }
            set { this._arrivalTime = value; }
        }

        // Check to see if ArrivalTime property is set
        internal bool IsSetArrivalTime()
        {
            return this._arrivalTime != null;
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Time of departure from thr origin.
        /// </para>
        ///  
        /// <para>
        /// Time format:<c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
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
        [AWSProperty(Sensitive=true)]
        public string DepartureTime
        {
            get { return this._departureTime; }
            set { this._departureTime = value; }
        }

        // Check to see if DepartureTime property is set
        internal bool IsSetDepartureTime()
        {
            return this._departureTime != null;
        }

        /// <summary>
        /// Gets and sets the property IsolineGeometryFormat. 
        /// <para>
        /// The format of the returned IsolineGeometry. 
        /// </para>
        ///  
        /// <para>
        /// Default Value:<c>FlexiblePolyline</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeometryFormat IsolineGeometryFormat
        {
            get { return this._isolineGeometryFormat; }
            set { this._isolineGeometryFormat = value; }
        }

        // Check to see if IsolineGeometryFormat property is set
        internal bool IsSetIsolineGeometryFormat()
        {
            return this._isolineGeometryFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Isolines. 
        /// <para>
        /// Calculated isolines and associated properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<Isoline> Isolines
        {
            get { return this._isolines; }
            set { this._isolines = value; }
        }

        // Check to see if Isolines property is set
        internal bool IsSetIsolines()
        {
            return this._isolines != null && (this._isolines.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property SnappedDestination. 
        /// <para>
        /// Snapped destination that was used for the Isoline calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> SnappedDestination
        {
            get { return this._snappedDestination; }
            set { this._snappedDestination = value; }
        }

        // Check to see if SnappedDestination property is set
        internal bool IsSetSnappedDestination()
        {
            return this._snappedDestination != null && (this._snappedDestination.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnappedOrigin. 
        /// <para>
        /// Snapped origin that was used for the Isoline calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> SnappedOrigin
        {
            get { return this._snappedOrigin; }
            set { this._snappedOrigin = value; }
        }

        // Check to see if SnappedOrigin property is set
        internal bool IsSetSnappedOrigin()
        {
            return this._snappedOrigin != null && (this._snappedOrigin.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}