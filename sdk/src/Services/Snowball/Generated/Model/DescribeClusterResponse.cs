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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the DescribeCluster operation.
    /// </summary>
    public partial class DescribeClusterResponse : AmazonWebServiceResponse
    {
        private ClusterMetadata _clusterMetadata;

        /// <summary>
        /// Gets and sets the property ClusterMetadata. 
        /// <para>
        /// Information about a specific cluster, including shipping information, cluster status,
        /// and other important metadata.
        /// </para>
        /// </summary>
        public ClusterMetadata ClusterMetadata
        {
            get { return this._clusterMetadata; }
            set { this._clusterMetadata = value; }
        }

        // Check to see if ClusterMetadata property is set
        internal bool IsSetClusterMetadata()
        {
            return this._clusterMetadata != null;
        }

    }
}