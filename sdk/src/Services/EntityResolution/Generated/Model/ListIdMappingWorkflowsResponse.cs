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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// This is the response object from the ListIdMappingWorkflows operation.
    /// </summary>
    public partial class ListIdMappingWorkflowsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<IdMappingWorkflowSummary> _workflowSummaries = AWSConfigs.InitializeCollections ? new List<IdMappingWorkflowSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from the previous API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property WorkflowSummaries. 
        /// <para>
        /// A list of <c>IdMappingWorkflowSummary</c> objects.
        /// </para>
        /// </summary>
        public List<IdMappingWorkflowSummary> WorkflowSummaries
        {
            get { return this._workflowSummaries; }
            set { this._workflowSummaries = value; }
        }

        // Check to see if WorkflowSummaries property is set
        internal bool IsSetWorkflowSummaries()
        {
            return this._workflowSummaries != null && (this._workflowSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}