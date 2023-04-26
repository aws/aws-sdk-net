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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceNetworkVpcAssociation operation.
    /// Associates a VPC with a service network. When you associate a VPC with the service
    /// network, it enables all the resources within that VPC to be clients and communicate
    /// with other services in the service network. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-network-associations.html#service-network-vpc-associations">Manage
    /// VPC associations</a> in the <i>Amazon VPC Lattice User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can't use this operation if there is a disassociation in progress. If the association
    /// fails, retry by deleting the association and recreating it.
    /// </para>
    ///  
    /// <para>
    /// As a result of this operation, the association gets created in the service network
    /// account and the VPC owner account.
    /// </para>
    ///  
    /// <para>
    /// If you add a security group to the service network and VPC association, the association
    /// must continue to always have at least one security group. You can add or edit security
    /// groups at any time. However, to remove all security groups, you must first delete
    /// the association and recreate it without security groups.
    /// </para>
    /// </summary>
    public partial class CreateServiceNetworkVpcAssociationRequest : AmazonVPCLatticeRequest
    {
        private string _clientToken;
        private List<string> _securityGroupIds = new List<string>();
        private string _serviceNetworkIdentifier;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _vpcIdentifier;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry succeeds without performing any actions. If the parameters
        /// aren't identical, the retry fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups. Security groups aren't added by default. You can add
        /// a security group to apply network level controls to control which resources in a VPC
        /// are allowed to access the service network and its services. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html">Control
        /// traffic to resources using security groups</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the service network. You must use the ARN
        /// when the resources specified in the operation are in different accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=2048)]
        public string ServiceNetworkIdentifier
        {
            get { return this._serviceNetworkIdentifier; }
            set { this._serviceNetworkIdentifier = value; }
        }

        // Check to see if ServiceNetworkIdentifier property is set
        internal bool IsSetServiceNetworkIdentifier()
        {
            return this._serviceNetworkIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcIdentifier. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=50)]
        public string VpcIdentifier
        {
            get { return this._vpcIdentifier; }
            set { this._vpcIdentifier = value; }
        }

        // Check to see if VpcIdentifier property is set
        internal bool IsSetVpcIdentifier()
        {
            return this._vpcIdentifier != null;
        }

    }
}