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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
    /// any new ones you want to add. Any existing capacity providers associated with a cluster
    /// that are omitted from a <a>PutClusterCapacityProviders</a> API call will be disassociated
    /// with the cluster. You can only disassociate an existing capacity provider from a cluster
    /// if it's not being used by any existing tasks.
    /// </para>
    ///  
    /// <para>
    /// When creating a service or running a task on a cluster, if no capacity provider or
    /// launch type is specified, then the cluster's default capacity provider strategy is
    /// used. It is recommended to define a default capacity provider strategy for your cluster,
    /// however you may specify an empty array (<code>[]</code>) to bypass defining a default
    /// strategy.
    /// </para>
    /// </summary>
    public partial class PutClusterCapacityProvidersRequest : AmazonECSRequest
    {
        private List<string> _capacityProviders = new List<string>();
        private string _cluster;
        private List<CapacityProviderStrategyItem> _defaultCapacityProviderStrategy = new List<CapacityProviderStrategyItem>();

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The name of one or more capacity providers to associate with the cluster.
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
            return this._capacityProviders != null && this._capacityProviders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster to modify the capacity
        /// provider settings for. If you do not specify a cluster, the default cluster is assumed.
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
            return this._defaultCapacityProviderStrategy != null && this._defaultCapacityProviderStrategy.Count > 0; 
        }

    }
}