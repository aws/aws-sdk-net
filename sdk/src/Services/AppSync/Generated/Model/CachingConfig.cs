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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The caching configuration for a resolver that has caching activated.
    /// </summary>
    public partial class CachingConfig
    {
        private List<string> _cachingKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _ttl;

        /// <summary>
        /// Gets and sets the property CachingKeys. 
        /// <para>
        /// The caching keys for a resolver that has caching activated.
        /// </para>
        ///  
        /// <para>
        /// Valid values are entries from the <c>$context.arguments</c>, <c>$context.source</c>,
        /// and <c>$context.identity</c> maps.
        /// </para>
        /// </summary>
        public List<string> CachingKeys
        {
            get { return this._cachingKeys; }
            set { this._cachingKeys = value; }
        }

        // Check to see if CachingKeys property is set
        internal bool IsSetCachingKeys()
        {
            return this._cachingKeys != null && (this._cachingKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// The TTL in seconds for a resolver that has caching activated.
        /// </para>
        ///  
        /// <para>
        /// Valid values are 1–3,600 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long Ttl
        {
            get { return this._ttl.GetValueOrDefault(); }
            set { this._ttl = value; }
        }

        // Check to see if Ttl property is set
        internal bool IsSetTtl()
        {
            return this._ttl.HasValue; 
        }

    }
}