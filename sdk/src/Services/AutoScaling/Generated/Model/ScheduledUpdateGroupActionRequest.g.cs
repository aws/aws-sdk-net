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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes information used for one or more scheduled scaling action updates in a <a
    /// href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_BatchPutScheduledUpdateGroupAction.html">BatchPutScheduledUpdateGroupAction</a>
    /// operation.
    /// </summary>
    public partial class ScheduledUpdateGroupActionRequest
    {
        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity is the initial capacity of the Auto Scaling group after the scheduled
        /// action runs and the capacity it attempts to maintain.
        /// </para>
        /// </summary>
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCapacity property is set.
        /// </summary>
        internal bool IsSetDesiredCapacity() => this.DesiredCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time for the recurring schedule to end, in UTC.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum size of the Auto Scaling group.
        /// </para>
        /// </summary>
        public int? MaxSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxSize property is set.
        /// </summary>
        internal bool IsSetMaxSize() => this.MaxSize.HasValue;

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum size of the Auto Scaling group.
        /// </para>
        /// </summary>
        public int? MinSize { get; set; }

        /// <summary>
        /// Checks to see if the MinSize property is set.
        /// </summary>
        internal bool IsSetMinSize() => this.MinSize.HasValue;

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// The recurring schedule for the action, in Unix cron syntax format. This format consists
        /// of five fields separated by white spaces: [Minute] [Hour] [Day_of_Month] [Month_of_Year]
        /// [Day_of_Week]. The value must be in quotes (for example, <c>"30 0 1 1,6,12 *"</c>).
        /// For more information about this format, see <a href="http://crontab.org">Crontab</a>.
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
        [AWSProperty(Min = 1, Max = 255)]
        public string Recurrence { get; set; }

        /// <summary>
        /// Checks to see if the Recurrence property is set.
        /// </summary>
        internal bool IsSetRecurrence() => this.Recurrence != null;

        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scaling action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ScheduledActionName { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledActionName property is set.
        /// </summary>
        internal bool IsSetScheduledActionName() => this.ScheduledActionName != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time for the action to start, in YYYY-MM-DDThh:mm:ssZ format in UTC/GMT
        /// only and in quotes (for example, <c>"2019-06-01T00:00:00Z"</c>).
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>Recurrence</c> and <c>StartTime</c>, Amazon EC2 Auto Scaling performs
        /// the action at this time, and then performs the action based on the specified recurrence.
        /// </para>
        ///  
        /// <para>
        /// If you try to schedule the action in the past, Amazon EC2 Auto Scaling returns an
        /// error message.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

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
        [AWSProperty(Min = 1, Max = 255)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;
    }
}
