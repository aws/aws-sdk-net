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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeClusterSecurityGroupIngress operation.
    /// Revokes an ingress rule in an Amazon Redshift security group for a previously authorized
    /// IP range or Amazon EC2 security group. To add an ingress rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.
    /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
    /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
    /// Guide</i>.
    /// </summary>
    public partial class RevokeClusterSecurityGroupIngressRequest : AmazonRedshiftRequest
    {
        private string _cidrip;
        private string _clusterSecurityGroupName;
        private string _ec2SecurityGroupName;
        private string _ec2SecurityGroupOwnerId;

        /// <summary>
        /// Gets and sets the property CIDRIP. 
        /// <para>
        /// The IP range for which to revoke access. This range must be a valid Classless Inter-Domain
        /// Routing (CIDR) block of IP addresses. If <c>CIDRIP</c> is specified, <c>EC2SecurityGroupName</c>
        /// and <c>EC2SecurityGroupOwnerId</c> cannot be provided. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property ClusterSecurityGroupName. 
        /// <para>
        /// The name of the security Group from which to revoke the ingress rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// The name of the EC2 Security Group whose access is to be revoked. If <c>EC2SecurityGroupName</c>
        /// is specified, <c>EC2SecurityGroupOwnerId</c> must also be provided and <c>CIDRIP</c>
        /// cannot be provided. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The Amazon Web Services account number of the owner of the security group specified
        /// in the <c>EC2SecurityGroupName</c> parameter. The Amazon Web Services access key ID
        /// is not an acceptable value. If <c>EC2SecurityGroupOwnerId</c> is specified, <c>EC2SecurityGroupName</c>
        /// must also be provided. and <c>CIDRIP</c> cannot be provided. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>111122223333</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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