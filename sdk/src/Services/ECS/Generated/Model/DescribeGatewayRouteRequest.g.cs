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
    /// Container for the parameters to the DescribeGatewayRoute operation. Describes a gateway
    /// route, including its status, the service it routes traffic to, and the service-specific
    /// infrastructure, such as target groups and listener rules, that the gateway manages
    /// for it.
    /// </summary>
    public partial class DescribeGatewayRouteRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property GatewayRouteArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway route to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayRouteArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayRouteArn property is set.
        /// </summary>
        internal bool IsSetGatewayRouteArn() => this.GatewayRouteArn != null;
    }
}
