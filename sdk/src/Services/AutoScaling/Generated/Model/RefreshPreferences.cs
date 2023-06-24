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
    /// Describes the preferences for an instance refresh.
    /// </summary>
    public partial class RefreshPreferences
    {
        private bool? _autoRollback;
        private int? _checkpointDelay;
        private List<int> _checkpointPercentages = new List<int>();
        private int? _instanceWarmup;
        private int? _minHealthyPercentage;
        private ScaleInProtectedInstances _scaleInProtectedInstances;
        private bool? _skipMatching;
        private StandbyInstances _standbyInstances;

        /// <summary>
        /// Gets and sets the property AutoRollback. 
        /// <para>
        /// (Optional) Indicates whether to roll back the Auto Scaling group to its previous configuration
        /// if the instance refresh fails. The default is <code>false</code>.
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
        /// Manager parameter instead of an AMI ID for the <code>ImageId</code> property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Auto Scaling group uses the launch template's <code>$Latest</code> or <code>$Default</code>
        /// version.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool AutoRollback
        {
            get { return this._autoRollback.GetValueOrDefault(); }
            set { this._autoRollback = value; }
        }

        // Check to see if AutoRollback property is set
        internal bool IsSetAutoRollback()
        {
            return this._autoRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckpointDelay. 
        /// <para>
        /// (Optional) The amount of time, in seconds, to wait after a checkpoint before continuing.
        /// This property is optional, but if you specify a value for it, you must also specify
        /// a value for <code>CheckpointPercentages</code>. If you specify a value for <code>CheckpointPercentages</code>
        /// and not for <code>CheckpointDelay</code>, the <code>CheckpointDelay</code> defaults
        /// to <code>3600</code> (1 hour). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=172800)]
        public int CheckpointDelay
        {
            get { return this._checkpointDelay.GetValueOrDefault(); }
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
        /// the array must be <code>100</code>.
        /// </para>
        ///  
        /// <para>
        /// For usage examples, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-adding-checkpoints-instance-refresh.html">Adding
        /// checkpoints to an instance refresh</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public List<int> CheckpointPercentages
        {
            get { return this._checkpointPercentages; }
            set { this._checkpointPercentages = value; }
        }

        // Check to see if CheckpointPercentages property is set
        internal bool IsSetCheckpointPercentages()
        {
            return this._checkpointPercentages != null && this._checkpointPercentages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceWarmup. 
        /// <para>
        /// A time period, in seconds, during which an instance refresh waits before moving on
        /// to replacing the next instance after a new instance enters the <code>InService</code>
        /// state.
        /// </para>
        ///  
        /// <para>
        /// This property is not required for normal usage. Instead, use the <code>DefaultInstanceWarmup</code>
        /// property of the Auto Scaling group. The <code>InstanceWarmup</code> and <code>DefaultInstanceWarmup</code>
        /// properties work the same way. Only specify this property if you must override the
        /// <code>DefaultInstanceWarmup</code> property. 
        /// </para>
        ///  
        /// <para>
        ///  If you do not specify this property, the instance warmup by default is the value
        /// of the <code>DefaultInstanceWarmup</code> property, if defined (which is recommended
        /// in all cases), or the <code>HealthCheckGracePeriod</code> property otherwise.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int InstanceWarmup
        {
            get { return this._instanceWarmup.GetValueOrDefault(); }
            set { this._instanceWarmup = value; }
        }

        // Check to see if InstanceWarmup property is set
        internal bool IsSetInstanceWarmup()
        {
            return this._instanceWarmup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinHealthyPercentage. 
        /// <para>
        /// The amount of capacity in the Auto Scaling group that must pass your group's health
        /// checks to allow the operation to continue. The value is expressed as a percentage
        /// of the desired capacity of the Auto Scaling group (rounded up to the nearest integer).
        /// The default is <code>90</code>.
        /// </para>
        ///  
        /// <para>
        /// Setting the minimum healthy percentage to 100 percent limits the rate of replacement
        /// to one instance at a time. In contrast, setting it to 0 percent has the effect of
        /// replacing all instances at the same time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int MinHealthyPercentage
        {
            get { return this._minHealthyPercentage.GetValueOrDefault(); }
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
        /// (Optional) Indicates whether skip matching is enabled. If enabled (<code>true</code>),
        /// then Amazon EC2 Auto Scaling skips replacing instances that match the desired configuration.
        /// If no desired configuration is specified, then it skips replacing instances that have
        /// the same launch template and instance types that the Auto Scaling group was using
        /// before the start of the instance refresh. The default is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh-skip-matching.html">Use
        /// an instance refresh with skip matching</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool SkipMatching
        {
            get { return this._skipMatching.GetValueOrDefault(); }
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
        /// Choose the behavior that you want Amazon EC2 Auto Scaling to use if instances in <code>Standby</code>
        /// state are found.
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <dl> <dt>Terminate</dt> <dd> 
        /// <para>
        /// Amazon EC2 Auto Scaling terminates instances that are in <code>Standby</code>.
        /// </para>
        ///  </dd> <dt>Ignore</dt> <dd> 
        /// <para>
        /// Amazon EC2 Auto Scaling ignores instances that are in <code>Standby</code> and continues
        /// to replace instances that are in the <code>InService</code> state.
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