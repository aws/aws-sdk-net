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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the StartCelebrityRecognition operation.
    /// Starts asynchronous recognition of celebrities in a stored video.
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition Video can detect celebrities in a video must be stored in an Amazon
    /// S3 bucket. Use <a>Video</a> to specify the bucket name and the filename of the video.
    /// <c>StartCelebrityRecognition</c> returns a job identifier (<c>JobId</c>) which you
    /// use to get the results of the analysis. When celebrity recognition analysis is finished,
    /// Amazon Rekognition Video publishes a completion status to the Amazon Simple Notification
    /// Service topic that you specify in <c>NotificationChannel</c>. To get the results of
    /// the celebrity recognition analysis, first check that the status value published to
    /// the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetCelebrityRecognition</a>
    /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartCelebrityRecognition</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Recognizing celebrities in the Amazon Rekognition Developer
    /// Guide.
    /// </para>
    /// </summary>
    public partial class StartCelebrityRecognitionRequest : AmazonRekognitionRequest
    {
        private string _clientRequestToken;
        private string _jobTag;
        private NotificationChannel _notificationChannel;
        private Video _video;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token used to identify the start request. If you use the same token with
        /// multiple <c>StartCelebrityRecognition</c> requests, the same <c>JobId</c> is returned.
        /// Use <c>ClientRequestToken</c> to prevent the same job from being accidently started
        /// more than once. 
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
        /// Gets and sets the property JobTag. 
        /// <para>
        /// An identifier you specify that's returned in the completion notification that's published
        /// to your Amazon Simple Notification Service topic. For example, you can use <c>JobTag</c>
        /// to group related jobs and identify them in the completion notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The Amazon SNS topic ARN that you want Amazon Rekognition Video to publish the completion
        /// status of the celebrity recognition analysis to. The Amazon SNS topic must have a
        /// topic name that begins with <i>AmazonRekognition</i> if you are using the AmazonRekognitionServiceRole
        /// permissions policy.
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
        /// The video in which you want to recognize celebrities. The video must be stored in
        /// an Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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