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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeClusterSecurityGroupIngress operation. Revokes
    /// an ingress rule in an Amazon Redshift security group for a previously authorized IP
    /// range or Amazon EC2 security group. To add an ingress rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.
    /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
    /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
    /// Guide</i>.
    /// </summary>
    public partial class RevokeClusterSecurityGroupIngressRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property CIDRIP. 
        /// <para>
        /// The IP range for which to revoke access. This range must be a valid Classless Inter-Domain
        /// Routing (CIDR) block of IP addresses. If <c>CIDRIP</c> is specified, <c>EC2SecurityGroupName</c>
        /// and <c>EC2SecurityGroupOwnerId</c> cannot be provided. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CIDRIP { get; set; }

        /// <summary>
        /// Checks to see if the CIDRIP property is set.
        /// </summary>
        internal bool IsSetCIDRIP() => this.CIDRIP != null;

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroupName. 
        /// <para>
        /// The name of the security Group from which to revoke the ingress rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string ClusterSecurityGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSecurityGroupName property is set.
        /// </summary>
        internal bool IsSetClusterSecurityGroupName() => this.ClusterSecurityGroupName != null;

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        /// The name of the EC2 Security Group whose access is to be revoked. If <c>EC2SecurityGroupName</c>
        /// is specified, <c>EC2SecurityGroupOwnerId</c> must also be provided and <c>CIDRIP</c>
        /// cannot be provided. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string EC2SecurityGroupName { get; set; }

        /// <summary>
        /// Checks to see if the EC2SecurityGroupName property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroupName() => this.EC2SecurityGroupName != null;

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string EC2SecurityGroupOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the EC2SecurityGroupOwnerId property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroupOwnerId() => this.EC2SecurityGroupOwnerId != null;
    }
}
