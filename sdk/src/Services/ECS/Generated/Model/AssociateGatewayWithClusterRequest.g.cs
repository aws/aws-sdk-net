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
    /// Container for the parameters to the AssociateGatewayWithCluster operation. Associates
    /// a gateway with an Amazon ECS cluster. After a cluster is associated with a gateway,
    /// services in that cluster can use the gateway for ingress. No changes take effect until
    /// you update a service in the cluster to use the gateway. A single cluster can be associated
    /// with up to 5 gateways.
    /// </summary>
    public partial class AssociateGatewayWithClusterRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the cluster to associate the gateway with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property Gateway. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the gateway to associate.
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
