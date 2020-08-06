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
    /// the Amazon ECS service-linked role for your account so that required resources in
    /// other AWS services can be managed on your behalf. However, if the IAM user that makes
    /// the call does not have permissions to create the service-linked role, it is not created.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
    /// Service-Linked Roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
    /// Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateClusterRequest : AmazonECSRequest
    {
        private List<string> _capacityProviders = new List<string>();
        private string _clusterName;
        private List<CapacityProviderStrategyItem> _defaultCapacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private List<ClusterSetting> _settings = new List<ClusterSetting>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The short name of one or more capacity providers to associate with the cluster.
        /// </para>
        ///  
        /// <para>
        /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
        /// must already be created and not already associated with another cluster. New capacity
        /// providers can be created with the <a>CreateCapacityProvider</a> API operation.
        /// </para>
        ///  
        /// <para>
        /// To use a AWS Fargate capacity provider, specify either the <code>FARGATE</code> or
        /// <code>FARGATE_SPOT</code> capacity providers. The AWS Fargate capacity providers are
        /// available to all accounts and only need to be associated with a cluster to be used.
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
        /// The name of your cluster. If you do not specify a name for your cluster, you create
        /// a cluster named <code>default</code>. Up to 255 letters (uppercase and lowercase),
        /// numbers, and hyphens are allowed. 
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
        /// Gets and sets the property DefaultCapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy to use by default for the cluster.
        /// </para>
        ///  
        /// <para>
        /// When creating a service or running a task on a cluster, if no capacity provider or
        /// launch type is specified then the default capacity provider strategy for the cluster
        /// is used.
        /// </para>
        ///  
        /// <para>
        /// A capacity provider strategy consists of one or more capacity providers along with
        /// the <code>base</code> and <code>weight</code> to assign to them. A capacity provider
        /// must be associated with the cluster to be used in a capacity provider strategy. The
        /// <a>PutClusterCapacityProviders</a> API is used to associate a capacity provider with
        /// a cluster. Only capacity providers with an <code>ACTIVE</code> or <code>UPDATING</code>
        /// status can be used.
        /// </para>
        ///  
        /// <para>
        /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
        /// must already be created. New capacity providers can be created with the <a>CreateCapacityProvider</a>
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// To use a AWS Fargate capacity provider, specify either the <code>FARGATE</code> or
        /// <code>FARGATE_SPOT</code> capacity providers. The AWS Fargate capacity providers are
        /// available to all accounts and only need to be associated with a cluster to be used.
        /// </para>
        ///  
        /// <para>
        /// If a default capacity provider strategy is not defined for a cluster during creation,
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// The setting to use when creating a cluster. This parameter is used to enable CloudWatch
        /// Container Insights for a cluster. If this value is specified, it will override the
        /// <code>containerInsights</code> value set with <a>PutAccountSetting</a> or <a>PutAccountSettingDefault</a>.
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
        /// Each tag consists of a key and an optional value, both of which you define.
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
        /// of such as a prefix for either keys or values as it is reserved for AWS use. You cannot
        /// edit or delete tag keys or values with this prefix. Tags with this prefix do not count
        /// against your tags per resource limit.
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