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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyNetworkInterfaceAttribute operation.
    /// <para>Modifies the specified network interface attribute. You can specify only one attribute at a time.</para>
    /// </summary>
    public partial class ModifyNetworkInterfaceAttributeRequest : AmazonEC2Request
    {
        private string networkInterfaceId;
        private string description;
        private bool? sourceDestCheck;
        private List<string> groups = new List<string>();
        private NetworkInterfaceAttachmentChanges attachment;


        /// <summary>
        /// The ID of the network interface.
        ///  
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }

        /// <summary>
        /// A description for the network interface.
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
        /// Indicates whether source/destination checking is enabled. A value of <c>true</c> means checking is enabled, and <c>false</c> means checking
        /// is disabled. This value must be <c>false</c> for a NAT instance to perform NAT. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT Instances</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i>.
        ///  
        /// </summary>
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheck ?? default(bool); }
            set { this.sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheck.HasValue;
        }

        /// <summary>
        /// Changes the security groups for the network interface. The new set of groups you specify replaces the current set. You must specify at least
        /// one group, even if it's just the default security group in the VPC. You must specify the ID of the security group, not the name.
        ///  
        /// </summary>
        public List<string> Groups
        {
            get { return this.groups; }
            set { this.groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this.groups.Count > 0;
        }

        /// <summary>
        /// The ID of the interface attachment.
        ///  
        /// </summary>
        public NetworkInterfaceAttachmentChanges Attachment
        {
            get { return this.attachment; }
            set { this.attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this.attachment != null;
        }

    }
}
    
