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
    /// A filter condition that filters numeric values within a specified range.
    /// </summary>
    public partial class DataSetNumericRangeFilterCondition
    {
        private bool? _includeMaximum;
        private bool? _includeMinimum;
        private DataSetNumericFilterValue _rangeMaximum;
        private DataSetNumericFilterValue _rangeMinimum;

        /// <summary>
        /// Gets and sets the property IncludeMaximum. 
        /// <para>
        /// Whether to include the maximum value in the filter range.
        /// </para>
        /// </summary>
        public bool IncludeMaximum
        {
            get { return this._includeMaximum.GetValueOrDefault(); }
            set { this._includeMaximum = value; }
        }

        // Check to see if IncludeMaximum property is set
        internal bool IsSetIncludeMaximum()
        {
            return this._includeMaximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeMinimum. 
        /// <para>
        /// Whether to include the minimum value in the filter range.
        /// </para>
        /// </summary>
        public bool IncludeMinimum
        {
            get { return this._includeMinimum.GetValueOrDefault(); }
            set { this._includeMinimum = value; }
        }

        // Check to see if IncludeMinimum property is set
        internal bool IsSetIncludeMinimum()
        {
            return this._includeMinimum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RangeMaximum. 
        /// <para>
        /// The maximum numeric value for the range filter.
        /// </para>
        /// </summary>
        public DataSetNumericFilterValue RangeMaximum
        {
            get { return this._rangeMaximum; }
            set { this._rangeMaximum = value; }
        }

        // Check to see if RangeMaximum property is set
        internal bool IsSetRangeMaximum()
        {
            return this._rangeMaximum != null;
        }

        /// <summary>
        /// Gets and sets the property RangeMinimum. 
        /// <para>
        /// The minimum numeric value for the range filter.
        /// </para>
        /// </summary>
        public DataSetNumericFilterValue RangeMinimum
        {
            get { return this._rangeMinimum; }
            set { this._rangeMinimum = value; }
        }

        // Check to see if RangeMinimum property is set
        internal bool IsSetRangeMinimum()
        {
            return this._rangeMinimum != null;
        }

    }
}