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
    /// The aggregated field well configuration of a <code>RadarChartVisual</code>.
    /// </summary>
    public partial class RadarChartAggregatedFieldWells
    {
        private List<DimensionField> _category = new List<DimensionField>();
        private List<DimensionField> _color = new List<DimensionField>();
        private List<MeasureField> _values = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The aggregated field well categories of a radar chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<DimensionField> Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null && this._category.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The color that are assigned to the aggregated field wells of a radar chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<DimensionField> Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        // Check to see if Color property is set
        internal bool IsSetColor()
        {
            return this._color != null && this._color.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values that are assigned to the aggregated field wells of a radar chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
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