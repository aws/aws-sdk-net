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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Represents list a map of dates with a count of total findings generated on each date.
    /// </summary>
    public partial class DateStatistics
    {
        private DateTime? _date;
        private DateTime? _lastGeneratedAt;
        private double? _severity;
        private int? _totalFindings;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The timestamp when the total findings count is observed.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>Date</c> would look like <c>"2024-09-05T17:00:00-07:00"</c> whereas
        /// <c>LastGeneratedAt</c> would look like 2024-09-05T17:12:29-07:00".
        /// </para>
        /// </summary>
        public DateTime? Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastGeneratedAt. 
        /// <para>
        /// The timestamp at which the last finding in the findings count, was generated.
        /// </para>
        /// </summary>
        public DateTime? LastGeneratedAt
        {
            get { return this._lastGeneratedAt; }
            set { this._lastGeneratedAt = value; }
        }

        // Check to see if LastGeneratedAt property is set
        internal bool IsSetLastGeneratedAt()
        {
            return this._lastGeneratedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the findings generated on each date.
        /// </para>
        /// </summary>
        public double? Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings that were generated per severity level on each date.
        /// </para>
        /// </summary>
        public int? TotalFindings
        {
            get { return this._totalFindings; }
            set { this._totalFindings = value; }
        }

        // Check to see if TotalFindings property is set
        internal bool IsSetTotalFindings()
        {
            return this._totalFindings.HasValue; 
        }

    }
}