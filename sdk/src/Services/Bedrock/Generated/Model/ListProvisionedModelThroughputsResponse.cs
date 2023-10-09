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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the ListProvisionedModelThroughputs operation.
    /// </summary>
    public partial class ListProvisionedModelThroughputsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProvisionedModelSummary> _provisionedModelSummaries = new List<ProvisionedModelSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Continuation token for the next request to list the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property ProvisionedModelSummaries. 
        /// <para>
        /// List of summaries, one for each provisioned throughput in the response.
        /// </para>
        /// </summary>
        public List<ProvisionedModelSummary> ProvisionedModelSummaries
        {
            get { return this._provisionedModelSummaries; }
            set { this._provisionedModelSummaries = value; }
        }

        // Check to see if ProvisionedModelSummaries property is set
        internal bool IsSetProvisionedModelSummaries()
        {
            return this._provisionedModelSummaries != null && this._provisionedModelSummaries.Count > 0; 
        }

    }
}