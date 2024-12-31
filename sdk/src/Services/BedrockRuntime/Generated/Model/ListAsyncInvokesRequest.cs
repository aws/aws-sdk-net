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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the ListAsyncInvokes operation.
    /// Lists asynchronous invocations.
    /// </summary>
    public partial class ListAsyncInvokesRequest : AmazonBedrockRuntimeRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private SortAsyncInvocationBy _sortBy;
        private SortOrder _sortOrder;
        private AsyncInvokeStatus _statusEquals;
        private DateTime? _submitTimeAfter;
        private DateTime? _submitTimeBefore;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of invocations to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// How to sort the response.
        /// </para>
        /// </summary>
        public SortAsyncInvocationBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sorting order for the response.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Filter invocations by status.
        /// </para>
        /// </summary>
        public AsyncInvokeStatus StatusEquals
        {
            get { return this._statusEquals; }
            set { this._statusEquals = value; }
        }

        // Check to see if StatusEquals property is set
        internal bool IsSetStatusEquals()
        {
            return this._statusEquals != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeAfter. 
        /// <para>
        /// Include invocations submitted after this time.
        /// </para>
        /// </summary>
        public DateTime? SubmitTimeAfter
        {
            get { return this._submitTimeAfter; }
            set { this._submitTimeAfter = value; }
        }

        // Check to see if SubmitTimeAfter property is set
        internal bool IsSetSubmitTimeAfter()
        {
            return this._submitTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeBefore. 
        /// <para>
        /// Include invocations submitted before this time.
        /// </para>
        /// </summary>
        public DateTime? SubmitTimeBefore
        {
            get { return this._submitTimeBefore; }
            set { this._submitTimeBefore = value; }
        }

        // Check to see if SubmitTimeBefore property is set
        internal bool IsSetSubmitTimeBefore()
        {
            return this._submitTimeBefore.HasValue; 
        }

    }
}