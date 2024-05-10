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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a tumbling window, which is a repeating fixed-sized, non-overlapping, and
    /// contiguous time window. You can use this window in metrics to aggregate data from
    /// properties and other assets.
    /// 
    ///  
    /// <para>
    /// You can use <c>m</c>, <c>h</c>, <c>d</c>, and <c>w</c> when you specify an interval
    /// or offset. Note that <c>m</c> represents minutes, <c>h</c> represents hours, <c>d</c>
    /// represents days, and <c>w</c> represents weeks. You can also use <c>s</c> to represent
    /// seconds in <c>offset</c>.
    /// </para>
    ///  
    /// <para>
    /// The <c>interval</c> and <c>offset</c> parameters support the <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO
    /// 8601 format</a>. For example, <c>PT5S</c> represents 5 seconds, <c>PT5M</c> represents
    /// 5 minutes, and <c>PT5H</c> represents 5 hours.
    /// </para>
    /// </summary>
    public partial class TumblingWindow
    {
        private string _interval;
        private string _offset;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time interval for the tumbling window. The interval time must be between 1 minute
        /// and 1 week.
        /// </para>
        ///  
        /// <para>
        /// IoT SiteWise computes the <c>1w</c> interval the end of Sunday at midnight each week
        /// (UTC), the <c>1d</c> interval at the end of each day at midnight (UTC), the <c>1h</c>
        /// interval at the end of each hour, and so on. 
        /// </para>
        ///  
        /// <para>
        /// When IoT SiteWise aggregates data points for metric computations, the start of each
        /// interval is exclusive and the end of each interval is inclusive. IoT SiteWise places
        /// the computed data point at the end of the interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=23)]
        public string Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval != null;
        }

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset for the tumbling window. The <c>offset</c> parameter accepts the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The offset time.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>18h</c> for <c>offset</c> and <c>1d</c> for <c>interval</c>,
        /// IoT SiteWise aggregates data in one of the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you create the metric before or at 6 PM (UTC), you get the first aggregation result
        /// at 6 PM (UTC) on the day when you create the metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you create the metric after 6 PM (UTC), you get the first aggregation result at
        /// 6 PM (UTC) the next day.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The ISO 8601 format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>PT18H</c> for <c>offset</c> and <c>1d</c> for <c>interval</c>,
        /// IoT SiteWise aggregates data in one of the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you create the metric before or at 6 PM (UTC), you get the first aggregation result
        /// at 6 PM (UTC) on the day when you create the metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you create the metric after 6 PM (UTC), you get the first aggregation result at
        /// 6 PM (UTC) the next day.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The 24-hour clock.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>00:03:00</c> for <c>offset</c>, <c>5m</c> for <c>interval</c>,
        /// and you create the metric at 2 PM (UTC), you get the first aggregation result at 2:03
        /// PM (UTC). You get the second aggregation result at 2:08 PM (UTC). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The offset time zone.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>2021-07-23T18:00-08</c> for <c>offset</c> and <c>1d</c>
        /// for <c>interval</c>, IoT SiteWise aggregates data in one of the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you create the metric before or at 6 PM (PST), you get the first aggregation result
        /// at 6 PM (PST) on the day when you create the metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you create the metric after 6 PM (PST), you get the first aggregation result at
        /// 6 PM (PST) the next day.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min=2, Max=25)]
        public string Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset != null;
        }

    }
}