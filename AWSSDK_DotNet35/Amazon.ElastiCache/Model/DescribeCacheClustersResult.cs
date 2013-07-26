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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para> Contains one or more Cache Clusters. </para>
    /// </summary>
    public partial class DescribeCacheClustersResult : AmazonWebServiceResponse
    {
        
        private string marker;
        private List<CacheCluster> cacheClusters = new List<CacheCluster>();

        /// <summary>
        /// The marker obtained from a previous operation response.
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
        /// A list of CacheClusters.
        ///  
        /// </summary>
        public List<CacheCluster> CacheClusters
        {
            get { return this.cacheClusters; }
            set { this.cacheClusters = value; }
        }

        // Check to see if CacheClusters property is set
        internal bool IsSetCacheClusters()
        {
            return this.cacheClusters.Count > 0;
        }
    }
}
