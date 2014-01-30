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
    /// <para>Describes a network ACL.</para>
    /// </summary>
    public class NetworkAcl
    {
        
        private string networkAclId;
        private string vpcId;
        private bool? isDefault;
        private List<NetworkAclEntry> entries = new List<NetworkAclEntry>();
        private List<NetworkAclAssociation> associations = new List<NetworkAclAssociation>();
        private List<Tag> tags = new List<Tag>();


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
        /// The ID of the VPC for the network ACL.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// Indicates whether this is the default network ACL for the VPC.
        ///  
        /// </summary>
        public bool IsDefault
        {
            get { return this.isDefault ?? default(bool); }
            set { this.isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this.isDefault.HasValue;
        }

        /// <summary>
        /// One or more entries (rules) in the network ACL.
        ///  
        /// </summary>
        public List<NetworkAclEntry> Entries
        {
            get { return this.entries; }
            set { this.entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this.entries.Count > 0;
        }

        /// <summary>
        /// Any associations between the network ACL and one or more subnets
        ///  
        /// </summary>
        public List<NetworkAclAssociation> Associations
        {
            get { return this.associations; }
            set { this.associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this.associations.Count > 0;
        }

        /// <summary>
        /// Any tags assigned to the network ACL.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
