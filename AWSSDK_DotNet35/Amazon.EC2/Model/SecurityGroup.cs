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
    /// <para> An Amazon EC2 security group, describing how EC2 instances in this group can receive network traffic. </para>
    /// </summary>
    public class SecurityGroup
    {
        
        private string ownerId;
        private string groupName;
        private string groupId;
        private string description;
        private List<IpPermission> ipPermissions = new List<IpPermission>();
        private List<IpPermission> ipPermissionsEgress = new List<IpPermission>();
        private string vpcId;
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The AWS Access Key ID of the owner of the security group.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }

        /// <summary>
        /// The name of this security group.
        ///  
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;
        }
        public string GroupId
        {
            get { return this.groupId; }
            set { this.groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this.groupId != null;
        }

        /// <summary>
        /// The description of this security group.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The permissions enabled for this security group.
        ///  
        /// </summary>
        public List<IpPermission> IpPermissions
        {
            get { return this.ipPermissions; }
            set { this.ipPermissions = value; }
        }

        // Check to see if IpPermissions property is set
        internal bool IsSetIpPermissions()
        {
            return this.ipPermissions.Count > 0;
        }
        public List<IpPermission> IpPermissionsEgress
        {
            get { return this.ipPermissionsEgress; }
            set { this.ipPermissionsEgress = value; }
        }

        // Check to see if IpPermissionsEgress property is set
        internal bool IsSetIpPermissionsEgress()
        {
            return this.ipPermissionsEgress.Count > 0;
        }
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
