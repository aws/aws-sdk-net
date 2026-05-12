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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private DateRangeComparison _comparison;
        private DateRangeUnit _unit;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The condition to apply to a date range filter. If you specify <c>WITHIN</c>, Security
        /// Hub filters for dates within the specified date range. If you specify <c>OLDER_THAN</c>,
        /// Security Hub filters for dates before the specified date range. If you don't specify
        /// a value, the default is <c>WITHIN</c>.
        /// </para>
        /// </summary>
        public DateRangeComparison Comparison
        {
            get { return this._comparison; }
            set { this._comparison = value; }
        }

        // Check to see if Comparison property is set
        internal bool IsSetComparison()
        {
            return this._comparison != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// A date range unit for the date filter.
        /// </para>
        /// </summary>
        public DateRangeUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A date range value for the date filter.
        /// </para>
        /// </summary>
        public int? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}