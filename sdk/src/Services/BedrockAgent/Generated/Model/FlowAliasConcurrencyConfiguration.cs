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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Determines how multiple nodes in a flow can run in parallel. Running nodes concurrently
    /// can improve your flow's performance.
    /// </summary>
    public partial class FlowAliasConcurrencyConfiguration
    {
        private int? _maxConcurrency;
        private ConcurrencyType _type;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of nodes that can be executed concurrently in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of concurrency to use for parallel node execution. Specify one of the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Automatic</c> - Amazon Bedrock determines which nodes can be executed in parallel
        /// based on the flow definition and its dependencies.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Manual</c> - You specify which nodes can be executed in parallel.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConcurrencyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}