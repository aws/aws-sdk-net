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
    /// The routing configuration of a global inference gateway. To add or remove in-cluster
    /// inference gateways, use `AddInferenceGateway` and `RemoveInferenceGateway`.
    /// </summary>
    public partial class GlobalInferenceGatewayRouting
    {
        /// <summary>
        /// Gets and sets the property Weights. 
        /// <para>
        /// The weights that the global inference gateway applies to each routing signal when
        /// it scores the in-cluster inference gateways for a request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GlobalInferenceGatewayRoutingWeights Weights { get; set; }

        /// <summary>
        /// Checks to see if the Weights property is set.
        /// </summary>
        internal bool IsSetWeights() => this.Weights != null;
    }
}
