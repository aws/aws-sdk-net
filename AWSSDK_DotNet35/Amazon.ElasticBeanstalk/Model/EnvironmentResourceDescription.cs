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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Describes the AWS resources in use by this environment. This data is live.</para>
    /// </summary>
    public class EnvironmentResourceDescription
    {
        
        private string environmentName;
        private List<AutoScalingGroup> autoScalingGroups = new List<AutoScalingGroup>();
        private List<Instance> instances = new List<Instance>();
        private List<LaunchConfiguration> launchConfigurations = new List<LaunchConfiguration>();
        private List<LoadBalancer> loadBalancers = new List<LoadBalancer>();
        private List<Trigger> triggers = new List<Trigger>();
        private List<Queue> queues = new List<Queue>();


        /// <summary>
        /// The name of the environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this.environmentName; }
            set { this.environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;
        }

        /// <summary>
        /// The <c>AutoScalingGroups</c> used by this environment.
        ///  
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this.autoScalingGroups; }
            set { this.autoScalingGroups = value; }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this.autoScalingGroups.Count > 0;
        }

        /// <summary>
        /// The Amazon EC2 instances used by this environment.
        ///  
        /// </summary>
        public List<Instance> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;
        }

        /// <summary>
        /// The Auto Scaling launch configurations in use by this environment.
        ///  
        /// </summary>
        public List<LaunchConfiguration> LaunchConfigurations
        {
            get { return this.launchConfigurations; }
            set { this.launchConfigurations = value; }
        }

        // Check to see if LaunchConfigurations property is set
        internal bool IsSetLaunchConfigurations()
        {
            return this.launchConfigurations.Count > 0;
        }

        /// <summary>
        /// The LoadBalancers in use by this environment.
        ///  
        /// </summary>
        public List<LoadBalancer> LoadBalancers
        {
            get { return this.loadBalancers; }
            set { this.loadBalancers = value; }
        }

        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this.loadBalancers.Count > 0;
        }

        /// <summary>
        /// The <c>AutoScaling</c> triggers in use by this environment.
        ///  
        /// </summary>
        public List<Trigger> Triggers
        {
            get { return this.triggers; }
            set { this.triggers = value; }
        }

        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this.triggers.Count > 0;
        }

        /// <summary>
        /// The queues used by this environment.
        ///  
        /// </summary>
        public List<Queue> Queues
        {
            get { return this.queues; }
            set { this.queues = value; }
        }

        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this.queues.Count > 0;
        }
    }
}
