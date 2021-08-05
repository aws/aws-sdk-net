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
    /// Starts a new instance refresh operation. An instance refresh performs a rolling replacement
    /// of all or some instances in an Auto Scaling group. Each instance is terminated first
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
    /// If the call succeeds, it creates a new instance refresh request with a unique ID that
    /// you can use to track its progress. To query its status, call the <a>DescribeInstanceRefreshes</a>
    /// API. To describe the instance refreshes that have already run, call the <a>DescribeInstanceRefreshes</a>
    /// API. To cancel an instance refresh operation in progress, use the <a>CancelInstanceRefresh</a>
    /// API. 
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
        /// that already use the specified launch template and version. This can help you reduce
        /// the number of replacements that are required to apply updates. 
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
        /// Set of preferences associated with the instance refresh request. If not provided,
        /// the default values are used.
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
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The strategy to use for the instance refresh. The only valid value is <code>Rolling</code>.
        /// </para>
        ///  
        /// <para>
        /// A rolling update helps you update your instances gradually. A rolling update can fail
        /// due to failed health checks or if instances are on standby or are protected from scale
        /// in. If the rolling update process fails, any instances that are replaced are not rolled
        /// back to their previous configuration. 
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