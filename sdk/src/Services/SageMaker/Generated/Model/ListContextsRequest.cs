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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListContexts operation.
    /// Lists the contexts in your account and their properties.
    /// </summary>
    public partial class ListContextsRequest : AmazonSageMakerRequest
    {
        private string _contextType;
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private int? _maxResults;
        private string _nextToken;
        private SortContextsBy _sortBy;
        private SortOrder _sortOrder;
        private string _sourceUri;

        /// <summary>
        /// Gets and sets the property ContextType. 
        /// <para>
        /// A filter that returns only contexts of the specified type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ContextType
        {
            get { return this._contextType; }
            set { this._contextType = value; }
        }

        // Check to see if ContextType property is set
        internal bool IsSetContextType()
        {
            return this._contextType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// A filter that returns only contexts created on or after the specified time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter
        {
            get { return this._createdAfter; }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// A filter that returns only contexts created on or before the specified time.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore
        {
            get { return this._createdBefore; }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of contexts to return in the response. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// If the previous call to <c>ListContexts</c> didn't return the full set of contexts,
        /// the call returns a token for getting the next set of contexts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// The property used to sort results. The default value is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public SortContextsBy SortBy
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
        /// The sort order. The default value is <c>Descending</c>.
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
        /// Gets and sets the property SourceUri. 
        /// <para>
        /// A filter that returns only contexts with the specified source URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceUri
        {
            get { return this._sourceUri; }
            set { this._sourceUri = value; }
        }

        // Check to see if SourceUri property is set
        internal bool IsSetSourceUri()
        {
            return this._sourceUri != null;
        }

    }
}