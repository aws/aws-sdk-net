/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Revokes an ingress rule in an Amazon Redshift security group for a previously authorized IP range or Amazon EC2 security group. To
    /// add an ingress rule, see AuthorizeClusterSecurityGroupIngress. For information about managing security groups, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Amazon Redshift Cluster Security Groups</a> in the
    /// <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class RevokeClusterSecurityGroupIngressRequest : AmazonRedshiftRequest
    {
        private string clusterSecurityGroupName;
        private string cIDRIP;
        private string eC2SecurityGroupName;
        private string eC2SecurityGroupOwnerId;


        /// <summary>
        /// The name of the security Group from which to revoke the ingress rule.
        ///  
        /// </summary>
        public string ClusterSecurityGroupName
        {
            get { return this.clusterSecurityGroupName; }
            set { this.clusterSecurityGroupName = value; }
        }

        // Check to see if ClusterSecurityGroupName property is set
        internal bool IsSetClusterSecurityGroupName()
        {
            return this.clusterSecurityGroupName != null;
        }

        /// <summary>
        /// The IP range for which to revoke access. This range must be a valid Classless Inter-Domain Routing (CIDR) block of IP addresses. If
        /// <c>CIDRIP</c> is specified, <c>EC2SecurityGroupName</c> and <c>EC2SecurityGroupOwnerId</c> cannot be provided.
        ///  
        /// </summary>
        public string CIDRIP
        {
            get { return this.cIDRIP; }
            set { this.cIDRIP = value; }
        }

        // Check to see if CIDRIP property is set
        internal bool IsSetCIDRIP()
        {
            return this.cIDRIP != null;
        }

        /// <summary>
        /// The name of the EC2 Security Group whose access is to be revoked. If <c>EC2SecurityGroupName</c> is specified,
        /// <c>EC2SecurityGroupOwnerId</c> must also be provided and <c>CIDRIP</c> cannot be provided.
        ///  
        /// </summary>
        public string EC2SecurityGroupName
        {
            get { return this.eC2SecurityGroupName; }
            set { this.eC2SecurityGroupName = value; }
        }

        // Check to see if EC2SecurityGroupName property is set
        internal bool IsSetEC2SecurityGroupName()
        {
            return this.eC2SecurityGroupName != null;
        }

        /// <summary>
        /// The AWS account number of the owner of the security group specified in the <c>EC2SecurityGroupName</c> parameter. The AWS access key ID is
        /// not an acceptable value. If <c>EC2SecurityGroupOwnerId</c> is specified, <c>EC2SecurityGroupName</c> must also be provided. and
        /// <c>CIDRIP</c> cannot be provided. Example: <c>111122223333</c>
        ///  
        /// </summary>
        public string EC2SecurityGroupOwnerId
        {
            get { return this.eC2SecurityGroupOwnerId; }
            set { this.eC2SecurityGroupOwnerId = value; }
        }

        // Check to see if EC2SecurityGroupOwnerId property is set
        internal bool IsSetEC2SecurityGroupOwnerId()
        {
            return this.eC2SecurityGroupOwnerId != null;
        }

    }
}
    
