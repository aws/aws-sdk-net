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
    /// The drill down filter for the column hierarchies.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class DrillDownFilter
    {
        private CategoryDrillDownFilter _categoryFilter;
        private NumericEqualityDrillDownFilter _numericEqualityFilter;
        private TimeRangeDrillDownFilter _timeRangeFilter;

        /// <summary>
        /// Gets and sets the property CategoryFilter. 
        /// <para>
        /// The category type drill down filter. This filter is used for string type columns.
        /// </para>
        /// </summary>
        public CategoryDrillDownFilter CategoryFilter
        {
            get { return this._categoryFilter; }
            set { this._categoryFilter = value; }
        }

        // Check to see if CategoryFilter property is set
        internal bool IsSetCategoryFilter()
        {
            return this._categoryFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NumericEqualityFilter. 
        /// <para>
        /// The numeric equality type drill down filter. This filter is used for number type columns.
        /// </para>
        /// </summary>
        public NumericEqualityDrillDownFilter NumericEqualityFilter
        {
            get { return this._numericEqualityFilter; }
            set { this._numericEqualityFilter = value; }
        }

        // Check to see if NumericEqualityFilter property is set
        internal bool IsSetNumericEqualityFilter()
        {
            return this._numericEqualityFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// The time range drill down filter. This filter is used for date time columns.
        /// </para>
        /// </summary>
        public TimeRangeDrillDownFilter TimeRangeFilter
        {
            get { return this._timeRangeFilter; }
            set { this._timeRangeFilter = value; }
        }

        // Check to see if TimeRangeFilter property is set
        internal bool IsSetTimeRangeFilter()
        {
            return this._timeRangeFilter != null;
        }

    }
}