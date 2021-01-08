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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeployments operation.
    /// Retrieves a paginated list of deployments.
    /// </summary>
    public partial class ListDeploymentsRequest : AmazonGreengrassV2Request
    {
        private DeploymentHistoryFilter _historyFilter;
        private int? _maxResults;
        private string _nextToken;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property HistoryFilter. 
        /// <para>
        /// The filter for the list of deployments. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALL</code> – The list includes all deployments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LATEST_ONLY</code> – The list includes only the latest revision of each deployment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>LATEST_ONLY</code> 
        /// </para>
        /// </summary>
        public DeploymentHistoryFilter HistoryFilter
        {
            get { return this._historyFilter; }
            set { this._historyFilter = value; }
        }

        // Check to see if HistoryFilter property is set
        internal bool IsSetHistoryFilter()
        {
            return this._historyFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned per paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token to be used for the next set of paginated results.
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

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the target AWS IoT thing or thing group.
        /// </para>
        /// </summary>
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}