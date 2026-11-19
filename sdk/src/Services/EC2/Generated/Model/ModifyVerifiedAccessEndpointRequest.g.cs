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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVerifiedAccessEndpoint operation. Modifies
    /// the configuration of the specified Amazon Web Services Verified Access endpoint.
    /// </summary>
    public partial class ModifyVerifiedAccessEndpointRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CidrOptions. 
        /// <para>
        /// The CIDR options.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessEndpointCidrOptions CidrOptions { get; set; }

        /// <summary>
        /// Checks to see if the CidrOptions property is set.
        /// </summary>
        internal bool IsSetCidrOptions() => this.CidrOptions != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Verified Access endpoint.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property LoadBalancerOptions. 
        /// <para>
        /// The load balancer details if creating the Verified Access endpoint as <c>load-balancer</c>type.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessEndpointLoadBalancerOptions LoadBalancerOptions { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerOptions property is set.
        /// </summary>
        internal bool IsSetLoadBalancerOptions() => this.LoadBalancerOptions != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceOptions. 
        /// <para>
        /// The network interface options.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessEndpointEniOptions NetworkInterfaceOptions { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceOptions property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceOptions() => this.NetworkInterfaceOptions != null;

        /// <summary>
        /// Gets and sets the property RdsOptions. 
        /// <para>
        /// The RDS options.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessEndpointRdsOptions RdsOptions { get; set; }

        /// <summary>
        /// Checks to see if the RdsOptions property is set.
        /// </summary>
        internal bool IsSetRdsOptions() => this.RdsOptions != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointId. 
        /// <para>
        /// The ID of the Verified Access endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VerifiedAccessEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessEndpointId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessEndpointId() => this.VerifiedAccessEndpointId != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupId. 
        /// <para>
        /// The ID of the Verified Access group.
        /// </para>
        /// </summary>
        public string VerifiedAccessGroupId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessGroupId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessGroupId() => this.VerifiedAccessGroupId != null;
    }
}
