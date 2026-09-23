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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A media pipeline that streams call analytics data.
    /// </summary>
    public partial class MediaInsightsPipeline
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the media insights pipeline was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ElementStatuses. 
        /// <para>
        /// The statuses that the elements in a media insights pipeline can have during data processing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaInsightsPipelineElementStatus> ElementStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaInsightsPipelineElementStatus>() : null;

        /// <summary>
        /// Checks to see if the ElementStatuses property is set.
        /// </summary>
        internal bool IsSetElementStatuses() => this.ElementStatuses != null && (this.ElementStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamRecordingSourceRuntimeConfiguration.
        /// 
        /// <para>
        /// The runtime configuration settings for a Kinesis recording video stream in a media
        /// insights pipeline.
        /// </para>
        /// </summary>
        public KinesisVideoStreamRecordingSourceRuntimeConfiguration KinesisVideoStreamRecordingSourceRuntimeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KinesisVideoStreamRecordingSourceRuntimeConfiguration property is set.
        /// </summary>
        internal bool IsSetKinesisVideoStreamRecordingSourceRuntimeConfiguration() => this.KinesisVideoStreamRecordingSourceRuntimeConfiguration != null;

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamSourceRuntimeConfiguration. 
        /// <para>
        /// The configuration settings for a Kinesis runtime video stream in a media insights
        /// pipeline.
        /// </para>
        /// </summary>
        public KinesisVideoStreamSourceRuntimeConfiguration KinesisVideoStreamSourceRuntimeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KinesisVideoStreamSourceRuntimeConfiguration property is set.
        /// </summary>
        internal bool IsSetKinesisVideoStreamSourceRuntimeConfiguration() => this.KinesisVideoStreamSourceRuntimeConfiguration != null;

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationArn. 
        /// <para>
        /// The ARN of a media insight pipeline's configuration settings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string MediaInsightsPipelineConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaInsightsPipelineConfigurationArn property is set.
        /// </summary>
        internal bool IsSetMediaInsightsPipelineConfigurationArn() => this.MediaInsightsPipelineConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property MediaInsightsRuntimeMetadata. 
        /// <para>
        /// The runtime metadata of a media insights pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> MediaInsightsRuntimeMetadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the MediaInsightsRuntimeMetadata property is set.
        /// </summary>
        internal bool IsSetMediaInsightsRuntimeMetadata() => this.MediaInsightsRuntimeMetadata != null && (this.MediaInsightsRuntimeMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MediaPipelineArn. 
        /// <para>
        /// The ARN of a media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string MediaPipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaPipelineArn property is set.
        /// </summary>
        internal bool IsSetMediaPipelineArn() => this.MediaPipelineArn != null;

        /// <summary>
        /// Gets and sets the property MediaPipelineId. 
        /// <para>
        /// The ID of a media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string MediaPipelineId { get; set; }

        /// <summary>
        /// Checks to see if the MediaPipelineId property is set.
        /// </summary>
        internal bool IsSetMediaPipelineId() => this.MediaPipelineId != null;

        /// <summary>
        /// Gets and sets the property S3RecordingSinkRuntimeConfiguration. 
        /// <para>
        /// The runtime configuration of the Amazon S3 bucket that stores recordings in a media
        /// insights pipeline.
        /// </para>
        /// </summary>
        public S3RecordingSinkRuntimeConfiguration S3RecordingSinkRuntimeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3RecordingSinkRuntimeConfiguration property is set.
        /// </summary>
        internal bool IsSetS3RecordingSinkRuntimeConfiguration() => this.S3RecordingSinkRuntimeConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a media insights pipeline.
        /// </para>
        /// </summary>
        public MediaPipelineStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
