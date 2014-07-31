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
    /// Container for the parameters to the CreateCacheParameterGroup operation.
    /// The <i>CreateCacheParameterGroup</i> operation creates a new cache parameter group.
    /// A cache parameter group is a collection of parameters that you apply to all of the
    /// nodes in a cache cluster.
    /// </summary>
    public partial class CreateCacheParameterGroupRequest : AmazonElastiCacheRequest
    {
        private string _cacheParameterGroupFamily;
        private string _cacheParameterGroupName;
        private string _description;


        /// <summary>
        /// Gets and sets the property CacheParameterGroupFamily. 
        /// <para>
        /// The name of the cache parameter group family the cache parameter group can be used
        /// with.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <code>memcached1.4</code> | <code>redis2.6</code> | <code>redis2.8</code>
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
        /// A user-specified name for the cache parameter group.
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
        /// A user-specified description for the cache parameter group.
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