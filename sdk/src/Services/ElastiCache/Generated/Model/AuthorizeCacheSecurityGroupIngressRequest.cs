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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeCacheSecurityGroupIngress operation.
    /// Allows network ingress to a cache security group. Applications using ElastiCache must
    /// be running on Amazon EC2, and Amazon EC2 security groups are used as the authorization
    /// mechanism.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot authorize ingress from an Amazon EC2 security group in one region to an
    /// ElastiCache cluster in another region.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AuthorizeCacheSecurityGroupIngressRequest : AmazonElastiCacheRequest
    {
        private string _cacheSecurityGroupName;
        private string _ec2SecurityGroupName;
        private string _ec2SecurityGroupOwnerId;

        /// <summary>
        /// Gets and sets the property CacheSecurityGroupName. 
        /// <para>
        /// The cache security group that allows network ingress.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CacheSecurityGroupName
        {
            get { return this._cacheSecurityGroupName; }
            set { this._cacheSecurityGroupName = value; }
        }

        // Check to see if CacheSecurityGroupName property is set
        internal bool IsSetCacheSecurityGroupName()
        {
            return this._cacheSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        /// The Amazon EC2 security group to be authorized for ingress to the cache security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The Amazon account number of the Amazon EC2 security group owner. Note that this is
        /// not the same thing as an Amazon access key ID - you must provide a valid Amazon account
        /// number for this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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