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
        private int? _checkpointDelay;
        private List<int> _checkpointPercentages = new List<int>();
        private int? _instanceWarmup;
        private int? _minHealthyPercentage;
        private bool? _skipMatching;

        /// <summary>
        /// Gets and sets the property CheckpointDelay. 
        /// <para>
        /// The amount of time, in seconds, to wait after a checkpoint before continuing. This
        /// property is optional, but if you specify a value for it, you must also specify a value
        /// for <code>CheckpointPercentages</code>. If you specify a value for <code>CheckpointPercentages</code>
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
        /// Threshold values for each checkpoint in ascending order. Each number must be unique.
        /// To replace all instances in the Auto Scaling group, the last number in the array must
        /// be <code>100</code>.
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
        /// The number of seconds until a newly launched instance is configured and ready to use.
        /// During this time, Amazon EC2 Auto Scaling does not immediately move on to the next
        /// replacement. The default is to use the value for the health check grace period defined
        /// for the group.
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
        /// The amount of capacity in the Auto Scaling group that must remain healthy during an
        /// instance refresh to allow the operation to continue. The value is expressed as a percentage
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
        /// Gets and sets the property SkipMatching. 
        /// <para>
        /// A boolean value that indicates whether skip matching is enabled. If true, then Amazon
        /// EC2 Auto Scaling skips replacing instances that match the desired configuration. If
        /// no desired configuration is specified, then it skips replacing instances that have
        /// the same configuration that is already set on the group. The default is <code>false</code>.
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

    }
}