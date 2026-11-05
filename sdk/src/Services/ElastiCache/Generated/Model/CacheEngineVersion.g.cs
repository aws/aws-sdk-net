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
    /// Provides all of the details about a particular cache engine version.
    /// </summary>
    public partial class CacheEngineVersion
    {
        /// <summary>
        /// Gets and sets the property CacheEngineDescription. 
        /// <para>
        /// The description of the cache engine.
        /// </para>
        /// </summary>
        public string CacheEngineDescription { get; set; }

        /// <summary>
        /// Checks to see if the CacheEngineDescription property is set.
        /// </summary>
        internal bool IsSetCacheEngineDescription() => this.CacheEngineDescription != null;

        /// <summary>
        /// Gets and sets the property CacheEngineVersionDescription. 
        /// <para>
        /// The description of the cache engine version.
        /// </para>
        /// </summary>
        public string CacheEngineVersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the CacheEngineVersionDescription property is set.
        /// </summary>
        internal bool IsSetCacheEngineVersionDescription() => this.CacheEngineVersionDescription != null;

        /// <summary>
        /// Gets and sets the property CacheParameterGroupFamily. 
        /// <para>
        /// The name of the cache parameter group family associated with this cache engine.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <c>memcached1.4</c> | <c>memcached1.5</c> | <c>memcached1.6</c>
        /// | <c>redis2.6</c> | <c>redis2.8</c> | <c>redis3.2</c> | <c>redis4.0</c> | <c>redis5.0</c>
        /// | <c>redis6.x</c> | <c>redis7</c> 
        /// </para>
        /// </summary>
        public string CacheParameterGroupFamily { get; set; }

        /// <summary>
        /// Checks to see if the CacheParameterGroupFamily property is set.
        /// </summary>
        internal bool IsSetCacheParameterGroupFamily() => this.CacheParameterGroupFamily != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the cache engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;
    }
}
