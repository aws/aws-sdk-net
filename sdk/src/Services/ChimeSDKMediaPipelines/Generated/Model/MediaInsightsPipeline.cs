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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A media pipeline that streams call analytics data.
    /// </summary>
    public partial class MediaInsightsPipeline
    {
        private DateTime? _createdTimestamp;
        private KinesisVideoStreamRecordingSourceRuntimeConfiguration _kinesisVideoStreamRecordingSourceRuntimeConfiguration;
        private KinesisVideoStreamSourceRuntimeConfiguration _kinesisVideoStreamSourceRuntimeConfiguration;
        private string _mediaInsightsPipelineConfigurationArn;
        private Dictionary<string, string> _mediaInsightsRuntimeMetadata = new Dictionary<string, string>();
        private string _mediaPipelineArn;
        private string _mediaPipelineId;
        private S3RecordingSinkRuntimeConfiguration _s3RecordingSinkRuntimeConfiguration;
        private MediaPipelineStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the media insights pipeline was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamRecordingSourceRuntimeConfiguration.
        /// 
        /// <para>
        /// The runtime configuration settings for a Kinesis recording video stream in a media
        /// insights pipeline.
        /// </para>
        /// </summary>
        public KinesisVideoStreamRecordingSourceRuntimeConfiguration KinesisVideoStreamRecordingSourceRuntimeConfiguration
        {
            get { return this._kinesisVideoStreamRecordingSourceRuntimeConfiguration; }
            set { this._kinesisVideoStreamRecordingSourceRuntimeConfiguration = value; }
        }

        // Check to see if KinesisVideoStreamRecordingSourceRuntimeConfiguration property is set
        internal bool IsSetKinesisVideoStreamRecordingSourceRuntimeConfiguration()
        {
            return this._kinesisVideoStreamRecordingSourceRuntimeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamSourceRuntimeConfiguration. 
        /// <para>
        /// The configuration settings for a Kinesis runtime video stream in a media insights
        /// pipeline.
        /// </para>
        /// </summary>
        public KinesisVideoStreamSourceRuntimeConfiguration KinesisVideoStreamSourceRuntimeConfiguration
        {
            get { return this._kinesisVideoStreamSourceRuntimeConfiguration; }
            set { this._kinesisVideoStreamSourceRuntimeConfiguration = value; }
        }

        // Check to see if KinesisVideoStreamSourceRuntimeConfiguration property is set
        internal bool IsSetKinesisVideoStreamSourceRuntimeConfiguration()
        {
            return this._kinesisVideoStreamSourceRuntimeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationArn. 
        /// <para>
        /// The ARN of a media insight pipeline's configuration settings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string MediaInsightsPipelineConfigurationArn
        {
            get { return this._mediaInsightsPipelineConfigurationArn; }
            set { this._mediaInsightsPipelineConfigurationArn = value; }
        }

        // Check to see if MediaInsightsPipelineConfigurationArn property is set
        internal bool IsSetMediaInsightsPipelineConfigurationArn()
        {
            return this._mediaInsightsPipelineConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsRuntimeMetadata. 
        /// <para>
        /// The runtime metadata of a media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> MediaInsightsRuntimeMetadata
        {
            get { return this._mediaInsightsRuntimeMetadata; }
            set { this._mediaInsightsRuntimeMetadata = value; }
        }

        // Check to see if MediaInsightsRuntimeMetadata property is set
        internal bool IsSetMediaInsightsRuntimeMetadata()
        {
            return this._mediaInsightsRuntimeMetadata != null && this._mediaInsightsRuntimeMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MediaPipelineArn. 
        /// <para>
        /// The ARN of a media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string MediaPipelineArn
        {
            get { return this._mediaPipelineArn; }
            set { this._mediaPipelineArn = value; }
        }

        // Check to see if MediaPipelineArn property is set
        internal bool IsSetMediaPipelineArn()
        {
            return this._mediaPipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaPipelineId. 
        /// <para>
        /// The ID of a media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MediaPipelineId
        {
            get { return this._mediaPipelineId; }
            set { this._mediaPipelineId = value; }
        }

        // Check to see if MediaPipelineId property is set
        internal bool IsSetMediaPipelineId()
        {
            return this._mediaPipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property S3RecordingSinkRuntimeConfiguration. 
        /// <para>
        /// The runtime configuration of the Amazon S3 bucket that stores recordings in a media
        /// insights pipeline.
        /// </para>
        /// </summary>
        public S3RecordingSinkRuntimeConfiguration S3RecordingSinkRuntimeConfiguration
        {
            get { return this._s3RecordingSinkRuntimeConfiguration; }
            set { this._s3RecordingSinkRuntimeConfiguration = value; }
        }

        // Check to see if S3RecordingSinkRuntimeConfiguration property is set
        internal bool IsSetS3RecordingSinkRuntimeConfiguration()
        {
            return this._s3RecordingSinkRuntimeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a media insights pipeline.
        /// </para>
        /// </summary>
        public MediaPipelineStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}