/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// This is the response object from the ListRepositoryAssociations operation.
    /// </summary>
    public partial class ListRepositoryAssociationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RepositoryAssociationSummary> _repositoryAssociationSummaries = new List<RepositoryAssociationSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListRecommendations</code>
        /// request. When the results of a <code>ListRecommendations</code> request exceed <code>maxResults</code>,
        /// this value can be used to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return. 
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
        /// Gets and sets the property RepositoryAssociationSummaries. 
        /// <para>
        /// A list of repository associations that meet the criteria of the request.
        /// </para>
        /// </summary>
        public List<RepositoryAssociationSummary> RepositoryAssociationSummaries
        {
            get { return this._repositoryAssociationSummaries; }
            set { this._repositoryAssociationSummaries = value; }
        }

        // Check to see if RepositoryAssociationSummaries property is set
        internal bool IsSetRepositoryAssociationSummaries()
        {
            return this._repositoryAssociationSummaries != null && this._repositoryAssociationSummaries.Count > 0; 
        }

    }
}