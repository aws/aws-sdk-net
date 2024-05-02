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
    /// Container for the parameters to the DeleteCacheSecurityGroup operation.
    /// Deletes a cache security group.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot delete a cache security group if it is associated with any clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteCacheSecurityGroupRequest : AmazonElastiCacheRequest
    {
        private string _cacheSecurityGroupName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteCacheSecurityGroupRequest() { }

        /// <summary>
        /// Instantiates DeleteCacheSecurityGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheSecurityGroupName">The name of the cache security group to delete. <note> You cannot delete the default security group. </note></param>
        public DeleteCacheSecurityGroupRequest(string cacheSecurityGroupName)
        {
            _cacheSecurityGroupName = cacheSecurityGroupName;
        }

        /// <summary>
        /// Gets and sets the property CacheSecurityGroupName. 
        /// <para>
        /// The name of the cache security group to delete.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot delete the default security group.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CacheSecurityGroupName
        {
            get { return this._cacheSecurityGroupName; }
            set { this._cacheSecurityGroupName = value; }
        }

        // Check to see if CacheSecurityGroupName property is set
        internal bool IsSetCacheSecurityGroupName()
        {
            return this._cacheSecurityGroupName != null;
        }

    }
}