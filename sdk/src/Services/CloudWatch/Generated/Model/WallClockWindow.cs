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
    /// An evaluation window that aligns the evaluated range to fixed clock boundaries that
    /// match the alarm's period, such as the top of the hour, midnight, or the start of the
    /// calendar week, optionally in a specific time zone.
    /// 
    ///  
    /// <para>
    /// When you use a wall clock window, the alarm's period must be 1 minute (60 seconds),
    /// 5 minutes (300 seconds), 1 hour (3,600 seconds), 1 day (86,400 seconds), or 1 week
    /// (604,800 seconds). Other period values aren't supported with a wall clock window.
    /// </para>
    ///  
    /// <para>
    /// Choose a wall clock window when your monitoring is tied to a business or calendar
    /// period, such as daily reports, batch jobs, or backups, or when you want alarm evaluations
    /// to match the periods shown on a metric dashboard.
    /// </para>
    /// </summary>
    public partial class WallClockWindow
    {
        private string _timezone;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone to use when the alarm aligns the evaluation window to clock boundaries.
        /// You can specify an IANA time zone name (for example, <c>America/New_York</c>), a fixed
        /// UTC offset (for example, <c>+05:30</c>), or an offset-prefixed identifier (for example,
        /// <c>UTC+05:30</c>). The offset must be aligned to a multiple of 5 minutes. If you don't
        /// specify a time zone, CloudWatch uses <c>UTC</c>.
        /// </para>
        ///  
        /// <para>
        /// The time zone affects window alignment for all periods, including periods of one hour
        /// or shorter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}