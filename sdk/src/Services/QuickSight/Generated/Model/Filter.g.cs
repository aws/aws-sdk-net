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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CategoryFilter. 
        /// <para>
        /// A <c>CategoryFilter</c> filters text values.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/add-a-text-filter-data-prep.html">Adding
        /// text filters</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public CategoryFilter CategoryFilter { get; set; }

        /// <summary>
        /// Checks to see if the CategoryFilter property is set.
        /// </summary>
        internal bool IsSetCategoryFilter() => this.CategoryFilter != null;

        /// <summary>
        /// Gets and sets the property HierarchyFilter. 
        /// <para>
        /// A <c>HierarchyFilter</c> filters data by drilling down through an ordered list of
        /// columns. Each level in the list narrows the data by one column, and the selected values
        /// at each level determine which values are available at the next.
        /// </para>
        /// </summary>
        public HierarchyFilter HierarchyFilter { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyFilter property is set.
        /// </summary>
        internal bool IsSetHierarchyFilter() => this.HierarchyFilter != null;

        /// <summary>
        /// Gets and sets the property NestedFilter. 
        /// <para>
        /// A <c>NestedFilter</c> filters data with a subset of data that is defined by the nested
        /// inner filter.
        /// </para>
        /// </summary>
        public NestedFilter NestedFilter { get; set; }

        /// <summary>
        /// Checks to see if the NestedFilter property is set.
        /// </summary>
        internal bool IsSetNestedFilter() => this.NestedFilter != null;

        /// <summary>
        /// Gets and sets the property NumericEqualityFilter. 
        /// <para>
        /// A <c>NumericEqualityFilter</c> filters numeric values that equal or do not equal a
        /// given numeric value.
        /// </para>
        /// </summary>
        public NumericEqualityFilter NumericEqualityFilter { get; set; }

        /// <summary>
        /// Checks to see if the NumericEqualityFilter property is set.
        /// </summary>
        internal bool IsSetNumericEqualityFilter() => this.NumericEqualityFilter != null;

        /// <summary>
        /// Gets and sets the property NumericRangeFilter. 
        /// <para>
        /// A <c>NumericRangeFilter</c> filters numeric values that are either inside or outside
        /// a given numeric range.
        /// </para>
        /// </summary>
        public NumericRangeFilter NumericRangeFilter { get; set; }

        /// <summary>
        /// Checks to see if the NumericRangeFilter property is set.
        /// </summary>
        internal bool IsSetNumericRangeFilter() => this.NumericRangeFilter != null;

        /// <summary>
        /// Gets and sets the property RelativeDatesFilter. 
        /// <para>
        /// A <c>RelativeDatesFilter</c> filters date values that are relative to a given date.
        /// </para>
        /// </summary>
        public RelativeDatesFilter RelativeDatesFilter { get; set; }

        /// <summary>
        /// Checks to see if the RelativeDatesFilter property is set.
        /// </summary>
        internal bool IsSetRelativeDatesFilter() => this.RelativeDatesFilter != null;

        /// <summary>
        /// Gets and sets the property TimeEqualityFilter. 
        /// <para>
        /// A <c>TimeEqualityFilter</c> filters date-time values that equal or do not equal a
        /// given date/time value.
        /// </para>
        /// </summary>
        public TimeEqualityFilter TimeEqualityFilter { get; set; }

        /// <summary>
        /// Checks to see if the TimeEqualityFilter property is set.
        /// </summary>
        internal bool IsSetTimeEqualityFilter() => this.TimeEqualityFilter != null;

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// A <c>TimeRangeFilter</c> filters date-time values that are either inside or outside
        /// a given date/time range.
        /// </para>
        /// </summary>
        public TimeRangeFilter TimeRangeFilter { get; set; }

        /// <summary>
        /// Checks to see if the TimeRangeFilter property is set.
        /// </summary>
        internal bool IsSetTimeRangeFilter() => this.TimeRangeFilter != null;

        /// <summary>
        /// Gets and sets the property TopBottomFilter. 
        /// <para>
        /// A <c>TopBottomFilter</c> filters data to the top or bottom values for a given column.
        /// </para>
        /// </summary>
        public TopBottomFilter TopBottomFilter { get; set; }

        /// <summary>
        /// Checks to see if the TopBottomFilter property is set.
        /// </summary>
        internal bool IsSetTopBottomFilter() => this.TopBottomFilter != null;
    }
}
