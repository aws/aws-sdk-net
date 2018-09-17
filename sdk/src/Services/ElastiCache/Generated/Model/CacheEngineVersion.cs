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
    /// Provides all of the details about a particular cache engine version.
    /// </summary>
    public partial class CacheEngineVersion
    {
        private string _cacheEngineDescription;
        private string _cacheEngineVersionDescription;
        private string _cacheParameterGroupFamily;
        private string _engine;
        private string _engineVersion;

        /// <summary>
        /// Gets and sets the property CacheEngineDescription. 
        /// <para>
        /// The description of the cache engine.
        /// </para>
        /// </summary>
        public string CacheEngineDescription
        {
            get { return this._cacheEngineDescription; }
            set { this._cacheEngineDescription = value; }
        }

        // Check to see if CacheEngineDescription property is set
        internal bool IsSetCacheEngineDescription()
        {
            return this._cacheEngineDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CacheEngineVersionDescription. 
        /// <para>
        /// The description of the cache engine version.
        /// </para>
        /// </summary>
        public string CacheEngineVersionDescription
        {
            get { return this._cacheEngineVersionDescription; }
            set { this._cacheEngineVersionDescription = value; }
        }

        // Check to see if CacheEngineVersionDescription property is set
        internal bool IsSetCacheEngineVersionDescription()
        {
            return this._cacheEngineVersionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CacheParameterGroupFamily. 
        /// <para>
        /// The name of the cache parameter group family associated with this cache engine.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <code>memcached1.4</code> | <code>redis2.6</code> | <code>redis2.8</code>
        /// | <code>redis3.2</code> | <code>redis4.0</code> 
        /// </para>
        /// </summary>
        public string CacheParameterGroupFamily
        {
            get { return this._cacheParameterGroupFamily; }
            set { this._cacheParameterGroupFamily = value; }
        }

        // Check to see if CacheParameterGroupFamily property is set
        internal bool IsSetCacheParameterGroupFamily()
        {
            return this._cacheParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the cache engine.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

    }
}