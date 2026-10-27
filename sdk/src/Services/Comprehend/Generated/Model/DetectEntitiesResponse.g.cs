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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the DetectEntities operation.
    /// </summary>
    public partial class DetectEntitiesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Blocks. 
        /// <para>
        /// Information about each block of text in the input document. Blocks are nested. A page
        /// block contains a block for each line of text, which contains a block for each word.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <c>Block</c> content for a Word input document does not include a <c>Geometry</c>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// The <c>Block</c> field is not present in the response for plain-text inputs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Block> Blocks { get; set; } = AWSConfigs.InitializeCollections ? new List<Block>() : null;

        /// <summary>
        /// Checks to see if the Blocks property is set.
        /// </summary>
        internal bool IsSetBlocks() => this.Blocks != null && (this.Blocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// Information about the document, discovered during text extraction. This field is present
        /// in the response only if your request used the <c>Byte</c> parameter. 
        /// </para>
        /// </summary>
        public DocumentMetadata DocumentMetadata { get; set; }

        /// <summary>
        /// Checks to see if the DocumentMetadata property is set.
        /// </summary>
        internal bool IsSetDocumentMetadata() => this.DocumentMetadata != null;

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The document type for each page in the input document. This field is present in the
        /// response only if your request used the <c>Byte</c> parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentTypeListItem> DocumentType { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentTypeListItem>() : null;

        /// <summary>
        /// Checks to see if the DocumentType property is set.
        /// </summary>
        internal bool IsSetDocumentType() => this.DocumentType != null && (this.DocumentType.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Entity> Entities { get; set; } = AWSConfigs.InitializeCollections ? new List<Entity>() : null;

        /// <summary>
        /// Checks to see if the Entities property is set.
        /// </summary>
        internal bool IsSetEntities() => this.Entities != null && (this.Entities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Page-level errors that the system detected while processing the input document. The
        /// field is empty if the system encountered no errors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorsListItem> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<ErrorsListItem>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
