/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// This is the response object from the ListClusters operation.
    /// </summary>
    public partial class ListClustersResponse : AmazonWebServiceResponse
    {
        private List<string> _clusterArns = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ClusterArns. 
        /// <para>
        /// The list of full Amazon Resource Name (ARN) entries for each cluster associated with
        /// your account.
        /// </para>
        /// </summary>
        public List<string> ClusterArns
        {
            get { return this._clusterArns; }
            set { this._clusterArns = value; }
        }

        // Check to see if ClusterArns property is set
        internal bool IsSetClusterArns()
        {
            return this._clusterArns != null && this._clusterArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListClusters</code>
        /// request. When the results of a <code>ListClusters</code> request exceed <code>maxResults</code>,
        /// this value can be used to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
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