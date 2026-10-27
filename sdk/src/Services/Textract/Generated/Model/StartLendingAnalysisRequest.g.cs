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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the StartLendingAnalysis operation. Starts the classification
    /// and analysis of an input document. <c>StartLendingAnalysis</c> initiates the classification
    /// and analysis of a packet of lending documents. <c>StartLendingAnalysis</c> operates
    /// on a document file located in an Amazon S3 bucket. <para> <c>StartLendingAnalysis</c>
    /// can analyze text in documents that are in one of the following formats: JPEG, PNG,
    /// TIFF, PDF. Use <c>DocumentLocation</c> to specify the bucket name and the file name
    /// of the document. </para> <para> <c>StartLendingAnalysis</c> returns a job identifier
    /// (<c>JobId</c>) that you use to get the results of the operation. When the text analysis
    /// is finished, Amazon Textract publishes a completion status to the Amazon Simple Notification
    /// Service (Amazon SNS) topic that you specify in <c>NotificationChannel</c>. To get
    /// the results of the text analysis operation, first check that the status value published
    /// to the Amazon SNS topic is SUCCEEDED. If the status is SUCCEEDED you can call either
    /// <c>GetLendingAnalysis</c> or <c>GetLendingAnalysisSummary</c> and provide the <c>JobId</c>
    /// to obtain the results of the analysis. </para> <para> If using <c>OutputConfig</c>
    /// to specify an Amazon S3 bucket, the output will be contained within the specified
    /// prefix in a directory labeled with the job-id. In the directory there are 3 sub-directories:
    /// </para> <ul> <li> <para> detailedResponse (contains the GetLendingAnalysis response)
    /// </para> </li> <li> <para> summaryResponse (for the GetLendingAnalysisSummary response)
    /// </para> </li> <li> <para> splitDocuments (documents split across logical boundaries)
    /// </para> </li> </ul>
    /// </summary>
    public partial class StartLendingAnalysisRequest : AmazonTextractRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The idempotent token that you use to identify the start request. If you use the same
        /// token with multiple <c>StartLendingAnalysis</c> requests, the same <c>JobId</c> is
        /// returned. Use <c>ClientRequestToken</c> to prevent the same job from being accidentally
        /// started more than once. For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/api-sync.html">Calling
        /// Amazon Textract Asynchronous Operations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property DocumentLocation.
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentLocation DocumentLocation { get; set; }

        /// <summary>
        /// Checks to see if the DocumentLocation property is set.
        /// </summary>
        internal bool IsSetDocumentLocation() => this.DocumentLocation != null;

        /// <summary>
        /// Gets and sets the property JobTag. 
        /// <para>
        /// An identifier that you specify to be included in the completion notification published
        /// to the Amazon SNS topic. For example, you can use <c>JobTag</c> to identify the type
        /// of document that the completion notification corresponds to (such as a tax form or
        /// a receipt).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobTag { get; set; }

        /// <summary>
        /// Checks to see if the JobTag property is set.
        /// </summary>
        internal bool IsSetJobTag() => this.JobTag != null;

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The KMS key used to encrypt the inference results. This can be in either Key ID or
        /// Key Alias format. When a KMS key is provided, the KMS key will be used for server-side
        /// encryption of the objects in the customer bucket. When this parameter is not enabled,
        /// the result will be encrypted server side, using SSE-S3. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyId property is set.
        /// </summary>
        internal bool IsSetKMSKeyId() => this.KMSKeyId != null;

        /// <summary>
        /// Gets and sets the property NotificationChannel.
        /// </summary>
        public NotificationChannel NotificationChannel { get; set; }

        /// <summary>
        /// Checks to see if the NotificationChannel property is set.
        /// </summary>
        internal bool IsSetNotificationChannel() => this.NotificationChannel != null;

        /// <summary>
        /// Gets and sets the property OutputConfig.
        /// </summary>
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;
    }
}
