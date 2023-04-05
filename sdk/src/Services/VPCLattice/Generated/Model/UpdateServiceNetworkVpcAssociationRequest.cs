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
    /// Container for the parameters to the UpdateServiceNetworkVpcAssociation operation.
    /// Updates the service network and VPC association. If you add a security group to the
    /// service network and VPC association, the association must continue to always have
    /// at least one security group. You can add or edit security groups at any time. However,
    /// to remove all security groups, you must first delete the association and recreate
    /// it without security groups.
    /// </summary>
    public partial class UpdateServiceNetworkVpcAssociationRequest : AmazonVPCLatticeRequest
    {
        private List<string> _securityGroupIds = new List<string>();
        private string _serviceNetworkVpcAssociationIdentifier;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
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
        /// Gets and sets the property ServiceNetworkVpcAssociationIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string ServiceNetworkVpcAssociationIdentifier
        {
            get { return this._serviceNetworkVpcAssociationIdentifier; }
            set { this._serviceNetworkVpcAssociationIdentifier = value; }
        }

        // Check to see if ServiceNetworkVpcAssociationIdentifier property is set
        internal bool IsSetServiceNetworkVpcAssociationIdentifier()
        {
            return this._serviceNetworkVpcAssociationIdentifier != null;
        }

    }
}