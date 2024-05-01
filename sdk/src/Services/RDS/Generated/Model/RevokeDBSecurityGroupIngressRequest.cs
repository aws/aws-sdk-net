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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    /// Container for the parameters to the RevokeDBSecurityGroupIngress operation.
    /// Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2
    /// or VPC security groups. Required parameters for this API are one of CIDRIP, EC2SecurityGroupId
    /// for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
    /// 
    ///  <note> 
    /// <para>
    /// EC2-Classic was retired on August 15, 2022. If you haven't migrated from EC2-Classic
    /// to a VPC, we recommend that you migrate as soon as possible. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
    /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>, the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
    /// Networking is Retiring – Here’s How to Prepare</a>, and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.Non-VPC2VPC.html">Moving
    /// a DB instance not in a VPC into a VPC</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RevokeDBSecurityGroupIngressRequest : AmazonRDSRequest
    {
        private string _cidrip;
        private string _dbSecurityGroupName;
        private string _ec2SecurityGroupId;
        private string _ec2SecurityGroupName;
        private string _ec2SecurityGroupOwnerId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RevokeDBSecurityGroupIngressRequest() { }

        /// <summary>
        /// Instantiates RevokeDBSecurityGroupIngressRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSecurityGroupName">The name of the DB security group to revoke ingress from.</param>
        public RevokeDBSecurityGroupIngressRequest(string dbSecurityGroupName)
        {
            _dbSecurityGroupName = dbSecurityGroupName;
        }

        /// <summary>
        /// Gets and sets the property CIDRIP. 
        /// <para>
        /// The IP range to revoke access from. Must be a valid CIDR range. If <c>CIDRIP</c> is
        /// specified, <c>EC2SecurityGroupName</c>, <c>EC2SecurityGroupId</c> and <c>EC2SecurityGroupOwnerId</c>
        /// can't be provided.
        /// </para>
        /// </summary>
        public string CIDRIP
        {
            get { return this._cidrip; }
            set { this._cidrip = value; }
        }

        // Check to see if CIDRIP property is set
        internal bool IsSetCIDRIP()
        {
            return this._cidrip != null;
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroupName. 
        /// <para>
        /// The name of the DB security group to revoke ingress from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBSecurityGroupName
        {
            get { return this._dbSecurityGroupName; }
            set { this._dbSecurityGroupName = value; }
        }

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this._dbSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupId. 
        /// <para>
        /// The id of the EC2 security group to revoke access from. For VPC DB security groups,
        /// <c>EC2SecurityGroupId</c> must be provided. Otherwise, EC2SecurityGroupOwnerId and
        /// either <c>EC2SecurityGroupName</c> or <c>EC2SecurityGroupId</c> must be provided.
        /// </para>
        /// </summary>
        public string EC2SecurityGroupId
        {
            get { return this._ec2SecurityGroupId; }
            set { this._ec2SecurityGroupId = value; }
        }

        // Check to see if EC2SecurityGroupId property is set
        internal bool IsSetEC2SecurityGroupId()
        {
            return this._ec2SecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        /// The name of the EC2 security group to revoke access from. For VPC DB security groups,
        /// <c>EC2SecurityGroupId</c> must be provided. Otherwise, EC2SecurityGroupOwnerId and
        /// either <c>EC2SecurityGroupName</c> or <c>EC2SecurityGroupId</c> must be provided.
        /// </para>
        /// </summary>
        public string EC2SecurityGroupName
        {
            get { return this._ec2SecurityGroupName; }
            set { this._ec2SecurityGroupName = value; }
        }

        // Check to see if EC2SecurityGroupName property is set
        internal bool IsSetEC2SecurityGroupName()
        {
            return this._ec2SecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupOwnerId. 
        /// <para>
        /// The Amazon Web Services account number of the owner of the EC2 security group specified
        /// in the <c>EC2SecurityGroupName</c> parameter. The Amazon Web Services access key ID
        /// isn't an acceptable value. For VPC DB security groups, <c>EC2SecurityGroupId</c> must
        /// be provided. Otherwise, EC2SecurityGroupOwnerId and either <c>EC2SecurityGroupName</c>
        /// or <c>EC2SecurityGroupId</c> must be provided.
        /// </para>
        /// </summary>
        public string EC2SecurityGroupOwnerId
        {
            get { return this._ec2SecurityGroupOwnerId; }
            set { this._ec2SecurityGroupOwnerId = value; }
        }

        // Check to see if EC2SecurityGroupOwnerId property is set
        internal bool IsSetEC2SecurityGroupOwnerId()
        {
            return this._ec2SecurityGroupOwnerId != null;
        }

    }
}