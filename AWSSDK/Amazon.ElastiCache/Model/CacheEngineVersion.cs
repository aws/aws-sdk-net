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

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">The value to set for the Engine property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheEngineVersion WithEngine(string engine)
        {
            this.engine = engine;
            return this;
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

        /// <summary>
        /// Sets the EngineVersion property
        /// </summary>
        /// <param name="engineVersion">The value to set for the EngineVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheEngineVersion WithEngineVersion(string engineVersion)
        {
            this.engineVersion = engineVersion;
            return this;
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

        /// <summary>
        /// Sets the CacheParameterGroupFamily property
        /// </summary>
        /// <param name="cacheParameterGroupFamily">The value to set for the CacheParameterGroupFamily property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheEngineVersion WithCacheParameterGroupFamily(string cacheParameterGroupFamily)
        {
            this.cacheParameterGroupFamily = cacheParameterGroupFamily;
            return this;
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

        /// <summary>
        /// Sets the CacheEngineDescription property
        /// </summary>
        /// <param name="cacheEngineDescription">The value to set for the CacheEngineDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheEngineVersion WithCacheEngineDescription(string cacheEngineDescription)
        {
            this.cacheEngineDescription = cacheEngineDescription;
            return this;
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

        /// <summary>
        /// Sets the CacheEngineVersionDescription property
        /// </summary>
        /// <param name="cacheEngineVersionDescription">The value to set for the CacheEngineVersionDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheEngineVersion WithCacheEngineVersionDescription(string cacheEngineVersionDescription)
        {
            this.cacheEngineVersionDescription = cacheEngineVersionDescription;
            return this;
        }
            

        // Check to see if CacheEngineVersionDescription property is set
        internal bool IsSetCacheEngineVersionDescription()
        {
            return this.cacheEngineVersionDescription != null;
        }
    }
}
