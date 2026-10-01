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
    /// A filter condition that filters date values within a specified range.
    /// </summary>
    public partial class DataSetDateRangeFilterCondition
    {
        /// <summary>
        /// Gets and sets the property IncludeMaximum. 
        /// <para>
        /// Whether to include the maximum value in the filter range.
        /// </para>
        /// </summary>
        public bool? IncludeMaximum { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMaximum property is set.
        /// </summary>
        internal bool IsSetIncludeMaximum() => this.IncludeMaximum.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeMinimum. 
        /// <para>
        /// Whether to include the minimum value in the filter range.
        /// </para>
        /// </summary>
        public bool? IncludeMinimum { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMinimum property is set.
        /// </summary>
        internal bool IsSetIncludeMinimum() => this.IncludeMinimum.HasValue;

        /// <summary>
        /// Gets and sets the property RangeMaximum. 
        /// <para>
        /// The maximum date value for the range filter.
        /// </para>
        /// </summary>
        public DataSetDateFilterValue RangeMaximum { get; set; }

        /// <summary>
        /// Checks to see if the RangeMaximum property is set.
        /// </summary>
        internal bool IsSetRangeMaximum() => this.RangeMaximum != null;

        /// <summary>
        /// Gets and sets the property RangeMinimum. 
        /// <para>
        /// The minimum date value for the range filter.
        /// </para>
        /// </summary>
        public DataSetDateFilterValue RangeMinimum { get; set; }

        /// <summary>
        /// Checks to see if the RangeMinimum property is set.
        /// </summary>
        internal bool IsSetRangeMinimum() => this.RangeMinimum != null;
    }
}
