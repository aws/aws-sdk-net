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
    /// Container for the parameters to the StartInstanceRefresh operation.
    /// Starts an instance refresh. During an instance refresh, Amazon EC2 Auto Scaling performs
    /// a rolling update of instances in an Auto Scaling group. Instances are terminated first
    /// and then replaced, which temporarily reduces the capacity available within your Auto
    /// Scaling group.
    /// 
    ///  
    /// <para>
    /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
    /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
    /// your Auto Scaling group. This feature is helpful, for example, when you have a new
    /// AMI or a new user data script. You just need to create a new launch template that
    /// specifies the new AMI or user data script. Then start an instance refresh to immediately
    /// begin the process of updating instances in the group. 
    /// </para>
    ///  
    /// <para>
    /// If successful, the request's response contains a unique ID that you can use to track
    /// the progress of the instance refresh. To query its status, call the <a>DescribeInstanceRefreshes</a>
    /// API. To describe the instance refreshes that have already run, call the <a>DescribeInstanceRefreshes</a>
    /// API. To cancel an instance refresh that is in progress, use the <a>CancelInstanceRefresh</a>
    /// API. 
    /// </para>
    ///  
    /// <para>
    /// An instance refresh might fail for several reasons, such as EC2 launch failures, misconfigured
    /// health checks, or not ignoring or allowing the termination of instances that are in
    /// <code>Standby</code> state or protected from scale in. You can monitor for failed
    /// EC2 launches using the scaling activities. To find the scaling activities, call the
    /// <a>DescribeScalingActivities</a> API.
    /// </para>
    ///  
    /// <para>
    /// If you enable auto rollback, your Auto Scaling group will be rolled back automatically
    /// when the instance refresh fails. You can enable this feature before starting an instance
    /// refresh by specifying the <code>AutoRollback</code> property in the instance refresh
    /// preferences. Otherwise, to roll back an instance refresh before it finishes, use the
    /// <a>RollbackInstanceRefresh</a> API. 
    /// </para>
    /// </summary>
    public partial class StartInstanceRefreshRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private DesiredConfiguration _desiredConfiguration;
        private RefreshPreferences _preferences;
        private RefreshStrategy _strategy;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The desired configuration. For example, the desired configuration can specify a new
        /// launch template or a new version of the current launch template.
        /// </para>
        ///  
        /// <para>
        /// Once the instance refresh succeeds, Amazon EC2 Auto Scaling updates the settings of
        /// the Auto Scaling group to reflect the new desired configuration. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you specify a new launch template or a new version of the current launch template
        /// for your desired configuration, consider enabling the <code>SkipMatching</code> property
        /// in preferences. If it's enabled, Amazon EC2 Auto Scaling skips replacing instances
        /// that already use the specified launch template and instance types. This can help you
        /// reduce the number of replacements that are required to apply updates. 
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Preferences. 
        /// <para>
        /// Sets your preferences for the instance refresh so that it performs as expected when
        /// you start it. Includes the instance warmup time, the minimum healthy percentage, and
        /// the behaviors that you want Amazon EC2 Auto Scaling to use if instances that are in
        /// <code>Standby</code> state or protected from scale in are found. You can also choose
        /// to enable additional features, such as the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto rollback
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Checkpoints
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Skip matching
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The strategy to use for the instance refresh. The only valid value is <code>Rolling</code>.
        /// </para>
        /// </summary>
        public RefreshStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}