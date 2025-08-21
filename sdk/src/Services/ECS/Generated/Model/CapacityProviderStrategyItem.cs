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
    /// The details of a capacity provider strategy. A capacity provider strategy can be set
    /// when using the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_RunTask.html">RunTask</a>or
    /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateCluster.html">CreateCluster</a>
    /// APIs or as the default capacity provider strategy for a cluster with the <c>CreateCluster</c>
    /// API.
    /// 
    ///  
    /// <para>
    /// Only capacity providers that are already associated with a cluster and have an <c>ACTIVE</c>
    /// or <c>UPDATING</c> status can be used in a capacity provider strategy. The <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html">PutClusterCapacityProviders</a>
    /// API is used to associate a capacity provider with a cluster.
    /// </para>
    ///  
    /// <para>
    /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
    /// must already be created. New Auto Scaling group capacity providers can be created
    /// with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateClusterCapacityProvider.html">CreateClusterCapacityProvider</a>
    /// API operation.
    /// </para>
    ///  
    /// <para>
    /// To use a Fargate capacity provider, specify either the <c>FARGATE</c> or <c>FARGATE_SPOT</c>
    /// capacity providers. The Fargate capacity providers are available to all accounts and
    /// only need to be associated with a cluster to be used in a capacity provider strategy.
    /// </para>
    ///  
    /// <para>
    /// With <c>FARGATE_SPOT</c>, you can run interruption tolerant tasks at a rate that's
    /// discounted compared to the <c>FARGATE</c> price. <c>FARGATE_SPOT</c> runs tasks on
    /// spare compute capacity. When Amazon Web Services needs the capacity back, your tasks
    /// are interrupted with a two-minute warning. <c>FARGATE_SPOT</c> supports Linux tasks
    /// with the X86_64 architecture on platform version 1.3.0 or later. <c>FARGATE_SPOT</c>
    /// supports Linux tasks with the ARM64 architecture on platform version 1.4.0 or later.
    /// </para>
    ///  
    /// <para>
    /// A capacity provider strategy can contain a maximum of 20 capacity providers.
    /// </para>
    /// </summary>
    public partial class CapacityProviderStrategyItem
    {
        private int? _base;
        private string _capacityProvider;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property Base. 
        /// <para>
        /// The <i>base</i> value designates how many tasks, at a minimum, to run on the specified
        /// capacity provider for each service. Only one capacity provider in a capacity provider
        /// strategy can have a <i>base</i> defined. If no value is specified, the default value
        /// of <c>0</c> is used.
        /// </para>
        ///  
        /// <para>
        /// Base value characteristics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Only one capacity provider in a strategy can have a base defined
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default value is <c>0</c> if not specified
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid range: 0 to 100,000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Base requirements are satisfied first before weight distribution
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int? Base
        {
            get { return this._base; }
            set { this._base = value; }
        }

        // Check to see if Base property is set
        internal bool IsSetBase()
        {
            return this._base.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityProvider. 
        /// <para>
        /// The short name of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityProvider
        {
            get { return this._capacityProvider; }
            set { this._capacityProvider = value; }
        }

        // Check to see if CapacityProvider property is set
        internal bool IsSetCapacityProvider()
        {
            return this._capacityProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The <i>weight</i> value designates the relative percentage of the total number of
        /// tasks launched that should use the specified capacity provider. The <c>weight</c>
        /// value is taken into consideration after the <c>base</c> value, if defined, is satisfied.
        /// </para>
        ///  
        /// <para>
        /// If no <c>weight</c> value is specified, the default value of <c>0</c> is used. When
        /// multiple capacity providers are specified within a capacity provider strategy, at
        /// least one of the capacity providers must have a weight value greater than zero and
        /// any capacity providers with a weight of <c>0</c> can't be used to place tasks. If
        /// you specify multiple capacity providers in a strategy that all have a weight of <c>0</c>,
        /// any <c>RunTask</c> or <c>CreateService</c> actions using the capacity provider strategy
        /// will fail.
        /// </para>
        ///  
        /// <para>
        /// Weight value characteristics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Weight is considered after the base value is satisfied
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default value is <c>0</c> if not specified
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid range: 0 to 1,000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At least one capacity provider must have a weight greater than zero
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Capacity providers with weight of <c>0</c> cannot place tasks
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Task distribution logic:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Base satisfaction: The minimum number of tasks specified by the base value are placed
        /// on that capacity provider
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Weight distribution: After base requirements are met, additional tasks are distributed
        /// according to weight ratios
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Examples:
        /// </para>
        ///  
        /// <para>
        /// Equal Distribution: Two capacity providers both with weight <c>1</c> will split tasks
        /// evenly after base requirements are met.
        /// </para>
        ///  
        /// <para>
        /// Weighted Distribution: If capacityProviderA has weight <c>1</c> and capacityProviderB
        /// has weight <c>4</c>, then for every 1 task on A, 4 tasks will run on B.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}