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
    /// Container for the parameters to the ModifyVpcEncryptionControl operation.
    /// Modifies the encryption control configuration for a VPC. You can update the encryption
    /// mode and exclusion settings for various gateway types and peering connections.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyVpcEncryptionControlRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private VpcEncryptionControlExclusionStateInput _egressOnlyInternetGatewayExclusion;
        private VpcEncryptionControlExclusionStateInput _elasticFileSystemExclusion;
        private VpcEncryptionControlExclusionStateInput _internetGatewayExclusion;
        private VpcEncryptionControlExclusionStateInput _lambdaExclusion;
        private VpcEncryptionControlMode _mode;
        private VpcEncryptionControlExclusionStateInput _natGatewayExclusion;
        private VpcEncryptionControlExclusionStateInput _virtualPrivateGatewayExclusion;
        private string _vpcEncryptionControlId;
        private VpcEncryptionControlExclusionStateInput _vpcLatticeExclusion;
        private VpcEncryptionControlExclusionStateInput _vpcPeeringExclusion;

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
        /// Gets and sets the property EgressOnlyInternetGatewayExclusion. 
        /// <para>
        /// Specifies whether to exclude egress-only internet gateway traffic from encryption
        /// enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput EgressOnlyInternetGatewayExclusion
        {
            get { return this._egressOnlyInternetGatewayExclusion; }
            set { this._egressOnlyInternetGatewayExclusion = value; }
        }

        // Check to see if EgressOnlyInternetGatewayExclusion property is set
        internal bool IsSetEgressOnlyInternetGatewayExclusion()
        {
            return this._egressOnlyInternetGatewayExclusion != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticFileSystemExclusion. 
        /// <para>
        /// Specifies whether to exclude Elastic File System traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput ElasticFileSystemExclusion
        {
            get { return this._elasticFileSystemExclusion; }
            set { this._elasticFileSystemExclusion = value; }
        }

        // Check to see if ElasticFileSystemExclusion property is set
        internal bool IsSetElasticFileSystemExclusion()
        {
            return this._elasticFileSystemExclusion != null;
        }

        /// <summary>
        /// Gets and sets the property InternetGatewayExclusion. 
        /// <para>
        /// Specifies whether to exclude internet gateway traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput InternetGatewayExclusion
        {
            get { return this._internetGatewayExclusion; }
            set { this._internetGatewayExclusion = value; }
        }

        // Check to see if InternetGatewayExclusion property is set
        internal bool IsSetInternetGatewayExclusion()
        {
            return this._internetGatewayExclusion != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaExclusion. 
        /// <para>
        /// Specifies whether to exclude Lambda function traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput LambdaExclusion
        {
            get { return this._lambdaExclusion; }
            set { this._lambdaExclusion = value; }
        }

        // Check to see if LambdaExclusion property is set
        internal bool IsSetLambdaExclusion()
        {
            return this._lambdaExclusion != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The encryption mode for the VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public VpcEncryptionControlMode Mode
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
        /// Gets and sets the property NatGatewayExclusion. 
        /// <para>
        /// Specifies whether to exclude NAT gateway traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput NatGatewayExclusion
        {
            get { return this._natGatewayExclusion; }
            set { this._natGatewayExclusion = value; }
        }

        // Check to see if NatGatewayExclusion property is set
        internal bool IsSetNatGatewayExclusion()
        {
            return this._natGatewayExclusion != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualPrivateGatewayExclusion. 
        /// <para>
        /// Specifies whether to exclude virtual private gateway traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VirtualPrivateGatewayExclusion
        {
            get { return this._virtualPrivateGatewayExclusion; }
            set { this._virtualPrivateGatewayExclusion = value; }
        }

        // Check to see if VirtualPrivateGatewayExclusion property is set
        internal bool IsSetVirtualPrivateGatewayExclusion()
        {
            return this._virtualPrivateGatewayExclusion != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEncryptionControlId. 
        /// <para>
        /// The ID of the VPC Encryption Control resource to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcEncryptionControlId
        {
            get { return this._vpcEncryptionControlId; }
            set { this._vpcEncryptionControlId = value; }
        }

        // Check to see if VpcEncryptionControlId property is set
        internal bool IsSetVpcEncryptionControlId()
        {
            return this._vpcEncryptionControlId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcLatticeExclusion. 
        /// <para>
        /// Specifies whether to exclude VPC Lattice traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VpcLatticeExclusion
        {
            get { return this._vpcLatticeExclusion; }
            set { this._vpcLatticeExclusion = value; }
        }

        // Check to see if VpcLatticeExclusion property is set
        internal bool IsSetVpcLatticeExclusion()
        {
            return this._vpcLatticeExclusion != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeeringExclusion. 
        /// <para>
        /// Specifies whether to exclude VPC peering connection traffic from encryption enforcement.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusionStateInput VpcPeeringExclusion
        {
            get { return this._vpcPeeringExclusion; }
            set { this._vpcPeeringExclusion = value; }
        }

        // Check to see if VpcPeeringExclusion property is set
        internal bool IsSetVpcPeeringExclusion()
        {
            return this._vpcPeeringExclusion != null;
        }

    }
}