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
    /// Describes the exclusion configurations for the various resource types in the account-level
    /// VPC Encryption Control configuration.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AccountVpcEncryptionControlExclusions
    {
        /// <summary>
        /// Gets and sets the property ApiGatewayV2. 
        /// <para>
        /// The exclusion configuration for Amazon API Gateway V2.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState ApiGatewayV2 { get; set; }

        /// <summary>
        /// Checks to see if the ApiGatewayV2 property is set.
        /// </summary>
        internal bool IsSetApiGatewayV2() => this.ApiGatewayV2 != null;

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGateway. 
        /// <para>
        /// The exclusion configuration for egress-only internet gateway resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState EgressOnlyInternetGateway { get; set; }

        /// <summary>
        /// Checks to see if the EgressOnlyInternetGateway property is set.
        /// </summary>
        internal bool IsSetEgressOnlyInternetGateway() => this.EgressOnlyInternetGateway != null;

        /// <summary>
        /// Gets and sets the property ElasticFileSystem. 
        /// <para>
        /// The exclusion configuration for Elastic File System service.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState ElasticFileSystem { get; set; }

        /// <summary>
        /// Checks to see if the ElasticFileSystem property is set.
        /// </summary>
        internal bool IsSetElasticFileSystem() => this.ElasticFileSystem != null;

        /// <summary>
        /// Gets and sets the property GlobalAccelerator. 
        /// <para>
        /// The exclusion configuration for AWS Global Accelerator.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState GlobalAccelerator { get; set; }

        /// <summary>
        /// Checks to see if the GlobalAccelerator property is set.
        /// </summary>
        internal bool IsSetGlobalAccelerator() => this.GlobalAccelerator != null;

        /// <summary>
        /// Gets and sets the property InternetGateway. 
        /// <para>
        /// The exclusion configuration for internet gateway resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState InternetGateway { get; set; }

        /// <summary>
        /// Checks to see if the InternetGateway property is set.
        /// </summary>
        internal bool IsSetInternetGateway() => this.InternetGateway != null;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// The exclusion configuration for Lambda service.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda != null;

        /// <summary>
        /// Gets and sets the property NatGateway. 
        /// <para>
        /// The exclusion configuration for NAT gateway resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState NatGateway { get; set; }

        /// <summary>
        /// Checks to see if the NatGateway property is set.
        /// </summary>
        internal bool IsSetNatGateway() => this.NatGateway != null;

        /// <summary>
        /// Gets and sets the property VirtualPrivateGateway. 
        /// <para>
        /// The exclusion configuration for virtual private gateway resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState VirtualPrivateGateway { get; set; }

        /// <summary>
        /// Checks to see if the VirtualPrivateGateway property is set.
        /// </summary>
        internal bool IsSetVirtualPrivateGateway() => this.VirtualPrivateGateway != null;

        /// <summary>
        /// Gets and sets the property VpcLattice. 
        /// <para>
        /// The exclusion configuration for VPC Lattice service.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState VpcLattice { get; set; }

        /// <summary>
        /// Checks to see if the VpcLattice property is set.
        /// </summary>
        internal bool IsSetVpcLattice() => this.VpcLattice != null;

        /// <summary>
        /// Gets and sets the property VpcPeering. 
        /// <para>
        /// The exclusion configuration for VPC peering connection resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState VpcPeering { get; set; }

        /// <summary>
        /// Checks to see if the VpcPeering property is set.
        /// </summary>
        internal bool IsSetVpcPeering() => this.VpcPeering != null;
    }
}
