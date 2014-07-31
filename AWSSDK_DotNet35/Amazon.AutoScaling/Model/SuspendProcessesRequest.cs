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
    /// Container for the parameters to the SuspendProcesses operation.
    /// Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process
    /// types, specify them by name with the <code>ScalingProcesses.member.N</code> parameter.
    /// To suspend all process types, omit the <code>ScalingProcesses.member.N</code> parameter.
    /// 
    /// 
    ///  <important> 
    /// <para>
    ///  Suspending either of the two primary process types, <code>Launch</code> or <code>Terminate</code>,
    /// can prevent other process types from functioning properly. 
    /// </para>
    ///  </important> 
    /// <para>
    ///  To resume processes that have been suspended, use <a>ResumeProcesses</a> For more
    /// information on suspending and resuming Auto Scaling process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
    /// and Resume Auto Scaling Process</a>. 
    /// </para>
    /// </summary>
    public partial class SuspendProcessesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _scalingProcesses = new List<string>();


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///  The name or Amazon Resource Name (ARN) of the Auto Scaling group. 
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
        ///  The processes that you want to suspend or resume, which can include one or more of
        /// the following: 
        /// </para>
        ///  <ul> <li>Launch</li> <li>Terminate</li> <li>HealthCheck</li> <li>ReplaceUnhealthy</li>
        /// <li>AZRebalance</li> <li>AlarmNotification</li> <li>ScheduledActions</li> <li>AddToLoadBalancer</li>
        /// </ul> 
        /// <para>
        ///  To suspend all process types, omit this parameter. 
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