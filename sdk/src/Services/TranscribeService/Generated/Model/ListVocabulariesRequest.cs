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
    /// Container for the parameters to the ListVocabularies operation.
    /// Returns a list of vocabularies that match the specified criteria. If no criteria are
    /// specified, returns the entire list of vocabularies.
    /// </summary>
    public partial class ListVocabulariesRequest : AmazonTranscribeServiceRequest
    {
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private VocabularyState _stateEquals;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of vocabularies to return in the response. If there are fewer results
        /// in the list, this response contains only the actual results.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// When specified, the vocabularies returned in the list are limited to vocabularies
        /// whose name contains the specified string. The search is case-insensitive, <code>ListVocabularies</code>
        /// will return both "vocabularyname" and "VocabularyName" in the response list.
        /// </para>
        /// </summary>
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous request to <code>ListVocabularies</code> was truncated,
        /// include the <code>NextToken</code> to fetch the next set of jobs.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StateEquals. 
        /// <para>
        /// When specified, only returns vocabularies with the <code>VocabularyState</code> field
        /// equal to the specified state.
        /// </para>
        /// </summary>
        public VocabularyState StateEquals
        {
            get { return this._stateEquals; }
            set { this._stateEquals = value; }
        }

        // Check to see if StateEquals property is set
        internal bool IsSetStateEquals()
        {
            return this._stateEquals != null;
        }

    }
}