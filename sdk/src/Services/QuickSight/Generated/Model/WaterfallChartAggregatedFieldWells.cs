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
    /// The field well configuration of a waterfall visual.
    /// </summary>
    public partial class WaterfallChartAggregatedFieldWells
    {
        private List<DimensionField> _breakdowns = new List<DimensionField>();
        private List<DimensionField> _categories = new List<DimensionField>();
        private List<MeasureField> _values = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property Breakdowns. 
        /// <para>
        /// The breakdown field wells of a waterfall visual.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> Breakdowns
        {
            get { return this._breakdowns; }
            set { this._breakdowns = value; }
        }

        // Check to see if Breakdowns property is set
        internal bool IsSetBreakdowns()
        {
            return this._breakdowns != null && this._breakdowns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The category field wells of a waterfall visual.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && this._categories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value field wells of a waterfall visual.
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