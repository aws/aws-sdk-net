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
        /// <summary>
        /// Gets and sets the property CategoryFilter. 
        /// <para>
        /// The category type drill down filter. This filter is used for string type columns.
        /// </para>
        /// </summary>
        public CategoryDrillDownFilter CategoryFilter { get; set; }

        /// <summary>
        /// Checks to see if the CategoryFilter property is set.
        /// </summary>
        internal bool IsSetCategoryFilter() => this.CategoryFilter != null;

        /// <summary>
        /// Gets and sets the property NumericEqualityFilter. 
        /// <para>
        /// The numeric equality type drill down filter. This filter is used for number type columns.
        /// </para>
        /// </summary>
        public NumericEqualityDrillDownFilter NumericEqualityFilter { get; set; }

        /// <summary>
        /// Checks to see if the NumericEqualityFilter property is set.
        /// </summary>
        internal bool IsSetNumericEqualityFilter() => this.NumericEqualityFilter != null;

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// The time range drill down filter. This filter is used for date time columns.
        /// </para>
        /// </summary>
        public TimeRangeDrillDownFilter TimeRangeFilter { get; set; }

        /// <summary>
        /// Checks to see if the TimeRangeFilter property is set.
        /// </summary>
        internal bool IsSetTimeRangeFilter() => this.TimeRangeFilter != null;
    }
}
