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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the interval period to use for returning results.
    /// </summary>
    public partial class IntervalDetails
    {
        /// <summary>
        /// Gets and sets the property IntervalPeriod. 
        /// <para>
        ///  <c>IntervalPeriod</c>: An aggregated grouping applied to request metrics. Valid <c>IntervalPeriod</c>
        /// values are: <c>FIFTEEN_MIN</c> | <c>THIRTY_MIN</c> | <c>HOUR</c> | <c>DAY</c> | <c>WEEK</c>
        /// | <c>TOTAL</c>. 
        /// </para>
        ///  
        /// <para>
        /// For example, if <c>IntervalPeriod</c> is selected <c>THIRTY_MIN</c>, <c>StartTime</c>
        /// and <c>EndTime</c> differs by 1 day, then Connect Customer returns 48 results in the
        /// response. Each result is aggregated by the THIRTY_MIN period. By default Connect Customer
        /// aggregates results based on the <c>TOTAL</c> interval period. 
        /// </para>
        ///  
        /// <para>
        /// The following list describes restrictions on <c>StartTime</c> and <c>EndTime</c> based
        /// on what <c>IntervalPeriod</c> is requested. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FIFTEEN_MIN</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must
        /// be less than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>THIRTY_MIN</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must
        /// be less than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOUR</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must be less
        /// than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DAY</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must be less
        /// than 35 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WEEK</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must be less
        /// than 35 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOTAL</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must be
        /// less than 35 days.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IntervalPeriod IntervalPeriod { get; set; }

        /// <summary>
        /// Checks to see if the IntervalPeriod property is set.
        /// </summary>
        internal bool IsSetIntervalPeriod() => this.IntervalPeriod != null;

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The timezone applied to requested metrics.
        /// </para>
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;
    }
}
