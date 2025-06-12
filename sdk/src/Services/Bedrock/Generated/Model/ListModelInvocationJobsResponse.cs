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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the ListModelInvocationJobs operation.
    /// </summary>
    public partial class ListModelInvocationJobsResponse : AmazonWebServiceResponse
    {
        private List<ModelInvocationJobSummary> _invocationJobSummaries = AWSConfigs.InitializeCollections ? new List<ModelInvocationJobSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InvocationJobSummaries. 
        /// <para>
        /// A list of items, each of which contains a summary about a batch inference job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelInvocationJobSummary> InvocationJobSummaries
        {
            get { return this._invocationJobSummaries; }
            set { this._invocationJobSummaries = value; }
        }

        // Check to see if InvocationJobSummaries property is set
        internal bool IsSetInvocationJobSummaries()
        {
            return this._invocationJobSummaries != null && (this._invocationJobSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more results than can fit in the response, a <c>nextToken</c> is returned.
        /// Use the <c>nextToken</c> in a request to return the next batch of results.
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

    }
}