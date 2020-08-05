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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the ListMedicalVocabularies operation.
    /// Returns a list of vocabularies that match the specified criteria. If you don't enter
    /// a value in any of the request parameters, returns the entire list of vocabularies.
    /// </summary>
    public partial class ListMedicalVocabulariesRequest : AmazonTranscribeServiceRequest
    {
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private VocabularyState _stateEquals;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of vocabularies to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Returns vocabularies whose names contain the specified string. The search is not case
        /// sensitive. <code>ListMedicalVocabularies</code> returns both "<code>vocabularyname</code>"
        /// and "<code>VocabularyName</code>".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// If the result of your previous request to <code>ListMedicalVocabularies</code> was
        /// truncated, include the <code>NextToken</code> to fetch the next set of vocabularies.
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
        /// Gets and sets the property StateEquals. 
        /// <para>
        /// When specified, returns only vocabularies with the <code>VocabularyState</code> equal
        /// to the specified vocabulary state. Use this field to see which vocabularies are ready
        /// for your medical transcription jobs.
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