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
    /// Container for the parameters to the AuthorizeClusterSecurityGroupIngress operation.
    /// Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on
    /// whether the application accessing your cluster is running on the Internet or an Amazon
    /// EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing
    /// (CIDR)/Internet Protocol (IP) range or to an Amazon EC2 security group. You can add
    /// as many as 20 ingress rules to an Amazon Redshift security group. <para> If you authorize
    /// access to an Amazon EC2 security group, specify <i>EC2SecurityGroupName</i> and <i>EC2SecurityGroupOwnerId</i>.
    /// The Amazon EC2 security group and Amazon Redshift cluster must be in the same Amazon
    /// Web Services Region. </para> <para> If you authorize access to a CIDR/IP address range,
    /// specify <i>CIDRIP</i>. For an overview of CIDR blocks, see the Wikipedia article on
    /// <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless Inter-Domain
    /// Routing</a>. </para> <para> You must also associate the security group with a cluster
    /// so that clients running on these IP addresses or the EC2 instance are authorized to
    /// connect to the cluster. For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
    /// with Security Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>. </para>
    /// </summary>
    public partial class AuthorizeClusterSecurityGroupIngressRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property CIDRIP. 
        /// <para>
        /// The IP range to be added the Amazon Redshift security group.
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
        /// The name of the security group to which the ingress rule is added.
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
        /// The EC2 security group to be added the Amazon Redshift security group.
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
        /// by the <i>EC2SecurityGroupName</i> parameter. The Amazon Web Services Access Key ID
        /// is not an acceptable value. 
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
