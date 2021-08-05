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
        /// Describes the specific update you want to deploy.
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
        ///  <code>Pending</code> - The request was created, but the operation has not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InProgress</code> - The operation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Successful</code> - The operation completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> - The operation failed to complete. You can troubleshoot using
        /// the status reason and the scaling activities. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelling</code> - An ongoing operation is being cancelled. Cancellation does
        /// not roll back any replacements that have already been completed, but it prevents new
        /// replacements from being started. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelled</code> - The operation is cancelled. 
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
        /// Provides more details about the current status of the instance refresh. 
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