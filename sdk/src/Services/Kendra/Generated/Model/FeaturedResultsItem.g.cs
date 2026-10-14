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
    /// A single featured result item. A featured result is displayed at the top of the search
    /// results page, placed above all other results for certain queries. If there's an exact
    /// match of a query, then certain documents are featured in the search results.
    /// </summary>
    public partial class FeaturedResultsItem
    {
        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// One or more additional attributes associated with the featured result.
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
        /// Gets and sets the property DocumentAttributes. 
        /// <para>
        /// An array of document attributes assigned to a featured document in the search results.
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
        /// </summary>
        public TextWithHighlights DocumentExcerpt { get; set; }

        /// <summary>
        /// Checks to see if the DocumentExcerpt property is set.
        /// </summary>
        internal bool IsSetDocumentExcerpt() => this.DocumentExcerpt != null;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier of the featured document.
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
        /// </summary>
        public TextWithHighlights DocumentTitle { get; set; }

        /// <summary>
        /// Checks to see if the DocumentTitle property is set.
        /// </summary>
        internal bool IsSetDocumentTitle() => this.DocumentTitle != null;

        /// <summary>
        /// Gets and sets the property DocumentURI. 
        /// <para>
        /// The source URI location of the featured document.
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
        /// A token that identifies a particular featured result from a particular query. Use
        /// this token to provide click-through feedback for the result. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/submitting-feedback.html">Submitting
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the featured result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 73)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of document within the featured result response. For example, a response
        /// could include a question-answer type that's relevant to the query.
        /// </para>
        /// </summary>
        public QueryResultType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
