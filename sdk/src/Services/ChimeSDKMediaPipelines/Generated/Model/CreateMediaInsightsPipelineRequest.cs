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
    /// Container for the parameters to the CreateMediaInsightsPipeline operation.
    /// Creates a media insights pipeline.
    /// </summary>
    public partial class CreateMediaInsightsPipelineRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        private string _clientRequestToken;
        private KinesisVideoStreamRecordingSourceRuntimeConfiguration _kinesisVideoStreamRecordingSourceRuntimeConfiguration;
        private KinesisVideoStreamSourceRuntimeConfiguration _kinesisVideoStreamSourceRuntimeConfiguration;
        private string _mediaInsightsPipelineConfigurationArn;
        private Dictionary<string, string> _mediaInsightsRuntimeMetadata = new Dictionary<string, string>();
        private S3RecordingSinkRuntimeConfiguration _s3RecordingSinkRuntimeConfiguration;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the media insights pipeline request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
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
        /// Gets and sets the property KinesisVideoStreamRecordingSourceRuntimeConfiguration.
        /// 
        /// <para>
        /// The runtime configuration for the Kinesis video recording stream source.
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
        /// The runtime configuration for the Kinesis video stream source of the media insights
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
        /// The ARN of the pipeline's configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
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
        /// The runtime metadata for the media insights pipeline. Consists of a key-value map
        /// of strings.
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
        /// Gets and sets the property S3RecordingSinkRuntimeConfiguration. 
        /// <para>
        /// The runtime configuration for the S3 recording sink.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}