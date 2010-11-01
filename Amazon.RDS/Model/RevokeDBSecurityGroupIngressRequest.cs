/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the RevokeDBSecurityGroupIngress operation.
    /// <para> This API revokes ingress from a DBSecurityGroup for previously
    /// authorized IP ranges or EC2 Security Groups. Required parameters for
    /// this API are one of CIDRIP or (EC2SecurityGroupName AND
    /// EC2SecurityGroupOwnerId). </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.RevokeDBSecurityGroupIngress"/>
    public class RevokeDBSecurityGroupIngressRequest : AmazonWebServiceRequest
    {
        private string dBSecurityGroupName;
        private string cIDRIP;
        private string eC2SecurityGroupName;
        private string eC2SecurityGroupOwnerId;

        /// <summary>
        /// The name of the DB Security Group to revoke ingress from.
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
        public RevokeDBSecurityGroupIngressRequest WithDBSecurityGroupName(string dBSecurityGroupName)
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
        /// The IP range to revoke access from.
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
        public RevokeDBSecurityGroupIngressRequest WithCIDRIP(string cIDRIP)
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
        /// The name of the EC2 Security Group to revoke access from.
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
        public RevokeDBSecurityGroupIngressRequest WithEC2SecurityGroupName(string eC2SecurityGroupName)
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
        /// The AWS Account Number of the owner of the security group specified in
        /// the <i>EC2SecurityGroupName</i> parameter. The AWS Access Key ID is
        /// not an acceptable value.
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
        public RevokeDBSecurityGroupIngressRequest WithEC2SecurityGroupOwnerId(string eC2SecurityGroupOwnerId)
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
    
