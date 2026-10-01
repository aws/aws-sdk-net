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
    /// Provides information about an Amazon RDS DB security group.
    /// </summary>
    public partial class AwsRdsDbSecurityGroupDetails
    {
        /// <summary>
        /// Gets and sets the property DbSecurityGroupArn. 
        /// <para>
        /// The ARN for the DB security group.
        /// </para>
        /// </summary>
        public string DbSecurityGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DbSecurityGroupArn property is set.
        /// </summary>
        internal bool IsSetDbSecurityGroupArn() => this.DbSecurityGroupArn != null;

        /// <summary>
        /// Gets and sets the property DbSecurityGroupDescription. 
        /// <para>
        /// Provides the description of the DB security group.
        /// </para>
        /// </summary>
        public string DbSecurityGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the DbSecurityGroupDescription property is set.
        /// </summary>
        internal bool IsSetDbSecurityGroupDescription() => this.DbSecurityGroupDescription != null;

        /// <summary>
        /// Gets and sets the property DbSecurityGroupName. 
        /// <para>
        /// Specifies the name of the DB security group.
        /// </para>
        /// </summary>
        public string DbSecurityGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DbSecurityGroupName property is set.
        /// </summary>
        internal bool IsSetDbSecurityGroupName() => this.DbSecurityGroupName != null;

        /// <summary>
        /// Gets and sets the property Ec2SecurityGroups. 
        /// <para>
        /// Contains a list of EC2 security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbSecurityGroupEc2SecurityGroup> Ec2SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbSecurityGroupEc2SecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the Ec2SecurityGroups property is set.
        /// </summary>
        internal bool IsSetEc2SecurityGroups() => this.Ec2SecurityGroups != null && (this.Ec2SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpRanges. 
        /// <para>
        /// Contains a list of IP ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbSecurityGroupIpRange> IpRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbSecurityGroupIpRange>() : null;

        /// <summary>
        /// Checks to see if the IpRanges property is set.
        /// </summary>
        internal bool IsSetIpRanges() => this.IpRanges != null && (this.IpRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// Provides the Amazon Web Services ID of the owner of a specific DB security group.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides VPC ID associated with the DB security group. 
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
