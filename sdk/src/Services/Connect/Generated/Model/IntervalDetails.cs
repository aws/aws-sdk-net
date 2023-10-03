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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the interval period to use for returning results.
    /// </summary>
    public partial class IntervalDetails
    {
        private IntervalPeriod _intervalPeriod;
        private string _timeZone;

        /// <summary>
        /// Gets and sets the property IntervalPeriod. 
        /// <para>
        ///  <code>IntervalPeriod</code>: An aggregated grouping applied to request metrics. Valid
        /// <code>IntervalPeriod</code> values are: <code>FIFTEEN_MIN</code> | <code>THIRTY_MIN</code>
        /// | <code>HOUR</code> | <code>DAY</code> | <code>WEEK</code> | <code>TOTAL</code>. 
        /// </para>
        ///  
        /// <para>
        /// For example, if <code>IntervalPeriod</code> is selected <code>THIRTY_MIN</code>, <code>StartTime</code>
        /// and <code>EndTime</code> differs by 1 day, then Amazon Connect returns 48 results
        /// in the response. Each result is aggregated by the THIRTY_MIN period. By default Amazon
        /// Connect aggregates results based on the <code>TOTAL</code> interval period. 
        /// </para>
        ///  
        /// <para>
        /// The following list describes restrictions on <code>StartTime</code> and <code>EndTime</code>
        /// based on what <code>IntervalPeriod</code> is requested. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FIFTEEN_MIN</code>: The difference between <code>StartTime</code> and <code>EndTime</code>
        /// must be less than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>THIRTY_MIN</code>: The difference between <code>StartTime</code> and <code>EndTime</code>
        /// must be less than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HOUR</code>: The difference between <code>StartTime</code> and <code>EndTime</code>
        /// must be less than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAY</code>: The difference between <code>StartTime</code> and <code>EndTime</code>
        /// must be less than 35 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WEEK</code>: The difference between <code>StartTime</code> and <code>EndTime</code>
        /// must be less than 35 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TOTAL</code>: The difference between <code>StartTime</code> and <code>EndTime</code>
        /// must be less than 35 days.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IntervalPeriod IntervalPeriod
        {
            get { return this._intervalPeriod; }
            set { this._intervalPeriod = value; }
        }

        // Check to see if IntervalPeriod property is set
        internal bool IsSetIntervalPeriod()
        {
            return this._intervalPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The timezone applied to requested metrics.
        /// </para>
        /// </summary>
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

    }
}