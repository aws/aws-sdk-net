/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Provides all of the details about a particular cache engine version.</para>
    /// </summary>
    public class CacheEngineVersion
    {
        
        private string engine;
        private string engineVersion;
        private string cacheParameterGroupFamily;
        private string cacheEngineDescription;
        private string cacheEngineVersionDescription;


        /// <summary>
        /// The name of the cache engine.
        ///  
        /// </summary>
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;
        }

        /// <summary>
        /// The version number of the cache engine.
        ///  
        /// </summary>
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }

        /// <summary>
        /// The name of the cache parameter group family associated with this cache engine.
        ///  
        /// </summary>
        public string CacheParameterGroupFamily
        {
            get { return this.cacheParameterGroupFamily; }
            set { this.cacheParameterGroupFamily = value; }
        }

        // Check to see if CacheParameterGroupFamily property is set
        internal bool IsSetCacheParameterGroupFamily()
        {
            return this.cacheParameterGroupFamily != null;
        }

        /// <summary>
        /// The description of the cache engine.
        ///  
        /// </summary>
        public string CacheEngineDescription
        {
            get { return this.cacheEngineDescription; }
            set { this.cacheEngineDescription = value; }
        }

        // Check to see if CacheEngineDescription property is set
        internal bool IsSetCacheEngineDescription()
        {
            return this.cacheEngineDescription != null;
        }

        /// <summary>
        /// The description of the cache engine version.
        ///  
        /// </summary>
        public string CacheEngineVersionDescription
        {
            get { return this.cacheEngineVersionDescription; }
            set { this.cacheEngineVersionDescription = value; }
        }

        // Check to see if CacheEngineVersionDescription property is set
        internal bool IsSetCacheEngineVersionDescription()
        {
            return this.cacheEngineVersionDescription != null;
        }
    }
}
