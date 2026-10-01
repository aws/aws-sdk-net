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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A date range for the date filter.
    /// </summary>
    public partial class DateRange
    {
        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The condition to apply to a date range filter. If you specify <c>WITHIN</c>, Security
        /// Hub filters for dates within the specified date range. If you specify <c>OLDER_THAN</c>,
        /// Security Hub filters for dates before the specified date range. If you don't specify
        /// a value, the default is <c>WITHIN</c>.
        /// </para>
        /// </summary>
        public DateRangeComparison Comparison { get; set; }

        /// <summary>
        /// Checks to see if the Comparison property is set.
        /// </summary>
        internal bool IsSetComparison() => this.Comparison != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// A date range unit for the date filter.
        /// </para>
        /// </summary>
        public DateRangeUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A date range value for the date filter.
        /// </para>
        /// </summary>
        public int? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
