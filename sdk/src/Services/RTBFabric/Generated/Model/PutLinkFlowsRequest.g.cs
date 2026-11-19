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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the PutLinkFlows operation. Replaces a link's flow
    /// configuration. The change applies asynchronously. The call returns once the change
    /// is accepted, and the link serves its prior flows until the update commits atomically.
    /// RTB Fabric validates the request before accepting it, and a request that fails validation
    /// changes nothing. After the call, use GetLink. Once the change completes, the link's
    /// status is ACTIVE again and its flows show the change.
    /// </summary>
    public partial class PutLinkFlowsRequest : AmazonRTBFabricRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you retry with the same token and parameters,
        /// you get the original response without an error. If you retry with the same token but
        /// different parameters, the call fails with ValidationException. If you don't provide
        /// a token, the SDK generates one, and RTB Fabric remembers it for 8 hours. A retry returns
        /// the original <c>updateId</c> before <c>lockToken</c> is checked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Flows. 
        /// <para>
        /// The link's flows, replacing the current ones. An empty list removes every flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 1)]
        public List<Flow> Flows { get; set; } = AWSConfigs.InitializeCollections ? new List<Flow>() : null;

        /// <summary>
        /// Checks to see if the Flows property is set.
        /// </summary>
        internal bool IsSetFlows() => this.Flows != null && (this.Flows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 32)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The unique identifier of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 30)]
        public string LinkId { get; set; }

        /// <summary>
        /// Checks to see if the LinkId property is set.
        /// </summary>
        internal bool IsSetLinkId() => this.LinkId != null;

        /// <summary>
        /// Gets and sets the property LockToken. 
        /// <para>
        /// The concurrency token that you read from GetLink. If the link changed since that read,
        /// by any operation, the call fails with ConflictException.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string LockToken { get; set; }

        /// <summary>
        /// Checks to see if the LockToken property is set.
        /// </summary>
        internal bool IsSetLockToken() => this.LockToken != null;
    }
}
