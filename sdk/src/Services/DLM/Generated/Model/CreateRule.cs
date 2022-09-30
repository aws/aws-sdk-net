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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Snapshot and AMI policies only]</b> Specifies when the policy should create snapshots
    /// or AMIs.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// You must specify either <b>CronExpression</b>, or <b>Interval</b>, <b>IntervalUnit</b>,
    /// and <b>Times</b>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you need to specify an <a>ArchiveRule</a> for the schedule, then you must specify
    /// a creation frequency of at least 28 days.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateRule
    {
        private string _cronExpression;
        private int? _interval;
        private IntervalUnitValues _intervalUnit;
        private LocationValues _location;
        private List<string> _times = new List<string>();

        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The schedule, as a Cron expression. The schedule interval must be between 1 hour and
        /// 1 year. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html#CronExpressions">Cron
        /// expressions</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=17, Max=106)]
        public string CronExpression
        {
            get { return this._cronExpression; }
            set { this._cronExpression = value; }
        }

        // Check to see if CronExpression property is set
        internal bool IsSetCronExpression()
        {
            return this._cronExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval between snapshots. The supported values are 1, 2, 3, 4, 6, 8, 12, and
        /// 24.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Interval
        {
            get { return this._interval.GetValueOrDefault(); }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalUnit. 
        /// <para>
        /// The interval unit.
        /// </para>
        /// </summary>
        public IntervalUnitValues IntervalUnit
        {
            get { return this._intervalUnit; }
            set { this._intervalUnit = value; }
        }

        // Check to see if IntervalUnit property is set
        internal bool IsSetIntervalUnit()
        {
            return this._intervalUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  <b>[Snapshot policies only]</b> Specifies the destination for snapshots created by
        /// the policy. To create snapshots in the same Region as the source resource, specify
        /// <code>CLOUD</code>. To create snapshots on the same Outpost as the source resource,
        /// specify <code>OUTPOST_LOCAL</code>. If you omit this parameter, <code>CLOUD</code>
        /// is used by default.
        /// </para>
        ///  
        /// <para>
        /// If the policy targets resources in an Amazon Web Services Region, then you must create
        /// snapshots in the same Region as the source resource. If the policy targets resources
        /// on an Outpost, then you can create snapshots on the same Outpost as the source resource,
        /// or in the Region of that Outpost.
        /// </para>
        /// </summary>
        public LocationValues Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Times. 
        /// <para>
        /// The time, in UTC, to start the operation. The supported format is hh:mm.
        /// </para>
        ///  
        /// <para>
        /// The operation occurs within a one-hour window following the specified time. If you
        /// do not specify a time, Amazon Data Lifecycle Manager selects a time within the next
        /// 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> Times
        {
            get { return this._times; }
            set { this._times = value; }
        }

        // Check to see if Times property is set
        internal bool IsSetTimes()
        {
            return this._times != null && this._times.Count > 0; 
        }

    }
}