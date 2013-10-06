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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeDBSecurityGroupIngress operation.
    /// <para> Enables ingress to a DBSecurityGroup using one of two forms of authorization. First, EC2 or VPC Security Groups can be added to the
    /// DBSecurityGroup if the application using the database is running on EC2 or VPC instances. Second, IP ranges are available if the application
    /// accessing your database is running on the Internet. Required parameters for this API are one of CIDR range, EC2SecurityGroupId for VPC, or
    /// (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC). </para> <para><b>NOTE:</b> You cannot authorize
    /// ingress from an EC2 security group in one Region to an Amazon RDS DB Instance in another. You cannot authorize ingress from a VPC security
    /// group in one VPC to an Amazon RDS DB Instance in another. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial.
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.AuthorizeDBSecurityGroupIngress"/>
    public class AuthorizeDBSecurityGroupIngressRequest : AmazonWebServiceRequest
    {
        private string dBSecurityGroupName;
        private string cIDRIP;
        private string eC2SecurityGroupName;
        private string eC2SecurityGroupId;
        private string eC2SecurityGroupOwnerId;

        /// <summary>
        /// The name of the DB Security Group to add authorization to.
        ///  
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this.dBSecurityGroupName; }
            set { this.dBSecurityGroupName = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupName property
        /// </summary>
        /// <param name="dBSecurityGroupName">The value to set for the DBSecurityGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeDBSecurityGroupIngressRequest WithDBSecurityGroupName(string dBSecurityGroupName)
        {
            this.dBSecurityGroupName = dBSecurityGroupName;
            return this;
        }
            

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this.dBSecurityGroupName != null;
        }

        /// <summary>
        /// The IP range to authorize.
        ///  
        /// </summary>
        public string CIDRIP
        {
            get { return this.cIDRIP; }
            set { this.cIDRIP = value; }
        }

        /// <summary>
        /// Sets the CIDRIP property
        /// </summary>
        /// <param name="cIDRIP">The value to set for the CIDRIP property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeDBSecurityGroupIngressRequest WithCIDRIP(string cIDRIP)
        {
            this.cIDRIP = cIDRIP;
            return this;
        }
            

        // Check to see if CIDRIP property is set
        internal bool IsSetCIDRIP()
        {
            return this.cIDRIP != null;
        }

        /// <summary>
        /// Name of the EC2 Security Group to authorize. For VPC DB Security Groups, <c>EC2SecurityGroupId</c> must be provided. Otherwise,
        /// EC2SecurityGroupOwnerId and either <c>EC2SecurityGroupName</c> or <c>EC2SecurityGroupId</c> must be provided.
        ///  
        /// </summary>
        public string EC2SecurityGroupName
        {
            get { return this.eC2SecurityGroupName; }
            set { this.eC2SecurityGroupName = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroupName property
        /// </summary>
        /// <param name="eC2SecurityGroupName">The value to set for the EC2SecurityGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeDBSecurityGroupIngressRequest WithEC2SecurityGroupName(string eC2SecurityGroupName)
        {
            this.eC2SecurityGroupName = eC2SecurityGroupName;
            return this;
        }
            

        // Check to see if EC2SecurityGroupName property is set
        internal bool IsSetEC2SecurityGroupName()
        {
            return this.eC2SecurityGroupName != null;
        }

        /// <summary>
        /// Id of the EC2 Security Group to authorize. For VPC DB Security Groups, <c>EC2SecurityGroupId</c> must be provided. Otherwise,
        /// EC2SecurityGroupOwnerId and either <c>EC2SecurityGroupName</c> or <c>EC2SecurityGroupId</c> must be provided.
        ///  
        /// </summary>
        public string EC2SecurityGroupId
        {
            get { return this.eC2SecurityGroupId; }
            set { this.eC2SecurityGroupId = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroupId property
        /// </summary>
        /// <param name="eC2SecurityGroupId">The value to set for the EC2SecurityGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeDBSecurityGroupIngressRequest WithEC2SecurityGroupId(string eC2SecurityGroupId)
        {
            this.eC2SecurityGroupId = eC2SecurityGroupId;
            return this;
        }
            

        // Check to see if EC2SecurityGroupId property is set
        internal bool IsSetEC2SecurityGroupId()
        {
            return this.eC2SecurityGroupId != null;
        }

        /// <summary>
        /// AWS Account Number of the owner of the EC2 Security Group specified in the EC2SecurityGroupName parameter. The AWS Access Key ID is not an
        /// acceptable value. For VPC DB Security Groups, <c>EC2SecurityGroupId</c> must be provided. Otherwise, EC2SecurityGroupOwnerId and either
        /// <c>EC2SecurityGroupName</c> or <c>EC2SecurityGroupId</c> must be provided.
        ///  
        /// </summary>
        public string EC2SecurityGroupOwnerId
        {
            get { return this.eC2SecurityGroupOwnerId; }
            set { this.eC2SecurityGroupOwnerId = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroupOwnerId property
        /// </summary>
        /// <param name="eC2SecurityGroupOwnerId">The value to set for the EC2SecurityGroupOwnerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeDBSecurityGroupIngressRequest WithEC2SecurityGroupOwnerId(string eC2SecurityGroupOwnerId)
        {
            this.eC2SecurityGroupOwnerId = eC2SecurityGroupOwnerId;
            return this;
        }
            

        // Check to see if EC2SecurityGroupOwnerId property is set
        internal bool IsSetEC2SecurityGroupOwnerId()
        {
            return this.eC2SecurityGroupOwnerId != null;
        }
    }
}
    
