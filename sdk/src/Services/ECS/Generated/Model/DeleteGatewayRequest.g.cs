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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteGateway operation. Deletes a gateway. Before
    /// you can delete a gateway, deletion protection must be disabled and the gateway must
    /// not have any cluster associations that are in the <c>ACTIVE</c> or <c>DISASSOCIATING</c>
    /// state. If associations exist, the operation fails; disassociate all clusters first.
    /// <c>DeleteGateway</c> is a synchronous operation. After you delete a gateway, subsequent
    /// requests for it return a <c>GatewayNotFoundException</c>.
    /// </summary>
    public partial class DeleteGatewayRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Gateway. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the gateway to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Checks to see if the Gateway property is set.
        /// </summary>
        internal bool IsSetGateway() => this.Gateway != null;
    }
}
