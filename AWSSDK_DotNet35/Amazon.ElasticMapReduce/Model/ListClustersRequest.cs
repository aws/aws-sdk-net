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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListClusters operation.
    /// <para>Provides the status of all clusters visible to this AWS account. Allows you to filter the list of clusters based on certain criteria;
    /// for example, filtering by cluster creation date and time or by status. This call returns a maximum of 50 clusters per call, but returns a
    /// marker to track the paging of the cluster list across multiple ListClusters calls. </para>
    /// </summary>
    public partial class ListClustersRequest : AmazonElasticMapReduceRequest
    {
        private DateTime? createdAfter;
        private DateTime? createdBefore;
        private List<string> clusterStates = new List<string>();
        private string marker;


        /// <summary>
        /// The creation date and time beginning value filter for listing clusters.
        ///  
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this.createdAfter ?? default(DateTime); }
            set { this.createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this.createdAfter.HasValue;
        }

        /// <summary>
        /// The creation date and time end value filter for listing clusters.
        ///  
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this.createdBefore ?? default(DateTime); }
            set { this.createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this.createdBefore.HasValue;
        }

        /// <summary>
        /// The cluster state filters to apply when listing clusters.
        ///  
        /// </summary>
        public List<string> ClusterStates
        {
            get { return this.clusterStates; }
            set { this.clusterStates = value; }
        }

        // Check to see if ClusterStates property is set
        internal bool IsSetClusterStates()
        {
            return this.clusterStates.Count > 0;
        }

        /// <summary>
        /// The pagination token is a random string indicating whether there are more results to fetch. Provide the pagination token from earlier API
        /// calls to retrieve the next page of results. When the value is null, all results have been returned.
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

    }
}
    
