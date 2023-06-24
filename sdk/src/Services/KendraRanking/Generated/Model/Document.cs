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
    /// Information about a document from a search service such as OpenSearch (self managed).
    /// Amazon Kendra Intelligent Ranking uses this information to rank and score on.
    /// </summary>
    public partial class Document
    {
        private string _body;
        private string _groupId;
        private string _id;
        private float? _originalScore;
        private string _title;
        private List<string> _tokenizedBody = new List<string>();
        private List<string> _tokenizedTitle = new List<string>();

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body text of the search service's document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The optional group identifier of the document from the search service. Documents with
        /// the same group identifier are grouped together and processed as one document within
        /// the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the document from the search service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalScore. 
        /// <para>
        /// The original document score or rank from the search service. Amazon Kendra Intelligent
        /// Ranking gives the document a new score or rank based on its intelligent search algorithms.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-100000, Max=100000)]
        public float OriginalScore
        {
            get { return this._originalScore.GetValueOrDefault(); }
            set { this._originalScore = value; }
        }

        // Check to see if OriginalScore property is set
        internal bool IsSetOriginalScore()
        {
            return this._originalScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the search service's document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property TokenizedBody. 
        /// <para>
        /// The body text of the search service's document represented as a list of tokens or
        /// words. You must choose to provide <code>Body</code> or <code>TokenizedBody</code>.
        /// You cannot provide both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> TokenizedBody
        {
            get { return this._tokenizedBody; }
            set { this._tokenizedBody = value; }
        }

        // Check to see if TokenizedBody property is set
        internal bool IsSetTokenizedBody()
        {
            return this._tokenizedBody != null && this._tokenizedBody.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TokenizedTitle. 
        /// <para>
        /// The title of the search service's document represented as a list of tokens or words.
        /// You must choose to provide <code>Title</code> or <code>TokenizedTitle</code>. You
        /// cannot provide both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> TokenizedTitle
        {
            get { return this._tokenizedTitle; }
            set { this._tokenizedTitle = value; }
        }

        // Check to see if TokenizedTitle property is set
        internal bool IsSetTokenizedTitle()
        {
            return this._tokenizedTitle != null && this._tokenizedTitle.Count > 0; 
        }

    }
}