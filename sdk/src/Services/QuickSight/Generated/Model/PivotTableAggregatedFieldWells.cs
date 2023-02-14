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
    /// The aggregated field well for the pivot table.
    /// </summary>
    public partial class PivotTableAggregatedFieldWells
    {
        private List<DimensionField> _columns = new List<DimensionField>();
        private List<DimensionField> _rows = new List<DimensionField>();
        private List<MeasureField> _values = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// The columns field well for a pivot table. Values are grouped by columns fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=40)]
        public List<DimensionField> Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }

        // Check to see if Columns property is set
        internal bool IsSetColumns()
        {
            return this._columns != null && this._columns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Rows. 
        /// <para>
        /// The rows field well for a pivot table. Values are grouped by rows fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=40)]
        public List<DimensionField> Rows
        {
            get { return this._rows; }
            set { this._rows = value; }
        }

        // Check to see if Rows property is set
        internal bool IsSetRows()
        {
            return this._rows != null && this._rows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values field well for a pivot table. Values are aggregated based on rows and columns
        /// fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=40)]
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