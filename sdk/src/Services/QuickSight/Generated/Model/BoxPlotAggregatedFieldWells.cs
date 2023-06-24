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
    /// The aggregated field well for a box plot.
    /// </summary>
    public partial class BoxPlotAggregatedFieldWells
    {
        private List<DimensionField> _groupBy = new List<DimensionField>();
        private List<MeasureField> _values = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The group by field well of a box plot chart. Values are grouped based on group by
        /// fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<DimensionField> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && this._groupBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value field well of a box plot chart. Values are aggregated based on group by
        /// fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
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