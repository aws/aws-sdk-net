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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeCacheSecurityGroupIngress operation.
    /// <para> Authorizes ingress to a CacheSecurityGroup using EC2 Security Groups as authorization (therefore the application using the cache must
    /// be running on EC2 clusters). This API requires the following parameters: EC2SecurityGroupName and EC2SecurityGroupOwnerId. </para>
    /// <para><b>NOTE:</b> You cannot authorize ingress from an EC2 security group in one Region to an Amazon Cache Cluster in another. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
    public class AuthorizeCacheSecurityGroupIngressRequest : AmazonWebServiceRequest
    {
        private string cacheSecurityGroupName;
        private string eC2SecurityGroupName;
        private string eC2SecurityGroupOwnerId;

        /// <summary>
        /// The name of the Cache Security Group to authorize.
        ///  
        /// </summary>
        public string CacheSecurityGroupName
        {
            get { return this.cacheSecurityGroupName; }
            set { this.cacheSecurityGroupName = value; }
        }

        /// <summary>
        /// Sets the CacheSecurityGroupName property
        /// </summary>
        /// <param name="cacheSecurityGroupName">The value to set for the CacheSecurityGroupName property </param>
        /// <returns>this instance</returns>
        public AuthorizeCacheSecurityGroupIngressRequest WithCacheSecurityGroupName(string cacheSecurityGroupName)
        {
            this.cacheSecurityGroupName = cacheSecurityGroupName;
            return this;
        }
            

        // Check to see if CacheSecurityGroupName property is set
        internal bool IsSetCacheSecurityGroupName()
        {
            return this.cacheSecurityGroupName != null;
        }

        /// <summary>
        /// Name of the EC2 Security Group to include in the authorization.
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
        public AuthorizeCacheSecurityGroupIngressRequest WithEC2SecurityGroupName(string eC2SecurityGroupName)
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
        /// AWS Account Number of the owner of the security group specified in the EC2SecurityGroupName parameter. The AWS Access Key ID is not an
        /// acceptable value.
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
        public AuthorizeCacheSecurityGroupIngressRequest WithEC2SecurityGroupOwnerId(string eC2SecurityGroupOwnerId)
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
    
