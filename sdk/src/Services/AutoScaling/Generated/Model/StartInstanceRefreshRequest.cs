/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Starts a new instance refresh operation, which triggers a rolling replacement of all
    /// previously launched instances in the Auto Scaling group with a new group of instances.
    /// 
    ///  
    /// <para>
    /// If successful, this call creates a new instance refresh request with a unique ID that
    /// you can use to track its progress. To query its status, call the <a>DescribeInstanceRefreshes</a>
    /// API. To describe the instance refreshes that have already run, call the <a>DescribeInstanceRefreshes</a>
    /// API. To cancel an instance refresh operation in progress, use the <a>CancelInstanceRefresh</a>
    /// API. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">Replacing
    /// Auto Scaling Instances Based on an Instance Refresh</a>.
    /// </para>
    /// </summary>
    public partial class StartInstanceRefreshRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
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
        /// Gets and sets the property Preferences. 
        /// <para>
        /// Set of preferences associated with the instance refresh request.
        /// </para>
        ///  
        /// <para>
        /// If not provided, the default values are used. For <code>MinHealthyPercentage</code>,
        /// the default value is <code>90</code>. For <code>InstanceWarmup</code>, the default
        /// is to use the value specified for the health check grace period for the Auto Scaling
        /// group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_RefreshPreferences.html">RefreshPreferences</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
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
        /// A rolling update is an update that is applied to all instances in an Auto Scaling
        /// group until all instances have been updated. A rolling update can fail due to failed
        /// health checks or if instances are on standby or are protected from scale in. If the
        /// rolling update process fails, any instances that were already replaced are not rolled
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