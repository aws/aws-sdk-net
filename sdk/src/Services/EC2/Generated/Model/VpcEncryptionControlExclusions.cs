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
    /// Describes the exclusion configurations for various resource types in VPC Encryption
    /// Control.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class VpcEncryptionControlExclusions
    {
        private VpcEncryptionControlExclusion _egressOnlyInternetGateway;
        private VpcEncryptionControlExclusion _elasticFileSystem;
        private VpcEncryptionControlExclusion _internetGateway;
        private VpcEncryptionControlExclusion _lambda;
        private VpcEncryptionControlExclusion _natGateway;
        private VpcEncryptionControlExclusion _virtualPrivateGateway;
        private VpcEncryptionControlExclusion _vpcLattice;
        private VpcEncryptionControlExclusion _vpcPeering;

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGateway. 
        /// <para>
        /// The exclusion configuration for egress-only internet gateway traffic.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusion EgressOnlyInternetGateway
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
        /// The exclusion configuration for Elastic File System traffic.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusion ElasticFileSystem
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
        /// The exclusion configuration for internet gateway traffic.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusion InternetGateway
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
        /// The exclusion configuration for Lambda function traffic.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusion Lambda
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
        /// The exclusion configuration for NAT gateway traffic.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusion NatGateway
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
        /// The exclusion configuration for virtual private gateway traffic.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusion VirtualPrivateGateway
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
        /// The exclusion configuration for VPC Lattice traffic.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusion VpcLattice
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
        /// The exclusion configuration for VPC peering connection traffic.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusion VpcPeering
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