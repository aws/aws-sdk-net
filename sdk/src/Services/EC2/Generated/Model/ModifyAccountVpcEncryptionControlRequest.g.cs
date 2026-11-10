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
    /// Container for the parameters to the ModifyAccountVpcEncryptionControl operation. Modifies
    /// the account-level VPC Encryption Control configuration. This sets the encryption control
    /// mode and resource exclusions that apply to the VPCs in your account. VPC Encryption
    /// Control enables you to enforce encryption for all data in transit within and between
    /// VPCs to meet compliance requirements. <para> For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>. </para>
    /// </summary>
    public partial class ModifyAccountVpcEncryptionControlRequest : AmazonEC2Request
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
        /// Gets and sets the property EgressOnlyInternetGateway. 
        /// <para>
        /// Specifies whether to exclude egress-only internet gateway resource from account-level
        /// encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput EgressOnlyInternetGateway { get; set; }

        /// <summary>
        /// Checks to see if the EgressOnlyInternetGateway property is set.
        /// </summary>
        internal bool IsSetEgressOnlyInternetGateway() => this.EgressOnlyInternetGateway != null;

        /// <summary>
        /// Gets and sets the property ElasticFileSystem. 
        /// <para>
        /// Specifies whether to exclude Elastic File System service from account-level encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput ElasticFileSystem { get; set; }

        /// <summary>
        /// Checks to see if the ElasticFileSystem property is set.
        /// </summary>
        internal bool IsSetElasticFileSystem() => this.ElasticFileSystem != null;

        /// <summary>
        /// Gets and sets the property InternetGateway. 
        /// <para>
        /// Specifies whether to exclude internet gateway resource from account-level encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput InternetGateway { get; set; }

        /// <summary>
        /// Checks to see if the InternetGateway property is set.
        /// </summary>
        internal bool IsSetInternetGateway() => this.InternetGateway != null;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// Specifies whether to exclude Lambda service from account-level encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The encryption mode for the account encryption control configuration.
        /// </para>
        /// </summary>
        public AccountVpcEncryptionControlMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property NatGateway. 
        /// <para>
        /// Specifies whether to exclude NAT gateway resource from account-level encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput NatGateway { get; set; }

        /// <summary>
        /// Checks to see if the NatGateway property is set.
        /// </summary>
        internal bool IsSetNatGateway() => this.NatGateway != null;

        /// <summary>
        /// Gets and sets the property VirtualPrivateGateway. 
        /// <para>
        /// Specifies whether to exclude virtual private gateway resource from account-level encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VirtualPrivateGateway { get; set; }

        /// <summary>
        /// Checks to see if the VirtualPrivateGateway property is set.
        /// </summary>
        internal bool IsSetVirtualPrivateGateway() => this.VirtualPrivateGateway != null;

        /// <summary>
        /// Gets and sets the property VpcLattice. 
        /// <para>
        /// Specifies whether to exclude VPC Lattice service from account-level encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VpcLattice { get; set; }

        /// <summary>
        /// Checks to see if the VpcLattice property is set.
        /// </summary>
        internal bool IsSetVpcLattice() => this.VpcLattice != null;

        /// <summary>
        /// Gets and sets the property VpcPeering. 
        /// <para>
        /// Specifies whether to exclude VPC peering connection resource from account-level encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VpcPeering { get; set; }

        /// <summary>
        /// Checks to see if the VpcPeering property is set.
        /// </summary>
        internal bool IsSetVpcPeering() => this.VpcPeering != null;
    }
}
