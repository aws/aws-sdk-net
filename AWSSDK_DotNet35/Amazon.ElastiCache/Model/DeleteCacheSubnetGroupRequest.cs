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
 * Do not modify this file. This file is generated from the elasticache-2014-09-30.normal.json service model.
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
    /// Container for the parameters to the DeleteCacheSubnetGroup operation.
    /// The <i>DeleteCacheSubnetGroup</i> operation deletes a cache subnet group.
    /// </summary>
    public partial class DeleteCacheSubnetGroupRequest : AmazonElastiCacheRequest
    {
        private string _cacheSubnetGroupName;

        /// <summary>
        /// Gets and sets the property CacheSubnetGroupName. 
        /// <para>
        /// The name of the cache subnet group to delete.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters or hyphens.
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

    }
}