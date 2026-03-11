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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The preference value for the geocode preference.
    /// </summary>
    public partial class GeocodePreferenceValue
    {
        private Coordinate _coordinate;
        private GeocoderHierarchy _geocoderHierarchy;

        /// <summary>
        /// Gets and sets the property Coordinate. 
        /// <para>
        /// The preference coordinate for the geocode preference.
        /// </para>
        /// </summary>
        public Coordinate Coordinate
        {
            get { return this._coordinate; }
            set { this._coordinate = value; }
        }

        // Check to see if Coordinate property is set
        internal bool IsSetCoordinate()
        {
            return this._coordinate != null;
        }

        /// <summary>
        /// Gets and sets the property GeocoderHierarchy. 
        /// <para>
        /// The preference hierarchy for the geocode preference.
        /// </para>
        /// </summary>
        public GeocoderHierarchy GeocoderHierarchy
        {
            get { return this._geocoderHierarchy; }
            set { this._geocoderHierarchy = value; }
        }

        // Check to see if GeocoderHierarchy property is set
        internal bool IsSetGeocoderHierarchy()
        {
            return this._geocoderHierarchy != null;
        }

    }
}