/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScheduledAudit operation.
    /// Creates a scheduled audit that is run at a specified time interval.
    /// </summary>
    public partial class CreateScheduledAuditRequest : AmazonIoTRequest
    {
        private string _dayOfMonth;
        private DayOfWeek _dayOfWeek;
        private AuditFrequency _frequency;
        private string _scheduledAuditName;
        private List<string> _targetCheckNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month on which the scheduled audit takes place. Can be "1" through
        /// "31" or "LAST". This field is required if the "frequency" parameter is set to "MONTHLY".
        /// If days 29-31 are specified, and the month does not have that many days, the audit
        /// takes place on the "LAST" day of the month.
        /// </para>
        /// </summary>
        public string DayOfMonth
        {
            get { return this._dayOfMonth; }
            set { this._dayOfMonth = value; }
        }

        // Check to see if DayOfMonth property is set
        internal bool IsSetDayOfMonth()
        {
            return this._dayOfMonth != null;
        }

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of the week on which the scheduled audit takes place. Can be one of "SUN",
        /// "MON", "TUE", "WED", "THU", "FRI" or "SAT". This field is required if the "frequency"
        /// parameter is set to "WEEKLY" or "BIWEEKLY".
        /// </para>
        /// </summary>
        public DayOfWeek DayOfWeek
        {
            get { return this._dayOfWeek; }
            set { this._dayOfWeek = value; }
        }

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this._dayOfWeek != null;
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// How often the scheduled audit takes place. Can be one of "DAILY", "WEEKLY", "BIWEEKLY"
        /// or "MONTHLY". The actual start time of each audit is determined by the system.
        /// </para>
        /// </summary>
        public AuditFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledAuditName. 
        /// <para>
        /// The name you want to give to the scheduled audit. (Max. 128 chars)
        /// </para>
        /// </summary>
        public string ScheduledAuditName
        {
            get { return this._scheduledAuditName; }
            set { this._scheduledAuditName = value; }
        }

        // Check to see if ScheduledAuditName property is set
        internal bool IsSetScheduledAuditName()
        {
            return this._scheduledAuditName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCheckNames. 
        /// <para>
        /// Which checks are performed during the scheduled audit. Checks must be enabled for
        /// your account. (Use <code>DescribeAccountAuditConfiguration</code> to see the list
        /// of all checks including those that are enabled or <code>UpdateAccountAuditConfiguration</code>
        /// to select which checks are enabled.)
        /// </para>
        /// </summary>
        public List<string> TargetCheckNames
        {
            get { return this._targetCheckNames; }
            set { this._targetCheckNames = value; }
        }

        // Check to see if TargetCheckNames property is set
        internal bool IsSetTargetCheckNames()
        {
            return this._targetCheckNames != null && this._targetCheckNames.Count > 0; 
        }

    }
}