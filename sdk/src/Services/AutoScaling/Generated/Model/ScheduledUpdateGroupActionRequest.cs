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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes one or more scheduled scaling action updates for a specified Auto Scaling
    /// group. Used in combination with <a>BatchPutScheduledUpdateGroupAction</a>. 
    /// 
    ///  
    /// <para>
    /// When updating a scheduled scaling action, all optional parameters are left unchanged
    /// if not specified. 
    /// </para>
    /// </summary>
    public partial class ScheduledUpdateGroupActionRequest
    {
        private int? _desiredCapacity;
        private DateTime? _endTimeUtc;
        private int? _maxSize;
        private int? _minSize;
        private string _recurrence;
        private string _scheduledActionName;
        private DateTime? _startTimeUtc;

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The number of EC2 instances that should be running in the group.
        /// </para>
        /// </summary>
        public int DesiredCapacity
        {
            get { return this._desiredCapacity.GetValueOrDefault(); }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// The time for the recurring schedule to end. Amazon EC2 Auto Scaling does not perform
        /// the action after this time.
        /// </para>
        /// </summary>
        public DateTime EndTimeUtc
        {
            get { return this._endTimeUtc.GetValueOrDefault(); }
            set { this._endTime = this._endTimeUtc = value; }
        }

        // Check to see if EndTimeUtc property is set
        internal bool IsSetEndTimeUtc()
        {
            return this._endTimeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum size of the group.
        /// </para>
        /// </summary>
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum size of the group.
        /// </para>
        /// </summary>
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// The recurring schedule for the action, in Unix cron syntax format. For more information
        /// about this format, see <a href="http://crontab.org">Crontab</a>.
        /// </para>
        /// </summary>
        public string Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this._recurrence != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scaling action.
        /// </para>
        /// </summary>
        public string ScheduledActionName
        {
            get { return this._scheduledActionName; }
            set { this._scheduledActionName = value; }
        }

        // Check to see if ScheduledActionName property is set
        internal bool IsSetScheduledActionName()
        {
            return this._scheduledActionName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// The time for the action to start, in "YYYY-MM-DDThh:mm:ssZ" format in UTC/GMT only
        /// (for example, <code>2014-06-01T00:00:00Z</code>).
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>Recurrence</code> and <code>StartTime</code>, Amazon EC2 Auto
        /// Scaling performs the action at this time, and then performs the action based on the
        /// specified recurrence.
        /// </para>
        ///  
        /// <para>
        /// If you try to schedule the action in the past, Amazon EC2 Auto Scaling returns an
        /// error message.
        /// </para>
        /// </summary>
        public DateTime StartTimeUtc
        {
            get { return this._startTimeUtc.GetValueOrDefault(); }
            set { this._startTime = this._startTimeUtc = value; }
        }

        // Check to see if StartTimeUtc property is set
        internal bool IsSetStartTimeUtc()
        {
            return this._startTimeUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc
        /// results in both EndTime and EndTimeUtc being assigned, the latest assignment to either
        /// one of the two property is reflected in the value of both. EndTime is provided for
        /// backwards compatibility only and assigning a non-Utc DateTime to it results in the
        /// wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time for the recurring schedule to end. Amazon EC2 Auto Scaling does not perform
        /// the action after this time.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc results in both EndTime and " +
            "EndTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. EndTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set
            {
                this._endTime = value;
                this._endTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use StartTimeUtc instead. Setting either StartTime or
        /// StartTimeUtc results in both StartTime and StartTimeUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. StartTime
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time for the action to start, in "YYYY-MM-DDThh:mm:ssZ" format in UTC/GMT only
        /// (for example, <code>2014-06-01T00:00:00Z</code>).
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>Recurrence</code> and <code>StartTime</code>, Amazon EC2 Auto
        /// Scaling performs the action at this time, and then performs the action based on the
        /// specified recurrence.
        /// </para>
        ///  
        /// <para>
        /// If you try to schedule the action in the past, Amazon EC2 Auto Scaling returns an
        /// error message.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use StartTimeUtc instead. Setting either StartTime or StartTimeUtc results in both StartTime and " +
            "StartTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. StartTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set
            {
                this._startTime = value;
                this._startTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}