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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An association between the network ACL and a subnet.
    /// </summary>
    public partial class AwsEc2NetworkAclAssociation
    {
        private string _networkAclAssociationId;
        private string _networkAclId;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property NetworkAclAssociationId. 
        /// <para>
        /// The identifier of the association between the network ACL and the subnet.
        /// </para>
        /// </summary>
        public string NetworkAclAssociationId
        {
            get { return this._networkAclAssociationId; }
            set { this._networkAclAssociationId = value; }
        }

        // Check to see if NetworkAclAssociationId property is set
        internal bool IsSetNetworkAclAssociationId()
        {
            return this._networkAclAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkAclId. 
        /// <para>
        /// The identifier of the network ACL.
        /// </para>
        /// </summary>
        public string NetworkAclId
        {
            get { return this._networkAclId; }
            set { this._networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this._networkAclId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet that is associated with the network ACL.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}