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
    /// Specifies when and how long an alarm mute rule is active.
    /// 
    ///  
    /// <para>
    /// The schedule uses either a cron expression for recurring mute windows or an at expression
    /// for one-time mute windows. When the schedule activates, the mute rule mutes alarm
    /// actions for the specified duration.
    /// </para>
    /// </summary>
    public partial class Schedule
    {
        private string _duration;
        private string _expression;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The length of time that alarms remain muted when the schedule activates. The duration
        /// must be between 1 and 50 characters in length.
        /// </para>
        ///  
        /// <para>
        /// Specify the duration using ISO 8601 duration format with a minimum of 1 minute (<c>PT1M</c>)
        /// and maximum of 15 days (<c>P15D</c>).
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PT4H</c> - 4 hours for weekly system maintenance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>P2DT12H</c> - 2 days and 12 hours for weekend muting from Friday 6:00 PM to Monday
        /// 6:00 AM
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PT6H</c> - 6 hours for monthly database maintenance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PT2H</c> - 2 hours for nightly backup operations
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>P7D</c> - 7 days for annual company shutdown
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The duration begins when the schedule expression time is reached. For recurring schedules,
        /// the duration applies to each occurrence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The schedule expression that defines when the mute rule activates. The expression
        /// must be between 1 and 256 characters in length.
        /// </para>
        ///  
        /// <para>
        /// You can use one of two expression formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Cron expressions</b> - For recurring mute windows. Format: <c>cron(Minutes Hours
        /// Day-of-month Month Day-of-week)</c> 
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>cron(0 2 * * *)</c> - Activates daily at 2:00 AM
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cron(0 2 * * SUN)</c> - Activates every Sunday at 2:00 AM for weekly system maintenance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cron(0 1 1 * *)</c> - Activates on the first day of each month at 1:00 AM for
        /// monthly database maintenance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cron(0 18 * * FRI)</c> - Activates every Friday at 6:00 PM
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cron(0 23 * * *)</c> - Activates every day at 11:00 PM during nightly backup operations
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The characters <c>*</c>, <c>-</c>, and <c>,</c> are supported in all fields. English
        /// names can be used for the month (JAN-DEC) and day of week (SUN-SAT) fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>At expressions</b> - For one-time mute windows. Format: <c>at(yyyy-MM-ddThh:mm)</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>at(2024-05-10T14:00)</c> - Activates once on May 10, 2024 at 2:00 PM during an
        /// active incident response session
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>at(2024-12-23T00:00)</c> - Activates once on December 23, 2024 at midnight during
        /// annual company shutdown
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone to use when evaluating the schedule expression. The time zone must be
        /// between 1 and 50 characters in length.
        /// </para>
        ///  
        /// <para>
        /// Specify the time zone using standard timezone identifiers (for example, <c>America/New_York</c>,
        /// <c>Europe/London</c>, or <c>Asia/Tokyo</c>).
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a time zone, UTC is used by default. The time zone affects how
        /// cron and at expressions are interpreted, as well as start and expire dates you specify
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>America/New_York</c> - Eastern Time (US)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>America/Los_Angeles</c> - Pacific Time (US)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Europe/London</c> - British Time
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Asia/Tokyo</c> - Japan Standard Time
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UTC</c> - Coordinated Universal Time
        /// </para>
        ///  </li> </ul>
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