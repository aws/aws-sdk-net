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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// This is the response object from the ListOperations operation.
    /// </summary>
    public partial class ListOperationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<OperationSummary> _operationSummaryList = AWSConfigs.InitializeCollections ? new List<OperationSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that you can pass in a subsequent request to get the next result page. It's
        /// returned in a paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=51200)]
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
        /// Gets and sets the property OperationSummaryList. 
        /// <para>
        /// A list of operation summary information records. In a paginated request, the request
        /// returns up to <c>MaxResults</c> records for each call.
        /// </para>
        /// </summary>
        public List<OperationSummary> OperationSummaryList
        {
            get { return this._operationSummaryList; }
            set { this._operationSummaryList = value; }
        }

        // Check to see if OperationSummaryList property is set
        internal bool IsSetOperationSummaryList()
        {
            return this._operationSummaryList != null && (this._operationSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}