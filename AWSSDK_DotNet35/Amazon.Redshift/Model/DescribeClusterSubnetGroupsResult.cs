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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Contains the output from the DescribeClusterSubnetGroups action. </para>
    /// </summary>
    public partial class DescribeClusterSubnetGroupsResult : AmazonWebServiceResponse
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

        // Check to see if ClusterSubnetGroups property is set
        internal bool IsSetClusterSubnetGroups()
        {
            return this.clusterSubnetGroups.Count > 0;
        }
    }
}
