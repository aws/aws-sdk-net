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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateSecurityGroup operation. Creates a security
    /// group. <para> A security group acts as a virtual firewall for your instance to control
    /// inbound and outbound traffic. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
    /// EC2 security groups</a> in the <i>Amazon EC2 User Guide</i> and <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
    /// groups for your VPC</a> in the <i>Amazon VPC User Guide</i>. </para> <para> When you
    /// create a security group, you specify a friendly name of your choice. You can't have
    /// two security groups for the same VPC with the same name. </para> <para> You have a
    /// default security group for use in your VPC. If you don't specify a security group
    /// when you launch an instance, the instance is launched into the appropriate default
    /// security group. A default security group includes a default rule that grants instances
    /// unrestricted network access to each other. </para> <para> You can add or remove rules
    /// from your security groups using <a>AuthorizeSecurityGroupIngress</a>, <a>AuthorizeSecurityGroupEgress</a>,
    /// <a>RevokeSecurityGroupIngress</a>, and <a>RevokeSecurityGroupEgress</a>. </para> <para>
    /// For more information about VPC security group limits, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
    /// VPC Limits</a>. </para>
    /// </summary>
    public partial class CreateSecurityGroupRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateSecurityGroupRequest() { }

        /// <summary>
        /// Instantiates CreateSecurityGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">The name of the security group. Names are case-insensitive and must be unique within the VPC.   Constraints: Up to 255 characters in length. Can't start with <c>sg-</c>.   Valid characters: a-z, A-Z, 0-9, spaces, and ._-:/()#,@[]+=&;{}!$*</param>
        /// <param name="description">A description for the security group.   Constraints: Up to 255 characters in length   Valid characters: a-z, A-Z, 0-9, spaces, and ._-:/()#,@[]+=&;{}!$*</param>
        public CreateSecurityGroupRequest(string groupName, string description)
        {
            this.GroupName = groupName;
            this.Description = description;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the security group.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 characters in length
        /// </para>
        ///  
        /// <para>
        /// Valid characters: a-z, A-Z, 0-9, spaces, and ._-:/()#,@[]+=&amp;;{}!$*
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the security group. Names are case-insensitive and must be unique within
        /// the VPC.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 characters in length. Can't start with <c>sg-</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid characters: a-z, A-Z, 0-9, spaces, and ._-:/()#,@[]+=&amp;;{}!$*
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC. Required for a nondefault VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
