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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
        private List<LaunchTemplate> _launchTemplates = new List<LaunchTemplate>();
        private List<LoadBalancer> _loadBalancers = new List<LoadBalancer>();
        private List<Queue> _queues = new List<Queue>();
        private List<Trigger> _triggers = new List<Trigger>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public EnvironmentResourceDescription() { }

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        ///  The <code>AutoScalingGroups</code> used by this environment. 
        /// </para>
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
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

        // Check to see if LaunchConfigurations property is set
        internal bool IsSetLaunchConfigurations()
        {
            return this._launchConfigurations != null && this._launchConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplates. 
        /// <para>
        /// The Amazon EC2 launch templates in use by this environment.
        /// </para>
        /// </summary>
        public List<LaunchTemplate> LaunchTemplates
        {
            get { return this._launchTemplates; }
            set { this._launchTemplates = value; }
        }

        // Check to see if LaunchTemplates property is set
        internal bool IsSetLaunchTemplates()
        {
            return this._launchTemplates != null && this._launchTemplates.Count > 0; 
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

        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this._loadBalancers != null && this._loadBalancers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        /// The queues used by this environment.
        /// </para>
        /// </summary>
        public List<Queue> Queues
        {
            get { return this._queues; }
            set { this._queues = value; }
        }

        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this._queues != null && this._queues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The <code>AutoScaling</code> triggers in use by this environment. 
        /// </para>
        /// </summary>
        public List<Trigger> Triggers
        {
            get { return this._triggers; }
            set { this._triggers = value; }
        }

        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this._triggers != null && this._triggers.Count > 0; 
        }

    }
}