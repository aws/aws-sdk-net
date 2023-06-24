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
    /// The aggregated field wells of a combo chart.
    /// </summary>
    public partial class ComboChartAggregatedFieldWells
    {
        private List<MeasureField> _barValues = new List<MeasureField>();
        private List<DimensionField> _category = new List<DimensionField>();
        private List<DimensionField> _colors = new List<DimensionField>();
        private List<MeasureField> _lineValues = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property BarValues. 
        /// <para>
        /// The aggregated <code>BarValues</code> field well of a combo chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<MeasureField> BarValues
        {
            get { return this._barValues; }
            set { this._barValues = value; }
        }

        // Check to see if BarValues property is set
        internal bool IsSetBarValues()
        {
            return this._barValues != null && this._barValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The aggregated category field wells of a combo chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
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
        /// Gets and sets the property Colors. 
        /// <para>
        /// The aggregated colors field well of a combo chart.
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
        /// Gets and sets the property LineValues. 
        /// <para>
        /// The aggregated <code>LineValues</code> field well of a combo chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<MeasureField> LineValues
        {
            get { return this._lineValues; }
            set { this._lineValues = value; }
        }

        // Check to see if LineValues property is set
        internal bool IsSetLineValues()
        {
            return this._lineValues != null && this._lineValues.Count > 0; 
        }

    }
}