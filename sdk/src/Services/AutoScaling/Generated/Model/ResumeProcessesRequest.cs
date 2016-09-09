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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the ResumeProcesses operation.
    /// Resumes the specified suspended Auto Scaling processes, or all suspended process,
    /// for the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspending
    /// and Resuming Auto Scaling Processes</a> in the <i>Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ResumeProcessesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _scalingProcesses = new List<string>();

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the Auto Scaling group.
        /// </para>
        /// </summary>
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
        /// One or more of the following processes. If you omit this parameter, all processes
        /// are specified.
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
        ///  <code>HealthCheck</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplaceUnhealthy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AZRebalance</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AlarmNotification</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ScheduledActions</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AddToLoadBalancer</code> 
        /// </para>
        ///  </li> </ul>
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