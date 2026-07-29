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
    /// Container for the parameters to the ModifyAccountVpcEncryptionControl operation.
    /// Modifies the account-level VPC Encryption Control configuration. This sets the encryption
    /// control mode and resource exclusions that apply to the VPCs in your account. VPC Encryption
    /// Control enables you to enforce encryption for all data in transit within and between
    /// VPCs to meet compliance requirements.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyAccountVpcEncryptionControlRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private VpcEncryptionControlExclusionStateInput _egressOnlyInternetGateway;
        private VpcEncryptionControlExclusionStateInput _elasticFileSystem;
        private VpcEncryptionControlExclusionStateInput _internetGateway;
        private VpcEncryptionControlExclusionStateInput _lambda;
        private AccountVpcEncryptionControlMode _mode;
        private VpcEncryptionControlExclusionStateInput _natGateway;
        private VpcEncryptionControlExclusionStateInput _virtualPrivateGateway;
        private VpcEncryptionControlExclusionStateInput _vpcLattice;
        private VpcEncryptionControlExclusionStateInput _vpcPeering;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGateway. 
        /// <para>
        /// Specifies whether to exclude egress-only internet gateway resource from account-level
        /// encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput EgressOnlyInternetGateway
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
        /// Specifies whether to exclude Elastic File System service from account-level encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput ElasticFileSystem
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
        /// Specifies whether to exclude internet gateway resource from account-level encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput InternetGateway
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
        /// Specifies whether to exclude Lambda service from account-level encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput Lambda
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
        /// Gets and sets the property Mode. 
        /// <para>
        /// The encryption mode for the account encryption control configuration.
        /// </para>
        /// </summary>
        public AccountVpcEncryptionControlMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property NatGateway. 
        /// <para>
        /// Specifies whether to exclude NAT gateway resource from account-level encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput NatGateway
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
        /// Specifies whether to exclude virtual private gateway resource from account-level encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VirtualPrivateGateway
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
        /// Specifies whether to exclude VPC Lattice service from account-level encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VpcLattice
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
        /// Specifies whether to exclude VPC peering connection resource from account-level encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VpcPeering
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