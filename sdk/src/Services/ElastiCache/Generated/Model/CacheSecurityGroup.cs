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
    /// Represents the output of one of the following operations:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>AuthorizeCacheSecurityGroupIngress</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateCacheSecurityGroup</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RevokeCacheSecurityGroupIngress</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CacheSecurityGroup
    {
        private string _arn;
        private string _cacheSecurityGroupName;
        private string _description;
        private List<EC2SecurityGroup> _ec2SecurityGroups = AWSConfigs.InitializeCollections ? new List<EC2SecurityGroup>() : null;
        private string _ownerId;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the cache security group,
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CacheSecurityGroupName. 
        /// <para>
        /// The name of the cache security group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cache security group.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroups. 
        /// <para>
        /// A list of Amazon EC2 security groups that are associated with this cache security
        /// group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups
        {
            get { return this._ec2SecurityGroups; }
            set { this._ec2SecurityGroups = value; }
        }

        // Check to see if EC2SecurityGroups property is set
        internal bool IsSetEC2SecurityGroups()
        {
            return this._ec2SecurityGroups != null && (this._ec2SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon account ID of the cache security group owner.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

    }
}