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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The documents used to generate an Amazon Q Business web experience response.
    /// </summary>
    public partial class SourceAttribution
    {
        private int? _citationNumber;
        private string _datasourceId;
        private string _documentId;
        private string _indexId;
        private string _snippet;
        private List<TextSegment> _textMessageSegments = AWSConfigs.InitializeCollections ? new List<TextSegment>() : null;
        private string _title;
        private DateTime? _updatedAt;
        private string _url;

        /// <summary>
        /// Gets and sets the property CitationNumber. 
        /// <para>
        /// The number attached to a citation in an Amazon Q Business generated response.
        /// </para>
        /// </summary>
        public int? CitationNumber
        {
            get { return this._citationNumber; }
            set { this._citationNumber = value; }
        }

        // Check to see if CitationNumber property is set
        internal bool IsSetCitationNumber()
        {
            return this._citationNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasourceId. 
        /// <para>
        /// The identifier of the data source from which the document was ingested. This field
        /// is not present if the document is ingested by directly calling the BatchPutDocument
        /// API (similar to checkDocumentAccess). If the document is from a file-upload data source,
        /// the datasource will be "uploaded-docs-file-stat-datasourceid".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DatasourceId
        {
            get { return this._datasourceId; }
            set { this._datasourceId = value; }
        }

        // Check to see if DatasourceId property is set
        internal bool IsSetDatasourceId()
        {
            return this._datasourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The unique identifier of the source document used in the citation, obtained from the
        /// Amazon Q Business index during chat response generation. This ID is used as input
        /// to the <c>GetDocumentContent</c> API to retrieve the actual document content for user
        /// verification.
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
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index containing the source document's metadata and access control
        /// information. This links the citation back to the specific Amazon Q Business index
        /// where the document's searchable content and permissions are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property Snippet. 
        /// <para>
        /// The content extract from the document on which the generated response is based. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Snippet
        {
            get { return this._snippet; }
            set { this._snippet = value; }
        }

        // Check to see if Snippet property is set
        internal bool IsSetSnippet()
        {
            return this._snippet != null;
        }

        /// <summary>
        /// Gets and sets the property TextMessageSegments. 
        /// <para>
        /// A text extract from a source document that is used for source attribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TextSegment> TextMessageSegments
        {
            get { return this._textMessageSegments; }
            set { this._textMessageSegments = value; }
        }

        // Check to see if TextMessageSegments property is set
        internal bool IsSetTextMessageSegments()
        {
            return this._textMessageSegments != null && (this._textMessageSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the document which is the source for the Amazon Q Business generated
        /// response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business application was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the document which is the source for the Amazon Q Business generated response.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}