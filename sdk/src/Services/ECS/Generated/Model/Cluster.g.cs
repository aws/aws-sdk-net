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
    /// A regional grouping of one or more container instances where you can run task requests.
    /// Each account receives a default cluster the first time you use the Amazon ECS service,
    /// but you may also create other clusters. Clusters may contain more than one instance
    /// type simultaneously.
    /// </summary>
    public partial class Cluster
    {
        /// <summary>
        /// Gets and sets the property ActiveServicesCount. 
        /// <para>
        /// The number of services that are running on the cluster in an <c>ACTIVE</c> state.
        /// You can view these services with <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ListServices.html">ListServices</a>.
        /// </para>
        /// </summary>
        public int? ActiveServicesCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveServicesCount property is set.
        /// </summary>
        internal bool IsSetActiveServicesCount() => this.ActiveServicesCount.HasValue;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The resources attached to a cluster. When using a capacity provider with a cluster,
        /// the capacity provider and associated resources are returned as cluster attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attachment> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<Attachment>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttachmentsStatus. 
        /// <para>
        /// The status of the capacity providers associated with the cluster. The following are
        /// the states that are returned.
        /// </para>
        ///  <dl> <dt>UPDATE_IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The available capacity providers for the cluster are updating.
        /// </para>
        ///  </dd> <dt>UPDATE_COMPLETE</dt> <dd> 
        /// <para>
        /// The capacity providers have successfully updated.
        /// </para>
        ///  </dd> <dt>UPDATE_FAILED</dt> <dd> 
        /// <para>
        /// The capacity provider updates failed.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string AttachmentsStatus { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentsStatus property is set.
        /// </summary>
        internal bool IsSetAttachmentsStatus() => this.AttachmentsStatus != null;

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The capacity providers associated with the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CapacityProviders property is set.
        /// </summary>
        internal bool IsSetCapacityProviders() => this.CapacityProviders != null && (this.CapacityProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the cluster. For more information about
        /// the ARN format, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#ecs-resource-ids">Amazon
        /// Resource Name (ARN)</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A user-generated string that you use to identify your cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The execute command and managed storage configuration for the cluster.
        /// </para>
        /// </summary>
        public ClusterConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DefaultCapacityProviderStrategy. 
        /// <para>
        /// The default capacity provider strategy for the cluster. When services or tasks are
        /// run in the cluster with no launch type or capacity provider strategy specified, the
        /// default capacity provider strategy is used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityProviderStrategyItem> DefaultCapacityProviderStrategy { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityProviderStrategyItem>() : null;

        /// <summary>
        /// Checks to see if the DefaultCapacityProviderStrategy property is set.
        /// </summary>
        internal bool IsSetDefaultCapacityProviderStrategy() => this.DefaultCapacityProviderStrategy != null && (this.DefaultCapacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <c>PENDING</c> state.
        /// </para>
        /// </summary>
        public int? PendingTasksCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingTasksCount property is set.
        /// </summary>
        internal bool IsSetPendingTasksCount() => this.PendingTasksCount.HasValue;

        /// <summary>
        /// Gets and sets the property RegisteredContainerInstancesCount. 
        /// <para>
        /// The number of container instances registered into the cluster. This includes container
        /// instances in both <c>ACTIVE</c> and <c>DRAINING</c> status.
        /// </para>
        /// </summary>
        public int? RegisteredContainerInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredContainerInstancesCount property is set.
        /// </summary>
        internal bool IsSetRegisteredContainerInstancesCount() => this.RegisteredContainerInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <c>RUNNING</c> state.
        /// </para>
        /// </summary>
        public int? RunningTasksCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningTasksCount property is set.
        /// </summary>
        internal bool IsSetRunningTasksCount() => this.RunningTasksCount.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceConnectDefaults. 
        /// <para>
        /// Use this parameter to set a default Service Connect namespace. After you set a default
        /// Service Connect namespace, any new services with Service Connect turned on that are
        /// created in the cluster are added as client services in the namespace. This setting
        /// only applies to new services that set the <c>enabled</c> parameter to <c>true</c>
        /// in the <c>ServiceConnectConfiguration</c>. You can set the namespace of each service
        /// individually in the <c>ServiceConnectConfiguration</c> to override this default parameter.
        /// </para>
        ///  
        /// <para>
        /// Tasks that run in a namespace can use short names to connect to services in the namespace.
        /// Tasks can connect to services across all of the clusters in the namespace. Tasks connect
        /// through a managed proxy container that collects logs and metrics for increased visibility.
        /// Only the tasks that Amazon ECS services create are supported with Service Connect.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public ClusterServiceConnectDefaults ServiceConnectDefaults { get; set; }

        /// <summary>
        /// Checks to see if the ServiceConnectDefaults property is set.
        /// </summary>
        internal bool IsSetServiceConnectDefaults() => this.ServiceConnectDefaults != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings for the cluster. This parameter indicates whether CloudWatch Container
        /// Insights is on or off for a cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterSetting> Settings { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterSetting>() : null;

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null && (this.Settings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Additional information about your clusters that are separated by launch type. They
        /// include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// runningEC2TasksCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RunningFargateTasksCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// pendingEC2TasksCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// pendingFargateTasksCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// activeEC2ServiceCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// activeFargateServiceCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// drainingEC2ServiceCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// drainingFargateServiceCount
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> Statistics { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null && (this.Statistics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the cluster. The following are the possible states that are returned.
        /// </para>
        ///  <dl> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The cluster is ready to accept tasks and if applicable you can register container
        /// instances with the cluster.
        /// </para>
        ///  </dd> <dt>PROVISIONING</dt> <dd> 
        /// <para>
        /// The cluster has capacity providers that are associated with it and the resources needed
        /// for the capacity provider are being created.
        /// </para>
        ///  </dd> <dt>DEPROVISIONING</dt> <dd> 
        /// <para>
        /// The cluster has capacity providers that are associated with it and the resources needed
        /// for the capacity provider are being deleted.
        /// </para>
        ///  </dd> <dt>FAILED</dt> <dd> 
        /// <para>
        /// The cluster has capacity providers that are associated with it and the resources needed
        /// for the capacity provider have failed to create.
        /// </para>
        ///  </dd> <dt>INACTIVE</dt> <dd> 
        /// <para>
        /// The cluster has been deleted. Clusters with an <c>INACTIVE</c> status may remain discoverable
        /// in your account for a period of time. However, this behavior is subject to change
        /// in the future. We don't recommend that you rely on <c>INACTIVE</c> clusters persisting.
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
        /// The metadata that you apply to the cluster to help you categorize and organize them.
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
    }
}
