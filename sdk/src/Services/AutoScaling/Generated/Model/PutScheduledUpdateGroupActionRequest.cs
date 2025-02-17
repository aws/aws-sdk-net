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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutScheduledUpdateGroupAction operation.
    /// Creates or updates a scheduled scaling action for an Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-scheduled-scaling.html">Scheduled
    /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can view the scheduled actions for an Auto Scaling group using the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeScheduledActions.html">DescribeScheduledActions</a>
    /// API call. If you are no longer using a scheduled action, you can delete it by calling
    /// the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DeleteScheduledAction.html">DeleteScheduledAction</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// If you try to schedule your action in the past, Amazon EC2 Auto Scaling returns an
    /// error message.
    /// </para>
    /// </summary>
    public partial class PutScheduledUpdateGroupActionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private int? _desiredCapacity;
        private DateTime? _endTimeUtc;
        private int? _maxSize;
        private int? _minSize;
        private string _recurrence;
        private string _scheduledActionName;
        private DateTime? _startTimeUtc;
        private DateTime? _timeUtc;
        private string _timeZone;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity is the initial capacity of the Auto Scaling group after the scheduled
        /// action runs and the capacity it attempts to maintain. It can scale beyond this capacity
        /// if you add more scaling conditions. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify at least one of the following properties: <c>MaxSize</c>, <c>MinSize</c>,
        /// or <c>DesiredCapacity</c>. 
        /// </para>
        ///  </note>
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
        /// The date and time for the recurring schedule to end, in UTC. For example, <c>"2021-06-01T00:00:00Z"</c>.
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
        /// The maximum size of the Auto Scaling group.
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
        /// The minimum size of the Auto Scaling group.
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
        /// The recurring schedule for this action. This format consists of five fields separated
        /// by white spaces: [Minute] [Hour] [Day_of_Month] [Month_of_Year] [Day_of_Week]. The
        /// value must be in quotes (for example, <c>"30 0 1 1,6,12 *"</c>). For more information
        /// about this format, see <a href="http://crontab.org">Crontab</a>.
        /// </para>
        ///  
        /// <para>
        /// When <c>StartTime</c> and <c>EndTime</c> are specified with <c>Recurrence</c>, they
        /// form the boundaries of when the recurring action starts and stops.
        /// </para>
        ///  
        /// <para>
        /// Cron expressions use Universal Coordinated Time (UTC) by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The name of this scaling action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The date and time for this action to start, in YYYY-MM-DDThh:mm:ssZ format in UTC/GMT
        /// only and in quotes (for example, <c>"2021-06-01T00:00:00Z"</c>).
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>Recurrence</c> and <c>StartTime</c>, Amazon EC2 Auto Scaling performs
        /// the action at this time, and then performs the action based on the specified recurrence.
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

        /// <summary>
        /// Gets and sets the property TimeUtc. 
        /// <para>
        /// This property is no longer used.
        /// </para>
        /// </summary>
        public DateTime TimeUtc
        {
            get { return this._timeUtc.GetValueOrDefault(); }
            set { this._time = this._timeUtc = value; }
        }

        // Check to see if TimeUtc property is set
        internal bool IsSetTimeUtc()
        {
            return this._timeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// Specifies the time zone for a cron expression. If a time zone is not provided, UTC
        /// is used by default. 
        /// </para>
        ///  
        /// <para>
        /// Valid values are the canonical names of the IANA time zones, derived from the IANA
        /// Time Zone Database (such as <c>Etc/GMT+9</c> or <c>Pacific/Tahiti</c>). For more information,
        /// see <a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">https://en.wikipedia.org/wiki/List_of_tz_database_time_zones</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

#region Backwards compatible properties
        private DateTime? _endTime;
        private DateTime? _startTime;
        private DateTime? _time;

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
        /// The date and time for the recurring schedule to end, in UTC. For example, <c>"2021-06-01T00:00:00Z"</c>.
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
        /// The date and time for this action to start, in YYYY-MM-DDThh:mm:ssZ format in UTC/GMT
        /// only and in quotes (for example, <c>"2021-06-01T00:00:00Z"</c>).
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>Recurrence</c> and <c>StartTime</c>, Amazon EC2 Auto Scaling performs
        /// the action at this time, and then performs the action based on the specified recurrence.
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
        /// <summary>
        /// Gets and sets the property TimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use TimeUtc instead. Setting either Time or TimeUtc results
        /// in both Time and TimeUtc being assigned, the latest assignment to either one of the
        /// two property is reflected in the value of both. Time is provided for backwards compatibility
        /// only and assigning a non-Utc DateTime to it results in the wrong timestamp being passed
        /// to the service.
        /// </para>
        ///  
        /// <para>
        /// This property is no longer used.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use TimeUtc instead. Setting either Time or TimeUtc results in both Time and " +
            "TimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. Time is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime Time
        {
            get { return this._time.GetValueOrDefault(); }
            set
            {
                this._time = value;
                this._timeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}