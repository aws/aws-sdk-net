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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the StartDocumentAnalysis operation.
    /// Starts the asynchronous analysis of an input document for relationships between detected
    /// items such as key-value pairs, tables, and selection elements.
    /// 
    ///  
    /// <para>
    ///  <c>StartDocumentAnalysis</c> can analyze text in documents that are in JPEG, PNG,
    /// TIFF, and PDF format. The documents are stored in an Amazon S3 bucket. Use <a>DocumentLocation</a>
    /// to specify the bucket name and file name of the document. 
    /// </para>
    ///  
    /// <para>
    ///  <c>StartDocumentAnalysis</c> returns a job identifier (<c>JobId</c>) that you use
    /// to get the results of the operation. When text analysis is finished, Amazon Textract
    /// publishes a completion status to the Amazon Simple Notification Service (Amazon SNS)
    /// topic that you specify in <c>NotificationChannel</c>. To get the results of the text
    /// analysis operation, first check that the status value published to the Amazon SNS
    /// topic is <c>SUCCEEDED</c>. If so, call <a>GetDocumentAnalysis</a>, and pass the job
    /// identifier (<c>JobId</c>) from the initial call to <c>StartDocumentAnalysis</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-analyzing.html">Document
    /// Text Analysis</a>.
    /// </para>
    /// </summary>
    public partial class StartDocumentAnalysisRequest : AmazonTextractRequest
    {
        private AdaptersConfig _adaptersConfig;
        private string _clientRequestToken;
        private DocumentLocation _documentLocation;
        private List<string> _featureTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _jobTag;
        private string _kmsKeyId;
        private NotificationChannel _notificationChannel;
        private OutputConfig _outputConfig;
        private QueriesConfig _queriesConfig;

        /// <summary>
        /// Gets and sets the property AdaptersConfig. 
        /// <para>
        /// Specifies the adapter to be used when analyzing a document.
        /// </para>
        /// </summary>
        public AdaptersConfig AdaptersConfig
        {
            get { return this._adaptersConfig; }
            set { this._adaptersConfig = value; }
        }

        // Check to see if AdaptersConfig property is set
        internal bool IsSetAdaptersConfig()
        {
            return this._adaptersConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The idempotent token that you use to identify the start request. If you use the same
        /// token with multiple <c>StartDocumentAnalysis</c> requests, the same <c>JobId</c> is
        /// returned. Use <c>ClientRequestToken</c> to prevent the same job from being accidentally
        /// started more than once. For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/api-async.html">Calling
        /// Amazon Textract Asynchronous Operations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentLocation. 
        /// <para>
        /// The location of the document to be processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentLocation DocumentLocation
        {
            get { return this._documentLocation; }
            set { this._documentLocation = value; }
        }

        // Check to see if DocumentLocation property is set
        internal bool IsSetDocumentLocation()
        {
            return this._documentLocation != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// A list of the types of analysis to perform. Add TABLES to the list to return information
        /// about the tables that are detected in the input document. Add FORMS to return detected
        /// form data. To perform both types of analysis, add TABLES and FORMS to <c>FeatureTypes</c>.
        /// All lines and words detected in the document are included in the response (including
        /// text that isn't related to the value of <c>FeatureTypes</c>). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> FeatureTypes
        {
            get { return this._featureTypes; }
            set { this._featureTypes = value; }
        }

        // Check to see if FeatureTypes property is set
        internal bool IsSetFeatureTypes()
        {
            return this._featureTypes != null && (this._featureTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobTag. 
        /// <para>
        /// An identifier that you specify that's included in the completion notification published
        /// to the Amazon SNS topic. For example, you can use <c>JobTag</c> to identify the type
        /// of document that the completion notification corresponds to (such as a tax form or
        /// a receipt).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobTag
        {
            get { return this._jobTag; }
            set { this._jobTag = value; }
        }

        // Check to see if JobTag property is set
        internal bool IsSetJobTag()
        {
            return this._jobTag != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The KMS key used to encrypt the inference results. This can be in either Key ID or
        /// Key Alias format. When a KMS key is provided, the KMS key will be used for server-side
        /// encryption of the objects in the customer bucket. When this parameter is not enabled,
        /// the result will be encrypted server side,using SSE-S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KMSKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KMSKeyId property is set
        internal bool IsSetKMSKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationChannel. 
        /// <para>
        /// The Amazon SNS topic ARN that you want Amazon Textract to publish the completion status
        /// of the operation to. 
        /// </para>
        /// </summary>
        public NotificationChannel NotificationChannel
        {
            get { return this._notificationChannel; }
            set { this._notificationChannel = value; }
        }

        // Check to see if NotificationChannel property is set
        internal bool IsSetNotificationChannel()
        {
            return this._notificationChannel != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Sets if the output will go to a customer defined bucket. By default, Amazon Textract
        /// will save the results internally to be accessed by the GetDocumentAnalysis operation.
        /// </para>
        /// </summary>
        public OutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QueriesConfig.
        /// </summary>
        public QueriesConfig QueriesConfig
        {
            get { return this._queriesConfig; }
            set { this._queriesConfig = value; }
        }

        // Check to see if QueriesConfig property is set
        internal bool IsSetQueriesConfig()
        {
            return this._queriesConfig != null;
        }

    }
}