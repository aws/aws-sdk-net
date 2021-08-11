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
    /// The details of a capacity provider strategy. A capacity provider strategy can be set
    /// when using the <a>RunTask</a> or <a>CreateCluster</a> APIs or as the default capacity
    /// provider strategy for a cluster with the <a>CreateCluster</a> API.
    /// 
    ///  
    /// <para>
    /// Only capacity providers that are already associated with a cluster and have an <code>ACTIVE</code>
    /// or <code>UPDATING</code> status can be used in a capacity provider strategy. The <a>PutClusterCapacityProviders</a>
    /// API is used to associate a capacity provider with a cluster.
    /// </para>
    ///  
    /// <para>
    /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
    /// must already be created. New Auto Scaling group capacity providers can be created
    /// with the <a>CreateCapacityProvider</a> API operation.
    /// </para>
    ///  
    /// <para>
    /// To use a Fargate capacity provider, specify either the <code>FARGATE</code> or <code>FARGATE_SPOT</code>
    /// capacity providers. The Fargate capacity providers are available to all accounts and
    /// only need to be associated with a cluster to be used in a capacity provider strategy.
    /// </para>
    ///  
    /// <para>
    /// A capacity provider strategy may contain a maximum of 6 capacity providers.
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
        /// capacity provider. Only one capacity provider in a capacity provider strategy can
        /// have a <i>base</i> defined. If no value is specified, the default value of <code>0</code>
        /// is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int Base
        {
            get { return this._base.GetValueOrDefault(); }
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
        /// tasks launched that should use the specified capacity provider. The <code>weight</code>
        /// value is taken into consideration after the <code>base</code> value, if defined, is
        /// satisfied.
        /// </para>
        ///  
        /// <para>
        /// If no <code>weight</code> value is specified, the default value of <code>0</code>
        /// is used. When multiple capacity providers are specified within a capacity provider
        /// strategy, at least one of the capacity providers must have a weight value greater
        /// than zero and any capacity providers with a weight of <code>0</code> will not be used
        /// to place tasks. If you specify multiple capacity providers in a strategy that all
        /// have a weight of <code>0</code>, any <code>RunTask</code> or <code>CreateService</code>
        /// actions using the capacity provider strategy will fail.
        /// </para>
        ///  
        /// <para>
        /// An example scenario for using weights is defining a strategy that contains two capacity
        /// providers and both have a weight of <code>1</code>, then when the <code>base</code>
        /// is satisfied, the tasks will be split evenly across the two capacity providers. Using
        /// that same logic, if you specify a weight of <code>1</code> for <i>capacityProviderA</i>
        /// and a weight of <code>4</code> for <i>capacityProviderB</i>, then for every one task
        /// that is run using <i>capacityProviderA</i>, four tasks would use <i>capacityProviderB</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int Weight
        {
            get { return this._weight.GetValueOrDefault(); }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}