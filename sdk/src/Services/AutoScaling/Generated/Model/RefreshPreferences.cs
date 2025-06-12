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
    /// Describes the preferences for an instance refresh.
    /// </summary>
    public partial class RefreshPreferences
    {
        private AlarmSpecification _alarmSpecification;
        private bool? _autoRollback;
        private int? _bakeTime;
        private int? _checkpointDelay;
        private List<int> _checkpointPercentages = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _instanceWarmup;
        private int? _maxHealthyPercentage;
        private int? _minHealthyPercentage;
        private ScaleInProtectedInstances _scaleInProtectedInstances;
        private bool? _skipMatching;
        private StandbyInstances _standbyInstances;

        /// <summary>
        /// Gets and sets the property AlarmSpecification. 
        /// <para>
        /// (Optional) The CloudWatch alarm specification. CloudWatch alarms can be used to identify
        /// any issues and fail the operation if an alarm threshold is met.
        /// </para>
        /// </summary>
        public AlarmSpecification AlarmSpecification
        {
            get { return this._alarmSpecification; }
            set { this._alarmSpecification = value; }
        }

        // Check to see if AlarmSpecification property is set
        internal bool IsSetAlarmSpecification()
        {
            return this._alarmSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property AutoRollback. 
        /// <para>
        /// (Optional) Indicates whether to roll back the Auto Scaling group to its previous configuration
        /// if the instance refresh fails or a CloudWatch alarm threshold is met. The default
        /// is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// A rollback is not supported in the following situations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is no desired configuration specified for the instance refresh.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Auto Scaling group has a launch template that uses an Amazon Web Services Systems
        /// Manager parameter instead of an AMI ID for the <c>ImageId</c> property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Auto Scaling group uses the launch template's <c>$Latest</c> or <c>$Default</c>
        /// version.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/instance-refresh-rollback.html">Undo
        /// changes with a rollback</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool? AutoRollback
        {
            get { return this._autoRollback; }
            set { this._autoRollback = value; }
        }

        // Check to see if AutoRollback property is set
        internal bool IsSetAutoRollback()
        {
            return this._autoRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BakeTime. 
        /// <para>
        ///  The amount of time, in seconds, to wait at the end of an instance refresh before
        /// the instance refresh is considered complete. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=172800)]
        public int? BakeTime
        {
            get { return this._bakeTime; }
            set { this._bakeTime = value; }
        }

        // Check to see if BakeTime property is set
        internal bool IsSetBakeTime()
        {
            return this._bakeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckpointDelay. 
        /// <para>
        /// (Optional) The amount of time, in seconds, to wait after a checkpoint before continuing.
        /// This property is optional, but if you specify a value for it, you must also specify
        /// a value for <c>CheckpointPercentages</c>. If you specify a value for <c>CheckpointPercentages</c>
        /// and not for <c>CheckpointDelay</c>, the <c>CheckpointDelay</c> defaults to <c>3600</c>
        /// (1 hour). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=172800)]
        public int? CheckpointDelay
        {
            get { return this._checkpointDelay; }
            set { this._checkpointDelay = value; }
        }

        // Check to see if CheckpointDelay property is set
        internal bool IsSetCheckpointDelay()
        {
            return this._checkpointDelay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckpointPercentages. 
        /// <para>
        /// (Optional) Threshold values for each checkpoint in ascending order. Each number must
        /// be unique. To replace all instances in the Auto Scaling group, the last number in
        /// the array must be <c>100</c>.
        /// </para>
        ///  
        /// <para>
        /// For usage examples, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-adding-checkpoints-instance-refresh.html">Add
        /// checkpoints to an instance refresh</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> CheckpointPercentages
        {
            get { return this._checkpointPercentages; }
            set { this._checkpointPercentages = value; }
        }

        // Check to see if CheckpointPercentages property is set
        internal bool IsSetCheckpointPercentages()
        {
            return this._checkpointPercentages != null && (this._checkpointPercentages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceWarmup. 
        /// <para>
        /// A time period, in seconds, during which an instance refresh waits before moving on
        /// to replacing the next instance after a new instance enters the <c>InService</c> state.
        /// </para>
        ///  
        /// <para>
        /// This property is not required for normal usage. Instead, use the <c>DefaultInstanceWarmup</c>
        /// property of the Auto Scaling group. The <c>InstanceWarmup</c> and <c>DefaultInstanceWarmup</c>
        /// properties work the same way. Only specify this property if you must override the
        /// <c>DefaultInstanceWarmup</c> property. 
        /// </para>
        ///  
        /// <para>
        ///  If you do not specify this property, the instance warmup by default is the value
        /// of the <c>DefaultInstanceWarmup</c> property, if defined (which is recommended in
        /// all cases), or the <c>HealthCheckGracePeriod</c> property otherwise.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? InstanceWarmup
        {
            get { return this._instanceWarmup; }
            set { this._instanceWarmup = value; }
        }

        // Check to see if InstanceWarmup property is set
        internal bool IsSetInstanceWarmup()
        {
            return this._instanceWarmup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxHealthyPercentage. 
        /// <para>
        /// Specifies the maximum percentage of the group that can be in service and healthy,
        /// or pending, to support your workload when replacing instances. The value is expressed
        /// as a percentage of the desired capacity of the Auto Scaling group. Value range is
        /// 100 to 200.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>MaxHealthyPercentage</c>, you must also specify <c>MinHealthyPercentage</c>,
        /// and the difference between them cannot be greater than 100. A larger range increases
        /// the number of instances that can be replaced at the same time.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this property, the default is 100 percent, or the percentage
        /// set in the instance maintenance policy for the Auto Scaling group, if defined.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=200)]
        public int? MaxHealthyPercentage
        {
            get { return this._maxHealthyPercentage; }
            set { this._maxHealthyPercentage = value; }
        }

        // Check to see if MaxHealthyPercentage property is set
        internal bool IsSetMaxHealthyPercentage()
        {
            return this._maxHealthyPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinHealthyPercentage. 
        /// <para>
        /// Specifies the minimum percentage of the group to keep in service, healthy, and ready
        /// to use to support your workload to allow the operation to continue. The value is expressed
        /// as a percentage of the desired capacity of the Auto Scaling group. Value range is
        /// 0 to 100.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this property, the default is 90 percent, or the percentage
        /// set in the instance maintenance policy for the Auto Scaling group, if defined.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MinHealthyPercentage
        {
            get { return this._minHealthyPercentage; }
            set { this._minHealthyPercentage = value; }
        }

        // Check to see if MinHealthyPercentage property is set
        internal bool IsSetMinHealthyPercentage()
        {
            return this._minHealthyPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleInProtectedInstances. 
        /// <para>
        /// Choose the behavior that you want Amazon EC2 Auto Scaling to use if instances protected
        /// from scale in are found. 
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <dl> <dt>Refresh</dt> <dd> 
        /// <para>
        /// Amazon EC2 Auto Scaling replaces instances that are protected from scale in.
        /// </para>
        ///  </dd> <dt>Ignore</dt> <dd> 
        /// <para>
        /// Amazon EC2 Auto Scaling ignores instances that are protected from scale in and continues
        /// to replace instances that are not protected.
        /// </para>
        ///  </dd> <dt>Wait (default)</dt> <dd> 
        /// <para>
        /// Amazon EC2 Auto Scaling waits one hour for you to remove scale-in protection. Otherwise,
        /// the instance refresh will fail.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ScaleInProtectedInstances ScaleInProtectedInstances
        {
            get { return this._scaleInProtectedInstances; }
            set { this._scaleInProtectedInstances = value; }
        }

        // Check to see if ScaleInProtectedInstances property is set
        internal bool IsSetScaleInProtectedInstances()
        {
            return this._scaleInProtectedInstances != null;
        }

        /// <summary>
        /// Gets and sets the property SkipMatching. 
        /// <para>
        /// (Optional) Indicates whether skip matching is enabled. If enabled (<c>true</c>), then
        /// Amazon EC2 Auto Scaling skips replacing instances that match the desired configuration.
        /// If no desired configuration is specified, then it skips replacing instances that have
        /// the same launch template and instance types that the Auto Scaling group was using
        /// before the start of the instance refresh. The default is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh-skip-matching.html">Use
        /// an instance refresh with skip matching</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool? SkipMatching
        {
            get { return this._skipMatching; }
            set { this._skipMatching = value; }
        }

        // Check to see if SkipMatching property is set
        internal bool IsSetSkipMatching()
        {
            return this._skipMatching.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StandbyInstances. 
        /// <para>
        /// Choose the behavior that you want Amazon EC2 Auto Scaling to use if instances in <c>Standby</c>
        /// state are found.
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <dl> <dt>Terminate</dt> <dd> 
        /// <para>
        /// Amazon EC2 Auto Scaling terminates instances that are in <c>Standby</c>.
        /// </para>
        ///  </dd> <dt>Ignore</dt> <dd> 
        /// <para>
        /// Amazon EC2 Auto Scaling ignores instances that are in <c>Standby</c> and continues
        /// to replace instances that are in the <c>InService</c> state.
        /// </para>
        ///  </dd> <dt>Wait (default)</dt> <dd> 
        /// <para>
        /// Amazon EC2 Auto Scaling waits one hour for you to return the instances to service.
        /// Otherwise, the instance refresh will fail.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public StandbyInstances StandbyInstances
        {
            get { return this._standbyInstances; }
            set { this._standbyInstances = value; }
        }

        // Check to see if StandbyInstances property is set
        internal bool IsSetStandbyInstances()
        {
            return this._standbyInstances != null;
        }

    }
}