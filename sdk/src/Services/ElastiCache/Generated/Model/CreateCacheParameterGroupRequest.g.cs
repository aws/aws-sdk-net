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
    /// Container for the parameters to the CreateCacheParameterGroup operation. Creates a
    /// new Amazon ElastiCache cache parameter group. An ElastiCache cache parameter group
    /// is a collection of parameters and their values that are applied to all of the nodes
    /// in any cluster or replication group using the CacheParameterGroup. <para> A newly
    /// created CacheParameterGroup is an exact duplicate of the default parameter group for
    /// the CacheParameterGroupFamily. To customize the newly created CacheParameterGroup
    /// you can change the values of specific parameters. For more information, see: </para>
    /// <ul> <li> <para> <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ModifyCacheParameterGroup.html">ModifyCacheParameterGroup</a>
    /// in the ElastiCache API Reference. </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ParameterGroups.html">Parameters
    /// and Parameter Groups</a> in the ElastiCache User Guide. </para> </li> </ul>
    /// </summary>
    public partial class CreateCacheParameterGroupRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateCacheParameterGroupRequest() { }

        /// <summary>
        /// Instantiates CreateCacheParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheParameterGroupName">A user-specified name for the cache parameter group. This value is stored as a lowercase string.</param>
        /// <param name="cacheParameterGroupFamily">The name of the cache parameter group family that the cache parameter group can be   used with.   Valid values are: <c>valkey8</c> | <c>valkey7</c> | <c>memcached1.4</c> | <c>memcached1.5</c> | <c>memcached1.6</c> | <c>redis2.6</c> | <c>redis2.8</c> |<c>redis3.2</c> | <c>redis4.0</c> | <c>redis5.0</c> | <c>redis6.x</c> | <c>redis7</c>   </param>
        /// <param name="description">A user-specified description for the cache parameter group.</param>
        public CreateCacheParameterGroupRequest(string cacheParameterGroupName, string cacheParameterGroupFamily, string description)
        {
            this.CacheParameterGroupName = cacheParameterGroupName;
            this.CacheParameterGroupFamily = cacheParameterGroupFamily;
            this.Description = description;
        }

        /// <summary>
        /// Gets and sets the property CacheParameterGroupFamily. 
        /// <para>
        /// The name of the cache parameter group family that the cache parameter group can be
        /// used with.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <c>valkey8</c> | <c>valkey7</c> | <c>memcached1.4</c> | <c>memcached1.5</c>
        /// | <c>memcached1.6</c> | <c>redis2.6</c> | <c>redis2.8</c> | <c>redis3.2</c> | <c>redis4.0</c>
        /// | <c>redis5.0</c> | <c>redis6.x</c> | <c>redis7</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CacheParameterGroupFamily { get; set; }

        /// <summary>
        /// Checks to see if the CacheParameterGroupFamily property is set.
        /// </summary>
        internal bool IsSetCacheParameterGroupFamily() => this.CacheParameterGroupFamily != null;

        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// A user-specified name for the cache parameter group. This value is stored as a lowercase
        /// string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CacheParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CacheParameterGroupName property is set.
        /// </summary>
        internal bool IsSetCacheParameterGroupName() => this.CacheParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-specified description for the cache parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
