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
    /// A single retrieved relevant passage result.
    /// </summary>
    public partial class RetrieveResultItem
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The contents of the relevant passage.
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

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
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier of the document.
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
        /// The title of the document.
        /// </para>
        /// </summary>
        public string DocumentTitle { get; set; }

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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the relevant passage result.
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
        /// The confidence score bucket for a retrieved passage result. The confidence bucket
        /// provides a relative ranking that indicates how confident Amazon Kendra is that the
        /// response is relevant to the query.
        /// </para>
        /// </summary>
        public ScoreAttributes ScoreAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ScoreAttributes property is set.
        /// </summary>
        internal bool IsSetScoreAttributes() => this.ScoreAttributes != null;
    }
}
