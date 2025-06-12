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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The details of the VPC of the Amazon OpenSearch Service destination.
    /// </summary>
    public partial class VpcConfigurationDescription
    {
        private string _roleARN;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the IAM role that the Firehose stream uses to create endpoints in the destination
        /// VPC. You can use your existing Firehose delivery role or you can specify a new role.
        /// In either case, make sure that the role trusts the Firehose service principal and
        /// that it grants the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ec2:DescribeVpcs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:DescribeVpcAttribute</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:DescribeSubnets</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:DescribeSecurityGroups</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:DescribeNetworkInterfaces</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:CreateNetworkInterface</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:CreateNetworkInterfacePermission</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:DeleteNetworkInterface</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you revoke these permissions after you create the Firehose stream, Firehose can't
        /// scale out by creating more ENIs when necessary. You might therefore see a degradation
        /// in performance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups that Firehose uses when it creates ENIs in the VPC
        /// of the Amazon OpenSearch Service destination. You can use the same security group
        /// that the Amazon ES domain uses or different ones. If you specify different security
        /// groups, ensure that they allow outbound HTTPS traffic to the Amazon OpenSearch Service
        /// domain's security group. Also ensure that the Amazon OpenSearch Service domain's security
        /// group allows HTTPS traffic from the security groups specified here. If you use the
        /// same security group for both your Firehose stream and the Amazon OpenSearch Service
        /// domain, make sure the security group inbound rule allows HTTPS traffic. For more information
        /// about security group rules, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html#SecurityGroupRules">Security
        /// group rules</a> in the Amazon VPC documentation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The IDs of the subnets that Firehose uses to create ENIs in the VPC of the Amazon
        /// OpenSearch Service destination. Make sure that the routing tables and inbound and
        /// outbound rules allow traffic to flow from the subnets whose IDs are specified here
        /// to the subnets that have the destination Amazon OpenSearch Service endpoints. Firehose
        /// creates at least one ENI in each of the subnets that are specified here. Do not delete
        /// or modify these ENIs.
        /// </para>
        ///  
        /// <para>
        /// The number of ENIs that Firehose creates in the subnets specified here scales up and
        /// down automatically based on throughput. To enable Firehose to scale up the number
        /// of ENIs to match throughput, ensure that you have sufficient quota. To help you calculate
        /// the quota you need, assume that Firehose can create up to three ENIs for this Firehose
        /// stream for each of the subnets specified here. For more information about ENI quota,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-enis">Network
        /// Interfaces </a> in the Amazon VPC Quotas topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon OpenSearch Service destination's VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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