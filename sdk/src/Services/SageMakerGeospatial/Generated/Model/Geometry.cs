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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The structure representing a Geometry in terms of Type and Coordinates as per GeoJson
    /// spec.
    /// </summary>
    public partial class Geometry
    {
        private List<List<List<double>>> _coordinates = new List<List<List<double>>>();
        private string _type;

        /// <summary>
        /// Gets and sets the property Coordinates. 
        /// <para>
        /// The coordinates of the GeoJson Geometry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<List<List<double>>> Coordinates
        {
            get { return this._coordinates; }
            set { this._coordinates = value; }
        }

        // Check to see if Coordinates property is set
        internal bool IsSetCoordinates()
        {
            return this._coordinates != null && this._coordinates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// GeoJson Geometry types like Polygon and MultiPolygon.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}