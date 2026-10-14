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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the StartLabelDetection operation. Starts asynchronous
    /// detection of labels in a stored video. <para> Amazon Rekognition Video can detect
    /// labels in a video. Labels are instances of real-world entities. This includes objects
    /// like flower, tree, and table; events like wedding, graduation, and birthday party;
    /// concepts like landscape, evening, and nature; and activities like a person getting
    /// out of a car or a person skiing. </para> <para> The video must be stored in an Amazon
    /// S3 bucket. Use <a>Video</a> to specify the bucket name and the filename of the video.
    /// <c>StartLabelDetection</c> returns a job identifier (<c>JobId</c>) which you use to
    /// get the results of the operation. When label detection is finished, Amazon Rekognition
    /// Video publishes a completion status to the Amazon Simple Notification Service topic
    /// that you specify in <c>NotificationChannel</c>. </para> <para> To get the results
    /// of the label detection operation, first check that the status value published to the
    /// Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetLabelDetection</a> and pass
    /// the job identifier (<c>JobId</c>) from the initial call to <c>StartLabelDetection</c>.
    /// </para> <para> <i>Optional Parameters</i> </para> <para> <c>StartLabelDetection</c>
    /// has the <c>GENERAL_LABELS</c> Feature applied by default. This feature allows you
    /// to provide filtering criteria to the <c>Settings</c> parameter. You can filter with
    /// sets of individual labels or with label categories. You can specify inclusive filters,
    /// exclusive filters, or a combination of inclusive and exclusive filters. For more information
    /// on filtering, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/labels-detecting-labels-video.html">Detecting
    /// labels in a video</a>. </para> <para> You can specify <c>MinConfidence</c> to control
    /// the confidence threshold for the labels returned. The default is 50. </para>
    /// </summary>
    public partial class StartLabelDetectionRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token used to identify the start request. If you use the same token with
        /// multiple <c>StartLabelDetection</c> requests, the same <c>JobId</c> is returned. Use
        /// <c>ClientRequestToken</c> to prevent the same job from being accidently started more
        /// than once. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// The features to return after video analysis. You can specify that GENERAL_LABELS are
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> Features { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null && (this.Features.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobTag. 
        /// <para>
        /// An identifier you specify that's returned in the completion notification that's published
        /// to your Amazon Simple Notification Service topic. For example, you can use <c>JobTag</c>
        /// to group related jobs and identify them in the completion notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string JobTag { get; set; }

        /// <summary>
        /// Checks to see if the JobTag property is set.
        /// </summary>
        internal bool IsSetJobTag() => this.JobTag != null;

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
        /// If you don't specify <c>MinConfidence</c>, the operation returns labels and bounding
        /// boxes (if detected) with confidence values greater than or equal to 50 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? MinConfidence { get; set; }

        /// <summary>
        /// Checks to see if the MinConfidence property is set.
        /// </summary>
        internal bool IsSetMinConfidence() => this.MinConfidence.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationChannel. 
        /// <para>
        /// The Amazon SNS topic ARN you want Amazon Rekognition Video to publish the completion
        /// status of the label detection operation to. The Amazon SNS topic must have a topic
        /// name that begins with <i>AmazonRekognition</i> if you are using the AmazonRekognitionServiceRole
        /// permissions policy.
        /// </para>
        /// </summary>
        public NotificationChannel NotificationChannel { get; set; }

        /// <summary>
        /// Checks to see if the NotificationChannel property is set.
        /// </summary>
        internal bool IsSetNotificationChannel() => this.NotificationChannel != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings for a StartLabelDetection request.Contains the specified parameters for
        /// the label detection request of an asynchronous label analysis operation. Settings
        /// can include filters for GENERAL_LABELS.
        /// </para>
        /// </summary>
        public LabelDetectionSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// The video in which you want to detect labels. The video must be stored in an Amazon
        /// S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Video Video { get; set; }

        /// <summary>
        /// Checks to see if the Video property is set.
        /// </summary>
        internal bool IsSetVideo() => this.Video != null;
    }
}
