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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
    /// Container for the parameters to the CreateCacheSubnetGroup operation.
    /// Creates a new cache subnet group.
    /// 
    ///  
    /// <para>
    /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
    /// Cloud (Amazon VPC).
    /// </para>
    /// </summary>
    public partial class CreateCacheSubnetGroupRequest : AmazonElastiCacheRequest
    {
        private string _cacheSubnetGroupDescription;
        private string _cacheSubnetGroupName;
        private List<string> _subnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CacheSubnetGroupDescription. 
        /// <para>
        /// A description for the cache subnet group.
        /// </para>
        /// </summary>
        public string CacheSubnetGroupDescription
        {
            get { return this._cacheSubnetGroupDescription; }
            set { this._cacheSubnetGroupDescription = value; }
        }

        // Check to see if CacheSubnetGroupDescription property is set
        internal bool IsSetCacheSubnetGroupDescription()
        {
            return this._cacheSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CacheSubnetGroupName. 
        /// <para>
        /// A name for the cache subnet group. This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters or hyphens.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>mysubnetgroup</code> 
        /// </para>
        /// </summary>
        public string CacheSubnetGroupName
        {
            get { return this._cacheSubnetGroupName; }
            set { this._cacheSubnetGroupName = value; }
        }

        // Check to see if CacheSubnetGroupName property is set
        internal bool IsSetCacheSubnetGroupName()
        {
            return this._cacheSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of VPC subnet IDs for the cache subnet group.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}