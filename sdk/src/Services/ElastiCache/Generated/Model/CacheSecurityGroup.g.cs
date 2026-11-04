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
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the cache security group,
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property CacheSecurityGroupName. 
        /// <para>
        /// The name of the cache security group.
        /// </para>
        /// </summary>
        public string CacheSecurityGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CacheSecurityGroupName property is set.
        /// </summary>
        internal bool IsSetCacheSecurityGroupName() => this.CacheSecurityGroupName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cache security group.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EC2SecurityGroups. 
        /// <para>
        /// A list of Amazon EC2 security groups that are associated with this cache security
        /// group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<EC2SecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the EC2SecurityGroups property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroups() => this.EC2SecurityGroups != null && (this.EC2SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon account ID of the cache security group owner.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;
    }
}
