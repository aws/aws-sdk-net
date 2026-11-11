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
    /// Describes an instance refresh for an Auto Scaling group.
    /// </summary>
    public partial class InstanceRefresh
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property DesiredConfiguration. 
        /// <para>
        /// Describes the desired configuration for the instance refresh.
        /// </para>
        /// </summary>
        public DesiredConfiguration DesiredConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DesiredConfiguration property is set.
        /// </summary>
        internal bool IsSetDesiredConfiguration() => this.DesiredConfiguration != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time at which the instance refresh ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceRefreshId. 
        /// <para>
        /// The instance refresh ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string InstanceRefreshId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRefreshId property is set.
        /// </summary>
        internal bool IsSetInstanceRefreshId() => this.InstanceRefreshId != null;

        /// <summary>
        /// Gets and sets the property InstancesToUpdate. 
        /// <para>
        /// The number of instances remaining to update before the instance refresh is complete.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you roll back the instance refresh, <c>InstancesToUpdate</c> shows you the number
        /// of instances that were not yet updated by the instance refresh. Therefore, these instances
        /// don't need to be replaced as part of the rollback.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? InstancesToUpdate { get; set; }

        /// <summary>
        /// Checks to see if the InstancesToUpdate property is set.
        /// </summary>
        internal bool IsSetInstancesToUpdate() => this.InstancesToUpdate.HasValue;

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
        ///  <c>PercentageComplete</c> does not include instances that are replaced during a rollback.
        /// This value gradually goes back down to zero during a rollback.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? PercentageComplete { get; set; }

        /// <summary>
        /// Checks to see if the PercentageComplete property is set.
        /// </summary>
        internal bool IsSetPercentageComplete() => this.PercentageComplete.HasValue;

        /// <summary>
        /// Gets and sets the property Preferences. 
        /// <para>
        /// The preferences for an instance refresh.
        /// </para>
        /// </summary>
        public RefreshPreferences Preferences { get; set; }

        /// <summary>
        /// Checks to see if the Preferences property is set.
        /// </summary>
        internal bool IsSetPreferences() => this.Preferences != null;

        /// <summary>
        /// Gets and sets the property ProgressDetails. 
        /// <para>
        /// Additional progress details for an Auto Scaling group that has a warm pool.
        /// </para>
        /// </summary>
        public InstanceRefreshProgressDetails ProgressDetails { get; set; }

        /// <summary>
        /// Checks to see if the ProgressDetails property is set.
        /// </summary>
        internal bool IsSetProgressDetails() => this.ProgressDetails != null;

        /// <summary>
        /// Gets and sets the property RollbackDetails. 
        /// <para>
        /// The rollback details.
        /// </para>
        /// </summary>
        public RollbackDetails RollbackDetails { get; set; }

        /// <summary>
        /// Checks to see if the RollbackDetails property is set.
        /// </summary>
        internal bool IsSetRollbackDetails() => this.RollbackDetails != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time at which the instance refresh began.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status for the instance refresh operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Pending</c> - The request was created, but the instance refresh has not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c> - An instance refresh is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Successful</c> - An instance refresh completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - An instance refresh failed to complete. You can troubleshoot using
        /// the status reason and the scaling activities. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Cancelling</c> - An ongoing instance refresh is being cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Cancelled</c> - The instance refresh is cancelled. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RollbackInProgress</c> - An instance refresh is being rolled back.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RollbackFailed</c> - The rollback failed to complete. You can troubleshoot using
        /// the status reason and the scaling activities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RollbackSuccessful</c> - The rollback completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Baking</c> - Waiting the specified bake time after an instance refresh has finished
        /// updating instances.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceRefreshStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The explanation for the specific status assigned to this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1023)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        ///  The strategy to use for the instance refresh. This determines how instances in the
        /// Auto Scaling group are updated. Default is Rolling. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Rolling</c> – Terminates instances and launches replacements in batches
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReplaceRootVolume</c> – Updates instances by replacing only the root volume without
        /// terminating the instance
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RefreshStrategy Strategy { get; set; }

        /// <summary>
        /// Checks to see if the Strategy property is set.
        /// </summary>
        internal bool IsSetStrategy() => this.Strategy != null;
    }
}
