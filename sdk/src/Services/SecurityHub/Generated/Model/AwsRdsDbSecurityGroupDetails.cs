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
    /// Provides information about an Amazon RDS DB security group.
    /// </summary>
    public partial class AwsRdsDbSecurityGroupDetails
    {
        private string _dbSecurityGroupArn;
        private string _dbSecurityGroupDescription;
        private string _dbSecurityGroupName;
        private List<AwsRdsDbSecurityGroupEc2SecurityGroup> _ec2SecurityGroups = AWSConfigs.InitializeCollections ? new List<AwsRdsDbSecurityGroupEc2SecurityGroup>() : null;
        private List<AwsRdsDbSecurityGroupIpRange> _ipRanges = AWSConfigs.InitializeCollections ? new List<AwsRdsDbSecurityGroupIpRange>() : null;
        private string _ownerId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property DbSecurityGroupArn. 
        /// <para>
        /// The ARN for the DB security group.
        /// </para>
        /// </summary>
        public string DbSecurityGroupArn
        {
            get { return this._dbSecurityGroupArn; }
            set { this._dbSecurityGroupArn = value; }
        }

        // Check to see if DbSecurityGroupArn property is set
        internal bool IsSetDbSecurityGroupArn()
        {
            return this._dbSecurityGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DbSecurityGroupDescription. 
        /// <para>
        /// Provides the description of the DB security group.
        /// </para>
        /// </summary>
        public string DbSecurityGroupDescription
        {
            get { return this._dbSecurityGroupDescription; }
            set { this._dbSecurityGroupDescription = value; }
        }

        // Check to see if DbSecurityGroupDescription property is set
        internal bool IsSetDbSecurityGroupDescription()
        {
            return this._dbSecurityGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DbSecurityGroupName. 
        /// <para>
        /// Specifies the name of the DB security group.
        /// </para>
        /// </summary>
        public string DbSecurityGroupName
        {
            get { return this._dbSecurityGroupName; }
            set { this._dbSecurityGroupName = value; }
        }

        // Check to see if DbSecurityGroupName property is set
        internal bool IsSetDbSecurityGroupName()
        {
            return this._dbSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2SecurityGroups. 
        /// <para>
        /// Contains a list of EC2 security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbSecurityGroupEc2SecurityGroup> Ec2SecurityGroups
        {
            get { return this._ec2SecurityGroups; }
            set { this._ec2SecurityGroups = value; }
        }

        // Check to see if Ec2SecurityGroups property is set
        internal bool IsSetEc2SecurityGroups()
        {
            return this._ec2SecurityGroups != null && (this._ec2SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpRanges. 
        /// <para>
        /// Contains a list of IP ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbSecurityGroupIpRange> IpRanges
        {
            get { return this._ipRanges; }
            set { this._ipRanges = value; }
        }

        // Check to see if IpRanges property is set
        internal bool IsSetIpRanges()
        {
            return this._ipRanges != null && (this._ipRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// Provides the Amazon Web Services ID of the owner of a specific DB security group.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides VPC ID associated with the DB security group. 
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}