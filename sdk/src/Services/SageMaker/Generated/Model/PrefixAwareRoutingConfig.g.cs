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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration for prefix-aware routing on a SageMaker real-time inference endpoint.
    /// Specify <c>PrefixLength</c> and <c>ConcurrencyThreshold</c> to control routing behavior.
    /// </summary>
    public partial class PrefixAwareRoutingConfig
    {
        /// <summary>
        /// Gets and sets the property ConcurrencyThreshold. 
        /// <para>
        /// The number of in-flight requests on the selected instance or inference component copy
        /// at which the endpoint routes a request to another copy or instance. Required when
        /// <c>RoutingStrategy</c> is <c>PREFIX_AWARE</c>.
        /// </para>
        ///  
        /// <para>
        /// On an endpoint without inference components, the endpoint compares this threshold
        /// with the number of in-flight requests on the selected instance. When that number reaches
        /// the threshold, the endpoint routes the request to another instance.
        /// </para>
        ///  
        /// <para>
        /// On an endpoint with inference components, the endpoint compares this threshold with
        /// the number of in-flight requests on the selected copy of the invoked inference component.
        /// Requests to other inference components on the same instance don't count. When the
        /// instance hosts more than one copy of the inference component, the endpoint routes
        /// requests that share a prefix to the same copy and, while that copy has reached the
        /// threshold, to another copy on the instance that is under the threshold. When every
        /// copy on the instance has reached the threshold, the endpoint routes the request to
        /// another instance.
        /// </para>
        ///  
        /// <para>
        /// The threshold applies to every instance and every copy of every inference component
        /// in the production variant, so choose a value that suits the instance or copy that
        /// can serve the fewest concurrent requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public int? ConcurrencyThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrencyThreshold property is set.
        /// </summary>
        internal bool IsSetConcurrencyThreshold() => this.ConcurrencyThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixLength. 
        /// <para>
        /// The maximum length of the prefix used for routing decisions. Required when <c>RoutingStrategy</c>
        /// is <c>PREFIX_AWARE</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the SageMaker Runtime <c>InvokeEndpoint</c> and <c>InvokeEndpointWithResponseStream</c>
        /// APIs, this value specifies the number of bytes from the beginning of the request body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For OpenAI-compatible API, this value specifies the number of characters from the
        /// text content of the messages array.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The endpoint routes requests that share the same prefix to the same instance and,
        /// when that instance hosts more than one copy of the invoked inference component, to
        /// the same copy. Set this value to cover shared content (such as system prompts) plus
        /// enough unique content to distribute workloads across instances and copies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 65536)]
        public int? PrefixLength { get; set; }

        /// <summary>
        /// Checks to see if the PrefixLength property is set.
        /// </summary>
        internal bool IsSetPrefixLength() => this.PrefixLength.HasValue;
    }
}
