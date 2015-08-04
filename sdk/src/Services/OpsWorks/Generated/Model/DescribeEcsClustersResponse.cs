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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeEcsClusters</code> request.
    /// </summary>
    public partial class DescribeEcsClustersResponse : AmazonWebServiceResponse
    {
        private List<EcsCluster> _ecsClusters = new List<EcsCluster>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EcsClusters. 
        /// <para>
        /// A list of <code>EcsCluster</code> objects containing the cluster descriptions.
        /// </para>
        /// </summary>
        public List<EcsCluster> EcsClusters
        {
            get { return this._ecsClusters; }
            set { this._ecsClusters = value; }
        }

        // Check to see if EcsClusters property is set
        internal bool IsSetEcsClusters()
        {
            return this._ecsClusters != null && this._ecsClusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a paginated request does not return all of the remaining results, this parameter
        /// is set to a token that you can assign to the request object's <code>NextToken</code>
        /// parameter to retrieve the next set of results. If the previous paginated request returned
        /// all of the remaining results, this parameter is set to <code>null</code>.
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