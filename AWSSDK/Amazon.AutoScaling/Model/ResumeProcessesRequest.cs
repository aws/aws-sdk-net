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
    /// <para> Resumes Auto Scaling processes for an Auto Scaling group. For more information, see SuspendProcesses and ProcessType. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.ResumeProcesses"/>
    public class ResumeProcessesRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResumeProcessesRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupName = autoScalingGroupName;
            return this;
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
        /// <summary>
        /// Adds elements to the ScalingProcesses collection
        /// </summary>
        /// <param name="scalingProcesses">The values to add to the ScalingProcesses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResumeProcessesRequest WithScalingProcesses(params string[] scalingProcesses)
        {
            foreach (string element in scalingProcesses)
            {
                this.scalingProcesses.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ScalingProcesses collection
        /// </summary>
        /// <param name="scalingProcesses">The values to add to the ScalingProcesses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResumeProcessesRequest WithScalingProcesses(IEnumerable<string> scalingProcesses)
        {
            foreach (string element in scalingProcesses)
            {
                this.scalingProcesses.Add(element);
            }

            return this;
        }

        // Check to see if ScalingProcesses property is set
        internal bool IsSetScalingProcesses()
        {
            return this.scalingProcesses.Count > 0;       
        }
    }
}
    
