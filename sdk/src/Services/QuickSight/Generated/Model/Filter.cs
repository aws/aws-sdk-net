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
    /// With a <c>Filter</c>, you can remove portions of data from a particular visual or
    /// view.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private CategoryFilter _categoryFilter;
        private NestedFilter _nestedFilter;
        private NumericEqualityFilter _numericEqualityFilter;
        private NumericRangeFilter _numericRangeFilter;
        private RelativeDatesFilter _relativeDatesFilter;
        private TimeEqualityFilter _timeEqualityFilter;
        private TimeRangeFilter _timeRangeFilter;
        private TopBottomFilter _topBottomFilter;

        /// <summary>
        /// Gets and sets the property CategoryFilter. 
        /// <para>
        /// A <c>CategoryFilter</c> filters text values.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/add-a-text-filter-data-prep.html">Adding
        /// text filters</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public CategoryFilter CategoryFilter
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
        /// Gets and sets the property NestedFilter. 
        /// <para>
        /// A <c>NestedFilter</c> filters data with a subset of data that is defined by the nested
        /// inner filter.
        /// </para>
        /// </summary>
        public NestedFilter NestedFilter
        {
            get { return this._nestedFilter; }
            set { this._nestedFilter = value; }
        }

        // Check to see if NestedFilter property is set
        internal bool IsSetNestedFilter()
        {
            return this._nestedFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NumericEqualityFilter. 
        /// <para>
        /// A <c>NumericEqualityFilter</c> filters numeric values that equal or do not equal a
        /// given numeric value.
        /// </para>
        /// </summary>
        public NumericEqualityFilter NumericEqualityFilter
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
        /// Gets and sets the property NumericRangeFilter. 
        /// <para>
        /// A <c>NumericRangeFilter</c> filters numeric values that are either inside or outside
        /// a given numeric range.
        /// </para>
        /// </summary>
        public NumericRangeFilter NumericRangeFilter
        {
            get { return this._numericRangeFilter; }
            set { this._numericRangeFilter = value; }
        }

        // Check to see if NumericRangeFilter property is set
        internal bool IsSetNumericRangeFilter()
        {
            return this._numericRangeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property RelativeDatesFilter. 
        /// <para>
        /// A <c>RelativeDatesFilter</c> filters date values that are relative to a given date.
        /// </para>
        /// </summary>
        public RelativeDatesFilter RelativeDatesFilter
        {
            get { return this._relativeDatesFilter; }
            set { this._relativeDatesFilter = value; }
        }

        // Check to see if RelativeDatesFilter property is set
        internal bool IsSetRelativeDatesFilter()
        {
            return this._relativeDatesFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TimeEqualityFilter. 
        /// <para>
        /// A <c>TimeEqualityFilter</c> filters date-time values that equal or do not equal a
        /// given date/time value.
        /// </para>
        /// </summary>
        public TimeEqualityFilter TimeEqualityFilter
        {
            get { return this._timeEqualityFilter; }
            set { this._timeEqualityFilter = value; }
        }

        // Check to see if TimeEqualityFilter property is set
        internal bool IsSetTimeEqualityFilter()
        {
            return this._timeEqualityFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// A <c>TimeRangeFilter</c> filters date-time values that are either inside or outside
        /// a given date/time range.
        /// </para>
        /// </summary>
        public TimeRangeFilter TimeRangeFilter
        {
            get { return this._timeRangeFilter; }
            set { this._timeRangeFilter = value; }
        }

        // Check to see if TimeRangeFilter property is set
        internal bool IsSetTimeRangeFilter()
        {
            return this._timeRangeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TopBottomFilter. 
        /// <para>
        /// A <c>TopBottomFilter</c> filters data to the top or bottom values for a given column.
        /// </para>
        /// </summary>
        public TopBottomFilter TopBottomFilter
        {
            get { return this._topBottomFilter; }
            set { this._topBottomFilter = value; }
        }

        // Check to see if TopBottomFilter property is set
        internal bool IsSetTopBottomFilter()
        {
            return this._topBottomFilter != null;
        }

    }
}