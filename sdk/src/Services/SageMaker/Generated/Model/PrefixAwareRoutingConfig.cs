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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private int? _concurrencyThreshold;
        private int? _prefixLength;

        /// <summary>
        /// Gets and sets the property ConcurrencyThreshold. 
        /// <para>
        /// The maximum number of in-flight requests on the target instance before the endpoint
        /// routes to another instance. Required when <c>RoutingStrategy</c> is <c>PREFIX_AWARE</c>.
        /// When in-flight requests on the prefix-selected instance reach this threshold, the
        /// endpoint routes the request to an instance with more available capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int? ConcurrencyThreshold
        {
            get { return this._concurrencyThreshold; }
            set { this._concurrencyThreshold = value; }
        }

        // Check to see if ConcurrencyThreshold property is set
        internal bool IsSetConcurrencyThreshold()
        {
            return this._concurrencyThreshold.HasValue; 
        }

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
        /// The endpoint routes requests that share the same prefix to the same instance. Set
        /// this value to cover shared content (such as system prompts) plus enough unique content
        /// to distribute workloads across instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=65536)]
        public int? PrefixLength
        {
            get { return this._prefixLength; }
            set { this._prefixLength = value; }
        }

        // Check to see if PrefixLength property is set
        internal bool IsSetPrefixLength()
        {
            return this._prefixLength.HasValue; 
        }

    }
}