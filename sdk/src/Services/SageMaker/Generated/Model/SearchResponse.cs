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
    /// This is the response object from the Search operation.
    /// </summary>
    public partial class SearchResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SearchRecord> _results = AWSConfigs.InitializeCollections ? new List<SearchRecord>() : null;
        private TotalHits _totalHits;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous <c>Search</c> request was truncated, the response includes
        /// a NextToken. To retrieve the next set of results, use the token in the next request.
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
        /// Gets and sets the property Results. 
        /// <para>
        /// A list of <c>SearchRecord</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SearchRecord> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && (this._results.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalHits. 
        /// <para>
        /// The total number of matching results.
        /// </para>
        /// </summary>
        public TotalHits TotalHits
        {
            get { return this._totalHits; }
            set { this._totalHits = value; }
        }

        // Check to see if TotalHits property is set
        internal bool IsSetTotalHits()
        {
            return this._totalHits != null;
        }

    }
}