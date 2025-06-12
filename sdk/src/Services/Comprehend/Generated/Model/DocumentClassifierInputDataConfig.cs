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
    /// The input properties for training a document classifier. 
    /// 
    ///  
    /// <para>
    /// For more information on how the input file is formatted, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/prep-classifier-data.html">Preparing
    /// training data</a> in the Comprehend Developer Guide. 
    /// </para>
    /// </summary>
    public partial class DocumentClassifierInputDataConfig
    {
        private List<AugmentedManifestsListItem> _augmentedManifests = AWSConfigs.InitializeCollections ? new List<AugmentedManifestsListItem>() : null;
        private DocumentClassifierDataFormat _dataFormat;
        private DocumentReaderConfig _documentReaderConfig;
        private DocumentClassifierDocuments _documents;
        private DocumentClassifierDocumentTypeFormat _documentType;
        private string _labelDelimiter;
        private string _s3Uri;
        private string _testS3Uri;

        /// <summary>
        /// Gets and sets the property AugmentedManifests. 
        /// <para>
        /// A list of augmented manifest files that provide training data for your custom model.
        /// An augmented manifest file is a labeled dataset that is produced by Amazon SageMaker
        /// Ground Truth.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you set <c>DataFormat</c> to <c>AUGMENTED_MANIFEST</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AugmentedManifestsListItem> AugmentedManifests
        {
            get { return this._augmentedManifests; }
            set { this._augmentedManifests = value; }
        }

        // Check to see if AugmentedManifests property is set
        internal bool IsSetAugmentedManifests()
        {
            return this._augmentedManifests != null && (this._augmentedManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The format of your training data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPREHEND_CSV</c>: A two-column CSV file, where labels are provided in the first
        /// column, and documents are provided in the second. If you use this value, you must
        /// provide the <c>S3Uri</c> parameter in your request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUGMENTED_MANIFEST</c>: A labeled dataset that is produced by Amazon SageMaker
        /// Ground Truth. This file is in JSON lines format. Each line is a complete JSON object
        /// that contains a training document and its associated labels. 
        /// </para>
        ///  
        /// <para>
        /// If you use this value, you must provide the <c>AugmentedManifests</c> parameter in
        /// your request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value, Amazon Comprehend uses <c>COMPREHEND_CSV</c> as the
        /// default.
        /// </para>
        /// </summary>
        public DocumentClassifierDataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentReaderConfig.
        /// </summary>
        public DocumentReaderConfig DocumentReaderConfig
        {
            get { return this._documentReaderConfig; }
            set { this._documentReaderConfig = value; }
        }

        // Check to see if DocumentReaderConfig property is set
        internal bool IsSetDocumentReaderConfig()
        {
            return this._documentReaderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The S3 location of the training documents. This parameter is required in a request
        /// to create a native document model.
        /// </para>
        /// </summary>
        public DocumentClassifierDocuments Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The type of input documents for training the model. Provide plain-text documents to
        /// create a plain-text model, and provide semi-structured documents to create a native
        /// document model.
        /// </para>
        /// </summary>
        public DocumentClassifierDocumentTypeFormat DocumentType
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
        /// Gets and sets the property LabelDelimiter. 
        /// <para>
        /// Indicates the delimiter used to separate each label for training a multi-label classifier.
        /// The default delimiter between labels is a pipe (|). You can use a different character
        /// as a delimiter (if it's an allowed character) by specifying it under Delimiter for
        /// labels. If the training documents use a delimiter other than the default or the delimiter
        /// you specify, the labels on that line will be combined to make a single unique label,
        /// such as LABELLABELLABEL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string LabelDelimiter
        {
            get { return this._labelDelimiter; }
            set { this._labelDelimiter = value; }
        }

        // Check to see if LabelDelimiter property is set
        internal bool IsSetLabelDelimiter()
        {
            return this._labelDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 URI for the input data. The S3 bucket must be in the same Region as
        /// the API endpoint that you are calling. The URI can point to a single input file or
        /// it can provide the prefix for a collection of input files.
        /// </para>
        ///  
        /// <para>
        /// For example, if you use the URI <c>S3://bucketName/prefix</c>, if the prefix is a
        /// single file, Amazon Comprehend uses that file as input. If more than one file begins
        /// with the prefix, Amazon Comprehend uses all of them as input.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you set <c>DataFormat</c> to <c>COMPREHEND_CSV</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property TestS3Uri. 
        /// <para>
        /// This specifies the Amazon S3 location that contains the test annotations for the document
        /// classifier. The URI must be in the same Amazon Web Services Region as the API endpoint
        /// that you are calling. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TestS3Uri
        {
            get { return this._testS3Uri; }
            set { this._testS3Uri = value; }
        }

        // Check to see if TestS3Uri property is set
        internal bool IsSetTestS3Uri()
        {
            return this._testS3Uri != null;
        }

    }
}