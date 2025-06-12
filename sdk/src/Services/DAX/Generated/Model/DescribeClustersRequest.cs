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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
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
namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusters operation.
    /// Returns information about all provisioned DAX clusters if no cluster identifier is
    /// specified, or about a specific DAX cluster if a cluster identifier is supplied.
    /// 
    ///  
    /// <para>
    /// If the cluster is in the CREATING state, only cluster level information will be displayed
    /// until all of the nodes are successfully provisioned.
    /// </para>
    ///  
    /// <para>
    /// If the cluster is in the DELETING state, only cluster level information will be displayed.
    /// </para>
    ///  
    /// <para>
    /// If nodes are currently being added to the DAX cluster, node endpoint information and
    /// creation time for the additional nodes will not be displayed until they are completely
    /// provisioned. When the DAX cluster state is <i>available</i>, the cluster is ready
    /// for use.
    /// </para>
    ///  
    /// <para>
    /// If nodes are currently being removed from the DAX cluster, no endpoint information
    /// for the removed nodes is displayed.
    /// </para>
    /// </summary>
    public partial class DescribeClustersRequest : AmazonDAXRequest
    {
        private List<string> _clusterNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ClusterNames. 
        /// <para>
        /// The names of the DAX clusters being described.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClusterNames
        {
            get { return this._clusterNames; }
            set { this._clusterNames = value; }
        }

        // Check to see if ClusterNames property is set
        internal bool IsSetClusterNames()
        {
            return this._clusterNames != null && (this._clusterNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response. If more results exist than
        /// the specified <c>MaxResults</c> value, a token is included in the response so that
        /// the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// The value for <c>MaxResults</c> must be between 20 and 100.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional token returned from a prior request. Use this token for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// results beyond the token, up to the value specified by <c>MaxResults</c>.
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