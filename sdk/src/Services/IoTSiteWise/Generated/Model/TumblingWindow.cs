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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a tumbling window, which is a repeating fixed-sized, non-overlapping, and
    /// contiguous time interval. This window is used in metric and aggregation computations.
    /// </summary>
    public partial class TumblingWindow
    {
        private string _interval;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time interval for the tumbling window. Note that <code>w</code> represents weeks,
        /// <code>d</code> represents days, <code>h</code> represents hours, and <code>m</code>
        /// represents minutes. AWS IoT SiteWise computes the <code>1w</code> interval the end
        /// of Sunday at midnight each week (UTC), the <code>1d</code> interval at the end of
        /// each day at midnight (UTC), the <code>1h</code> interval at the end of each hour,
        /// and so on. 
        /// </para>
        ///  
        /// <para>
        /// When AWS IoT SiteWise aggregates data points for metric computations, the start of
        /// each interval is exclusive and the end of each interval is inclusive. AWS IoT SiteWise
        /// places the computed data point at the end of the interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=3)]
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

    }
}