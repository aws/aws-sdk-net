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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the DescribeCluster operation.
    /// </summary>
    public partial class DescribeClusterResponse : AmazonWebServiceResponse
    {
        private ClusterInfo _clusterInfo;

        /// <summary>
        /// Gets and sets the property ClusterInfo.             
        /// <para>
        /// The cluster information.
        /// </para>
        /// </summary>
        public ClusterInfo ClusterInfo
        {
            get { return this._clusterInfo; }
            set { this._clusterInfo = value; }
        }

        // Check to see if ClusterInfo property is set
        internal bool IsSetClusterInfo()
        {
            return this._clusterInfo != null;
        }

    }
}