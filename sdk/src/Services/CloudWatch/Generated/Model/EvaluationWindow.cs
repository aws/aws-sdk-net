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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// The evaluation window that an alarm uses to select the range of metric data that it
    /// evaluates each time it runs. This is a union type. Set exactly one of its members,
    /// <c>SlidingWindow</c> or <c>WallClockWindow</c>. If you don't set <c>EvaluationWindow</c>,
    /// the alarm uses a <c>SlidingWindow</c> by default.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/alarm-evaluation-window.html">Alarm
    /// evaluation windows</a> in the <i>CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EvaluationWindow
    {
        private SlidingWindow _slidingWindow;
        private WallClockWindow _wallClockWindow;

        /// <summary>
        /// Gets and sets the property SlidingWindow. 
        /// <para>
        /// A sliding window, which advances each time the alarm is evaluated, forming a rolling
        /// time window. This is the default evaluation window.
        /// </para>
        /// </summary>
        public SlidingWindow SlidingWindow
        {
            get { return this._slidingWindow; }
            set { this._slidingWindow = value; }
        }

        // Check to see if SlidingWindow property is set
        internal bool IsSetSlidingWindow()
        {
            return this._slidingWindow != null;
        }

        /// <summary>
        /// Gets and sets the property WallClockWindow. 
        /// <para>
        /// A wall clock window, which aligns the evaluated range to fixed clock boundaries that
        /// match the alarm's period, such as the top of the hour, midnight, or the start of the
        /// calendar week.
        /// </para>
        /// </summary>
        public WallClockWindow WallClockWindow
        {
            get { return this._wallClockWindow; }
            set { this._wallClockWindow = value; }
        }

        // Check to see if WallClockWindow property is set
        internal bool IsSetWallClockWindow()
        {
            return this._wallClockWindow != null;
        }

    }
}