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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScheduledAction operation.
    /// Updates a scheduled action.
    /// </summary>
    public partial class UpdateScheduledActionRequest : AmazonRedshiftServerlessRequest
    {
        private bool? _enabled;
        private DateTime? _endTime;
        private string _roleArn;
        private Schedule _schedule;
        private string _scheduledActionDescription;
        private string _scheduledActionName;
        private DateTime? _startTime;
        private TargetAction _targetAction;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable the scheduled action.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time in UTC of the scheduled action to update.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role to assume to run the scheduled action. This IAM role must
        /// have permission to run the Amazon Redshift Serverless API operation in the scheduled
        /// action. This IAM role must allow the Amazon Redshift scheduler to schedule creating
        /// snapshots (Principal scheduler.redshift.amazonaws.com) to assume permissions on your
        /// behalf. For more information about the IAM role to use with the Amazon Redshift scheduler,
        /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html">Using
        /// Identity-Based Policies for Amazon Redshift</a> in the Amazon Redshift Cluster Management
        /// Guide
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule for a one-time (at timestamp format) or recurring (cron format) scheduled
        /// action. Schedule invocations must be separated by at least one hour. Times are in
        /// UTC.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format of at timestamp is <c>yyyy-mm-ddThh:mm:ss</c>. For example, <c>2016-03-04T17:27:00</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Format of cron expression is <c>(Minutes Hours Day-of-month Month Day-of-week Year)</c>.
        /// For example, <c>"(0 10 ? * MON *)"</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html#CronExpressions">Cron
        /// Expressions</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledActionDescription. 
        /// <para>
        /// The descripion of the scheduled action to update to.
        /// </para>
        /// </summary>
        public string ScheduledActionDescription
        {
            get { return this._scheduledActionDescription; }
            set { this._scheduledActionDescription = value; }
        }

        // Check to see if ScheduledActionDescription property is set
        internal bool IsSetScheduledActionDescription()
        {
            return this._scheduledActionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scheduled action to update to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=60)]
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time in UTC of the scheduled action to update to.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetAction.
        /// </summary>
        public TargetAction TargetAction
        {
            get { return this._targetAction; }
            set { this._targetAction = value; }
        }

        // Check to see if TargetAction property is set
        internal bool IsSetTargetAction()
        {
            return this._targetAction != null;
        }

    }
}