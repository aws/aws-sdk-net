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
    /// A document in an Amazon Q Business application.
    /// </summary>
    public partial class Document
    {
        private AccessConfiguration _accessConfiguration;
        private List<DocumentAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<DocumentAttribute>() : null;
        private DocumentContent _content;
        private ContentType _contentType;
        private DocumentEnrichmentConfiguration _documentEnrichmentConfiguration;
        private string _id;
        private MediaExtractionConfiguration _mediaExtractionConfiguration;
        private string _title;

        /// <summary>
        /// Gets and sets the property AccessConfiguration. 
        /// <para>
        /// Configuration information for access permission to a document.
        /// </para>
        /// </summary>
        public AccessConfiguration AccessConfiguration
        {
            get { return this._accessConfiguration; }
            set { this._accessConfiguration = value; }
        }

        // Check to see if AccessConfiguration property is set
        internal bool IsSetAccessConfiguration()
        {
            return this._accessConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Custom attributes to apply to the document for refining Amazon Q Business web experience
        /// responses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<DocumentAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The contents of the document.
        /// </para>
        /// </summary>
        public DocumentContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The file type of the document in the Blob field.
        /// </para>
        ///  
        /// <para>
        /// If you want to index snippets or subsets of HTML documents instead of the entirety
        /// of the HTML documents, you add the <c>HTML</c> start and closing tags (<c>&lt;HTML&gt;content&lt;/HTML&gt;</c>)
        /// around the content.
        /// </para>
        /// </summary>
        public ContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentEnrichmentConfiguration. 
        /// <para>
        /// The configuration information for altering document metadata and content during the
        /// document ingestion process.
        /// </para>
        /// </summary>
        public DocumentEnrichmentConfiguration DocumentEnrichmentConfiguration
        {
            get { return this._documentEnrichmentConfiguration; }
            set { this._documentEnrichmentConfiguration = value; }
        }

        // Check to see if DocumentEnrichmentConfiguration property is set
        internal bool IsSetDocumentEnrichmentConfiguration()
        {
            return this._documentEnrichmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1825)]
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
        /// Gets and sets the property MediaExtractionConfiguration. 
        /// <para>
        /// The configuration for extracting information from media in the document.
        /// </para>
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration
        {
            get { return this._mediaExtractionConfiguration; }
            set { this._mediaExtractionConfiguration = value; }
        }

        // Check to see if MediaExtractionConfiguration property is set
        internal bool IsSetMediaExtractionConfiguration()
        {
            return this._mediaExtractionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the document.
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

    }
}