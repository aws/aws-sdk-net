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
    /// This is the response object from the ClassifyDocument operation.
    /// </summary>
    public partial class ClassifyDocumentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Classes. 
        /// <para>
        /// The classes used by the document being analyzed. These are used for models trained
        /// in multi-class mode. Individual classes are mutually exclusive and each document is
        /// expected to have only a single class assigned to it. For example, an animal can be
        /// a dog or a cat, but not both at the same time. 
        /// </para>
        ///  
        /// <para>
        /// For prompt safety classification, the response includes only two classes (SAFE_PROMPT
        /// and UNSAFE_PROMPT), along with a confidence score for each class. The value range
        /// of the score is zero to one, where one is the highest confidence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentClass> Classes { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentClass>() : null;

        /// <summary>
        /// Checks to see if the Classes property is set.
        /// </summary>
        internal bool IsSetClasses() => this.Classes != null && (this.Classes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// Extraction information about the document. This field is present in the response only
        /// if your request includes the <c>Byte</c> parameter. 
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
        /// response only if your request includes the <c>Byte</c> parameter. 
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

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The labels used in the document being analyzed. These are used for multi-label trained
        /// models. Individual labels represent different categories that are related in some
        /// manner and are not mutually exclusive. For example, a movie can be just an action
        /// movie, or it can be an action movie, a science fiction movie, and a comedy, all at
        /// the same time. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentLabel> Labels { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentLabel>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Warnings detected while processing the input document. The response includes a warning
        /// if there is a mismatch between the input document type and the model type associated
        /// with the endpoint that you specified. The response can also include warnings for individual
        /// pages that have a mismatch. 
        /// </para>
        ///  
        /// <para>
        /// The field is empty if the system generated no warnings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WarningsListItem> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<WarningsListItem>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
