/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeDBSecurityGroupIngress operation.
    /// Enables ingress to a DBSecurityGroup using one of two forms of authorization. First,
    /// EC2 or VPC security groups can be added to the DBSecurityGroup if the application
    /// using the database is running on EC2 or VPC instances. Second, IP ranges are available
    /// if the application accessing your database is running on the Internet. Required parameters
    /// for this API are one of CIDR range, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId
    /// and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC).
    /// 
    ///  <note> 
    /// <para>
    /// You can't authorize ingress from an EC2 security group in one AWS Region to an Amazon
    /// RDS DB instance in another. You can't authorize ingress from a VPC security group
    /// in one VPC to an Amazon RDS DB instance in another.
    /// </para>
    ///  </note> 
    /// <para>
    /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
    /// Tutorial</a>. 
    /// </para>
    /// </summary>
    public partial class AuthorizeDBSecurityGroupIngressRequest : AmazonRDSRequest
    {
        private string _cidrip;
        private string _dbSecurityGroupName;
        private string _ec2SecurityGroupId;
        private string _ec2SecurityGroupName;
        private string _ec2SecurityGroupOwnerId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AuthorizeDBSecurityGroupIngressRequest() { }

        /// <summary>
        /// Instantiates AuthorizeDBSecurityGroupIngressRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSecurityGroupName">The name of the DB security group to add authorization to.</param>
        public AuthorizeDBSecurityGroupIngressRequest(string dbSecurityGroupName)
        {
            _dbSecurityGroupName = dbSecurityGroupName;
        }

        /// <summary>
        /// Gets and sets the property CIDRIP. 
        /// <para>
        /// The IP range to authorize.
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
        /// The name of the DB security group to add authorization to.
        /// </para>
        /// </summary>
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
        ///  Id of the EC2 security group to authorize. For VPC DB security groups, <code>EC2SecurityGroupId</code>
        /// must be provided. Otherwise, <code>EC2SecurityGroupOwnerId</code> and either <code>EC2SecurityGroupName</code>
        /// or <code>EC2SecurityGroupId</code> must be provided. 
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
        ///  Name of the EC2 security group to authorize. For VPC DB security groups, <code>EC2SecurityGroupId</code>
        /// must be provided. Otherwise, <code>EC2SecurityGroupOwnerId</code> and either <code>EC2SecurityGroupName</code>
        /// or <code>EC2SecurityGroupId</code> must be provided. 
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
        ///  AWS account number of the owner of the EC2 security group specified in the <code>EC2SecurityGroupName</code>
        /// parameter. The AWS Access Key ID is not an acceptable value. For VPC DB security groups,
        /// <code>EC2SecurityGroupId</code> must be provided. Otherwise, <code>EC2SecurityGroupOwnerId</code>
        /// and either <code>EC2SecurityGroupName</code> or <code>EC2SecurityGroupId</code> must
        /// be provided. 
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