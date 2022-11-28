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
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a new Amazon ECS cluster. By default, your account receives a <code>default</code>
    /// cluster when you launch your first container instance. However, you can create your
    /// own cluster with a unique name with the <code>CreateCluster</code> action.
    /// 
    ///  <note> 
    /// <para>
    /// When you call the <a>CreateCluster</a> API operation, Amazon ECS attempts to create
    /// the Amazon ECS service-linked role for your account. This is so that it can manage
    /// required resources in other Amazon Web Services services on your behalf. However,
    /// if the IAM user that makes the call doesn't have permissions to create the service-linked
    /// role, it isn't created. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
    /// service-linked roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
    /// Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateClusterRequest : AmazonECSRequest
    {
        private List<string> _capacityProviders = new List<string>();
        private string _clusterName;
        private ClusterConfiguration _configuration;
        private List<CapacityProviderStrategyItem> _defaultCapacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private ClusterServiceConnectDefaultsRequest _serviceConnectDefaults;
        private List<ClusterSetting> _settings = new List<ClusterSetting>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The short name of one or more capacity providers to associate with the cluster. A
        /// capacity provider must be associated with a cluster before it can be included as part
        /// of the default capacity provider strategy of the cluster or used in a capacity provider
        /// strategy when calling the <a>CreateService</a> or <a>RunTask</a> actions.
        /// </para>
        ///  
        /// <para>
        /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
        /// must be created but not associated with another cluster. New Auto Scaling group capacity
        /// providers can be created with the <a>CreateCapacityProvider</a> API operation.
        /// </para>
        ///  
        /// <para>
        /// To use a Fargate capacity provider, specify either the <code>FARGATE</code> or <code>FARGATE_SPOT</code>
        /// capacity providers. The Fargate capacity providers are available to all accounts and
        /// only need to be associated with a cluster to be used.
        /// </para>
        ///  
        /// <para>
        /// The <a>PutClusterCapacityProviders</a> API operation is used to update the list of
        /// available capacity providers for a cluster after the cluster is created.
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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster. If you don't specify a name for your cluster, you create
        /// a cluster that's named <code>default</code>. Up to 255 letters (uppercase and lowercase),
        /// numbers, underscores, and hyphens are allowed. 
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
        /// The <code>execute</code> command configuration for the cluster.
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
        /// The capacity provider strategy to set as the default for the cluster. After a default
        /// capacity provider strategy is set for a cluster, when you call the <a>RunTask</a>
        /// or <a>CreateService</a> APIs with no capacity provider strategy or launch type specified,
        /// the default capacity provider strategy for the cluster is used.
        /// </para>
        ///  
        /// <para>
        /// If a default capacity provider strategy isn't defined for a cluster when it was created,
        /// it can be defined later with the <a>PutClusterCapacityProviders</a> API operation.
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
        public ClusterServiceConnectDefaultsRequest ServiceConnectDefaults
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
        /// The setting to use when creating a cluster. This parameter is used to turn on CloudWatch
        /// Container Insights for a cluster. If this value is specified, it overrides the <code>containerInsights</code>
        /// value set with <a>PutAccountSetting</a> or <a>PutAccountSettingDefault</a>.
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