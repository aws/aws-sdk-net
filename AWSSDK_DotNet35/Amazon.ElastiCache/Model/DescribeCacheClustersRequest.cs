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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCacheClusters operation.
    /// <para>The <i>DescribeCacheClusters</i> operation returns information about all provisioned cache clusters if no cache cluster identifier is
    /// specified, or about a specific cache cluster if a cache cluster identifier is supplied.</para> <para>By default, abbreviated information
    /// about the cache clusters(s) will be returned. You can use the optional <i>ShowDetails</i> flag to retrieve detailed information about the
    /// cache nodes associated with the cache clusters. These details include the DNS address and port for the cache node endpoint.</para> <para>If
    /// the cluster is in the CREATING state, only cluster level information will be displayed until all of the nodes are successfully
    /// provisioned.</para> <para>If the cluster is in the DELETING state, only cluster level information will be displayed.</para> <para>If cache
    /// nodes are currently being added to the cache cluster, node endpoint information and creation time for the additional nodes will not be
    /// displayed until they are completely provisioned. When the cache cluster state is <i>available</i> , the cluster is ready for use.</para>
    /// <para>If cache nodes are currently being removed from the cache cluster, no endpoint information for the removed nodes is displayed.</para>
    /// </summary>
    public partial class DescribeCacheClustersRequest : AmazonElastiCacheRequest
    {
        private string cacheClusterId;
        private int? maxRecords;
        private string marker;
        private bool? showCacheNodeInfo;


        /// <summary>
        /// The user-supplied cluster identifier. If this parameter is specified, only information about that specific cache cluster is returned. This
        /// parameter isn't case sensitive.
        ///  
        /// </summary>
        public string CacheClusterId
        {
            get { return this.cacheClusterId; }
            set { this.cacheClusterId = value; }
        }

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this.cacheClusterId != null;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more records exist than the specified <c>MaxRecords</c> value, a marker is
        /// included in the response so that the remaining results can be retrieved. Default: 100Constraints: minimum 20; maximum 100.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional marker returned from a prior request. Use this marker for pagination of results from this operation. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified by <i>MaxRecords</i>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// An optional flag that can be included in the DescribeCacheCluster request to retrieve information about the individual cache nodes.
        ///  
        /// </summary>
        public bool ShowCacheNodeInfo
        {
            get { return this.showCacheNodeInfo ?? default(bool); }
            set { this.showCacheNodeInfo = value; }
        }

        // Check to see if ShowCacheNodeInfo property is set
        internal bool IsSetShowCacheNodeInfo()
        {
            return this.showCacheNodeInfo.HasValue;
        }

    }
}
    
