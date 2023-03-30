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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an instance refresh for an Auto Scaling group.
    /// </summary>
    public partial class InstanceRefresh
    {
        private string _autoScalingGroupName;
        private DesiredConfiguration _desiredConfiguration;
        private DateTime? _endTime;
        private string _instanceRefreshId;
        private int? _instancesToUpdate;
        private int? _percentageComplete;
        private RefreshPreferences _preferences;
        private InstanceRefreshProgressDetails _progressDetails;
        private RollbackDetails _rollbackDetails;
        private DateTime? _startTime;
        private InstanceRefreshStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property DesiredConfiguration. 
        /// <para>
        /// Describes the desired configuration for the instance refresh.
        /// </para>
        /// </summary>
        public DesiredConfiguration DesiredConfiguration
        {
            get { return this._desiredConfiguration; }
            set { this._desiredConfiguration = value; }
        }

        // Check to see if DesiredConfiguration property is set
        internal bool IsSetDesiredConfiguration()
        {
            return this._desiredConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time at which the instance refresh ended.
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
        /// Gets and sets the property InstanceRefreshId. 
        /// <para>
        /// The instance refresh ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InstanceRefreshId
        {
            get { return this._instanceRefreshId; }
            set { this._instanceRefreshId = value; }
        }

        // Check to see if InstanceRefreshId property is set
        internal bool IsSetInstanceRefreshId()
        {
            return this._instanceRefreshId != null;
        }

        /// <summary>
        /// Gets and sets the property InstancesToUpdate. 
        /// <para>
        /// The number of instances remaining to update before the instance refresh is complete.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you roll back the instance refresh, <code>InstancesToUpdate</code> shows you the
        /// number of instances that were not yet updated by the instance refresh. Therefore,
        /// these instances don't need to be replaced as part of the rollback.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public int InstancesToUpdate
        {
            get { return this._instancesToUpdate.GetValueOrDefault(); }
            set { this._instancesToUpdate = value; }
        }

        // Check to see if InstancesToUpdate property is set
        internal bool IsSetInstancesToUpdate()
        {
            return this._instancesToUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentageComplete. 
        /// <para>
        /// The percentage of the instance refresh that is complete. For each instance replacement,
        /// Amazon EC2 Auto Scaling tracks the instance's health status and warm-up time. When
        /// the instance's health status changes to healthy and the specified warm-up time passes,
        /// the instance is considered updated and is added to the percentage complete.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>PercentageComplete</code> does not include instances that are replaced during
        /// a rollback. This value gradually goes back down to zero during a rollback.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int PercentageComplete
        {
            get { return this._percentageComplete.GetValueOrDefault(); }
            set { this._percentageComplete = value; }
        }

        // Check to see if PercentageComplete property is set
        internal bool IsSetPercentageComplete()
        {
            return this._percentageComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Preferences. 
        /// <para>
        /// The preferences for an instance refresh.
        /// </para>
        /// </summary>
        public RefreshPreferences Preferences
        {
            get { return this._preferences; }
            set { this._preferences = value; }
        }

        // Check to see if Preferences property is set
        internal bool IsSetPreferences()
        {
            return this._preferences != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressDetails. 
        /// <para>
        /// Additional progress details for an Auto Scaling group that has a warm pool.
        /// </para>
        /// </summary>
        public InstanceRefreshProgressDetails ProgressDetails
        {
            get { return this._progressDetails; }
            set { this._progressDetails = value; }
        }

        // Check to see if ProgressDetails property is set
        internal bool IsSetProgressDetails()
        {
            return this._progressDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackDetails. 
        /// <para>
        /// The rollback details.
        /// </para>
        /// </summary>
        public RollbackDetails RollbackDetails
        {
            get { return this._rollbackDetails; }
            set { this._rollbackDetails = value; }
        }

        // Check to see if RollbackDetails property is set
        internal bool IsSetRollbackDetails()
        {
            return this._rollbackDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time at which the instance refresh began.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status for the instance refresh operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Pending</code> - The request was created, but the instance refresh has not
        /// started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InProgress</code> - An instance refresh is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Successful</code> - An instance refresh completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> - An instance refresh failed to complete. You can troubleshoot
        /// using the status reason and the scaling activities. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelling</code> - An ongoing instance refresh is being cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelled</code> - The instance refresh is cancelled. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RollbackInProgress</code> - An instance refresh is being rolled back.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RollbackFailed</code> - The rollback failed to complete. You can troubleshoot
        /// using the status reason and the scaling activities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RollbackSuccessful</code> - The rollback completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceRefreshStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The explanation for the specific status assigned to this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1023)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}