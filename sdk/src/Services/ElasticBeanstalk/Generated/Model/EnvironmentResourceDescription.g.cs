/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the Amazon Web Services resources in use by this environment. This data
    /// is live.
    /// </summary>
    public partial class EnvironmentResourceDescription
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public EnvironmentResourceDescription() { }

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        ///  The <c>AutoScalingGroups</c> used by this environment. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoScalingGroup>() : null;

        /// <summary>
        /// Checks to see if the AutoScalingGroups property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroups() => this.AutoScalingGroups != null && (this.AutoScalingGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The Amazon EKS cluster that this environment runs on. This member is present only
        /// for environments in the <i>Cluster</i> tier.
        /// </para>
        /// </summary>
        public Cluster Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The Amazon EC2 instances used by this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Instance> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<Instance>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchConfigurations. 
        /// <para>
        /// The Auto Scaling launch configurations in use by this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchConfiguration> LaunchConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchConfiguration>() : null;

        /// <summary>
        /// Checks to see if the LaunchConfigurations property is set.
        /// </summary>
        internal bool IsSetLaunchConfigurations() => this.LaunchConfigurations != null && (this.LaunchConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchTemplates. 
        /// <para>
        /// The Amazon EC2 launch templates in use by this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplate> LaunchTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchTemplate>() : null;

        /// <summary>
        /// Checks to see if the LaunchTemplates property is set.
        /// </summary>
        internal bool IsSetLaunchTemplates() => this.LaunchTemplates != null && (this.LaunchTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// The LoadBalancers in use by this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoadBalancer> LoadBalancers { get; set; } = AWSConfigs.InitializeCollections ? new List<LoadBalancer>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancers property is set.
        /// </summary>
        internal bool IsSetLoadBalancers() => this.LoadBalancers != null && (this.LoadBalancers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        /// The queues used by this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Queue> Queues { get; set; } = AWSConfigs.InitializeCollections ? new List<Queue>() : null;

        /// <summary>
        /// Checks to see if the Queues property is set.
        /// </summary>
        internal bool IsSetQueues() => this.Queues != null && (this.Queues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The <c>AutoScaling</c> triggers in use by this environment. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Trigger> Triggers { get; set; } = AWSConfigs.InitializeCollections ? new List<Trigger>() : null;

        /// <summary>
        /// Checks to see if the Triggers property is set.
        /// </summary>
        internal bool IsSetTriggers() => this.Triggers != null && (this.Triggers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
