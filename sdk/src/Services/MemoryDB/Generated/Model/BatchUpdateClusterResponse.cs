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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateCluster operation.
    /// </summary>
    public partial class BatchUpdateClusterResponse : AmazonWebServiceResponse
    {
        private List<Cluster> _processedClusters = new List<Cluster>();
        private List<UnprocessedCluster> _unprocessedClusters = new List<UnprocessedCluster>();

        /// <summary>
        /// Gets and sets the property ProcessedClusters. 
        /// <para>
        /// The list of clusters that have been updated.
        /// </para>
        /// </summary>
        public List<Cluster> ProcessedClusters
        {
            get { return this._processedClusters; }
            set { this._processedClusters = value; }
        }

        // Check to see if ProcessedClusters property is set
        internal bool IsSetProcessedClusters()
        {
            return this._processedClusters != null && this._processedClusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedClusters. 
        /// <para>
        /// The list of clusters where updates have not been applied.
        /// </para>
        /// </summary>
        public List<UnprocessedCluster> UnprocessedClusters
        {
            get { return this._unprocessedClusters; }
            set { this._unprocessedClusters = value; }
        }

        // Check to see if UnprocessedClusters property is set
        internal bool IsSetUnprocessedClusters()
        {
            return this._unprocessedClusters != null && this._unprocessedClusters.Count > 0; 
        }

    }
}