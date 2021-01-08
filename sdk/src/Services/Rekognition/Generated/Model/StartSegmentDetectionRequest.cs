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
    /// Container for the parameters to the StartSegmentDetection operation.
    /// Starts asynchronous detection of segment detection in a stored video.
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition Video can detect segments in a video stored in an Amazon S3 bucket.
    /// Use <a>Video</a> to specify the bucket name and the filename of the video. <code>StartSegmentDetection</code>
    /// returns a job identifier (<code>JobId</code>) which you use to get the results of
    /// the operation. When segment detection is finished, Amazon Rekognition Video publishes
    /// a completion status to the Amazon Simple Notification Service topic that you specify
    /// in <code>NotificationChannel</code>.
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>Filters</code> (<a>StartSegmentDetectionFilters</a>) input parameter
    /// to specify the minimum detection confidence returned in the response. Within <code>Filters</code>,
    /// use <code>ShotFilter</code> (<a>StartShotDetectionFilter</a>) to filter detected shots.
    /// Use <code>TechnicalCueFilter</code> (<a>StartTechnicalCueDetectionFilter</a>) to filter
    /// technical cues. 
    /// </para>
    ///  
    /// <para>
    /// To get the results of the segment detection operation, first check that the status
    /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. if so, call <a>GetSegmentDetection</a>
    /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartSegmentDetection</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Detecting Video Segments in Stored Video in the Amazon Rekognition
    /// Developer Guide.
    /// </para>
    /// </summary>
    public partial class StartSegmentDetectionRequest : AmazonRekognitionRequest
    {
        private string _clientRequestToken;
        private StartSegmentDetectionFilters _filters;
        private string _jobTag;
        private NotificationChannel _notificationChannel;
        private List<string> _segmentTypes = new List<string>();
        private Video _video;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token used to identify the start request. If you use the same token with
        /// multiple <code>StartSegmentDetection</code> requests, the same <code>JobId</code>
        /// is returned. Use <code>ClientRequestToken</code> to prevent the same job from being
        /// accidently started more than once. 
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters for technical cue or shot detection.
        /// </para>
        /// </summary>
        public StartSegmentDetectionFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
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
        /// Gets and sets the property NotificationChannel. 
        /// <para>
        /// The ARN of the Amazon SNS topic to which you want Amazon Rekognition Video to publish
        /// the completion status of the segment detection operation.
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
        /// Gets and sets the property SegmentTypes. 
        /// <para>
        /// An array of segment types to detect in the video. Valid values are TECHNICAL_CUE and
        /// SHOT.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> SegmentTypes
        {
            get { return this._segmentTypes; }
            set { this._segmentTypes = value; }
        }

        // Check to see if SegmentTypes property is set
        internal bool IsSetSegmentTypes()
        {
            return this._segmentTypes != null && this._segmentTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Video.
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