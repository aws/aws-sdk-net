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
    /// <para> Returns information about all provisioned Cache Clusters if no Cache Cluster identifier is specified, or about a specific Cache
    /// Cluster if a Cache Cluster identifier is supplied. </para> <para> Cluster information will be returned by default. An optional
    /// <i>ShowDetails</i> flag can be used to retrieve detailed information about the Cache Nodes associated with the Cache Cluster. Details
    /// include the DNS address and port for the Cache Node endpoint. </para> <para> If the cluster is in the CREATING state, only cluster level
    /// information will be displayed until all of the nodes are successfully provisioned. </para> <para> If the cluster is in the DELETING state,
    /// only cluster level information will be displayed. </para> <para> While adding Cache Nodes, node endpoint information and creation time for
    /// the additional nodes will not be displayed until they are completely provisioned. The cluster lifecycle tells the customer when new nodes
    /// are AVAILABLE. </para> <para> While removing existing Cache Nodes from an cluster, endpoint information for the removed nodes will not be
    /// displayed. </para> <para>DescribeCacheClusters supports pagination.</para>
    /// </summary>
    public partial class DescribeCacheClustersRequest : AmazonWebServiceRequest
    {
        private string cacheClusterId;
        private int? maxRecords;
        private string marker;
        private bool? showCacheNodeInfo;

        /// <summary>
        /// The user-supplied cluster identifier. If this parameter is specified, only information about that specific Cache Cluster is returned. This
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
        /// The maximum number of records to include in the response. If more records exist than the specified <i>MaxRecords</i> value, a marker is
        /// included in the response so that the remaining results may be retrieved. Default: 100 Constraints: minimum 20, maximum 100
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
        /// An optional marker provided in the previous DescribeCacheClusters request. If this parameter is specified, the response includes only
        /// records beyond the marker, up to the value specified by <i>MaxRecords</i>.
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
        /// An optional flag that can be included in the DescribeCacheCluster request to retrieve Cache Nodes information.
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
    
