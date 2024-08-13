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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The configuration for read only disk cache associated with a cluster.
    /// </summary>
    public partial class KxCacheStorageConfiguration
    {
        private int? _size;
        private string _type;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of cache in Gigabytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of cache storage. The valid values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CACHE_1000 – This type provides at least 1000 MB/s disk access throughput. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CACHE_250 – This type provides at least 250 MB/s disk access throughput. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CACHE_12 – This type provides at least 12 MB/s disk access throughput. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For cache type <c>CACHE_1000</c> and <c>CACHE_250</c> you can select cache size as
        /// 1200 GB or increments of 2400 GB. For cache type <c>CACHE_12</c> you can select the
        /// cache size in increments of 6000 GB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=10)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}