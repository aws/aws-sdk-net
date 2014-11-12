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
    /// There are two primary Auto Scaling process types--<code>Launch</code>
    ///            and <code>Terminate</code>. The <code>Launch</code> process creates a new
    ///            Amazon EC2 instance for an Auto Scaling group, and the <code>Terminate</code>
    ///            process removes an existing Amazon EC2 instance.        
    /// 
    ///         
    /// <para>
    ///             The remaining Auto Scaling process types relate to specific Auto Scaling
    /// features:            <ul>                <li>AddToLoadBalancer</li>              
    ///  <li>AlarmNotification</li>                <li>AZRebalance</li>                <li>HealthCheck</li>
    ///                <li>ReplaceUnhealthy</li>                <li>ScheduledActions</li>
    ///            </ul>        
    /// </para>
    ///         <important>            
    /// <para>
    ///                 If you suspend <code>Launch</code> or <code>Terminate</code>,    
    ///            all other process types are affected to varying degrees.              
    ///  The following descriptions discuss how each process type                is affected
    /// by a suspension of <code>Launch</code> or                <code>Terminate</code>. 
    ///           
    /// </para>
    ///         </important>        
    /// <para>
    ///             The <code>AddToLoadBalancer</code> process type adds instances to the
    /// load balancer             when the instances are launched. If you suspend this process,
    /// Auto Scaling will launch             the instances but will not add them to the load
    /// balancer. If you resume the             <code>AddToLoadBalancer</code> process, Auto
    /// Scaling will also resume adding new instances to the load             balancer when
    /// they are launched. However, Auto Scaling will not add running instances that     
    ///       were launched while the process was suspended; those instances must be added
    /// manually using the             the <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_RegisterInstancesWithLoadBalancer.html">
    ///        RegisterInstancesWithLoadBalancer</a> call in the <i>Elastic Load Balancing
    /// API Reference</i>.        
    /// </para>
    ///         
    /// <para>
    ///             The <code>AlarmNotification</code> process type accepts notifications
    /// from            Amazon CloudWatch alarms that are associated with the Auto Scaling
    /// group. If you            suspend the <code>AlarmNotification</code> process type,
    /// Auto Scaling will not            automatically execute scaling policies that would
    /// be triggered by alarms.        
    /// </para>
    ///         
    /// <para>
    ///             Although the <code>AlarmNotification</code> process type is not directly
    ///            affected by a suspension of <code>Launch</code> or <code>Terminate</code>,
    ///            alarm notifications are often used to signal that a change in the size
    ///            of the Auto Scaling group is warranted. If you suspend <code>Launch</code>
    ///            or <code>Terminate</code>, Auto Scaling might not be able to implement
    /// the alarm's            associated policy.        
    /// </para>
    ///         
    /// <para>
    ///             The <code>AZRebalance</code> process type seeks to maintain a balanced
    /// number of             instances across Availability Zones within a Region. If you
    /// remove an Availability            Zone from your Auto Scaling group or an Availability
    /// Zone otherwise            becomes unhealthy or unavailable, Auto Scaling launches
    /// new instances in an             unaffected Availability Zone before terminating the
    /// unhealthy or unavailable instances.             When the unhealthy Availability Zone
    /// returns to a healthy state, Auto Scaling automatically            redistributes the
    /// application instances evenly across all of the designated Availability Zones.    
    ///    
    /// </para>
    ///         <important>            
    /// <para>
    ///                 If you call <a>SuspendProcesses</a> on the <code>launch</code> process
    /// type, the <code>AZRebalance</code>                process will neither launch new
    /// instances nor terminate existing instances.                 This is because the <code>AZRebalance</code>
    /// process terminates existing instances only                after launching the replacement
    /// instances.             
    /// </para>
    ///             
    /// <para>
    ///                 If you call <a>SuspendProcesses</a> on the <code>terminate</code>
    /// process type, the <code>AZRebalance</code>                process can cause your Auto
    /// Scaling group to grow up to ten percent larger than                the maximum size.
    /// This is because Auto Scaling allows groups to temporarily grow                larger
    /// than the maximum size during rebalancing activities.                If Auto Scaling
    /// cannot terminate instances, your Auto Scaling group could remain                up
    /// to ten percent larger than the maximum size until you resume the <code>terminate</code>
    ///                process type.            
    /// </para>
    ///         </important>        
    /// <para>
    ///             The <code>HealthCheck</code> process type checks the health of the instances.
    ///            Auto Scaling marks an instance as unhealthy if Amazon EC2 or Elastic Load
    /// Balancing             informs Auto Scaling that the instance is unhealthy. The <code>HealthCheck</code>
    ///            process can override the health status of an instance that you set with
    /// <a>SetInstanceHealth</a>.        
    /// </para>
    ///         
    /// <para>
    ///             The <code>ReplaceUnhealthy</code> process type terminates instances that
    /// are marked            as unhealthy and subsequently creates new instances to replace
    /// them. This process            calls both of the primary process types--first <code>Terminate</code>
    /// and            then <code>Launch</code>.         
    /// </para>
    ///         <important>            
    /// <para>
    ///                 The <code>HealthCheck</code> process type works in conjunction with
    /// the                 <code>ReplaceUnhealthly</code> process type to provide health
    /// check functionality.                If you suspend either <code>Launch</code> or <code>Terminate</code>,
    /// the                <code>ReplaceUnhealthy</code> process type will not function properly.
    ///            
    /// </para>
    ///         </important>        
    /// <para>
    ///             The <code>ScheduledActions</code> process type performs scheduled actions
    /// that you            create with <a>PutScheduledUpdateGroupAction</a>. Scheduled actions
    /// often involve            launching new instances or terminating existing instances.
    /// If you suspend either             <code>Launch</code> or <code>Terminate</code>, your
    /// scheduled actions might not            function as expected.        
    /// </para>
    /// </summary>
    public partial class ProcessType
    {
        private string _processName;


        /// <summary>
        /// Gets and sets the property ProcessName. 
        /// <para>
        ///             The name of a process.        
        /// </para>
        /// </summary>
        public string ProcessName
        {
            get { return this._processName; }
            set { this._processName = value; }
        }


        /// <summary>
        /// Sets the ProcessName property
        /// </summary>
        /// <param name="processName">The value to set for the ProcessName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ProcessType WithProcessName(string processName)
        {
            this._processName = processName;
            return this;
        }

        // Check to see if ProcessName property is set
        internal bool IsSetProcessName()
        {
            return this._processName != null;
        }

    }
}