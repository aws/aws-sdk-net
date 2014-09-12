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
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
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
    /// Container for the parameters to the RevokeDBSecurityGroupIngress operation.
    /// Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2
    /// or VPC Security Groups. Required parameters for this API are one of CIDRIP, EC2SecurityGroupId
    /// for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
    /// </summary>
    public partial class RevokeDBSecurityGroupIngressRequest : AmazonRDSRequest
    {
        private string _cIDRIP;
        private string _dBSecurityGroupName;
        private string _eC2SecurityGroupId;
        private string _eC2SecurityGroupName;
        private string _eC2SecurityGroupOwnerId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RevokeDBSecurityGroupIngressRequest() { }

        /// <summary>
        /// Instantiates RevokeDBSecurityGroupIngressRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSecurityGroupName"> The name of the DB security group to revoke ingress from. </param>
        public RevokeDBSecurityGroupIngressRequest(string dbSecurityGroupName)
        {
            _dBSecurityGroupName = dbSecurityGroupName;
        }

        /// <summary>
        /// Gets and sets the property CIDRIP. 
        /// <para>
        ///  The IP range to revoke access from. Must be a valid CIDR range. If <code>CIDRIP</code>
        /// is specified, <code>EC2SecurityGroupName</code>, <code>EC2SecurityGroupId</code> and
        /// <code>EC2SecurityGroupOwnerId</code> cannot be provided. 
        /// </para>
        /// </summary>
        public string CIDRIP
        {
            get { return this._cIDRIP; }
            set { this._cIDRIP = value; }
        }

        // Check to see if CIDRIP property is set
        internal bool IsSetCIDRIP()
        {
            return this._cIDRIP != null;
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroupName. 
        /// <para>
        ///  The name of the DB security group to revoke ingress from. 
        /// </para>
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this._dBSecurityGroupName; }
            set { this._dBSecurityGroupName = value; }
        }

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this._dBSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupId. 
        /// <para>
        ///  The id of the EC2 security group to revoke access from. For VPC DB security groups,
        /// <code>EC2SecurityGroupId</code> must be provided. Otherwise, EC2SecurityGroupOwnerId
        /// and either <code>EC2SecurityGroupName</code> or <code>EC2SecurityGroupId</code> must
        /// be provided. 
        /// </para>
        /// </summary>
        public string EC2SecurityGroupId
        {
            get { return this._eC2SecurityGroupId; }
            set { this._eC2SecurityGroupId = value; }
        }

        // Check to see if EC2SecurityGroupId property is set
        internal bool IsSetEC2SecurityGroupId()
        {
            return this._eC2SecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        ///  The name of the EC2 security group to revoke access from. For VPC DB security groups,
        /// <code>EC2SecurityGroupId</code> must be provided. Otherwise, EC2SecurityGroupOwnerId
        /// and either <code>EC2SecurityGroupName</code> or <code>EC2SecurityGroupId</code> must
        /// be provided. 
        /// </para>
        /// </summary>
        public string EC2SecurityGroupName
        {
            get { return this._eC2SecurityGroupName; }
            set { this._eC2SecurityGroupName = value; }
        }

        // Check to see if EC2SecurityGroupName property is set
        internal bool IsSetEC2SecurityGroupName()
        {
            return this._eC2SecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupOwnerId. 
        /// <para>
        ///  The AWS Account Number of the owner of the EC2 security group specified in the <code>EC2SecurityGroupName</code>
        /// parameter. The AWS Access Key ID is not an acceptable value. For VPC DB security groups,
        /// <code>EC2SecurityGroupId</code> must be provided. Otherwise, EC2SecurityGroupOwnerId
        /// and either <code>EC2SecurityGroupName</code> or <code>EC2SecurityGroupId</code> must
        /// be provided. 
        /// </para>
        /// </summary>
        public string EC2SecurityGroupOwnerId
        {
            get { return this._eC2SecurityGroupOwnerId; }
            set { this._eC2SecurityGroupOwnerId = value; }
        }

        // Check to see if EC2SecurityGroupOwnerId property is set
        internal bool IsSetEC2SecurityGroupOwnerId()
        {
            return this._eC2SecurityGroupOwnerId != null;
        }

    }
}