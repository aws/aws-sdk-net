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
    /// Container for the parameters to the ModifyVpcEncryptionControl operation. Modifies
    /// the encryption control configuration for a VPC. You can update the encryption mode
    /// and exclusion settings for various gateway types and peering connections. <para> For
    /// more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>. </para>
    /// </summary>
    public partial class ModifyVpcEncryptionControlRequest : AmazonEC2Request
    {
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
        /// Gets and sets the property EgressOnlyInternetGatewayExclusion. 
        /// <para>
        /// Specifies whether to exclude egress-only internet gateway traffic from encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput EgressOnlyInternetGatewayExclusion { get; set; }

        /// <summary>
        /// Checks to see if the EgressOnlyInternetGatewayExclusion property is set.
        /// </summary>
        internal bool IsSetEgressOnlyInternetGatewayExclusion() => this.EgressOnlyInternetGatewayExclusion != null;

        /// <summary>
        /// Gets and sets the property ElasticFileSystemExclusion. 
        /// <para>
        /// Specifies whether to exclude Elastic File System traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput ElasticFileSystemExclusion { get; set; }

        /// <summary>
        /// Checks to see if the ElasticFileSystemExclusion property is set.
        /// </summary>
        internal bool IsSetElasticFileSystemExclusion() => this.ElasticFileSystemExclusion != null;

        /// <summary>
        /// Gets and sets the property InternetGatewayExclusion. 
        /// <para>
        /// Specifies whether to exclude internet gateway traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput InternetGatewayExclusion { get; set; }

        /// <summary>
        /// Checks to see if the InternetGatewayExclusion property is set.
        /// </summary>
        internal bool IsSetInternetGatewayExclusion() => this.InternetGatewayExclusion != null;

        /// <summary>
        /// Gets and sets the property LambdaExclusion. 
        /// <para>
        /// Specifies whether to exclude Lambda function traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput LambdaExclusion { get; set; }

        /// <summary>
        /// Checks to see if the LambdaExclusion property is set.
        /// </summary>
        internal bool IsSetLambdaExclusion() => this.LambdaExclusion != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The encryption mode for the VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public VpcEncryptionControlMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property NatGatewayExclusion. 
        /// <para>
        /// Specifies whether to exclude NAT gateway traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput NatGatewayExclusion { get; set; }

        /// <summary>
        /// Checks to see if the NatGatewayExclusion property is set.
        /// </summary>
        internal bool IsSetNatGatewayExclusion() => this.NatGatewayExclusion != null;

        /// <summary>
        /// Gets and sets the property VirtualPrivateGatewayExclusion. 
        /// <para>
        /// Specifies whether to exclude virtual private gateway traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VirtualPrivateGatewayExclusion { get; set; }

        /// <summary>
        /// Checks to see if the VirtualPrivateGatewayExclusion property is set.
        /// </summary>
        internal bool IsSetVirtualPrivateGatewayExclusion() => this.VirtualPrivateGatewayExclusion != null;

        /// <summary>
        /// Gets and sets the property VpcEncryptionControlId. 
        /// <para>
        /// The ID of the VPC Encryption Control resource to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcEncryptionControlId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEncryptionControlId property is set.
        /// </summary>
        internal bool IsSetVpcEncryptionControlId() => this.VpcEncryptionControlId != null;

        /// <summary>
        /// Gets and sets the property VpcLatticeExclusion. 
        /// <para>
        /// Specifies whether to exclude VPC Lattice traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VpcLatticeExclusion { get; set; }

        /// <summary>
        /// Checks to see if the VpcLatticeExclusion property is set.
        /// </summary>
        internal bool IsSetVpcLatticeExclusion() => this.VpcLatticeExclusion != null;

        /// <summary>
        /// Gets and sets the property VpcPeeringExclusion. 
        /// <para>
        /// Specifies whether to exclude VPC peering connection traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VpcPeeringExclusion { get; set; }

        /// <summary>
        /// Checks to see if the VpcPeeringExclusion property is set.
        /// </summary>
        internal bool IsSetVpcPeeringExclusion() => this.VpcPeeringExclusion != null;
    }
}
