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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KendraRanking.Model
{
    /// <summary>
    /// Container for the parameters to the Rescore operation.
    /// Rescores or re-ranks search results from a search service such as OpenSearch (self
    /// managed). You use the semantic search capabilities of Amazon Kendra Intelligent Ranking
    /// to improve the search service's results.
    /// </summary>
    public partial class RescoreRequest : AmazonKendraRankingRequest
    {
        private List<Document> _documents = new List<Document>();
        private string _rescoreExecutionPlanId;
        private string _searchQuery;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The list of documents for Amazon Kendra Intelligent Ranking to rescore or rank on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<Document> Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null && this._documents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RescoreExecutionPlanId. 
        /// <para>
        /// The identifier of the rescore execution plan. A rescore execution plan is an Amazon
        /// Kendra Intelligent Ranking resource used for provisioning the <code>Rescore</code>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string RescoreExecutionPlanId
        {
            get { return this._rescoreExecutionPlanId; }
            set { this._rescoreExecutionPlanId = value; }
        }

        // Check to see if RescoreExecutionPlanId property is set
        internal bool IsSetRescoreExecutionPlanId()
        {
            return this._rescoreExecutionPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property SearchQuery. 
        /// <para>
        /// The input query from the search service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string SearchQuery
        {
            get { return this._searchQuery; }
            set { this._searchQuery = value; }
        }

        // Check to see if SearchQuery property is set
        internal bool IsSetSearchQuery()
        {
            return this._searchQuery != null;
        }

    }
}