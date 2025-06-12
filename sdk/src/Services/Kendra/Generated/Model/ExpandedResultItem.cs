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
        private List<DocumentAttribute> _documentAttributes = AWSConfigs.InitializeCollections ? new List<DocumentAttribute>() : null;
        private TextWithHighlights _documentExcerpt;
        private string _documentId;
        private TextWithHighlights _documentTitle;
        private string _documentURI;
        private string _id;

        /// <summary>
        /// Gets and sets the property DocumentAttributes. 
        /// <para>
        /// An array of document attributes assigned to a document in the search results. For
        /// example, the document author ("_author") or the source URI ("_source_uri") of the
        /// document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentAttribute> DocumentAttributes
        {
            get { return this._documentAttributes; }
            set { this._documentAttributes = value; }
        }

        // Check to see if DocumentAttributes property is set
        internal bool IsSetDocumentAttributes()
        {
            return this._documentAttributes != null && (this._documentAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DocumentExcerpt.
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
        /// The idenitifier of the document.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the expanded result.
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

    }
}