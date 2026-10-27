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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AugmentedManifestsListItem> AugmentedManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<AugmentedManifestsListItem>() : null;

        /// <summary>
        /// Checks to see if the AugmentedManifests property is set.
        /// </summary>
        internal bool IsSetAugmentedManifests() => this.AugmentedManifests != null && (this.AugmentedManifests.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public DocumentClassifierDataFormat DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

        /// <summary>
        /// Gets and sets the property DocumentReaderConfig.
        /// </summary>
        public DocumentReaderConfig DocumentReaderConfig { get; set; }

        /// <summary>
        /// Checks to see if the DocumentReaderConfig property is set.
        /// </summary>
        internal bool IsSetDocumentReaderConfig() => this.DocumentReaderConfig != null;

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The type of input documents for training the model. Provide plain-text documents to
        /// create a plain-text model, and provide semi-structured documents to create a native
        /// document model.
        /// </para>
        /// </summary>
        public DocumentClassifierDocumentTypeFormat DocumentType { get; set; }

        /// <summary>
        /// Checks to see if the DocumentType property is set.
        /// </summary>
        internal bool IsSetDocumentType() => this.DocumentType != null;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The S3 location of the training documents. This parameter is required in a request
        /// to create a native document model.
        /// </para>
        /// </summary>
        public DocumentClassifierDocuments Documents { get; set; }

        /// <summary>
        /// Checks to see if the Documents property is set.
        /// </summary>
        internal bool IsSetDocuments() => this.Documents != null;

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
        [AWSProperty(Min = 1, Max = 1)]
        public string LabelDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the LabelDelimiter property is set.
        /// </summary>
        internal bool IsSetLabelDelimiter() => this.LabelDelimiter != null;

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
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;

        /// <summary>
        /// Gets and sets the property TestS3Uri. 
        /// <para>
        /// This specifies the Amazon S3 location that contains the test annotations for the document
        /// classifier. The URI must be in the same Amazon Web Services Region as the API endpoint
        /// that you are calling. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TestS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the TestS3Uri property is set.
        /// </summary>
        internal bool IsSetTestS3Uri() => this.TestS3Uri != null;
    }
}
