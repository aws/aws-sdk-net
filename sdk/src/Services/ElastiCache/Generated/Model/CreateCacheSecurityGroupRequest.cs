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
    /// Container for the parameters to the CreateCacheSecurityGroup operation.
    /// Creates a new cache security group. Use a cache security group to control access to
    /// one or more clusters.
    /// 
    ///  
    /// <para>
    /// Cache security groups are only used when you are creating a cluster outside of an
    /// Amazon Virtual Private Cloud (Amazon VPC). If you are creating a cluster inside of
    /// a VPC, use a cache subnet group instead. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_CreateCacheSubnetGroup.html">CreateCacheSubnetGroup</a>.
    /// </para>
    /// </summary>
    public partial class CreateCacheSecurityGroupRequest : AmazonElastiCacheRequest
    {
        private string _cacheSecurityGroupName;
        private string _description;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateCacheSecurityGroupRequest() { }

        /// <summary>
        /// Instantiates CreateCacheSecurityGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheSecurityGroupName">A name for the cache security group. This value is stored as a lowercase string. Constraints: Must contain no more than 255 alphanumeric characters. Cannot be the word "Default". Example: <c>mysecuritygroup</c> </param>
        /// <param name="description">A description for the cache security group.</param>
        public CreateCacheSecurityGroupRequest(string cacheSecurityGroupName, string description)
        {
            _cacheSecurityGroupName = cacheSecurityGroupName;
            _description = description;
        }

        /// <summary>
        /// Gets and sets the property CacheSecurityGroupName. 
        /// <para>
        /// A name for the cache security group. This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters. Cannot be the
        /// word "Default".
        /// </para>
        ///  
        /// <para>
        /// Example: <c>mysecuritygroup</c> 
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the cache security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}