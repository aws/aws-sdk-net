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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the StartLabelDetection operation.
    /// Starts asynchronous detection of labels in a stored video.
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition Video can detect labels in a video. Labels are instances of real-world
    /// entities. This includes objects like flower, tree, and table; events like wedding,
    /// graduation, and birthday party; concepts like landscape, evening, and nature; and
    /// activities like a person getting out of a car or a person skiing.
    /// </para>
    ///  
    /// <para>
    /// The video must be stored in an Amazon S3 bucket. Use <a>Video</a> to specify the bucket
    /// name and the filename of the video. <code>StartLabelDetection</code> returns a job
    /// identifier (<code>JobId</code>) which you use to get the results of the operation.
    /// When label detection is finished, Amazon Rekognition Video publishes a completion
    /// status to the Amazon Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
    /// </para>
    ///  
    /// <para>
    /// To get the results of the label detection operation, first check that the status value
    /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetLabelDetection</a>
    /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartLabelDetection</code>.
    /// </para>
    ///  
    /// <para>
    ///  <i>Optional Parameters</i> 
    /// </para>
    ///  
    /// <para>
    ///  <code>StartLabelDetection</code> has the <code>GENERAL_LABELS</code> Feature applied
    /// by default. This feature allows you to provide filtering criteria to the <code>Settings</code>
    /// parameter. You can filter with sets of individual labels or with label categories.
    /// You can specify inclusive filters, exclusive filters, or a combination of inclusive
    /// and exclusive filters. For more information on filtering, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/labels-detecting-labels-video.html">Detecting
    /// labels in a video</a>.
    /// </para>
    ///  
    /// <para>
    /// You can specify <code>MinConfidence</code> to control the confidence threshold for
    /// the labels returned. The default is 50.
    /// </para>
    /// </summary>
    public partial class StartLabelDetectionRequest : AmazonRekognitionRequest
    {
        private string _clientRequestToken;
        private List<string> _features = new List<string>();
        private string _jobTag;
        private float? _minConfidence;
        private NotificationChannel _notificationChannel;
        private LabelDetectionSettings _settings;
        private Video _video;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token used to identify the start request. If you use the same token with
        /// multiple <code>StartLabelDetection</code> requests, the same <code>JobId</code> is
        /// returned. Use <code>ClientRequestToken</code> to prevent the same job from being accidently
        /// started more than once. 
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
        /// Gets and sets the property Features. 
        /// <para>
        /// The features to return after video analysis. You can specify that GENERAL_LABELS are
        /// returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && this._features.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobTag. 
        /// <para>
        /// An identifier you specify that's returned in the completion notification that's published
        /// to your Amazon Simple Notification Service topic. For example, you can use <code>JobTag</code>
        /// to group related jobs and identify them in the completion notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Specifies the minimum confidence that Amazon Rekognition Video must have in order
        /// to return a detected label. Confidence represents how certain Amazon Rekognition is
        /// that a label is correctly identified.0 is the lowest confidence. 100 is the highest
        /// confidence. Amazon Rekognition Video doesn't return any labels with a confidence level
        /// lower than this specified value.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <code>MinConfidence</code>, the operation returns labels and
        /// bounding boxes (if detected) with confidence values greater than or equal to 50 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// The Amazon SNS topic ARN you want Amazon Rekognition Video to publish the completion
        /// status of the label detection operation to. The Amazon SNS topic must have a topic
        /// name that begins with <i>AmazonRekognition</i> if you are using the AmazonRekognitionServiceRole
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings for a StartLabelDetection request.Contains the specified parameters for
        /// the label detection request of an asynchronous label analysis operation. Settings
        /// can include filters for GENERAL_LABELS.
        /// </para>
        /// </summary>
        public LabelDetectionSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// The video in which you want to detect labels. The video must be stored in an Amazon
        /// S3 bucket.
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