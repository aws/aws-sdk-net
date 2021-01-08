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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the ListClusters operation.
    /// </summary>
    public partial class ListClustersResponse : AmazonWebServiceResponse
    {
        private List<ClusterListEntry> _clusterListEntries = new List<ClusterListEntry>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ClusterListEntries. 
        /// <para>
        /// Each <code>ClusterListEntry</code> object contains a cluster's state, a cluster's
        /// ID, and other important status information.
        /// </para>
        /// </summary>
        public List<ClusterListEntry> ClusterListEntries
        {
            get { return this._clusterListEntries; }
            set { this._clusterListEntries = value; }
        }

        // Check to see if ClusterListEntries property is set
        internal bool IsSetClusterListEntries()
        {
            return this._clusterListEntries != null && this._clusterListEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// HTTP requests are stateless. If you use the automatically generated <code>NextToken</code>
        /// value in your next <code>ClusterListEntry</code> call, your list of returned clusters
        /// will start from this point in the array.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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