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
    /// The field well configuration of a pie chart.
    /// </summary>
    public partial class PieChartAggregatedFieldWells
    {
        private List<DimensionField> _category = new List<DimensionField>();
        private List<DimensionField> _smallMultiples = new List<DimensionField>();
        private List<MeasureField> _values = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category (group/color) field wells of a pie chart.
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
        /// Gets and sets the property SmallMultiples. 
        /// <para>
        /// The small multiples field well of a pie chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<DimensionField> SmallMultiples
        {
            get { return this._smallMultiples; }
            set { this._smallMultiples = value; }
        }

        // Check to see if SmallMultiples property is set
        internal bool IsSetSmallMultiples()
        {
            return this._smallMultiples != null && this._smallMultiples.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value field wells of a pie chart. Values are aggregated based on categories.
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