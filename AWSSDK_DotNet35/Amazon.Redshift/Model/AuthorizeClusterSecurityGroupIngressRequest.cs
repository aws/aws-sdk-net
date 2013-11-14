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
    /// Container for the parameters to the AuthorizeClusterSecurityGroupIngress operation.
    /// <para> Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on whether the application accessing your cluster is
    /// running on the Internet or an EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing (CIDR) IP address
    /// range or an EC2 security group. You can add as many as 20 ingress rules to an Amazon Redshift security group. </para> <para><b>NOTE:</b> The
    /// EC2 security group must be defined in the AWS region where the cluster resides. </para> <para>For an overview of CIDR blocks, see the
    /// Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing" >Classless Inter-Domain Routing</a> .
    /// </para> <para> You must also associate the security group with a cluster so that clients running on these IP addresses or the EC2
    /// instance are authorized to connect to the cluster. For information about managing security groups, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Working with Security Groups</a> in the <i>Amazon
    /// Redshift Management Guide</i> .</para>
    /// </summary>
    public partial class AuthorizeClusterSecurityGroupIngressRequest : AmazonRedshiftRequest
    {
        private string clusterSecurityGroupName;
        private string cIDRIP;
        private string eC2SecurityGroupName;
        private string eC2SecurityGroupOwnerId;


        /// <summary>
        /// The name of the security group to which the ingress rule is added.
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
        /// The IP range to be added the Amazon Redshift security group.
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
        /// The EC2 security group to be added the Amazon Redshift security group.
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
        /// The AWS account number of the owner of the security group specified by the <i>EC2SecurityGroupName</i> parameter. The AWS Access Key ID is
        /// not an acceptable value. Example: <c>111122223333</c>
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
    
