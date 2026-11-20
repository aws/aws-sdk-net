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
    /// Container for the parameters to the UpdateGlobalInferenceGateway operation. Updates
    /// the routing configuration of a global inference gateway. To add or remove in-cluster
    /// inference gateways, use `AddInferenceGateway` and `RemoveInferenceGateway`. This operation
    /// is asynchronous: the global inference gateway moves to the `UPDATING` status. The
    /// operation fails with `ConflictException` while another operation is in progress on
    /// the global inference gateway.
    /// </summary>
    public partial class UpdateGlobalInferenceGatewayRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The name, Amazon Resource Name (ARN), or ID of the global inference gateway to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Routing. 
        /// <para>
        /// The new routing configuration of the global inference gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GlobalInferenceGatewayRouting Routing { get; set; }

        /// <summary>
        /// Checks to see if the Routing property is set.
        /// </summary>
        internal bool IsSetRouting() => this.Routing != null;
    }
}
