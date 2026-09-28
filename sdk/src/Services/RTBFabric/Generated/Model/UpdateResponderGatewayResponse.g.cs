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
    /// This is the response object from the UpdateResponderGateway operation.
    /// </summary>
    public partial class UpdateResponderGatewayResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientRoutingPolicy. 
        /// <para>
        /// The client routing policy of the gateway. If the operation changed this policy, the
        /// gateway uses the new policy after its status returns to <c>ACTIVE</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/rtb-fabric/latest/userguide/working-with-responder-gateways.html#configuring-availability-zone-affinity">Configuring
        /// Availability Zone affinity</a> in the <i>Amazon Web Services RTB Fabric User Guide</i>.
        /// </para>
        /// </summary>
        public ClientRoutingPolicy ClientRoutingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ClientRoutingPolicy property is set.
        /// </summary>
        internal bool IsSetClientRoutingPolicy() => this.ClientRoutingPolicy != null;

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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResponderGatewayStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
