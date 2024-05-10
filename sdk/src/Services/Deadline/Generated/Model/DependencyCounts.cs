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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
        private int? _consumersResolved;
        private int? _consumersUnresolved;
        private int? _dependenciesResolved;
        private int? _dependenciesUnresolved;

        /// <summary>
        /// Gets and sets the property ConsumersResolved. 
        /// <para>
        /// The number of consumers resolved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ConsumersResolved
        {
            get { return this._consumersResolved; }
            set { this._consumersResolved = value; }
        }

        // Check to see if ConsumersResolved property is set
        internal bool IsSetConsumersResolved()
        {
            return this._consumersResolved.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumersUnresolved. 
        /// <para>
        /// The number of unresolved consumers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ConsumersUnresolved
        {
            get { return this._consumersUnresolved; }
            set { this._consumersUnresolved = value; }
        }

        // Check to see if ConsumersUnresolved property is set
        internal bool IsSetConsumersUnresolved()
        {
            return this._consumersUnresolved.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DependenciesResolved. 
        /// <para>
        /// The number of resolved dependencies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DependenciesResolved
        {
            get { return this._dependenciesResolved; }
            set { this._dependenciesResolved = value; }
        }

        // Check to see if DependenciesResolved property is set
        internal bool IsSetDependenciesResolved()
        {
            return this._dependenciesResolved.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DependenciesUnresolved. 
        /// <para>
        /// The number of unresolved dependencies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DependenciesUnresolved
        {
            get { return this._dependenciesUnresolved; }
            set { this._dependenciesUnresolved = value; }
        }

        // Check to see if DependenciesUnresolved property is set
        internal bool IsSetDependenciesUnresolved()
        {
            return this._dependenciesUnresolved.HasValue; 
        }

    }
}