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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeClusterSecurityGroupIngress operation.
    /// Revokes an ingress rule in an Amazon Redshift security group for a previously
    /// authorized IP range or         Amazon EC2 security group. To add        an ingress
    /// rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.             For information
    /// about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
    /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
    /// </summary>
    public partial class RevokeClusterSecurityGroupIngressRequest : AmazonRedshiftRequest
    {
        private string _cIDRIP;
        private string _clusterSecurityGroupName;
        private string _eC2SecurityGroupName;
        private string _eC2SecurityGroupOwnerId;


        /// <summary>
        /// Gets and sets the property CIDRIP. 
        /// <para>
        ///         The IP range for which to revoke access.         This range must be a valid
        /// Classless Inter-Domain Routing (CIDR) block of IP addresses.         If <code>CIDRIP</code>
        /// is specified,        <code>EC2SecurityGroupName</code> and <code>EC2SecurityGroupOwnerId</code>
        ///        cannot be provided.        
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
        /// Gets and sets the property ClusterSecurityGroupName. 
        /// <para>
        ///         The name of the security Group from which to revoke the ingress rule.    
        ///    
        /// </para>
        /// </summary>
        public string ClusterSecurityGroupName
        {
            get { return this._clusterSecurityGroupName; }
            set { this._clusterSecurityGroupName = value; }
        }

        // Check to see if ClusterSecurityGroupName property is set
        internal bool IsSetClusterSecurityGroupName()
        {
            return this._clusterSecurityGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        ///         The name of the EC2 Security Group whose access is to be revoked.        If
        /// <code>EC2SecurityGroupName</code> is specified, <code>EC2SecurityGroupOwnerId</code>
        ///         must also be provided and <code>CIDRIP</code> cannot be provided.        
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
        ///         The AWS account number of the owner of the security group        specified
        /// in the <code>EC2SecurityGroupName</code> parameter.        The AWS access key ID is
        /// not an acceptable value.        If <code>EC2SecurityGroupOwnerId</code> is specified,
        /// <code>EC2SecurityGroupName</code>             must also be provided. and <code>CIDRIP</code>
        /// cannot be provided.        
        /// </para>
        ///         
        /// <para>
        /// Example: <code>111122223333</code>
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