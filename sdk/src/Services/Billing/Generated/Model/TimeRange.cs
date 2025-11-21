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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// Specifies a time range with inclusive begin and end dates.
    /// </summary>
    public partial class TimeRange
    {
        private DateTime? _beginDateInclusive;
        private DateTime? _endDateInclusive;

        /// <summary>
        /// Gets and sets the property BeginDateInclusive. 
        /// <para>
        ///  The inclusive start date of the time range. 
        /// </para>
        /// </summary>
        public DateTime? BeginDateInclusive
        {
            get { return this._beginDateInclusive; }
            set { this._beginDateInclusive = value; }
        }

        // Check to see if BeginDateInclusive property is set
        internal bool IsSetBeginDateInclusive()
        {
            return this._beginDateInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDateInclusive. 
        /// <para>
        ///  The inclusive end date of the time range. 
        /// </para>
        /// </summary>
        public DateTime? EndDateInclusive
        {
            get { return this._endDateInclusive; }
            set { this._endDateInclusive = value; }
        }

        // Check to see if EndDateInclusive property is set
        internal bool IsSetEndDateInclusive()
        {
            return this._endDateInclusive.HasValue; 
        }

    }
}