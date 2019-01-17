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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the StartContentModeration operation.
    /// Starts asynchronous detection of explicit or suggestive adult content in a stored
    /// video.
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition Video can moderate content in a video stored in an Amazon S3 bucket.
    /// Use <a>Video</a> to specify the bucket name and the filename of the video. <code>StartContentModeration</code>
    /// returns a job identifier (<code>JobId</code>) which you use to get the results of
    /// the analysis. When content moderation analysis is finished, Amazon Rekognition Video
    /// publishes a completion status to the Amazon Simple Notification Service topic that
    /// you specify in <code>NotificationChannel</code>.
    /// </para>
    ///  
    /// <para>
    /// To get the results of the content moderation analysis, first check that the status
    /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetContentModeration</a>
    /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartContentModeration</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Detecting Unsafe Content in the Amazon Rekognition Developer
    /// Guide.
    /// </para>
    /// </summary>
    public partial class StartContentModerationRequest : AmazonRekognitionRequest
    {
        private string _clientRequestToken;
        private string _jobTag;
        private float? _minConfidence;
        private NotificationChannel _notificationChannel;
        private Video _video;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token used to identify the start request. If you use the same token with
        /// multiple <code>StartContentModeration</code> requests, the same <code>JobId</code>
        /// is returned. Use <code>ClientRequestToken</code> to prevent the same job from being
        /// accidently started more than once. 
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
        /// Gets and sets the property JobTag. 
        /// <para>
        /// Unique identifier you specify to identify the job in the completion status published
        /// to the Amazon Simple Notification Service topic. 
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
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// Specifies the minimum confidence that Amazon Rekognition must have in order to return
        /// a moderated content label. Confidence represents how certain Amazon Rekognition is
        /// that the moderated content is correctly identified. 0 is the lowest confidence. 100
        /// is the highest confidence. Amazon Rekognition doesn't return any moderated content
        /// labels with a confidence level lower than this specified value. If you don't specify
        /// <code>MinConfidence</code>, <code>GetContentModeration</code> returns labels with
        /// confidence values greater than or equal to 50 percent.
        /// </para>
        /// </summary>
        public float MinConfidence
        {
            get { return this._minConfidence.GetValueOrDefault(); }
            set { this._minConfidence = value; }
        }

        // Check to see if MinConfidence property is set
        internal bool IsSetMinConfidence()
        {
            return this._minConfidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationChannel. 
        /// <para>
        /// The Amazon SNS topic ARN that you want Amazon Rekognition Video to publish the completion
        /// status of the content moderation analysis to.
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
        /// Gets and sets the property Video. 
        /// <para>
        /// The video in which you want to moderate content. The video must be stored in an Amazon
        /// S3 bucket.
        /// </para>
        /// </summary>
        public Video Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

    }
}