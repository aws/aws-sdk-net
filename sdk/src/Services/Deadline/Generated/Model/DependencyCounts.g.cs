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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The number of dependencies for the consumer.
    /// </summary>
    public partial class DependencyCounts
    {
        /// <summary>
        /// Gets and sets the property ConsumersResolved. 
        /// <para>
        /// The number of consumers resolved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ConsumersResolved { get; set; }

        /// <summary>
        /// Checks to see if the ConsumersResolved property is set.
        /// </summary>
        internal bool IsSetConsumersResolved() => this.ConsumersResolved.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumersUnresolved. 
        /// <para>
        /// The number of unresolved consumers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ConsumersUnresolved { get; set; }

        /// <summary>
        /// Checks to see if the ConsumersUnresolved property is set.
        /// </summary>
        internal bool IsSetConsumersUnresolved() => this.ConsumersUnresolved.HasValue;

        /// <summary>
        /// Gets and sets the property DependenciesResolved. 
        /// <para>
        /// The number of resolved dependencies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DependenciesResolved { get; set; }

        /// <summary>
        /// Checks to see if the DependenciesResolved property is set.
        /// </summary>
        internal bool IsSetDependenciesResolved() => this.DependenciesResolved.HasValue;

        /// <summary>
        /// Gets and sets the property DependenciesUnresolved. 
        /// <para>
        /// The number of unresolved dependencies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DependenciesUnresolved { get; set; }

        /// <summary>
        /// Checks to see if the DependenciesUnresolved property is set.
        /// </summary>
        internal bool IsSetDependenciesUnresolved() => this.DependenciesUnresolved.HasValue;
    }
}
