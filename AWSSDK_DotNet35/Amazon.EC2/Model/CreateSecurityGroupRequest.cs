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
    /// Container for the parameters to the CreateSecurityGroup operation.
    /// <para>Creates a security group.</para> <para>A security group is for use with instances either in the EC2-Classic platform or in a specific
    /// VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Amazon EC2 Security
    /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security Groups for Your VPC</a> in the <i>Amazon
    /// Virtual Private Cloud User Guide</i> .</para> <para><b>IMPORTANT:</b> EC2-Classic: You can have up to 500 security groups. EC2-VPC: You can
    /// create up to 100 security groups per VPC. </para> <para>When you create a security group, you specify a friendly name of your choice. You
    /// can have a security group for use in EC2-Classic with the same name as a security group for use in a VPC. However, you can't have two
    /// security groups for use in EC2-Classic with the same name or two security groups for use in a VPC with the same name.</para> <para>You have
    /// a default security group for use in EC2-Classic and a default security group for use in your VPC. If you don't specify a security group when
    /// you launch an instance, the instance is launched into the appropriate default security group. A default security group includes a default
    /// rule that grants instances unrestricted network access to each other.</para> <para>You can add or remove rules from your security groups
    /// using AuthorizeSecurityGroupIngress, AuthorizeSecurityGroupEgress, RevokeSecurityGroupIngress, and RevokeSecurityGroupEgress.</para>
    /// </summary>
    public partial class CreateSecurityGroupRequest : AmazonEC2Request
    {
        private string groupName;
        private string description;
        private string vpcId;


        /// <summary>
        /// The name of the security group. Constraints: Up to 255 characters in length Constraints for EC2-Classic: ASCII characters Constraints for
        /// EC2-VPC: a-z, A-Z, 0-9, spaces, and ._-:/()#,@[]+=&amp;;{}!$*
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

        /// <summary>
        /// A description for the security group. This is informational only.
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
        /// [EC2-VPC] The ID of the VPC.
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

    }
}
    
