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
    /// A single expanded result in a collapsed group of search results.
    /// 
    ///  
    /// <para>
    /// An expanded result item contains information about an expanded result document within
    /// a collapsed group of search results. This includes the original location of the document,
    /// a list of attributes assigned to the document, and relevant text from the document
    /// that satisfies the query. 
    /// </para>
    /// </summary>
    public partial class ExpandedResultItem
    {
        /// <summary>
        /// Gets and sets the property DocumentAttributes. 
        /// <para>
        /// An array of document attributes assigned to a document in the search results. For
        /// example, the document author ("_author") or the source URI ("_source_uri") of the
        /// document.
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
        /// The idenitifier of the document.
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
        /// The identifier for the expanded result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 73)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
