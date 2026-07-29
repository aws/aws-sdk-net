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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private VpcEncryptionControlExclusionState _egressOnlyInternetGateway;
        private VpcEncryptionControlExclusionState _elasticFileSystem;
        private VpcEncryptionControlExclusionState _internetGateway;
        private VpcEncryptionControlExclusionState _lambda;
        private VpcEncryptionControlExclusionState _natGateway;
        private VpcEncryptionControlExclusionState _virtualPrivateGateway;
        private VpcEncryptionControlExclusionState _vpcLattice;
        private VpcEncryptionControlExclusionState _vpcPeering;

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGateway. 
        /// <para>
        /// The exclusion configuration for egress-only internet gateway resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState EgressOnlyInternetGateway
        {
            get { return this._egressOnlyInternetGateway; }
            set { this._egressOnlyInternetGateway = value; }
        }

        // Check to see if EgressOnlyInternetGateway property is set
        internal bool IsSetEgressOnlyInternetGateway()
        {
            return this._egressOnlyInternetGateway != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticFileSystem. 
        /// <para>
        /// The exclusion configuration for Elastic File System service.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState ElasticFileSystem
        {
            get { return this._elasticFileSystem; }
            set { this._elasticFileSystem = value; }
        }

        // Check to see if ElasticFileSystem property is set
        internal bool IsSetElasticFileSystem()
        {
            return this._elasticFileSystem != null;
        }

        /// <summary>
        /// Gets and sets the property InternetGateway. 
        /// <para>
        /// The exclusion configuration for internet gateway resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState InternetGateway
        {
            get { return this._internetGateway; }
            set { this._internetGateway = value; }
        }

        // Check to see if InternetGateway property is set
        internal bool IsSetInternetGateway()
        {
            return this._internetGateway != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// The exclusion configuration for Lambda service.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

        /// <summary>
        /// Gets and sets the property NatGateway. 
        /// <para>
        /// The exclusion configuration for NAT gateway resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState NatGateway
        {
            get { return this._natGateway; }
            set { this._natGateway = value; }
        }

        // Check to see if NatGateway property is set
        internal bool IsSetNatGateway()
        {
            return this._natGateway != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualPrivateGateway. 
        /// <para>
        /// The exclusion configuration for virtual private gateway resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState VirtualPrivateGateway
        {
            get { return this._virtualPrivateGateway; }
            set { this._virtualPrivateGateway = value; }
        }

        // Check to see if VirtualPrivateGateway property is set
        internal bool IsSetVirtualPrivateGateway()
        {
            return this._virtualPrivateGateway != null;
        }

        /// <summary>
        /// Gets and sets the property VpcLattice. 
        /// <para>
        /// The exclusion configuration for VPC Lattice service.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState VpcLattice
        {
            get { return this._vpcLattice; }
            set { this._vpcLattice = value; }
        }

        // Check to see if VpcLattice property is set
        internal bool IsSetVpcLattice()
        {
            return this._vpcLattice != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeering. 
        /// <para>
        /// The exclusion configuration for VPC peering connection resource.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionState VpcPeering
        {
            get { return this._vpcPeering; }
            set { this._vpcPeering = value; }
        }

        // Check to see if VpcPeering property is set
        internal bool IsSetVpcPeering()
        {
            return this._vpcPeering != null;
        }

    }
}