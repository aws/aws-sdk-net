/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an association between a network ACL and a subnet.</para>
    /// </summary>
    public class NetworkAclAssociation
    {
        
        private string networkAclAssociationId;
        private string networkAclId;
        private string subnetId;


        /// <summary>
        /// The ID of the association between a network ACL and a subnet.
        ///  
        /// </summary>
        public string NetworkAclAssociationId
        {
            get { return this.networkAclAssociationId; }
            set { this.networkAclAssociationId = value; }
        }

        // Check to see if NetworkAclAssociationId property is set
        internal bool IsSetNetworkAclAssociationId()
        {
            return this.networkAclAssociationId != null;
        }

        /// <summary>
        /// The ID of the network ACL.
        ///  
        /// </summary>
        public string NetworkAclId
        {
            get { return this.networkAclId; }
            set { this.networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this.networkAclId != null;
        }

        /// <summary>
        /// The ID of the subnet.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }
    }
}
