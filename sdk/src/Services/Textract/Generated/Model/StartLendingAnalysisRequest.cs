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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the StartLendingAnalysis operation.
    /// Starts the classification and analysis of an input document. <code>StartLendingAnalysis</code>
    /// initiates the classification and analysis of a packet of lending documents. <code>StartLendingAnalysis</code>
    /// operates on a document file located in an Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    ///  <code>StartLendingAnalysis</code> can analyze text in documents that are in one of
    /// the following formats: JPEG, PNG, TIFF, PDF. Use <code>DocumentLocation</code> to
    /// specify the bucket name and the file name of the document. 
    /// </para>
    ///  
    /// <para>
    ///  <code>StartLendingAnalysis</code> returns a job identifier (<code>JobId</code>) that
    /// you use to get the results of the operation. When the text analysis is finished, Amazon
    /// Textract publishes a completion status to the Amazon Simple Notification Service (Amazon
    /// SNS) topic that you specify in <code>NotificationChannel</code>. To get the results
    /// of the text analysis operation, first check that the status value published to the
    /// Amazon SNS topic is SUCCEEDED. If the status is SUCCEEDED you can call either <code>GetLendingAnalysis</code>
    /// or <code>GetLendingAnalysisSummary</code> and provide the <code>JobId</code> to obtain
    /// the results of the analysis.
    /// </para>
    ///  
    /// <para>
    /// If using <code>OutputConfig</code> to specify an Amazon S3 bucket, the output will
    /// be contained within the specified prefix in a directory labeled with the job-id. In
    /// the directory there are 3 sub-directories: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// detailedResponse (contains the GetLendingAnalysis response)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// summaryResponse (for the GetLendingAnalysisSummary response)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// splitDocuments (documents split across logical boundaries)
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartLendingAnalysisRequest : AmazonTextractRequest
    {
        private string _clientRequestToken;
        private DocumentLocation _documentLocation;
        private string _jobTag;
        private string _kmsKeyId;
        private NotificationChannel _notificationChannel;
        private OutputConfig _outputConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The idempotent token that you use to identify the start request. If you use the same
        /// token with multiple <code>StartLendingAnalysis</code> requests, the same <code>JobId</code>
        /// is returned. Use <code>ClientRequestToken</code> to prevent the same job from being
        /// accidentally started more than once. For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/api-sync.html">Calling
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
        /// Gets and sets the property JobTag. 
        /// <para>
        /// An identifier that you specify to be included in the completion notification published
        /// to the Amazon SNS topic. For example, you can use <code>JobTag</code> to identify
        /// the type of document that the completion notification corresponds to (such as a tax
        /// form or a receipt).
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
        /// the result will be encrypted server side, using SSE-S3. 
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

    }
}