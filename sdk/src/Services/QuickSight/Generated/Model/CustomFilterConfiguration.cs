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
    /// A custom filter that filters based on a single value. This filter can be partially
    /// matched.
    /// </summary>
    public partial class CustomFilterConfiguration
    {
        private string _categoryValue;
        private CategoryFilterMatchOperator _matchOperator;
        private FilterNullOption _nullOption;
        private string _parameterName;
        private CategoryFilterSelectAllOptions _selectAllOptions;

        /// <summary>
        /// Gets and sets the property CategoryValue. 
        /// <para>
        /// The category value for the filter.
        /// </para>
        ///  
        /// <para>
        /// This field is mutually exclusive to <code>ParameterName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string CategoryValue
        {
            get { return this._categoryValue; }
            set { this._categoryValue = value; }
        }

        // Check to see if CategoryValue property is set
        internal bool IsSetCategoryValue()
        {
            return this._categoryValue != null;
        }

        /// <summary>
        /// Gets and sets the property MatchOperator. 
        /// <para>
        /// The match operator that is used to determine if a filter should be applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CategoryFilterMatchOperator MatchOperator
        {
            get { return this._matchOperator; }
            set { this._matchOperator = value; }
        }

        // Check to see if MatchOperator property is set
        internal bool IsSetMatchOperator()
        {
            return this._matchOperator != null;
        }

        /// <summary>
        /// Gets and sets the property NullOption. 
        /// <para>
        /// This option determines how null values should be treated when filtering data.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALL_VALUES</code>: Include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NULLS_ONLY</code>: Only include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NON_NULLS_ONLY</code>: Exclude null values from filtered results.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterNullOption NullOption
        {
            get { return this._nullOption; }
            set { this._nullOption = value; }
        }

        // Check to see if NullOption property is set
        internal bool IsSetNullOption()
        {
            return this._nullOption != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The parameter whose value should be used for the filter value.
        /// </para>
        ///  
        /// <para>
        /// This field is mutually exclusive to <code>CategoryValue</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

        /// <summary>
        /// Gets and sets the property SelectAllOptions. 
        /// <para>
        /// Select all of the values. Null is not the assigned value of select all.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FILTER_ALL_VALUES</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CategoryFilterSelectAllOptions SelectAllOptions
        {
            get { return this._selectAllOptions; }
            set { this._selectAllOptions = value; }
        }

        // Check to see if SelectAllOptions property is set
        internal bool IsSetSelectAllOptions()
        {
            return this._selectAllOptions != null;
        }

    }
}