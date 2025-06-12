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
    /// Represents the output of a <c>DescribeCacheSubnetGroups</c> operation.
    /// </summary>
    public partial class DescribeCacheSubnetGroupsResponse : AmazonWebServiceResponse
    {
        private List<CacheSubnetGroup> _cacheSubnetGroups = AWSConfigs.InitializeCollections ? new List<CacheSubnetGroup>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property CacheSubnetGroups. 
        /// <para>
        /// A list of cache subnet groups. Each element in the list contains detailed information
        /// about one group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheSubnetGroup> CacheSubnetGroups
        {
            get { return this._cacheSubnetGroups; }
            set { this._cacheSubnetGroups = value; }
        }

        // Check to see if CacheSubnetGroups property is set
        internal bool IsSetCacheSubnetGroups()
        {
            return this._cacheSubnetGroups != null && (this._cacheSubnetGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Provides an identifier to allow retrieval of paginated results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}