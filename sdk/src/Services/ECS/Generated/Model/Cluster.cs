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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private int? _activeServicesCount;
        private List<Attachment> _attachments = new List<Attachment>();
        private string _attachmentsStatus;
        private List<string> _capacityProviders = new List<string>();
        private string _clusterArn;
        private string _clusterName;
        private ClusterConfiguration _configuration;
        private List<CapacityProviderStrategyItem> _defaultCapacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private int? _pendingTasksCount;
        private int? _registeredContainerInstancesCount;
        private int? _runningTasksCount;
        private ClusterServiceConnectDefaults _serviceConnectDefaults;
        private List<ClusterSetting> _settings = new List<ClusterSetting>();
        private List<KeyValuePair> _statistics = new List<KeyValuePair>();
        private string _status;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ActiveServicesCount. 
        /// <para>
        /// The number of services that are running on the cluster in an <code>ACTIVE</code> state.
        /// You can view these services with <a>ListServices</a>.
        /// </para>
        /// </summary>
        public int ActiveServicesCount
        {
            get { return this._activeServicesCount.GetValueOrDefault(); }
            set { this._activeServicesCount = value; }
        }

        // Check to see if ActiveServicesCount property is set
        internal bool IsSetActiveServicesCount()
        {
            return this._activeServicesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The resources attached to a cluster. When using a capacity provider with a cluster,
        /// the capacity provider and associated resources are returned as cluster attachments.
        /// </para>
        /// </summary>
        public List<Attachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

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
        public string AttachmentsStatus
        {
            get { return this._attachmentsStatus; }
            set { this._attachmentsStatus = value; }
        }

        // Check to see if AttachmentsStatus property is set
        internal bool IsSetAttachmentsStatus()
        {
            return this._attachmentsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The capacity providers associated with the cluster.
        /// </para>
        /// </summary>
        public List<string> CapacityProviders
        {
            get { return this._capacityProviders; }
            set { this._capacityProviders = value; }
        }

        // Check to see if CapacityProviders property is set
        internal bool IsSetCapacityProviders()
        {
            return this._capacityProviders != null && this._capacityProviders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the cluster. For more information about
        /// the ARN format, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#ecs-resource-ids">Amazon
        /// Resource Name (ARN)</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A user-generated string that you use to identify your cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The execute command configuration for the cluster.
        /// </para>
        /// </summary>
        public ClusterConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCapacityProviderStrategy. 
        /// <para>
        /// The default capacity provider strategy for the cluster. When services or tasks are
        /// run in the cluster with no launch type or capacity provider strategy specified, the
        /// default capacity provider strategy is used.
        /// </para>
        /// </summary>
        public List<CapacityProviderStrategyItem> DefaultCapacityProviderStrategy
        {
            get { return this._defaultCapacityProviderStrategy; }
            set { this._defaultCapacityProviderStrategy = value; }
        }

        // Check to see if DefaultCapacityProviderStrategy property is set
        internal bool IsSetDefaultCapacityProviderStrategy()
        {
            return this._defaultCapacityProviderStrategy != null && this._defaultCapacityProviderStrategy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PendingTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <code>PENDING</code> state.
        /// </para>
        /// </summary>
        public int PendingTasksCount
        {
            get { return this._pendingTasksCount.GetValueOrDefault(); }
            set { this._pendingTasksCount = value; }
        }

        // Check to see if PendingTasksCount property is set
        internal bool IsSetPendingTasksCount()
        {
            return this._pendingTasksCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisteredContainerInstancesCount. 
        /// <para>
        /// The number of container instances registered into the cluster. This includes container
        /// instances in both <code>ACTIVE</code> and <code>DRAINING</code> status.
        /// </para>
        /// </summary>
        public int RegisteredContainerInstancesCount
        {
            get { return this._registeredContainerInstancesCount.GetValueOrDefault(); }
            set { this._registeredContainerInstancesCount = value; }
        }

        // Check to see if RegisteredContainerInstancesCount property is set
        internal bool IsSetRegisteredContainerInstancesCount()
        {
            return this._registeredContainerInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <code>RUNNING</code> state.
        /// </para>
        /// </summary>
        public int RunningTasksCount
        {
            get { return this._runningTasksCount.GetValueOrDefault(); }
            set { this._runningTasksCount = value; }
        }

        // Check to see if RunningTasksCount property is set
        internal bool IsSetRunningTasksCount()
        {
            return this._runningTasksCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceConnectDefaults. 
        /// <para>
        /// Use this parameter to set a default Service Connect namespace. After you set a default
        /// Service Connect namespace, any new services with Service Connect turned on that are
        /// created in the cluster are added as client services in the namespace. This setting
        /// only applies to new services that set the <code>enabled</code> parameter to <code>true</code>
        /// in the <code>ServiceConnectConfiguration</code>. You can set the namespace of each
        /// service individually in the <code>ServiceConnectConfiguration</code> to override this
        /// default parameter.
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
        public ClusterServiceConnectDefaults ServiceConnectDefaults
        {
            get { return this._serviceConnectDefaults; }
            set { this._serviceConnectDefaults = value; }
        }

        // Check to see if ServiceConnectDefaults property is set
        internal bool IsSetServiceConnectDefaults()
        {
            return this._serviceConnectDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings for the cluster. This parameter indicates whether CloudWatch Container
        /// Insights is enabled or disabled for a cluster.
        /// </para>
        /// </summary>
        public List<ClusterSetting> Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null && this._settings.Count > 0; 
        }

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
        /// </summary>
        public List<KeyValuePair> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

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
        /// The cluster has been deleted. Clusters with an <code>INACTIVE</code> status may remain
        /// discoverable in your account for a period of time. However, this behavior is subject
        /// to change in the future. We don't recommend that you rely on <code>INACTIVE</code>
        /// clusters persisting.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        /// Do not use <code>aws:</code>, <code>AWS:</code>, or any upper or lowercase combination
        /// of such as a prefix for either keys or values as it is reserved for Amazon Web Services
        /// use. You cannot edit or delete tag keys or values with this prefix. Tags with this
        /// prefix do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}