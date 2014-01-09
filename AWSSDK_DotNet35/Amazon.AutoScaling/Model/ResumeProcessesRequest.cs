/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ResumeProcesses operation.
    /// <para> Resumes all suspended Auto Scaling processes for an Auto Scaling group. For information on suspending and resuming Auto Scaling
    /// process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html" >Suspend and Resume Auto Scaling
    /// Process</a> .
    /// </para>
    /// </summary>
    public partial class ResumeProcessesRequest : AmazonAutoScalingRequest
    {
        private string autoScalingGroupName;
        private List<string> scalingProcesses = new List<string>();


        /// <summary>
        /// The name or Amazon Resource Name (ARN) of the Auto Scaling group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The processes that you want to suspend or resume, which can include one or more of the following: <ul> <li>Launch</li> <li>Terminate</li>
        /// <li>HealthCheck</li> <li>ReplaceUnhealthy</li> <li>AZRebalance</li> <li>AlarmNotification</li> <li>ScheduledActions</li>
        /// <li>AddToLoadBalancer</li> </ul> To suspend all process types, omit this parameter.
        ///  
        /// </summary>
        public List<string> ScalingProcesses
        {
            get { return this.scalingProcesses; }
            set { this.scalingProcesses = value; }
        }

        // Check to see if ScalingProcesses property is set
        internal bool IsSetScalingProcesses()
        {
            return this.scalingProcesses.Count > 0;
        }

    }
}
    
