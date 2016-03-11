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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on
    /// whether the application accessing your cluster is running on the Internet or an Amazon
    /// EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing
    /// (CIDR)/Internet Protocol (IP) range or to an Amazon EC2 security group. You can add
    /// as many as 20 ingress rules to an Amazon Redshift security group. 
    /// 
    ///  
    /// <para>
    /// If you authorize access to an Amazon EC2 security group, specify <i>EC2SecurityGroupName</i>
    /// and <i>EC2SecurityGroupOwnerId</i>. The Amazon EC2 security group and Amazon Redshift
    /// cluster must be in the same AWS region. 
    /// </para>
    ///  
    /// <para>
    ///  If you authorize access to a CIDR/IP address range, specify <i>CIDRIP</i>. For an
    /// overview of CIDR blocks, see the Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
    /// Inter-Domain Routing</a>. 
    /// </para>
    ///  
    /// <para>
    ///  You must also associate the security group with a cluster so that clients running
    /// on these IP addresses or the EC2 instance are authorized to connect to the cluster.
    /// For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
    /// with Security Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class AuthorizeClusterSecurityGroupIngressRequest : AmazonRedshiftRequest
    {
        private string _cidrip;
        private string _clusterSecurityGroupName;
        private string _ec2SecurityGroupName;
        private string _ec2SecurityGroupOwnerId;

        /// <summary>
        /// Gets and sets the property CIDRIP. 
        /// <para>
        ///  The IP range to be added the Amazon Redshift security group. 
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
        /// Gets and sets the property ClusterSecurityGroupName. 
        /// <para>
        ///  The name of the security group to which the ingress rule is added. 
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
        ///  The EC2 security group to be added the Amazon Redshift security group. 
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
        ///  The AWS account number of the owner of the security group specified by the <i>EC2SecurityGroupName</i>
        /// parameter. The AWS Access Key ID is not an acceptable value. 
        /// </para>
        ///  
        /// <para>
        ///  Example: <code>111122223333</code> 
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