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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the PutClusterCapacityProviders operation.
    /// Modifies the available capacity providers and the default capacity provider strategy
    /// for a cluster.
    /// 
    ///  
    /// <para>
    /// You must specify both the available capacity providers and a default capacity provider
    /// strategy for the cluster. If the specified cluster has existing capacity providers
    /// associated with it, you must specify all existing capacity providers in addition to
    /// any new ones you want to add. Any existing capacity providers that are associated
    /// with a cluster that are omitted from a <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html">PutClusterCapacityProviders</a>
    /// API call will be disassociated with the cluster. You can only disassociate an existing
    /// capacity provider from a cluster if it's not being used by any existing tasks.
    /// </para>
    ///  
    /// <para>
    /// When creating a service or running a task on a cluster, if no capacity provider or
    /// launch type is specified, then the cluster's default capacity provider strategy is
    /// used. We recommend that you define a default capacity provider strategy for your cluster.
    /// However, you must specify an empty array (<c>[]</c>) to bypass defining a default
    /// strategy.
    /// </para>
    ///  
    /// <para>
    /// Amazon ECS Managed Instances doesn't support this, because when you create a capacity
    /// provider with Amazon ECS Managed Instances, it becomes available only within the specified
    /// cluster.
    /// </para>
    /// </summary>
    public partial class PutClusterCapacityProvidersRequest : AmazonECSRequest
    {
        private List<string> _capacityProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _cluster;
        private List<CapacityProviderStrategyItem> _defaultCapacityProviderStrategy = AWSConfigs.InitializeCollections ? new List<CapacityProviderStrategyItem>() : null;

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The name of one or more capacity providers to associate with the cluster.
        /// </para>
        ///  
        /// <para>
        /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
        /// must already be created. New capacity providers can be created with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateCapacityProvider.html">CreateCapacityProvider</a>
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// To use a Fargate capacity provider, specify either the <c>FARGATE</c> or <c>FARGATE_SPOT</c>
        /// capacity providers. The Fargate capacity providers are available to all accounts and
        /// only need to be associated with a cluster to be used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CapacityProviders
        {
            get { return this._capacityProviders; }
            set { this._capacityProviders = value; }
        }

        // Check to see if CapacityProviders property is set
        internal bool IsSetCapacityProviders()
        {
            return this._capacityProviders != null && (this._capacityProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster to modify the capacity
        /// provider settings for. If you don't specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
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
        /// the <c>base</c> and <c>weight</c> to assign to them. A capacity provider must be associated
        /// with the cluster to be used in a capacity provider strategy. The <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html">PutClusterCapacityProviders</a>
        /// API is used to associate a capacity provider with a cluster. Only capacity providers
        /// with an <c>ACTIVE</c> or <c>UPDATING</c> status can be used.
        /// </para>
        ///  
        /// <para>
        /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
        /// must already be created. New capacity providers can be created with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateCapacityProvider.html">CreateCapacityProvider</a>
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// To use a Fargate capacity provider, specify either the <c>FARGATE</c> or <c>FARGATE_SPOT</c>
        /// capacity providers. The Fargate capacity providers are available to all accounts and
        /// only need to be associated with a cluster to be used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CapacityProviderStrategyItem> DefaultCapacityProviderStrategy
        {
            get { return this._defaultCapacityProviderStrategy; }
            set { this._defaultCapacityProviderStrategy = value; }
        }

        // Check to see if DefaultCapacityProviderStrategy property is set
        internal bool IsSetDefaultCapacityProviderStrategy()
        {
            return this._defaultCapacityProviderStrategy != null && (this._defaultCapacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}