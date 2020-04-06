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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the ListVocabularyFilters operation.
    /// </summary>
    public partial class ListVocabularyFiltersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<VocabularyFilterInfo> _vocabularyFilters = new List<VocabularyFilterInfo>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>ListVocabularyFilters</code> operation returns a page of collections at
        /// a time. The maximum size of the page is set by the <code>MaxResults</code> parameter.
        /// If there are more jobs in the list than the page size, Amazon Transcribe returns the
        /// <code>NextPage</code> token. Include the token in the next request to the <code>ListVocabularyFilters</code>
        /// operation to return in the next page of jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property VocabularyFilters. 
        /// <para>
        /// The list of vocabulary filters. It contains at most <code>MaxResults</code> number
        /// of filters. If there are more filters, call the <code>ListVocabularyFilters</code>
        /// operation again with the <code>NextToken</code> parameter in the request set to the
        /// value of the <code>NextToken</code> field in the response.
        /// </para>
        /// </summary>
        public List<VocabularyFilterInfo> VocabularyFilters
        {
            get { return this._vocabularyFilters; }
            set { this._vocabularyFilters = value; }
        }

        // Check to see if VocabularyFilters property is set
        internal bool IsSetVocabularyFilters()
        {
            return this._vocabularyFilters != null && this._vocabularyFilters.Count > 0; 
        }

    }
}