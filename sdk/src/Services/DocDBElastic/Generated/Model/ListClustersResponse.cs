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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
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
namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// This is the response object from the ListClusters operation.
    /// </summary>
    public partial class ListClustersResponse : AmazonWebServiceResponse
    {
        private List<ClusterInList> _clusters = AWSConfigs.InitializeCollections ? new List<ClusterInList>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        /// A list of Amazon DocumentDB elastic clusters.
        /// </para>
        /// </summary>
        public List<ClusterInList> Clusters
        {
            get { return this._clusters; }
            set { this._clusters = value; }
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this._clusters != null && (this._clusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token provided by a previous request. If this parameter is specified,
        /// the response includes only records beyond this token, up to the value specified by
        /// <c>max-results</c>.
        /// </para>
        ///  
        /// <para>
        /// If there is no more data in the responce, the <c>nextToken</c> will not be returned.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}