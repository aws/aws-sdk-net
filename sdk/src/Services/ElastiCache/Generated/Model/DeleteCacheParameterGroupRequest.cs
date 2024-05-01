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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
    /// Container for the parameters to the DeleteCacheParameterGroup operation.
    /// Deletes the specified cache parameter group. You cannot delete a cache parameter group
    /// if it is associated with any cache clusters. You cannot delete the default cache parameter
    /// groups in your account.
    /// </summary>
    public partial class DeleteCacheParameterGroupRequest : AmazonElastiCacheRequest
    {
        private string _cacheParameterGroupName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteCacheParameterGroupRequest() { }

        /// <summary>
        /// Instantiates DeleteCacheParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheParameterGroupName">The name of the cache parameter group to delete. <note> The specified cache security group must not be associated with any clusters. </note></param>
        public DeleteCacheParameterGroupRequest(string cacheParameterGroupName)
        {
            _cacheParameterGroupName = cacheParameterGroupName;
        }

        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to delete.
        /// </para>
        ///  <note> 
        /// <para>
        /// The specified cache security group must not be associated with any clusters.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}