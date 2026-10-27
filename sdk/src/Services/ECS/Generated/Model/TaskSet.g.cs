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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Information about a set of Amazon ECS tasks in either an CodeDeploy or an <c>EXTERNAL</c>
    /// deployment. An Amazon ECS task set includes details such as the desired number of
    /// tasks, how many tasks are running, and whether the task set serves production traffic.
    /// </summary>
    public partial class TaskSet
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy that are associated with the task set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityProviderStrategyItem> CapacityProviderStrategy { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityProviderStrategyItem>() : null;

        /// <summary>
        /// Checks to see if the CapacityProviderStrategy property is set.
        /// </summary>
        internal bool IsSetCapacityProviderStrategy() => this.CapacityProviderStrategy != null && (this.CapacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that the service that hosts the task
        /// set exists in.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ComputedDesiredCount. 
        /// <para>
        /// The computed desired count for the task set. This is calculated by multiplying the
        /// service's <c>desiredCount</c> by the task set's <c>scale</c> percentage. The result
        /// is always rounded up. For example, if the computed desired count is 1.2, it rounds
        /// up to 2 tasks.
        /// </para>
        /// </summary>
        public int? ComputedDesiredCount { get; set; }

        /// <summary>
        /// Checks to see if the ComputedDesiredCount property is set.
        /// </summary>
        internal bool IsSetComputedDesiredCount() => this.ComputedDesiredCount.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task set was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID associated with the task set.
        /// </para>
        ///  
        /// <para>
        /// If an CodeDeploy deployment created a task set, the <c>externalId</c> parameter contains
        /// the CodeDeploy deployment ID.
        /// </para>
        ///  
        /// <para>
        /// If a task set is created for an external deployment and is associated with a service
        /// discovery registry, the <c>externalId</c> parameter contains the <c>ECS_TASK_SET_EXTERNAL_ID</c>
        /// Cloud Map attribute.
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property FargateEphemeralStorage. 
        /// <para>
        /// The Fargate ephemeral storage settings for the task set.
        /// </para>
        /// </summary>
        public DeploymentEphemeralStorage FargateEphemeralStorage { get; set; }

        /// <summary>
        /// Checks to see if the FargateEphemeralStorage property is set.
        /// </summary>
        internal bool IsSetFargateEphemeralStorage() => this.FargateEphemeralStorage != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the task set.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type the tasks in the task set are using. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public LaunchType LaunchType { get; set; }

        /// <summary>
        /// Checks to see if the LaunchType property is set.
        /// </summary>
        internal bool IsSetLaunchType() => this.LaunchType != null;

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// Details on a load balancer that are used with a task set.
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the task set.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property PendingCount. 
        /// <para>
        /// The number of tasks in the task set that are in the <c>PENDING</c> status during a
        /// deployment. A task in the <c>PENDING</c> state is preparing to enter the <c>RUNNING</c>
        /// state. A task set enters the <c>PENDING</c> status when it launches for the first
        /// time or when it's restarted after being in the <c>STOPPED</c> state.
        /// </para>
        /// </summary>
        public int? PendingCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingCount property is set.
        /// </summary>
        internal bool IsSetPendingCount() => this.PendingCount.HasValue;

        /// <summary>
        /// Gets and sets the property PlatformFamily. 
        /// <para>
        /// The operating system that your tasks in the set are running on. A platform family
        /// is specified only for tasks that use the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        ///  All tasks in the set must have the same value.
        /// </para>
        /// </summary>
        public string PlatformFamily { get; set; }

        /// <summary>
        /// Checks to see if the PlatformFamily property is set.
        /// </summary>
        internal bool IsSetPlatformFamily() => this.PlatformFamily != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The Fargate platform version where the tasks in the task set are running. A platform
        /// version is only specified for tasks run on Fargate. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// platform versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property RunningCount. 
        /// <para>
        /// The number of tasks in the task set that are in the <c>RUNNING</c> status during a
        /// deployment. A task in the <c>RUNNING</c> state is running and ready for use.
        /// </para>
        /// </summary>
        public int? RunningCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningCount property is set.
        /// </summary>
        internal bool IsSetRunningCount() => this.RunningCount.HasValue;

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// A floating-point percentage of your desired number of tasks to place and keep running
        /// in the task set.
        /// </para>
        /// </summary>
        public Scale Scale { get; set; }

        /// <summary>
        /// Checks to see if the Scale property is set.
        /// </summary>
        internal bool IsSetScale() => this.Scale != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service the task set exists in.
        /// </para>
        /// </summary>
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceRegistries. 
        /// <para>
        /// The details for the service discovery registries to assign to this task set. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// discovery</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceRegistry> ServiceRegistries { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceRegistry>() : null;

        /// <summary>
        /// Checks to see if the ServiceRegistries property is set.
        /// </summary>
        internal bool IsSetServiceRegistries() => this.ServiceRegistries != null && (this.ServiceRegistries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StabilityStatus. 
        /// <para>
        /// The stability status. This indicates whether the task set has reached a steady state.
        /// If the following conditions are met, the task set are in <c>STEADY_STATE</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The task <c>runningCount</c> is equal to the <c>computedDesiredCount</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>pendingCount</c> is <c>0</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are no tasks that are running on container instances in the <c>DRAINING</c>
        /// status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All tasks are reporting a healthy status from the load balancers, service discovery,
        /// and container health checks.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If any of those conditions aren't met, the stability status returns <c>STABILIZING</c>.
        /// </para>
        /// </summary>
        public StabilityStatus StabilityStatus { get; set; }

        /// <summary>
        /// Checks to see if the StabilityStatus property is set.
        /// </summary>
        internal bool IsSetStabilityStatus() => this.StabilityStatus != null;

        /// <summary>
        /// Gets and sets the property StabilityStatusAt. 
        /// <para>
        /// The Unix timestamp for the time when the task set stability status was retrieved.
        /// </para>
        /// </summary>
        public DateTime? StabilityStatusAt { get; set; }

        /// <summary>
        /// Checks to see if the StabilityStatusAt property is set.
        /// </summary>
        internal bool IsSetStabilityStatusAt() => this.StabilityStatusAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The tag specified when a task set is started. If an CodeDeploy deployment created
        /// the task set, the <c>startedBy</c> parameter is <c>CODE_DEPLOY</c>. If an external
        /// deployment created the task set, the <c>startedBy</c> field isn't used.
        /// </para>
        /// </summary>
        public string StartedBy { get; set; }

        /// <summary>
        /// Checks to see if the StartedBy property is set.
        /// </summary>
        internal bool IsSetStartedBy() => this.StartedBy != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task set. The following describes each state.
        /// </para>
        ///  <dl> <dt>PRIMARY</dt> <dd> 
        /// <para>
        /// The task set is serving production traffic.
        /// </para>
        ///  </dd> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The task set isn't serving production traffic.
        /// </para>
        ///  </dd> <dt>DRAINING</dt> <dd> 
        /// <para>
        /// The tasks in the task set are being stopped, and their corresponding targets are being
        /// deregistered from their target group.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task set to help you categorize and organize them.
        /// Each tag consists of a key and an optional value. You define both.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for either keys or values as it is reserved for Amazon Web Services use.
        /// You cannot edit or delete tag keys or values with this prefix. Tags with this prefix
        /// do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The task definition that the task set is using.
        /// </para>
        /// </summary>
        public string TaskDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinition property is set.
        /// </summary>
        internal bool IsSetTaskDefinition() => this.TaskDefinition != null;

        /// <summary>
        /// Gets and sets the property TaskSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task set.
        /// </para>
        /// </summary>
        public string TaskSetArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskSetArn property is set.
        /// </summary>
        internal bool IsSetTaskSetArn() => this.TaskSetArn != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task set was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
