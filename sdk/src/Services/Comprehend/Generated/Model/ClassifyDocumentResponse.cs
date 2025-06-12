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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the ClassifyDocument operation.
    /// </summary>
    public partial class ClassifyDocumentResponse : AmazonWebServiceResponse
    {
        private List<DocumentClass> _classes = AWSConfigs.InitializeCollections ? new List<DocumentClass>() : null;
        private DocumentMetadata _documentMetadata;
        private List<DocumentTypeListItem> _documentType = AWSConfigs.InitializeCollections ? new List<DocumentTypeListItem>() : null;
        private List<ErrorsListItem> _errors = AWSConfigs.InitializeCollections ? new List<ErrorsListItem>() : null;
        private List<DocumentLabel> _labels = AWSConfigs.InitializeCollections ? new List<DocumentLabel>() : null;
        private List<WarningsListItem> _warnings = AWSConfigs.InitializeCollections ? new List<WarningsListItem>() : null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentClass> Classes
        {
            get { return this._classes; }
            set { this._classes = value; }
        }

        // Check to see if Classes property is set
        internal bool IsSetClasses()
        {
            return this._classes != null && (this._classes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// Extraction information about the document. This field is present in the response only
        /// if your request includes the <c>Byte</c> parameter. 
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
        /// response only if your request includes the <c>Byte</c> parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentTypeListItem> DocumentType
        {
            get { return this._documentType; }
            set { this._documentType = value; }
        }

        // Check to see if DocumentType property is set
        internal bool IsSetDocumentType()
        {
            return this._documentType != null && (this._documentType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Page-level errors that the system detected while processing the input document. The
        /// field is empty if the system encountered no errors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorsListItem> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentLabel> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WarningsListItem> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}