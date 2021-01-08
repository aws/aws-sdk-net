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
    /// Container for the parameters to the SuspendProcesses operation.
    /// Suspends the specified auto scaling processes, or all processes, for the specified
    /// Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// If you suspend either the <code>Launch</code> or <code>Terminate</code> process types,
    /// it can prevent other process types from functioning properly. For more information,
    /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
    /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To resume processes that have been suspended, call the <a>ResumeProcesses</a> API.
    /// </para>
    /// </summary>
    public partial class SuspendProcessesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _scalingProcesses = new List<string>();

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
        /// Gets and sets the property ScalingProcesses. 
        /// <para>
        /// One or more of the following processes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Launch</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Terminate</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AddToLoadBalancer</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AlarmNotification</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AZRebalance</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HealthCheck</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InstanceRefresh</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplaceUnhealthy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ScheduledActions</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you omit this parameter, all processes are specified.
        /// </para>
        /// </summary>
        public List<string> ScalingProcesses
        {
            get { return this._scalingProcesses; }
            set { this._scalingProcesses = value; }
        }

        // Check to see if ScalingProcesses property is set
        internal bool IsSetScalingProcesses()
        {
            return this._scalingProcesses != null && this._scalingProcesses.Count > 0; 
        }

    }
}