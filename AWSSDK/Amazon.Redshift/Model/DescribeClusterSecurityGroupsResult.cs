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
    /// <para> Contains the output from the DescribeClusterSecurityGroups action. </para>
    /// </summary>
    public class DescribeClusterSecurityGroupsResult
    {
        
        private string marker;
        private List<ClusterSecurityGroup> clusterSecurityGroups = new List<ClusterSecurityGroup>();

        /// <summary>
        /// A marker at which to continue listing cluster security groups in a new request. The response returns a marker if there are more security
        /// groups to list than could be returned in the response.
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
        public DescribeClusterSecurityGroupsResult WithMarker(string marker)
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
        /// A list of <a>ClusterSecurityGroup</a> instances.
        ///  
        /// </summary>
        public List<ClusterSecurityGroup> ClusterSecurityGroups
        {
            get { return this.clusterSecurityGroups; }
            set { this.clusterSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the ClusterSecurityGroups collection
        /// </summary>
        /// <param name="clusterSecurityGroups">The values to add to the ClusterSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterSecurityGroupsResult WithClusterSecurityGroups(params ClusterSecurityGroup[] clusterSecurityGroups)
        {
            foreach (ClusterSecurityGroup element in clusterSecurityGroups)
            {
                this.clusterSecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ClusterSecurityGroups collection
        /// </summary>
        /// <param name="clusterSecurityGroups">The values to add to the ClusterSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterSecurityGroupsResult WithClusterSecurityGroups(IEnumerable<ClusterSecurityGroup> clusterSecurityGroups)
        {
            foreach (ClusterSecurityGroup element in clusterSecurityGroups)
            {
                this.clusterSecurityGroups.Add(element);
            }

            return this;
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this.clusterSecurityGroups.Count > 0;
        }
    }
}
