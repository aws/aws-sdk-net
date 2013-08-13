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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Contains the output from the DescribeClusters action. </para>
    /// </summary>
    public class DescribeClustersResult
    {
        
        private string marker;
        private List<Cluster> clusters = new List<Cluster>();

        /// <summary>
        /// A marker at which to continue listing clusters in a new request. A marker is returned if there are more clusters to list than were returned
        /// in the response.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClustersResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of <a>Cluster</a> objects, where each object describes one cluster.
        ///  
        /// </summary>
        public List<Cluster> Clusters
        {
            get { return this.clusters; }
            set { this.clusters = value; }
        }
        /// <summary>
        /// Adds elements to the Clusters collection
        /// </summary>
        /// <param name="clusters">The values to add to the Clusters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClustersResult WithClusters(params Cluster[] clusters)
        {
            foreach (Cluster element in clusters)
            {
                this.clusters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Clusters collection
        /// </summary>
        /// <param name="clusters">The values to add to the Clusters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClustersResult WithClusters(IEnumerable<Cluster> clusters)
        {
            foreach (Cluster element in clusters)
            {
                this.clusters.Add(element);
            }

            return this;
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this.clusters.Count > 0;
        }
    }
}
