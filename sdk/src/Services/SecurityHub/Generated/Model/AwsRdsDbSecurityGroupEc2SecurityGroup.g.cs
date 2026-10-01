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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// EC2 security group information for an RDS DB security group.
    /// </summary>
    public partial class AwsRdsDbSecurityGroupEc2SecurityGroup
    {
        /// <summary>
        /// Gets and sets the property Ec2SecurityGroupId. 
        /// <para>
        /// Specifies the ID for the EC2 security group.
        /// </para>
        /// </summary>
        public string Ec2SecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2SecurityGroupId property is set.
        /// </summary>
        internal bool IsSetEc2SecurityGroupId() => this.Ec2SecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property Ec2SecurityGroupName. 
        /// <para>
        /// Specifies the name of the EC2 security group.
        /// </para>
        /// </summary>
        public string Ec2SecurityGroupName { get; set; }

        /// <summary>
        /// Checks to see if the Ec2SecurityGroupName property is set.
        /// </summary>
        internal bool IsSetEc2SecurityGroupName() => this.Ec2SecurityGroupName != null;

        /// <summary>
        /// Gets and sets the property Ec2SecurityGroupOwnerId. 
        /// <para>
        /// Provides the Amazon Web Services ID of the owner of the EC2 security group.
        /// </para>
        /// </summary>
        public string Ec2SecurityGroupOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2SecurityGroupOwnerId property is set.
        /// </summary>
        internal bool IsSetEc2SecurityGroupOwnerId() => this.Ec2SecurityGroupOwnerId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides the status of the EC2 security group.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
