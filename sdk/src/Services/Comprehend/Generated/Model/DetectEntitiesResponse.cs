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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the DetectEntities operation.
    /// </summary>
    public partial class DetectEntitiesResponse : AmazonWebServiceResponse
    {
        private List<Block> _blocks = new List<Block>();
        private DocumentMetadata _documentMetadata;
        private List<DocumentTypeListItem> _documentType = new List<DocumentTypeListItem>();
        private List<Entity> _entities = new List<Entity>();
        private List<ErrorsListItem> _errors = new List<ErrorsListItem>();

        /// <summary>
        /// Gets and sets the property Blocks. 
        /// <para>
        /// Information about each block of text in the input document. Blocks are nested. A page
        /// block contains a block for each line of text, which contains a block for each word.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <code>Block</code> content for a Word input document does not include a <code>Geometry</code>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// The <code>Block</code> field is not present in the response for plain-text inputs.
        /// </para>
        /// </summary>
        public List<Block> Blocks
        {
            get { return this._blocks; }
            set { this._blocks = value; }
        }

        // Check to see if Blocks property is set
        internal bool IsSetBlocks()
        {
            return this._blocks != null && this._blocks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// Information about the document, discovered during text extraction. This field is present
        /// in the response only if your request used the <code>Byte</code> parameter. 
        /// </para>
        /// </summary>
        public DocumentMetadata DocumentMetadata
        {
            get { return this._documentMetadata; }
            set { this._documentMetadata = value; }
        }

        // Check to see if DocumentMetadata property is set
        internal bool IsSetDocumentMetadata()
        {
            return this._documentMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The document type for each page in the input document. This field is present in the
        /// response only if your request used the <code>Byte</code> parameter. 
        /// </para>
        /// </summary>
        public List<DocumentTypeListItem> DocumentType
        {
            get { return this._documentType; }
            set { this._documentType = value; }
        }

        // Check to see if DocumentType property is set
        internal bool IsSetDocumentType()
        {
            return this._documentType != null && this._documentType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// A collection of entities identified in the input text. For each entity, the response
        /// provides the entity text, entity type, where the entity text begins and ends, and
        /// the level of confidence that Amazon Comprehend has in the detection. 
        /// </para>
        ///  
        /// <para>
        /// If your request uses a custom entity recognition model, Amazon Comprehend detects
        /// the entities that the model is trained to recognize. Otherwise, it detects the default
        /// entity types. For a list of default entity types, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-entities.html">Entities</a>
        /// in the Comprehend Developer Guide. 
        /// </para>
        /// </summary>
        public List<Entity> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null && this._entities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Page-level errors that the system detected while processing the input document. The
        /// field is empty if the system encountered no errors.
        /// </para>
        /// </summary>
        public List<ErrorsListItem> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

    }
}