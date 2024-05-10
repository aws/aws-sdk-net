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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the ListStackSetOperations operation.
    /// </summary>
    public partial class ListStackSetOperationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StackSetOperationSummary> _summaries = AWSConfigs.InitializeCollections ? new List<StackSetOperationSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the request doesn't return all results, <c>NextToken</c> is set to a token. To
        /// retrieve the next set of results, call <c>ListOperationResults</c> again and assign
        /// that token to the request object's <c>NextToken</c> parameter. If there are no remaining
        /// results, <c>NextToken</c> is set to <c>null</c>.
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
        /// Gets and sets the property Summaries. 
        /// <para>
        /// A list of <c>StackSetOperationSummary</c> structures that contain summary information
        /// about operations for the specified stack set.
        /// </para>
        /// </summary>
        public List<StackSetOperationSummary> Summaries
        {
            get { return this._summaries; }
            set { this._summaries = value; }
        }

        // Check to see if Summaries property is set
        internal bool IsSetSummaries()
        {
            return this._summaries != null && (this._summaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}