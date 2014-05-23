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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the AWS resources in use by this environment. This data is live.
    /// </summary>
    public partial class EnvironmentResourceDescription
    {
        private List<AutoScalingGroup> _autoScalingGroups = new List<AutoScalingGroup>();
        private string _environmentName;
        private List<Instance> _instances = new List<Instance>();
        private List<LaunchConfiguration> _launchConfigurations = new List<LaunchConfiguration>();
        private List<LoadBalancer> _loadBalancers = new List<LoadBalancer>();
        private List<Queue> _queues = new List<Queue>();
        private List<Trigger> _triggers = new List<Trigger>();


        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        ///          The         <code>AutoScalingGroups</code>         used by this environment.
        ///      
        /// </para>
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroups property
        /// </summary>
        /// <param name="autoScalingGroups">The values to add to the AutoScalingGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithAutoScalingGroups(params AutoScalingGroup[] autoScalingGroups)
        {
            foreach (var element in autoScalingGroups)
            {
                this._autoScalingGroups.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AutoScalingGroups property
        /// </summary>
        /// <param name="autoScalingGroups">The values to add to the AutoScalingGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithAutoScalingGroups(IEnumerable<AutoScalingGroup> autoScalingGroups)
        {
            foreach (var element in autoScalingGroups)
            {
                this._autoScalingGroups.Add(element);
            }
            return this;
        }
        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null && this._autoScalingGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }


        /// <summary>
        /// Sets the EnvironmentName property
        /// </summary>
        /// <param name="environmentName">The value to set for the EnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithEnvironmentName(string environmentName)
        {
            this._environmentName = environmentName;
            return this;
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }


        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The Amazon EC2 instances used by this environment.
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithInstances(params Instance[] instances)
        {
            foreach (var element in instances)
            {
                this._instances.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithInstances(IEnumerable<Instance> instances)
        {
            foreach (var element in instances)
            {
                this._instances.Add(element);
            }
            return this;
        }
        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property LaunchConfigurations. 
        /// <para>
        /// The Auto Scaling launch configurations in use by this environment.
        /// </para>
        /// </summary>
        public List<LaunchConfiguration> LaunchConfigurations
        {
            get { return this._launchConfigurations; }
            set { this._launchConfigurations = value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurations property
        /// </summary>
        /// <param name="launchConfigurations">The values to add to the LaunchConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithLaunchConfigurations(params LaunchConfiguration[] launchConfigurations)
        {
            foreach (var element in launchConfigurations)
            {
                this._launchConfigurations.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the LaunchConfigurations property
        /// </summary>
        /// <param name="launchConfigurations">The values to add to the LaunchConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithLaunchConfigurations(IEnumerable<LaunchConfiguration> launchConfigurations)
        {
            foreach (var element in launchConfigurations)
            {
                this._launchConfigurations.Add(element);
            }
            return this;
        }
        // Check to see if LaunchConfigurations property is set
        internal bool IsSetLaunchConfigurations()
        {
            return this._launchConfigurations != null && this._launchConfigurations.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// The LoadBalancers in use by this environment.
        /// </para>
        /// </summary>
        public List<LoadBalancer> LoadBalancers
        {
            get { return this._loadBalancers; }
            set { this._loadBalancers = value; }
        }

        /// <summary>
        /// Sets the LoadBalancers property
        /// </summary>
        /// <param name="loadBalancers">The values to add to the LoadBalancers collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithLoadBalancers(params LoadBalancer[] loadBalancers)
        {
            foreach (var element in loadBalancers)
            {
                this._loadBalancers.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the LoadBalancers property
        /// </summary>
        /// <param name="loadBalancers">The values to add to the LoadBalancers collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithLoadBalancers(IEnumerable<LoadBalancer> loadBalancers)
        {
            foreach (var element in loadBalancers)
            {
                this._loadBalancers.Add(element);
            }
            return this;
        }
        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this._loadBalancers != null && this._loadBalancers.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        ///          The queues used by this environment.      
        /// </para>
        /// </summary>
        public List<Queue> Queues
        {
            get { return this._queues; }
            set { this._queues = value; }
        }

        /// <summary>
        /// Sets the Queues property
        /// </summary>
        /// <param name="queues">The values to add to the Queues collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithQueues(params Queue[] queues)
        {
            foreach (var element in queues)
            {
                this._queues.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Queues property
        /// </summary>
        /// <param name="queues">The values to add to the Queues collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithQueues(IEnumerable<Queue> queues)
        {
            foreach (var element in queues)
            {
                this._queues.Add(element);
            }
            return this;
        }
        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this._queues != null && this._queues.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        ///          The         <code>AutoScaling</code>         triggers in use by this environment.
        ///      
        /// </para>
        /// </summary>
        public List<Trigger> Triggers
        {
            get { return this._triggers; }
            set { this._triggers = value; }
        }

        /// <summary>
        /// Sets the Triggers property
        /// </summary>
        /// <param name="triggers">The values to add to the Triggers collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithTriggers(params Trigger[] triggers)
        {
            foreach (var element in triggers)
            {
                this._triggers.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Triggers property
        /// </summary>
        /// <param name="triggers">The values to add to the Triggers collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourceDescription WithTriggers(IEnumerable<Trigger> triggers)
        {
            foreach (var element in triggers)
            {
                this._triggers.Add(element);
            }
            return this;
        }
        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this._triggers != null && this._triggers.Count > 0; 
        }

    }
}