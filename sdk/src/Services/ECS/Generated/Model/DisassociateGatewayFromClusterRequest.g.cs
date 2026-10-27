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
    /// Container for the parameters to the DisassociateGatewayFromCluster operation. Removes
    /// the association between a gateway and an Amazon ECS cluster. The association remains
    /// in the <c>DISASSOCIATING</c> state until you remove all of the gateway routes for
    /// the cluster by updating the associated services. You can use <c>ListGatewayRoutes</c>
    /// with a cluster filter to determine which routes are preventing disassociation. No
    /// infrastructure changes are made until the affected services are updated.
    /// </summary>
    public partial class DisassociateGatewayFromClusterRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the cluster to disassociate the gateway
        /// from.
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
        /// The name or Amazon Resource Name (ARN) of the gateway to disassociate.
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
