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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> There are two primary Auto Scaling process types-- <c>Launch</c> and <c>Terminate</c> . The <c>Launch</c> process creates a new
    /// Amazon EC2 instance for an Auto Scaling group, and the <c>Terminate</c> process removes an existing Amazon EC2 instance. </para> <para> The
    /// remaining Auto Scaling process types relate to specific Auto Scaling features:
    /// <ul>
    /// <li>AddToLoadBalancer</li>
    /// <li>AlarmNotification</li>
    /// <li>AZRebalance</li>
    /// <li>HealthCheck</li>
    /// <li>ReplaceUnhealthy</li>
    /// <li>ScheduledActions</li>
    /// 
    /// </ul>
    /// </para> <para><b>IMPORTANT:</b> If you suspend Launch or Terminate, all other process types are affected to varying degrees. The following
    /// descriptions discuss how each process type is affected by a suspension of Launch or Terminate. </para> <para> The <c>AddToLoadBalancer</c>
    /// process type adds instances to the the load balancer when the instances are launched. If you suspend this process, Auto Scaling will launch
    /// the instances but will not add them to the load balancer. If you resume the <c>AddToLoadBalancer</c> process, Auto Scaling will also resume
    /// adding new instances to the load balancer when they are launched. However, Auto Scaling will not add running instances that were launched
    /// while the process was suspended; those instances must be added manually using the the RegisterInstancesWithLoadBalancer call in the
    /// <i>Elastic Load Balancing API Reference</i> .
    /// </para> <para> The <c>AlarmNotification</c> process type accepts notifications from Amazon CloudWatch alarms that are associated
    /// with the Auto Scaling group. If you suspend the <c>AlarmNotification</c> process type, Auto Scaling will not automatically execute scaling
    /// policies that would be triggered by alarms. </para> <para> Although the <c>AlarmNotification</c> process type is not directly affected by a
    /// suspension of <c>Launch</c> or <c>Terminate</c> ,
    /// alarm notifications are often used to signal that a change in the size of the Auto Scaling group is warranted. If you suspend
    /// <c>Launch</c> or <c>Terminate</c> , Auto Scaling might not be able to implement the alarm's associated policy. </para> <para> The
    /// <c>AZRebalance</c> process type seeks to maintain a balanced number of instances across Availability Zones within a Region. If you remove an
    /// Availability Zone from your Auto Scaling group or an Availability Zone otherwise becomes unhealthy or unavailable, Auto Scaling launches new
    /// instances in an unaffected Availability Zone before terminating the unhealthy or unavailable instances. When the unhealthy Availability Zone
    /// returns to a healthy state, Auto Scaling automatically redistributes the application instances evenly across all of the designated
    /// Availability Zones. </para> <para><b>IMPORTANT:</b> If you call SuspendProcesses on the launch process type, the AZRebalance process will
    /// neither launch new instances nor terminate existing instances. This is because the AZRebalance process terminates existing instances only
    /// after launching the replacement instances. If you call SuspendProcesses on the terminate process type, the AZRebalance process can cause
    /// your Auto Scaling group to grow up to ten percent larger than the maximum size. This is because Auto Scaling allows groups to temporarily
    /// grow larger than the maximum size during rebalancing activities. If Auto Scaling cannot terminate instances, your Auto Scaling group could
    /// remain up to ten percent larger than the maximum size until you resume the terminate process type. </para> <para> The <c>HealthCheck</c>
    /// process type checks the health of the instances. Auto Scaling marks an instance as unhealthy if Amazon EC2 or Elastic Load Balancing informs
    /// Auto Scaling that the instance is unhealthy. The <c>HealthCheck</c> process can override the health status of an instance that you set with
    /// SetInstanceHealth. </para> <para> The <c>ReplaceUnhealthy</c> process type terminates instances that are marked as unhealthy and
    /// subsequently creates new instances to replace them. This process calls both of the primary process types--first <c>Terminate</c> and then
    /// <c>Launch</c> .
    /// </para> <para><b>IMPORTANT:</b> The HealthCheck process type works in conjunction with the ReplaceUnhealthly process type to provide
    /// health check functionality. If you suspend either Launch or Terminate, the ReplaceUnhealthy process type will not function properly. </para>
    /// <para> The <c>ScheduledActions</c> process type performs scheduled actions that you create with PutScheduledUpdateGroupAction. Scheduled
    /// actions often involve launching new instances or terminating existing instances. If you suspend either <c>Launch</c> or <c>Terminate</c> ,
    /// your scheduled actions might not function as expected. </para>
    /// </summary>
    public class ProcessType  
    {
        
        private string processName;

        /// <summary>
        /// The name of a process.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ProcessName
        {
            get { return this.processName; }
            set { this.processName = value; }
        }

        /// <summary>
        /// Sets the ProcessName property
        /// </summary>
        /// <param name="processName">The value to set for the ProcessName property </param>
        /// <returns>this instance</returns>
        public ProcessType WithProcessName(string processName)
        {
            this.processName = processName;
            return this;
        }
            

        // Check to see if ProcessName property is set
        internal bool IsSetProcessName()
        {
            return this.processName != null;       
        }
    }
}
