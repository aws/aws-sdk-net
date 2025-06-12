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
    /// Describes a scheduled action. You can use a scheduled action to trigger some Amazon
    /// Redshift API operations on a schedule. For information about which API operations
    /// can be scheduled, see <a>ScheduledActionType</a>.
    /// </summary>
    public partial class ModifyScheduledActionResponse : AmazonWebServiceResponse
    {
        private DateTime? _endTime;
        private string _iamRole;
        private List<DateTime> _nextInvocations = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;
        private string _schedule;
        private string _scheduledActionDescription;
        private string _scheduledActionName;
        private DateTime? _startTime;
        private ScheduledActionState _state;
        private ScheduledActionType _targetAction;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time in UTC when the schedule is no longer active. After this time, the scheduled
        /// action does not trigger. 
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
        /// The IAM role to assume to run the scheduled action. This IAM role must have permission
        /// to run the Amazon Redshift API operation in the scheduled action. This IAM role must
        /// allow the Amazon Redshift scheduler (Principal scheduler.redshift.amazonaws.com) to
        /// assume permissions on your behalf. For more information about the IAM role to use
        /// with the Amazon Redshift scheduler, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html">Using
        /// Identity-Based Policies for Amazon Redshift</a> in the <i>Amazon Redshift Cluster
        /// Management Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property NextInvocations. 
        /// <para>
        /// List of times when the scheduled action will run. 
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
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule for a one-time (at format) or recurring (cron format) scheduled action.
        /// Schedule invocations must be separated by at least one hour.
        /// </para>
        ///  
        /// <para>
        /// Format of at expressions is "<c>at(yyyy-mm-ddThh:mm:ss)</c>". For example, "<c>at(2016-03-04T17:27:00)</c>".
        /// </para>
        ///  
        /// <para>
        /// Format of cron expressions is "<c>cron(Minutes Hours Day-of-month Month Day-of-week
        /// Year)</c>". For example, "<c>cron(0 10 ? * MON *)</c>". For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html#CronExpressions">Cron
        /// Expressions</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The name of the scheduled action. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The state of the scheduled action. For example, <c>DISABLED</c>. 
        /// </para>
        /// </summary>
        public ScheduledActionState State
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
        /// <para>
        /// A JSON format string of the Amazon Redshift API operation with input parameters. 
        /// </para>
        ///  
        /// <para>
        /// "<c>{\"ResizeCluster\":{\"NodeType\":\"ra3.4xlarge\",\"ClusterIdentifier\":\"my-test-cluster\",\"NumberOfNodes\":3}}</c>".
        /// 
        /// </para>
        /// </summary>
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