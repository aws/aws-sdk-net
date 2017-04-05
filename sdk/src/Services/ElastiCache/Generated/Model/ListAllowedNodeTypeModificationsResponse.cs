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
    /// Represents the allowed node types you can use to modify your cache cluster or replication
    /// group.
    /// </summary>
    public partial class ListAllowedNodeTypeModificationsResponse : AmazonWebServiceResponse
    {
        private List<string> _scaleUpModifications = new List<string>();

        /// <summary>
        /// Gets and sets the property ScaleUpModifications. 
        /// <para>
        /// A string list, each element of which specifies a cache node type which you can use
        /// to scale your cache cluster or replication group.
        /// </para>
        ///  
        /// <para>
        /// When scaling up a Redis cluster or replication group using <code>ModifyCacheCluster</code>
        /// or <code>ModifyReplicationGroup</code>, use a value from this list for the <code>CacheNodeType</code>
        /// parameter.
        /// </para>
        /// </summary>
        public List<string> ScaleUpModifications
        {
            get { return this._scaleUpModifications; }
            set { this._scaleUpModifications = value; }
        }

        // Check to see if ScaleUpModifications property is set
        internal bool IsSetScaleUpModifications()
        {
            return this._scaleUpModifications != null && this._scaleUpModifications.Count > 0; 
        }

    }
}