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
    /// This is the response object from the ListMedicalVocabularies operation.
    /// </summary>
    public partial class ListMedicalVocabulariesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private VocabularyState _status;
        private List<VocabularyInfo> _vocabularies = new List<VocabularyInfo>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>NextToken</code> is present in your response, it indicates that not all results
        /// are displayed. To view the next set of results, copy the string associated with the
        /// <code>NextToken</code> parameter in your results output, then run your request again
        /// including <code>NextToken</code> with the value of the copied string. Repeat as needed
        /// to view all your results.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Lists all custom medical vocabularies that have the status specified in your request.
        /// Custom vocabularies are ordered by creation date, with the newest vocabulary first.
        /// </para>
        /// </summary>
        public VocabularyState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Vocabularies. 
        /// <para>
        /// Provides information about the custom medical vocabularies that match the criteria
        /// specified in your request.
        /// </para>
        /// </summary>
        public List<VocabularyInfo> Vocabularies
        {
            get { return this._vocabularies; }
            set { this._vocabularies = value; }
        }

        // Check to see if Vocabularies property is set
        internal bool IsSetVocabularies()
        {
            return this._vocabularies != null && this._vocabularies.Count > 0; 
        }

    }
}