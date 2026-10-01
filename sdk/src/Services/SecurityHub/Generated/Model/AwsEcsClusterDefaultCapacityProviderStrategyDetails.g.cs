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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The default capacity provider strategy for the cluster. The default capacity provider
    /// strategy is used when services or tasks are run without a specified launch type or
    /// capacity provider strategy.
    /// </summary>
    public partial class AwsEcsClusterDefaultCapacityProviderStrategyDetails
    {
        /// <summary>
        /// Gets and sets the property Base. 
        /// <para>
        /// The minimum number of tasks to run on the specified capacity provider.
        /// </para>
        /// </summary>
        public int? Base { get; set; }

        /// <summary>
        /// Checks to see if the Base property is set.
        /// </summary>
        internal bool IsSetBase() => this.Base.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityProvider. 
        /// <para>
        /// The name of the capacity provider.
        /// </para>
        /// </summary>
        public string CapacityProvider { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProvider property is set.
        /// </summary>
        internal bool IsSetCapacityProvider() => this.CapacityProvider != null;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The relative percentage of the total number of tasks launched that should use the
        /// capacity provider.
        /// </para>
        /// </summary>
        public int? Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight.HasValue;
    }
}
