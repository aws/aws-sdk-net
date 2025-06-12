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
    /// Represents the allowed node types you can use to modify your cluster or replication
    /// group.
    /// </summary>
    public partial class ListAllowedNodeTypeModificationsResponse : AmazonWebServiceResponse
    {
        private List<string> _scaleDownModifications = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _scaleUpModifications = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ScaleDownModifications. 
        /// <para>
        /// A string list, each element of which specifies a cache node type which you can use
        /// to scale your cluster or replication group. When scaling down a Valkey or Redis OSS
        /// cluster or replication group using ModifyCacheCluster or ModifyReplicationGroup, use
        /// a value from this list for the CacheNodeType parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ScaleDownModifications
        {
            get { return this._scaleDownModifications; }
            set { this._scaleDownModifications = value; }
        }

        // Check to see if ScaleDownModifications property is set
        internal bool IsSetScaleDownModifications()
        {
            return this._scaleDownModifications != null && (this._scaleDownModifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScaleUpModifications. 
        /// <para>
        /// A string list, each element of which specifies a cache node type which you can use
        /// to scale your cluster or replication group.
        /// </para>
        ///  
        /// <para>
        /// When scaling up a Valkey or Redis OSS cluster or replication group using <c>ModifyCacheCluster</c>
        /// or <c>ModifyReplicationGroup</c>, use a value from this list for the <c>CacheNodeType</c>
        /// parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ScaleUpModifications
        {
            get { return this._scaleUpModifications; }
            set { this._scaleUpModifications = value; }
        }

        // Check to see if ScaleUpModifications property is set
        internal bool IsSetScaleUpModifications()
        {
            return this._scaleUpModifications != null && (this._scaleUpModifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}