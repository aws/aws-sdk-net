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
    /// Container for the parameters to the ModifyNetworkingFlexCostAllocationPolicy operation.
    /// Modifies a flex cost allocation policy. Changing a policy document or <c>ShowBackEnabled</c>
    /// creates a new version of the policy. Changing only the description doesn't create
    /// a new version. <para> A policy can have up to 100 versions. Versions are never removed,
    /// so after a policy reaches 100 versions, you can't change its policy document or <c>ShowBackEnabled</c>.
    /// Policies that are managed by a declarative policy aren't subject to this limit. </para>
    /// </summary>
    public partial class ModifyNetworkingFlexCostAllocationPolicyRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
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
        /// A description for the policy. The description can be up to 1024 characters long.
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
        /// Gets and sets the property FcaPolicyId. 
        /// <para>
        /// The ID of the flex cost allocation policy to modify. This parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string FcaPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the FcaPolicyId property is set.
        /// </summary>
        internal bool IsSetFcaPolicyId() => this.FcaPolicyId != null;

        /// <summary>
        /// Gets and sets the property InstanceFcaPolicyDocument. 
        /// <para>
        /// The updated policy document that defines cost allocation for EC2 instances.
        /// </para>
        /// </summary>
        public InstanceFlexCostAllocationPolicyDocument InstanceFcaPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFcaPolicyDocument property is set.
        /// </summary>
        internal bool IsSetInstanceFcaPolicyDocument() => this.InstanceFcaPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property NatFcaPolicyDocument. 
        /// <para>
        /// The updated policy document that defines cost allocation for NAT gateways.
        /// </para>
        /// </summary>
        public NatFlexCostAllocationPolicyDocument NatFcaPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the NatFcaPolicyDocument property is set.
        /// </summary>
        internal bool IsSetNatFcaPolicyDocument() => this.NatFcaPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PcxFcaPolicyDocument. 
        /// <para>
        /// The updated policy document that defines cost allocation for Amazon VPC peering connections.
        /// </para>
        /// </summary>
        public PcxFlexCostAllocationPolicyDocument PcxFcaPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PcxFcaPolicyDocument property is set.
        /// </summary>
        internal bool IsSetPcxFcaPolicyDocument() => this.PcxFcaPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property ShowBackEnabled. 
        /// <para>
        /// Specifies whether showback reporting is enabled for the policy. If you omit this parameter,
        /// the current setting is unchanged.
        /// </para>
        /// </summary>
        public bool? ShowBackEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ShowBackEnabled property is set.
        /// </summary>
        internal bool IsSetShowBackEnabled() => this.ShowBackEnabled.HasValue;
    }
}
