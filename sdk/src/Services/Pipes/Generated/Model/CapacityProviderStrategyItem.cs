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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The details of a capacity provider strategy. To learn more, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CapacityProviderStrategyItem.html">CapacityProviderStrategyItem</a>
    /// in the Amazon ECS API Reference.
    /// </summary>
    public partial class CapacityProviderStrategyItem
    {
        private int? _base;
        private string _capacityProvider;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property Base. 
        /// <para>
        /// The base value designates how many tasks, at a minimum, to run on the specified capacity
        /// provider. Only one capacity provider in a capacity provider strategy can have a base
        /// defined. If no value is specified, the default value of 0 is used. 
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
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
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
        /// The weight value designates the relative percentage of the total number of tasks launched
        /// that should use the specified capacity provider. The weight value is taken into consideration
        /// after the base value, if defined, is satisfied.
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