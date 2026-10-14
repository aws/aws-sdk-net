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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// One or more additional fields/attributes associated with the query result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalResultAttribute> AdditionalAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalResultAttribute>() : null;

        /// <summary>
        /// Checks to see if the AdditionalAttributes property is set.
        /// </summary>
        internal bool IsSetAdditionalAttributes() => this.AdditionalAttributes != null && (this.AdditionalAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CollapsedResultDetail. 
        /// <para>
        /// Provides details about a collapsed group of search results.
        /// </para>
        /// </summary>
        public CollapsedResultDetail CollapsedResultDetail { get; set; }

        /// <summary>
        /// Checks to see if the CollapsedResultDetail property is set.
        /// </summary>
        internal bool IsSetCollapsedResultDetail() => this.CollapsedResultDetail != null;

        /// <summary>
        /// Gets and sets the property DocumentAttributes. 
        /// <para>
        /// An array of document fields/attributes assigned to a document in the search results.
        /// For example, the document author (<c>_author</c>) or the source URI (<c>_source_uri</c>)
        /// of the document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentAttribute> DocumentAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentAttribute>() : null;

        /// <summary>
        /// Checks to see if the DocumentAttributes property is set.
        /// </summary>
        internal bool IsSetDocumentAttributes() => this.DocumentAttributes != null && (this.DocumentAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DocumentExcerpt. 
        /// <para>
        /// An extract of the text in the document. Contains information about highlighting the
        /// relevant terms in the excerpt.
        /// </para>
        /// </summary>
        public TextWithHighlights DocumentExcerpt { get; set; }

        /// <summary>
        /// Checks to see if the DocumentExcerpt property is set.
        /// </summary>
        internal bool IsSetDocumentExcerpt() => this.DocumentExcerpt != null;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier for the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Checks to see if the DocumentId property is set.
        /// </summary>
        internal bool IsSetDocumentId() => this.DocumentId != null;

        /// <summary>
        /// Gets and sets the property DocumentTitle. 
        /// <para>
        /// The title of the document. Contains the text of the title and information for highlighting
        /// the relevant terms in the title.
        /// </para>
        /// </summary>
        public TextWithHighlights DocumentTitle { get; set; }

        /// <summary>
        /// Checks to see if the DocumentTitle property is set.
        /// </summary>
        internal bool IsSetDocumentTitle() => this.DocumentTitle != null;

        /// <summary>
        /// Gets and sets the property DocumentURI. 
        /// <para>
        /// The URI of the original location of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DocumentURI { get; set; }

        /// <summary>
        /// Checks to see if the DocumentURI property is set.
        /// </summary>
        internal bool IsSetDocumentURI() => this.DocumentURI != null;

        /// <summary>
        /// Gets and sets the property FeedbackToken. 
        /// <para>
        /// A token that identifies a particular result from a particular query. Use this token
        /// to provide click-through feedback for the result. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/submitting-feedback.html">Submitting
        /// feedback</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FeedbackToken { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackToken property is set.
        /// </summary>
        internal bool IsSetFeedbackToken() => this.FeedbackToken != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// If the <c>Type</c> of document within the response is <c>ANSWER</c>, then it is either
        /// a <c>TABLE</c> answer or <c>TEXT</c> answer. If it's a table answer, a table excerpt
        /// is returned in <c>TableExcerpt</c>. If it's a text answer, a text excerpt is returned
        /// in <c>DocumentExcerpt</c>.
        /// </para>
        /// </summary>
        public QueryResultFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the query result item id (<c>Id</c>) and the query result
        /// item document id (<c>DocumentId</c>) combined. The value of this field changes with
        /// every request, even when you have the same documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 73)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ScoreAttributes. 
        /// <para>
        /// Indicates the confidence level of Amazon Kendra providing a relevant result for the
        /// query. Each result is placed into a bin that indicates the confidence, <c>VERY_HIGH</c>,
        /// <c>HIGH</c>, <c>MEDIUM</c> and <c>LOW</c>. You can use the score to determine if a
        /// response meets the confidence needed for your application.
        /// </para>
        ///  
        /// <para>
        /// The field is only set to <c>LOW</c> when the <c>Type</c> field is set to <c>DOCUMENT</c>
        /// and Amazon Kendra is not confident that the result is relevant to the query.
        /// </para>
        /// </summary>
        public ScoreAttributes ScoreAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ScoreAttributes property is set.
        /// </summary>
        internal bool IsSetScoreAttributes() => this.ScoreAttributes != null;

        /// <summary>
        /// Gets and sets the property TableExcerpt. 
        /// <para>
        /// An excerpt from a table within a document.
        /// </para>
        /// </summary>
        public TableExcerpt TableExcerpt { get; set; }

        /// <summary>
        /// Checks to see if the TableExcerpt property is set.
        /// </summary>
        internal bool IsSetTableExcerpt() => this.TableExcerpt != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of document within the response. For example, a response could include a
        /// question-answer that's relevant to the query.
        /// </para>
        /// </summary>
        public QueryResultType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
