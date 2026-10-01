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
    /// A custom filter that filters based on a single value. This filter can be partially
    /// matched.
    /// </summary>
    public partial class CustomFilterConfiguration
    {
        /// <summary>
        /// Gets and sets the property CategoryValue. 
        /// <para>
        /// The category value for the filter.
        /// </para>
        ///  
        /// <para>
        /// This field is mutually exclusive to <c>ParameterName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string CategoryValue { get; set; }

        /// <summary>
        /// Checks to see if the CategoryValue property is set.
        /// </summary>
        internal bool IsSetCategoryValue() => this.CategoryValue != null;

        /// <summary>
        /// Gets and sets the property MatchOperator. 
        /// <para>
        /// The match operator that is used to determine if a filter should be applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CategoryFilterMatchOperator MatchOperator { get; set; }

        /// <summary>
        /// Checks to see if the MatchOperator property is set.
        /// </summary>
        internal bool IsSetMatchOperator() => this.MatchOperator != null;

        /// <summary>
        /// Gets and sets the property NullOption. 
        /// <para>
        /// This option determines how null values should be treated when filtering data.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_VALUES</c>: Include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NULLS_ONLY</c>: Only include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_NULLS_ONLY</c>: Exclude null values from filtered results.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FilterNullOption NullOption { get; set; }

        /// <summary>
        /// Checks to see if the NullOption property is set.
        /// </summary>
        internal bool IsSetNullOption() => this.NullOption != null;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The parameter whose value should be used for the filter value.
        /// </para>
        ///  
        /// <para>
        /// This field is mutually exclusive to <c>CategoryValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ParameterName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterName property is set.
        /// </summary>
        internal bool IsSetParameterName() => this.ParameterName != null;

        /// <summary>
        /// Gets and sets the property SelectAllOptions. 
        /// <para>
        /// Select all of the values. Null is not the assigned value of select all.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FILTER_ALL_VALUES</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CategoryFilterSelectAllOptions SelectAllOptions { get; set; }

        /// <summary>
        /// Checks to see if the SelectAllOptions property is set.
        /// </summary>
        internal bool IsSetSelectAllOptions() => this.SelectAllOptions != null;
    }
}
