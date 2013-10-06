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
    /// <para> Contains the output from the DescribeClusterVersions action. </para>
    /// </summary>
    public class DescribeClusterVersionsResult
    {
        
        private string marker;
        private List<ClusterVersion> clusterVersions = new List<ClusterVersion>();

        /// <summary>
        /// The identifier returned to allow retrieval of paginated results.
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
        public DescribeClusterVersionsResult WithMarker(string marker)
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
        /// A list of <c>Version</c> elements.
        ///  
        /// </summary>
        public List<ClusterVersion> ClusterVersions
        {
            get { return this.clusterVersions; }
            set { this.clusterVersions = value; }
        }
        /// <summary>
        /// Adds elements to the ClusterVersions collection
        /// </summary>
        /// <param name="clusterVersions">The values to add to the ClusterVersions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterVersionsResult WithClusterVersions(params ClusterVersion[] clusterVersions)
        {
            foreach (ClusterVersion element in clusterVersions)
            {
                this.clusterVersions.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ClusterVersions collection
        /// </summary>
        /// <param name="clusterVersions">The values to add to the ClusterVersions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterVersionsResult WithClusterVersions(IEnumerable<ClusterVersion> clusterVersions)
        {
            foreach (ClusterVersion element in clusterVersions)
            {
                this.clusterVersions.Add(element);
            }

            return this;
        }

        // Check to see if ClusterVersions property is set
        internal bool IsSetClusterVersions()
        {
            return this.clusterVersions.Count > 0;
        }
    }
}
