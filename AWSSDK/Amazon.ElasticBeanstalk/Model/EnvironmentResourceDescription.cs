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

        /// <summary>
        /// Sets the EnvironmentName property
        /// </summary>
        /// <param name="environmentName">The value to set for the EnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithEnvironmentName(string environmentName)
        {
            this.environmentName = environmentName;
            return this;
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
        /// <summary>
        /// Adds elements to the AutoScalingGroups collection
        /// </summary>
        /// <param name="autoScalingGroups">The values to add to the AutoScalingGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithAutoScalingGroups(params AutoScalingGroup[] autoScalingGroups)
        {
            foreach (AutoScalingGroup element in autoScalingGroups)
            {
                this.autoScalingGroups.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AutoScalingGroups collection
        /// </summary>
        /// <param name="autoScalingGroups">The values to add to the AutoScalingGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithAutoScalingGroups(IEnumerable<AutoScalingGroup> autoScalingGroups)
        {
            foreach (AutoScalingGroup element in autoScalingGroups)
            {
                this.autoScalingGroups.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithInstances(params Instance[] instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithInstances(IEnumerable<Instance> instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the LaunchConfigurations collection
        /// </summary>
        /// <param name="launchConfigurations">The values to add to the LaunchConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithLaunchConfigurations(params LaunchConfiguration[] launchConfigurations)
        {
            foreach (LaunchConfiguration element in launchConfigurations)
            {
                this.launchConfigurations.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the LaunchConfigurations collection
        /// </summary>
        /// <param name="launchConfigurations">The values to add to the LaunchConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithLaunchConfigurations(IEnumerable<LaunchConfiguration> launchConfigurations)
        {
            foreach (LaunchConfiguration element in launchConfigurations)
            {
                this.launchConfigurations.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the LoadBalancers collection
        /// </summary>
        /// <param name="loadBalancers">The values to add to the LoadBalancers collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithLoadBalancers(params LoadBalancer[] loadBalancers)
        {
            foreach (LoadBalancer element in loadBalancers)
            {
                this.loadBalancers.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the LoadBalancers collection
        /// </summary>
        /// <param name="loadBalancers">The values to add to the LoadBalancers collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithLoadBalancers(IEnumerable<LoadBalancer> loadBalancers)
        {
            foreach (LoadBalancer element in loadBalancers)
            {
                this.loadBalancers.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the Triggers collection
        /// </summary>
        /// <param name="triggers">The values to add to the Triggers collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithTriggers(params Trigger[] triggers)
        {
            foreach (Trigger element in triggers)
            {
                this.triggers.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Triggers collection
        /// </summary>
        /// <param name="triggers">The values to add to the Triggers collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithTriggers(IEnumerable<Trigger> triggers)
        {
            foreach (Trigger element in triggers)
            {
                this.triggers.Add(element);
            }

            return this;
        }

        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this.triggers.Count > 0;       
        }
    }
}
