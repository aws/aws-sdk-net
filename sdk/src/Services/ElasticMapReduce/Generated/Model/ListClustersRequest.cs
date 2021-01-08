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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListClusters operation.
    /// Provides the status of all clusters visible to this AWS account. Allows you to filter
    /// the list of clusters based on certain criteria; for example, filtering by cluster
    /// creation date and time or by status. This call returns a maximum of 50 clusters per
    /// call, but returns a marker to track the paging of the cluster list across multiple
    /// ListClusters calls.
    /// </summary>
    public partial class ListClustersRequest : AmazonElasticMapReduceRequest
    {
        private List<string> _clusterStates = new List<string>();
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private string _marker;

        /// <summary>
        /// Gets and sets the property ClusterStates. 
        /// <para>
        /// The cluster state filters to apply when listing clusters.
        /// </para>
        /// </summary>
        public List<string> ClusterStates
        {
            get { return this._clusterStates; }
            set { this._clusterStates = value; }
        }

        // Check to see if ClusterStates property is set
        internal bool IsSetClusterStates()
        {
            return this._clusterStates != null && this._clusterStates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The creation date and time beginning value filter for listing clusters.
        /// </para>
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this._createdAfter.GetValueOrDefault(); }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// The creation date and time end value filter for listing clusters.
        /// </para>
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this._createdBefore.GetValueOrDefault(); }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
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