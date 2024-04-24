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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about the scheduled audit.
    /// </summary>
    public partial class ScheduledAuditMetadata
    {
        private string _dayOfMonth;
        private DayOfWeek _dayOfWeek;
        private AuditFrequency _frequency;
        private string _scheduledAuditArn;
        private string _scheduledAuditName;

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month on which the scheduled audit is run (if the <c>frequency</c>
        /// is "MONTHLY"). If days 29-31 are specified, and the month does not have that many
        /// days, the audit takes place on the "LAST" day of the month.
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
        /// The day of the week on which the scheduled audit is run (if the <c>frequency</c> is
        /// "WEEKLY" or "BIWEEKLY").
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
        /// How often the scheduled audit occurs.
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
        /// Gets and sets the property ScheduledAuditArn. 
        /// <para>
        /// The ARN of the scheduled audit.
        /// </para>
        /// </summary>
        public string ScheduledAuditArn
        {
            get { return this._scheduledAuditArn; }
            set { this._scheduledAuditArn = value; }
        }

        // Check to see if ScheduledAuditArn property is set
        internal bool IsSetScheduledAuditArn()
        {
            return this._scheduledAuditArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledAuditName. 
        /// <para>
        /// The name of the scheduled audit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}