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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// A single query result.
    /// 
    ///  
    /// <para>
    /// A query result contains information about a document returned by the query. This includes
    /// the original location of the document, a list of attributes assigned to the document,
    /// and relevant text from the document that satisfies the query.
    /// </para>
    /// </summary>
    public partial class QueryResultItem
    {
        private List<AdditionalResultAttribute> _additionalAttributes = new List<AdditionalResultAttribute>();
        private List<DocumentAttribute> _documentAttributes = new List<DocumentAttribute>();
        private TextWithHighlights _documentExcerpt;
        private string _documentId;
        private TextWithHighlights _documentTitle;
        private string _documentURI;
        private string _feedbackToken;
        private QueryResultFormat _format;
        private string _id;
        private ScoreAttributes _scoreAttributes;
        private TableExcerpt _tableExcerpt;
        private QueryResultType _type;

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// One or more additional attributes associated with the query result.
        /// </para>
        /// </summary>
        public List<AdditionalResultAttribute> AdditionalAttributes
        {
            get { return this._additionalAttributes; }
            set { this._additionalAttributes = value; }
        }

        // Check to see if AdditionalAttributes property is set
        internal bool IsSetAdditionalAttributes()
        {
            return this._additionalAttributes != null && this._additionalAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DocumentAttributes. 
        /// <para>
        /// An array of document attributes assigned to a document in the search results. For
        /// example, the document author (<code>_author</code>) or the source URI (<code>_source_uri</code>)
        /// of the document.
        /// </para>
        /// </summary>
        public List<DocumentAttribute> DocumentAttributes
        {
            get { return this._documentAttributes; }
            set { this._documentAttributes = value; }
        }

        // Check to see if DocumentAttributes property is set
        internal bool IsSetDocumentAttributes()
        {
            return this._documentAttributes != null && this._documentAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DocumentExcerpt. 
        /// <para>
        /// An extract of the text in the document. Contains information about highlighting the
        /// relevant terms in the excerpt.
        /// </para>
        /// </summary>
        public TextWithHighlights DocumentExcerpt
        {
            get { return this._documentExcerpt; }
            set { this._documentExcerpt = value; }
        }

        // Check to see if DocumentExcerpt property is set
        internal bool IsSetDocumentExcerpt()
        {
            return this._documentExcerpt != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier for the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentTitle. 
        /// <para>
        /// The title of the document. Contains the text of the title and information for highlighting
        /// the relevant terms in the title.
        /// </para>
        /// </summary>
        public TextWithHighlights DocumentTitle
        {
            get { return this._documentTitle; }
            set { this._documentTitle = value; }
        }

        // Check to see if DocumentTitle property is set
        internal bool IsSetDocumentTitle()
        {
            return this._documentTitle != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentURI. 
        /// <para>
        /// The URI of the original location of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DocumentURI
        {
            get { return this._documentURI; }
            set { this._documentURI = value; }
        }

        // Check to see if DocumentURI property is set
        internal bool IsSetDocumentURI()
        {
            return this._documentURI != null;
        }

        /// <summary>
        /// Gets and sets the property FeedbackToken. 
        /// <para>
        /// A token that identifies a particular result from a particular query. Use this token
        /// to provide click-through feedback for the result. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/submitting-feedback.html">Submitting
        /// feedback </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FeedbackToken
        {
            get { return this._feedbackToken; }
            set { this._feedbackToken = value; }
        }

        // Check to see if FeedbackToken property is set
        internal bool IsSetFeedbackToken()
        {
            return this._feedbackToken != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// If the <code>Type</code> of document within the response is <code>ANSWER</code>, then
        /// it is either a <code>TABLE</code> answer or <code>TEXT</code> answer. If it's a table
        /// answer, a table excerpt is returned in <code>TableExcerpt</code>. If it's a text answer,
        /// a text excerpt is returned in <code>DocumentExcerpt</code>.
        /// </para>
        /// </summary>
        public QueryResultFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the query result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=73)]
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
        /// Gets and sets the property ScoreAttributes. 
        /// <para>
        /// Indicates the confidence that Amazon Kendra has that a result matches the query that
        /// you provided. Each result is placed into a bin that indicates the confidence, <code>VERY_HIGH</code>,
        /// <code>HIGH</code>, <code>MEDIUM</code> and <code>LOW</code>. You can use the score
        /// to determine if a response meets the confidence needed for your application.
        /// </para>
        ///  
        /// <para>
        /// The field is only set to <code>LOW</code> when the <code>Type</code> field is set
        /// to <code>DOCUMENT</code> and Amazon Kendra is not confident that the result matches
        /// the query.
        /// </para>
        /// </summary>
        public ScoreAttributes ScoreAttributes
        {
            get { return this._scoreAttributes; }
            set { this._scoreAttributes = value; }
        }

        // Check to see if ScoreAttributes property is set
        internal bool IsSetScoreAttributes()
        {
            return this._scoreAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property TableExcerpt. 
        /// <para>
        /// An excerpt from a table within a document.
        /// </para>
        /// </summary>
        public TableExcerpt TableExcerpt
        {
            get { return this._tableExcerpt; }
            set { this._tableExcerpt = value; }
        }

        // Check to see if TableExcerpt property is set
        internal bool IsSetTableExcerpt()
        {
            return this._tableExcerpt != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of document within the response. For example, a response could include a
        /// question-answer that's relevant to the query.
        /// </para>
        /// </summary>
        public QueryResultType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}