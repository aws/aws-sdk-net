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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The returned scheduled action object.
    /// </summary>
    public partial class ScheduledActionResponse
    {
        private DateTime? _endTime;
        private string _namespaceName;
        private List<DateTime> _nextInvocations = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;
        private string _roleArn;
        private Schedule _schedule;
        private string _scheduledActionDescription;
        private string _scheduledActionName;
        private string _scheduledActionUuid;
        private DateTime? _startTime;
        private State _state;
        private TargetAction _targetAction;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of 
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The end time in UTC when the schedule is no longer active. After this time, the scheduled
        /// action does not trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property NextInvocations. 
        /// <para>
        /// An array of timestamps of when the next scheduled actions will trigger.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> NextInvocations
        {
            get { return this._nextInvocations; }
            set { this._nextInvocations = value; }
        }

        // Check to see if NextInvocations property is set
        internal bool IsSetNextInvocations()
        {
            return this._nextInvocations != null && (this._nextInvocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role to assume to run the scheduled action. This IAM role must
        /// have permission to run the Amazon Redshift Serverless API operation in the scheduled
        /// action. This IAM role must allow the Amazon Redshift scheduler to schedule creating
        /// snapshots. (Principal scheduler.redshift.amazonaws.com) to assume permissions on your
        /// behalf. For more information about the IAM role to use with the Amazon Redshift scheduler,
        /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html">Using
        /// Identity-Based Policies for Amazon Redshift</a> in the Amazon Redshift Management
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
        /// The description of the scheduled action.
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
        /// The name of the scheduled action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=60)]
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
        /// Gets and sets the property ScheduledActionUuid. 
        /// <para>
        /// The uuid of the scheduled action.
        /// </para>
        /// </summary>
        public string ScheduledActionUuid
        {
            get { return this._scheduledActionUuid; }
            set { this._scheduledActionUuid = value; }
        }

        // Check to see if ScheduledActionUuid property is set
        internal bool IsSetScheduledActionUuid()
        {
            return this._scheduledActionUuid != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time in UTC when the schedule is active. Before this time, the scheduled
        /// action does not trigger.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the scheduled action.
        /// </para>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
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