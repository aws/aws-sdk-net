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
    /// <para>The <i>AuthorizeCacheSecurityGroupIngress</i> operation allows network ingress to a cache security group. Applications using
    /// ElastiCache must be running on Amazon EC2, and Amazon EC2 security groups are used as the authorization mechanism.</para> <para><b>NOTE:</b>
    /// You cannot authorize ingress from an Amazon EC2 security group in one Region to an ElastiCache cluster in another Region. </para>
    /// </summary>
    public partial class AuthorizeCacheSecurityGroupIngressRequest : AmazonElastiCacheRequest
    {
        private string cacheSecurityGroupName;
        private string eC2SecurityGroupName;
        private string eC2SecurityGroupOwnerId;


        /// <summary>
        /// The cache security group which will allow network ingress.
        ///  
        /// </summary>
        public string CacheSecurityGroupName
        {
            get { return this.cacheSecurityGroupName; }
            set { this.cacheSecurityGroupName = value; }
        }

        // Check to see if CacheSecurityGroupName property is set
        internal bool IsSetCacheSecurityGroupName()
        {
            return this.cacheSecurityGroupName != null;
        }

        /// <summary>
        /// The Amazon EC2 security group to be authorized for ingress to the cache security group.
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
        /// The AWS account number of the Amazon EC2 security group owner. Note that this is not the same thing as an AWS access key ID - you must
        /// provide a valid AWS account number for this parameter.
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
    
