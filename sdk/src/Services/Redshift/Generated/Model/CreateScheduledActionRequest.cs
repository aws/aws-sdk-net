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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScheduledAction operation.
    /// Creates a scheduled action. A scheduled action contains a schedule and an Amazon Redshift
    /// API action. For example, you can create a schedule of when to run the <c>ResizeCluster</c>
    /// API operation.
    /// </summary>
    public partial class CreateScheduledActionRequest : AmazonRedshiftRequest
    {
        private bool? _enable;
        private DateTime? _endTime;
        private string _iamRole;
        private string _schedule;
        private string _scheduledActionDescription;
        private string _scheduledActionName;
        private DateTime? _startTime;
        private ScheduledActionType _targetAction;

        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// If true, the schedule is enabled. If false, the scheduled action does not trigger.
        /// For more information about <c>state</c> of the scheduled action, see <a>ScheduledAction</a>.
        /// 
        /// </para>
        /// </summary>
        public bool? Enable
        {
            get { return this._enable; }
            set { this._enable = value; }
        }

        // Check to see if Enable property is set
        internal bool IsSetEnable()
        {
            return this._enable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time in UTC of the scheduled action. After this time, the scheduled action
        /// does not trigger. For more information about this parameter, see <a>ScheduledAction</a>.
        /// 
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
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role to assume to run the target action. For more information about this parameter,
        /// see <a>ScheduledAction</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule in <c>at( )</c> or <c>cron( )</c> format. For more information about
        /// this parameter, see <a>ScheduledAction</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string Schedule
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
        [AWSProperty(Max=2147483647)]
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
        /// The name of the scheduled action. The name must be unique within an account. For more
        /// information about this parameter, see <a>ScheduledAction</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// The start time in UTC of the scheduled action. Before this time, the scheduled action
        /// does not trigger. For more information about this parameter, see <a>ScheduledAction</a>.
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
        /// Gets and sets the property TargetAction. 
        /// <para>
        /// A JSON format string of the Amazon Redshift API operation with input parameters. For
        /// more information about this parameter, see <a>ScheduledAction</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledActionType TargetAction
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