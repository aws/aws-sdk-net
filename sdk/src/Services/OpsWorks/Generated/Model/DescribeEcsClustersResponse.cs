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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <c>DescribeEcsClusters</c> request.
    /// </summary>
    public partial class DescribeEcsClustersResponse : AmazonWebServiceResponse
    {
        private List<EcsCluster> _ecsClusters = AWSConfigs.InitializeCollections ? new List<EcsCluster>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EcsClusters. 
        /// <para>
        /// A list of <c>EcsCluster</c> objects containing the cluster descriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EcsCluster> EcsClusters
        {
            get { return this._ecsClusters; }
            set { this._ecsClusters = value; }
        }

        // Check to see if EcsClusters property is set
        internal bool IsSetEcsClusters()
        {
            return this._ecsClusters != null && (this._ecsClusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a paginated request does not return all of the remaining results, this parameter
        /// is set to a token that you can assign to the request object's <c>NextToken</c> parameter
        /// to retrieve the next set of results. If the previous paginated request returned all
        /// of the remaining results, this parameter is set to <c>null</c>.
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