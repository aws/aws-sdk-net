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
    /// Container for the parameters to the CreateNetworkingFlexCostAllocationPolicy operation.
    /// Creates a flex cost allocation policy for Networking Flexible Cost Allocation (FCA),
    /// a feature of Amazon Virtual Private Cloud (Amazon VPC). The policy allocates the charges
    /// of a shared networking resource at the reporting granularity that you specify. You
    /// can create a policy for one of the following resource types: NAT gateways, Amazon
    /// VPC peering connections, or EC2 instances. Policies can allocate data transfer charges
    /// for all three types, and data processing charges for NAT gateways. <para> You can
    /// have up to 100 policies per account in each Amazon Web Services Region, plus one additional
    /// policy per network resource type created by a declarative policy, for a maximum of
    /// 103 policies in an Amazon Web Services Region. </para>
    /// </summary>
    public partial class CreateNetworkingFlexCostAllocationPolicyRequest : AmazonEC2Request
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
        /// Gets and sets the property InstanceFcaPolicyDocument. 
        /// <para>
        /// The policy document that defines cost allocation for EC2 instances. Provide this document
        /// when <c>NetworkResourceType</c> is <c>ec2</c>.
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
        /// The policy document that defines cost allocation for NAT gateways. Provide this document
        /// when <c>NetworkResourceType</c> is <c>natgw</c>.
        /// </para>
        /// </summary>
        public NatFlexCostAllocationPolicyDocument NatFcaPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the NatFcaPolicyDocument property is set.
        /// </summary>
        internal bool IsSetNatFcaPolicyDocument() => this.NatFcaPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property NetworkResourceType. 
        /// <para>
        /// The type of network resource that the policy applies to. This parameter is required.
        /// Valid values are <c>natgw</c> (NAT gateway), <c>pcx</c> (Amazon VPC peering connection),
        /// and <c>ec2</c> (EC2 instance).
        /// </para>
        ///  
        /// <para>
        /// Specify the policy document that matches the resource type: <c>NatFcaPolicyDocument</c>
        /// for <c>natgw</c>, <c>InstanceFcaPolicyDocument</c> for <c>ec2</c>, or <c>PcxFcaPolicyDocument</c>
        /// for <c>pcx</c>. Don't specify a policy document for a different resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlexCostAllocationNetworkResourceType NetworkResourceType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkResourceType property is set.
        /// </summary>
        internal bool IsSetNetworkResourceType() => this.NetworkResourceType != null;

        /// <summary>
        /// Gets and sets the property PcxFcaPolicyDocument. 
        /// <para>
        /// The policy document that defines cost allocation for Amazon VPC peering connections.
        /// Provide this document when <c>NetworkResourceType</c> is <c>pcx</c>.
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
        /// Specifies whether showback reporting is enabled for the policy.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? ShowBackEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ShowBackEnabled property is set.
        /// </summary>
        internal bool IsSetShowBackEnabled() => this.ShowBackEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
