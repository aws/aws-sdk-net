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
    /// Represents the geometry of connections between non-contiguous parts of an isoline.
    /// These connections can be provided in either coordinate pairs (LineString) or encoded
    /// (Polyline) format, matching the format specified in the request.
    /// </summary>
    public partial class IsolineConnectionGeometry
    {
        private List<List<double>> _lineString = AWSConfigs.InitializeCollections ? new List<List<double>>() : null;
        private string _polyline;

        /// <summary>
        /// Gets and sets the property LineString. 
        /// <para>
        /// A series of <c>[longitude, latitude]</c> coordinate pairs defining the connection
        /// path when <c>Simple</c> geometry format is requested. These coordinates can be directly
        /// used as the coordinates array in a GeoJSON LineString without transformation.
        /// </para>
        ///  <note> 
        /// <para>
        /// LineString and Polyline are mutually exclusive properties.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2)]
        public List<List<double>> LineString
        {
            get { return this._lineString; }
            set { this._lineString = value; }
        }

        // Check to see if LineString property is set
        internal bool IsSetLineString()
        {
            return this._lineString != null && (this._lineString.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Polyline. 
        /// <para>
        /// An encoded representation of the connection path when <c>FlexiblePolyline</c> geometry
        /// format is requested. This provides a more compact representation suitable for transmission
        /// and storage. To convert to GeoJSON, first decode to obtain coordinate pairs, then
        /// use those coordinates as the coordinates array in a GeoJSON LineString.
        /// </para>
        ///  <note> 
        /// <para>
        /// LineString and Polyline are mutually exclusive properties.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string Polyline
        {
            get { return this._polyline; }
            set { this._polyline = value; }
        }

        // Check to see if Polyline property is set
        internal bool IsSetPolyline()
        {
            return this._polyline != null;
        }

    }
}