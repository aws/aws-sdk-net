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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// This is the response object from the ListWorkflowRuns operation.
    /// </summary>
    public partial class ListWorkflowRunsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WorkflowRunSummary> _workflowRunSummaries = AWSConfigs.InitializeCollections ? new List<WorkflowRunSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for retrieving the next page of results, if available.
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
        /// Gets and sets the property WorkflowRunSummaries. 
        /// <para>
        /// A list of summary information for workflow runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WorkflowRunSummary> WorkflowRunSummaries
        {
            get { return this._workflowRunSummaries; }
            set { this._workflowRunSummaries = value; }
        }

        // Check to see if WorkflowRunSummaries property is set
        internal bool IsSetWorkflowRunSummaries()
        {
            return this._workflowRunSummaries != null && (this._workflowRunSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}