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
    /// Represents the output of a <i>CreateCacheParameterGroup</i> operation.
    /// </summary>
    public partial class CacheParameterGroup
    {
        private string _cacheParameterGroupFamily;
        private string _cacheParameterGroupName;
        private string _description;

        /// <summary>
        /// Gets and sets the property CacheParameterGroupFamily. 
        /// <para>
        /// The name of the cache parameter group family that this cache parameter group is compatible
        /// with.
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
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group.
        /// </para>
        /// </summary>
        public string CacheParameterGroupName
        {
            get { return this._cacheParameterGroupName; }
            set { this._cacheParameterGroupName = value; }
        }

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this._cacheParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for this cache parameter group.
        /// </para>
        /// </summary>
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

    }
}