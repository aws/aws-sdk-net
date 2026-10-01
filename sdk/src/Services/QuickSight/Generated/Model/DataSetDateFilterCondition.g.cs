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
    /// A filter condition for date columns, supporting both comparison and range-based filtering.
    /// </summary>
    public partial class DataSetDateFilterCondition
    {
        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the date column to filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property ComparisonFilterCondition. 
        /// <para>
        /// A comparison-based filter condition for the date column.
        /// </para>
        /// </summary>
        public DataSetDateComparisonFilterCondition ComparisonFilterCondition { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonFilterCondition property is set.
        /// </summary>
        internal bool IsSetComparisonFilterCondition() => this.ComparisonFilterCondition != null;

        /// <summary>
        /// Gets and sets the property RangeFilterCondition. 
        /// <para>
        /// A range-based filter condition for the date column, filtering values between minimum
        /// and maximum dates.
        /// </para>
        /// </summary>
        public DataSetDateRangeFilterCondition RangeFilterCondition { get; set; }

        /// <summary>
        /// Checks to see if the RangeFilterCondition property is set.
        /// </summary>
        internal bool IsSetRangeFilterCondition() => this.RangeFilterCondition != null;
    }
}
