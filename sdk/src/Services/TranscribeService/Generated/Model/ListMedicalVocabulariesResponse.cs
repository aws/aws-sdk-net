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
        /// The <code>ListMedicalVocabularies</code> operation returns a page of vocabularies
        /// at a time. You set the maximum number of vocabularies to return on a page with the
        /// <code>MaxResults</code> parameter. If there are more jobs in the list will fit on
        /// a page, Amazon Transcribe Medical returns the <code>NextPage</code> token. To return
        /// the next page of vocabularies, include the token in the next request to the <code>ListMedicalVocabularies</code>
        /// operation .
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
        /// The requested vocabulary state.
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
        /// A list of objects that describe the vocabularies that match your search criteria.
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