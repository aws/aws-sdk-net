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
    /// <para> Contains the output from the DescribeClusterSubnetGroups action. </para>
    /// </summary>
    public class DescribeClusterSubnetGroupsResult
    {
        
        private string marker;
        private List<ClusterSubnetGroup> clusterSubnetGroups = new List<ClusterSubnetGroup>();

        /// <summary>
        /// A marker at which to continue listing cluster subnet groups in a new request. A marker is returned if there are more cluster subnet groups
        /// to list than were returned in the response.
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
        public DescribeClusterSubnetGroupsResult WithMarker(string marker)
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
        /// A list of <a>ClusterSubnetGroup</a> instances.
        ///  
        /// </summary>
        public List<ClusterSubnetGroup> ClusterSubnetGroups
        {
            get { return this.clusterSubnetGroups; }
            set { this.clusterSubnetGroups = value; }
        }
        /// <summary>
        /// Adds elements to the ClusterSubnetGroups collection
        /// </summary>
        /// <param name="clusterSubnetGroups">The values to add to the ClusterSubnetGroups collection </param>
        /// <returns>this instance</returns>
        public DescribeClusterSubnetGroupsResult WithClusterSubnetGroups(params ClusterSubnetGroup[] clusterSubnetGroups)
        {
            foreach (ClusterSubnetGroup element in clusterSubnetGroups)
            {
                this.clusterSubnetGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ClusterSubnetGroups collection
        /// </summary>
        /// <param name="clusterSubnetGroups">The values to add to the ClusterSubnetGroups collection </param>
        /// <returns>this instance</returns>
        public DescribeClusterSubnetGroupsResult WithClusterSubnetGroups(IEnumerable<ClusterSubnetGroup> clusterSubnetGroups)
        {
            foreach (ClusterSubnetGroup element in clusterSubnetGroups)
            {
                this.clusterSubnetGroups.Add(element);
            }

            return this;
        }

        // Check to see if ClusterSubnetGroups property is set
        internal bool IsSetClusterSubnetGroups()
        {
            return this.clusterSubnetGroups.Count > 0;
        }
    }
}
