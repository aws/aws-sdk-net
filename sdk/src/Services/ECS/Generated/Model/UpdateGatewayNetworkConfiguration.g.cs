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
    /// The mutable network configuration for the load balancers that a gateway manages.
    /// </summary>
    public partial class UpdateGatewayNetworkConfiguration
    {
        /// <summary>
        /// Gets and sets the property InboundSecurityGroup. 
        /// <para>
        /// The ID of a security group that you provide to control inbound traffic to the load
        /// balancers that the gateway manages. When you specify a security group, the gateway
        /// doesn't create inbound rules on the security group it manages.
        /// </para>
        /// </summary>
        public string InboundSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the InboundSecurityGroup property is set.
        /// </summary>
        internal bool IsSetInboundSecurityGroup() => this.InboundSecurityGroup != null;
    }
}
