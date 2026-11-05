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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the following actions:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>AuthorizeDBSecurityGroupIngress</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeDBSecurityGroups</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RevokeDBSecurityGroupIngress</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EC2SecurityGroup
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public EC2SecurityGroup() { }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupId. 
        /// <para>
        /// Specifies the id of the EC2 security group.
        /// </para>
        /// </summary>
        public string EC2SecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the EC2SecurityGroupId property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroupId() => this.EC2SecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        /// Specifies the name of the EC2 security group.
        /// </para>
        /// </summary>
        public string EC2SecurityGroupName { get; set; }

        /// <summary>
        /// Checks to see if the EC2SecurityGroupName property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroupName() => this.EC2SecurityGroupName != null;

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupOwnerId. 
        /// <para>
        /// Specifies the Amazon Web Services ID of the owner of the EC2 security group specified
        /// in the <c>EC2SecurityGroupName</c> field.
        /// </para>
        /// </summary>
        public string EC2SecurityGroupOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the EC2SecurityGroupOwnerId property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroupOwnerId() => this.EC2SecurityGroupOwnerId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides the status of the EC2 security group. Status can be "authorizing", "authorized",
        /// "revoking", and "revoked".
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
