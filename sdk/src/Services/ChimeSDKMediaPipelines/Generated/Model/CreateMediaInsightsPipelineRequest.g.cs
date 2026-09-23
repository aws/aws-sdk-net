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
    /// Container for the parameters to the CreateMediaInsightsPipeline operation. Creates
    /// a media insights pipeline.
    /// </summary>
    public partial class CreateMediaInsightsPipelineRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the media insights pipeline request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamRecordingSourceRuntimeConfiguration.
        /// 
        /// <para>
        /// The runtime configuration for the Kinesis video recording stream source.
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
        /// The runtime configuration for the Kinesis video stream source of the media insights
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
        /// The ARN of the pipeline's configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string MediaInsightsPipelineConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaInsightsPipelineConfigurationArn property is set.
        /// </summary>
        internal bool IsSetMediaInsightsPipelineConfigurationArn() => this.MediaInsightsPipelineConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property MediaInsightsRuntimeMetadata. 
        /// <para>
        /// The runtime metadata for the media insights pipeline. Consists of a key-value map
        /// of strings.
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
        /// Gets and sets the property S3RecordingSinkRuntimeConfiguration. 
        /// <para>
        /// The runtime configuration for the S3 recording sink. If specified, the settings in
        /// this structure override any settings in <c>S3RecordingSinkConfiguration</c>.
        /// </para>
        /// </summary>
        public S3RecordingSinkRuntimeConfiguration S3RecordingSinkRuntimeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3RecordingSinkRuntimeConfiguration property is set.
        /// </summary>
        internal bool IsSetS3RecordingSinkRuntimeConfiguration() => this.S3RecordingSinkRuntimeConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the media insights pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
