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
    /// An augmented manifest file that provides training data for your custom model. An augmented
    /// manifest file is a labeled dataset that is produced by Amazon SageMaker Ground Truth.
    /// </summary>
    public partial class AugmentedManifestsListItem
    {
        private string _annotationDataS3Uri;
        private List<string> _attributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AugmentedManifestsDocumentTypeFormat _documentType;
        private string _s3Uri;
        private string _sourceDocumentsS3Uri;
        private Split _split;

        /// <summary>
        /// Gets and sets the property AnnotationDataS3Uri. 
        /// <para>
        /// The S3 prefix to the annotation files that are referred in the augmented manifest
        /// file.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string AnnotationDataS3Uri
        {
            get { return this._annotationDataS3Uri; }
            set { this._annotationDataS3Uri = value; }
        }

        // Check to see if AnnotationDataS3Uri property is set
        internal bool IsSetAnnotationDataS3Uri()
        {
            return this._annotationDataS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// The JSON attribute that contains the annotations for your training documents. The
        /// number of attribute names that you specify depends on whether your augmented manifest
        /// file is the output of a single labeling job or a chained labeling job.
        /// </para>
        ///  
        /// <para>
        /// If your file is the output of a single labeling job, specify the LabelAttributeName
        /// key that was used when the job was created in Ground Truth.
        /// </para>
        ///  
        /// <para>
        /// If your file is the output of a chained labeling job, specify the LabelAttributeName
        /// key for one or more jobs in the chain. Each LabelAttributeName key provides the annotations
        /// from an individual job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && (this._attributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The type of augmented manifest. PlainTextDocument or SemiStructuredDocument. If you
        /// don't specify, the default is PlainTextDocument. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PLAIN_TEXT_DOCUMENT</c> A document type that represents any unicode text that
        /// is encoded in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SEMI_STRUCTURED_DOCUMENT</c> A document type with positional and structural context,
        /// like a PDF. For training with Amazon Comprehend, only PDFs are supported. For inference,
        /// Amazon Comprehend support PDFs, DOCX and TXT.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AugmentedManifestsDocumentTypeFormat DocumentType
        {
            get { return this._documentType; }
            set { this._documentType = value; }
        }

        // Check to see if DocumentType property is set
        internal bool IsSetDocumentType()
        {
            return this._documentType != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 location of the augmented manifest file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDocumentsS3Uri. 
        /// <para>
        /// The S3 prefix to the source files (PDFs) that are referred to in the augmented manifest
        /// file.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string SourceDocumentsS3Uri
        {
            get { return this._sourceDocumentsS3Uri; }
            set { this._sourceDocumentsS3Uri = value; }
        }

        // Check to see if SourceDocumentsS3Uri property is set
        internal bool IsSetSourceDocumentsS3Uri()
        {
            return this._sourceDocumentsS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property Split. 
        /// <para>
        /// The purpose of the data you've provided in the augmented manifest. You can either
        /// train or test this data. If you don't specify, the default is train.
        /// </para>
        ///  
        /// <para>
        /// TRAIN - all of the documents in the manifest will be used for training. If no test
        /// documents are provided, Amazon Comprehend will automatically reserve a portion of
        /// the training documents for testing.
        /// </para>
        ///  
        /// <para>
        ///  TEST - all of the documents in the manifest will be used for testing.
        /// </para>
        /// </summary>
        public Split Split
        {
            get { return this._split; }
            set { this._split = value; }
        }

        // Check to see if Split property is set
        internal bool IsSetSplit()
        {
            return this._split != null;
        }

    }
}