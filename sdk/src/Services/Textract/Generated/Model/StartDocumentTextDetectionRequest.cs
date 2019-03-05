/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the StartDocumentTextDetection operation.
    /// Starts the asynchronous detection of text in a document. Amazon Textract can detect
    /// lines of text and the words that make up a line of text.
    /// 
    ///  
    /// <para>
    /// Amazon Textract can detect text in document images and PDF files that are stored in
    /// an Amazon S3 bucket. Use <a>DocumentLocation</a> to specify the bucket name and the
    /// file name of the document image. 
    /// </para>
    ///  
    /// <para>
    ///  <code>StartTextDetection</code> returns a job identifier (<code>JobId</code>) that
    /// you use to get the results of the operation. When text detection is finished, Amazon
    /// Textract publishes a completion status to the Amazon Simple Notification Service (Amazon
    /// SNS) topic that you specify in <code>NotificationChannel</code>. To get the results
    /// of the text detection operation, first check that the status value published to the
    /// Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetDocumentTextDetection</a>,
    /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartDocumentTextDetection</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see Document Text Detection in the Amazon Textract Developer
    /// Guide.
    /// </para>
    /// </summary>
    public partial class StartDocumentTextDetectionRequest : AmazonTextractRequest
    {
        private string _clientRequestToken;
        private DocumentLocation _documentLocation;
        private string _jobTag;
        private NotificationChannel _notificationChannel;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The idempotent token that's used to identify the start request. If you use the same
        /// token with multiple <code>StartDocumentTextDetection</code> requests, the same <code>JobId</code>
        /// is returned. Use <code>ClientRequestToken</code> to prevent the same job from being
        /// accidentally started more than once. 
        /// </para>
        /// </summary>
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
        /// A unique identifier you specify to identify the job in the completion status that's
        /// published to the Amazon Simple Notification Service (Amazon SNS) topic.
        /// </para>
        /// </summary>
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

    }
}