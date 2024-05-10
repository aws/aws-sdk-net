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
    /// Container for the parameters to the StartExpenseAnalysis operation.
    /// Starts the asynchronous analysis of invoices or receipts for data like contact information,
    /// items purchased, and vendor names.
    /// 
    ///  
    /// <para>
    ///  <c>StartExpenseAnalysis</c> can analyze text in documents that are in JPEG, PNG,
    /// and PDF format. The documents must be stored in an Amazon S3 bucket. Use the <a>DocumentLocation</a>
    /// parameter to specify the name of your S3 bucket and the name of the document in that
    /// bucket. 
    /// </para>
    ///  
    /// <para>
    ///  <c>StartExpenseAnalysis</c> returns a job identifier (<c>JobId</c>) that you will
    /// provide to <c>GetExpenseAnalysis</c> to retrieve the results of the operation. When
    /// the analysis of the input invoices/receipts is finished, Amazon Textract publishes
    /// a completion status to the Amazon Simple Notification Service (Amazon SNS) topic that
    /// you provide to the <c>NotificationChannel</c>. To obtain the results of the invoice
    /// and receipt analysis operation, ensure that the status value published to the Amazon
    /// SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetExpenseAnalysis</a>, and pass the
    /// job identifier (<c>JobId</c>) that was returned by your call to <c>StartExpenseAnalysis</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/invoice-receipts.html">Analyzing
    /// Invoices and Receipts</a>.
    /// </para>
    /// </summary>
    public partial class StartExpenseAnalysisRequest : AmazonTextractRequest
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
        /// The idempotent token that's used to identify the start request. If you use the same
        /// token with multiple <c>StartDocumentTextDetection</c> requests, the same <c>JobId</c>
        /// is returned. Use <c>ClientRequestToken</c> to prevent the same job from being accidentally
        /// started more than once. For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/api-async.html">Calling
        /// Amazon Textract Asynchronous Operations</a> 
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
        /// Gets and sets the property JobTag. 
        /// <para>
        /// An identifier you specify that's included in the completion notification published
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
        /// will save the results internally to be accessed by the <c>GetExpenseAnalysis</c> operation.
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

    }
}