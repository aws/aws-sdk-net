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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The aggregated field wells for a geospatial map.
    /// </summary>
    public partial class GeospatialMapAggregatedFieldWells
    {
        private List<DimensionField> _colors = new List<DimensionField>();
        private List<DimensionField> _geospatial = new List<DimensionField>();
        private List<MeasureField> _values = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property Colors. 
        /// <para>
        /// The color field wells of a geospatial map.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> Colors
        {
            get { return this._colors; }
            set { this._colors = value; }
        }

        // Check to see if Colors property is set
        internal bool IsSetColors()
        {
            return this._colors != null && this._colors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Geospatial. 
        /// <para>
        /// The geospatial field wells of a geospatial map. Values are grouped by geospatial fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> Geospatial
        {
            get { return this._geospatial; }
            set { this._geospatial = value; }
        }

        // Check to see if Geospatial property is set
        internal bool IsSetGeospatial()
        {
            return this._geospatial != null && this._geospatial.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The size field wells of a geospatial map. Values are aggregated based on geospatial
        /// fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<MeasureField> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}