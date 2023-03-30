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
    /// Container for the parameters to the DetachLoadBalancerTargetGroups operation.
    /// <note> 
    /// <para>
    /// This API call has been replaced with a new "traffic sources" API call (<code>DetachTrafficSources</code>)
    /// that can detach multiple traffic sources types. While we continue to support <code>DetachLoadBalancerTargetGroups</code>,
    /// and you can use both the original <code>DetachLoadBalancerTargetGroups</code> API
    /// call and the new <code>DetachTrafficSources</code> API call on the same Auto Scaling
    /// group, we recommend using the new "traffic sources" API call to simplify how you manage
    /// traffic sources.
    /// </para>
    ///  </note> 
    /// <para>
    /// Detaches one or more target groups from the specified Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// When you detach a target group, it enters the <code>Removing</code> state while deregistering
    /// the instances in the group. When all instances are deregistered, then you can no longer
    /// describe the target group using the <a>DescribeLoadBalancerTargetGroups</a> API call.
    /// The instances remain running.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can use this operation to detach target groups that were attached by using <a>AttachLoadBalancerTargetGroups</a>,
    /// but not for target groups that were attached by using <a>AttachTrafficSources</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DetachLoadBalancerTargetGroupsRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _targetGroupARNs = new List<string>();

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
        /// Gets and sets the property TargetGroupARNs. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the target groups. You can specify up to 10 target
        /// groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TargetGroupARNs
        {
            get { return this._targetGroupARNs; }
            set { this._targetGroupARNs = value; }
        }

        // Check to see if TargetGroupARNs property is set
        internal bool IsSetTargetGroupARNs()
        {
            return this._targetGroupARNs != null && this._targetGroupARNs.Count > 0; 
        }

    }
}