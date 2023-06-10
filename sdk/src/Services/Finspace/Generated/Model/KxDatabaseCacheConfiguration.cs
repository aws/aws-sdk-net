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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The structure of database cache configuration that is used for mapping database paths
    /// to cache types in clusters.
    /// </summary>
    public partial class KxDatabaseCacheConfiguration
    {
        private string _cacheType;
        private List<string> _dbPaths = new List<string>();

        /// <summary>
        /// Gets and sets the property CacheType. 
        /// <para>
        /// The type of disk cache. This parameter is used to map the database path to cache storage.
        /// The valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CACHE_1000 – This type provides at least 1000 MB/s disk access throughput. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=10)]
        public string CacheType
        {
            get { return this._cacheType; }
            set { this._cacheType = value; }
        }

        // Check to see if CacheType property is set
        internal bool IsSetCacheType()
        {
            return this._cacheType != null;
        }

        /// <summary>
        /// Gets and sets the property DbPaths. 
        /// <para>
        /// Specifies the portions of database that will be loaded into the cache for access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DbPaths
        {
            get { return this._dbPaths; }
            set { this._dbPaths = value; }
        }

        // Check to see if DbPaths property is set
        internal bool IsSetDbPaths()
        {
            return this._dbPaths != null && this._dbPaths.Count > 0; 
        }

    }
}