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
    /// An element in a media insights pipeline configuration.
    /// </summary>
    public partial class MediaInsightsPipelineConfigurationElement
    {
        /// <summary>
        /// Gets and sets the property AmazonTranscribeCallAnalyticsProcessorConfiguration. 
        /// <para>
        /// The analytics configuration settings for transcribing audio in a media insights pipeline
        /// configuration element.
        /// </para>
        /// </summary>
        public AmazonTranscribeCallAnalyticsProcessorConfiguration AmazonTranscribeCallAnalyticsProcessorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AmazonTranscribeCallAnalyticsProcessorConfiguration property is set.
        /// </summary>
        internal bool IsSetAmazonTranscribeCallAnalyticsProcessorConfiguration() => this.AmazonTranscribeCallAnalyticsProcessorConfiguration != null;

        /// <summary>
        /// Gets and sets the property AmazonTranscribeProcessorConfiguration. 
        /// <para>
        /// The transcription processor configuration settings in a media insights pipeline configuration
        /// element.
        /// </para>
        /// </summary>
        public AmazonTranscribeProcessorConfiguration AmazonTranscribeProcessorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AmazonTranscribeProcessorConfiguration property is set.
        /// </summary>
        internal bool IsSetAmazonTranscribeProcessorConfiguration() => this.AmazonTranscribeProcessorConfiguration != null;

        /// <summary>
        /// Gets and sets the property KinesisDataStreamSinkConfiguration. 
        /// <para>
        /// The configuration settings for the Kinesis Data Stream Sink in a media insights pipeline
        /// configuration element.
        /// </para>
        /// </summary>
        public KinesisDataStreamSinkConfiguration KinesisDataStreamSinkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KinesisDataStreamSinkConfiguration property is set.
        /// </summary>
        internal bool IsSetKinesisDataStreamSinkConfiguration() => this.KinesisDataStreamSinkConfiguration != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionSinkConfiguration. 
        /// <para>
        /// The configuration settings for the Amazon Web Services Lambda sink in a media insights
        /// pipeline configuration element.
        /// </para>
        /// </summary>
        public LambdaFunctionSinkConfiguration LambdaFunctionSinkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionSinkConfiguration property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionSinkConfiguration() => this.LambdaFunctionSinkConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3RecordingSinkConfiguration. 
        /// <para>
        /// The configuration settings for the Amazon S3 recording bucket in a media insights
        /// pipeline configuration element.
        /// </para>
        /// </summary>
        public S3RecordingSinkConfiguration S3RecordingSinkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3RecordingSinkConfiguration property is set.
        /// </summary>
        internal bool IsSetS3RecordingSinkConfiguration() => this.S3RecordingSinkConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnsTopicSinkConfiguration. 
        /// <para>
        /// The configuration settings for an SNS topic sink in a media insights pipeline configuration
        /// element.
        /// </para>
        /// </summary>
        public SnsTopicSinkConfiguration SnsTopicSinkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicSinkConfiguration property is set.
        /// </summary>
        internal bool IsSetSnsTopicSinkConfiguration() => this.SnsTopicSinkConfiguration != null;

        /// <summary>
        /// Gets and sets the property SqsQueueSinkConfiguration. 
        /// <para>
        /// The configuration settings for an SQS queue sink in a media insights pipeline configuration
        /// element.
        /// </para>
        /// </summary>
        public SqsQueueSinkConfiguration SqsQueueSinkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SqsQueueSinkConfiguration property is set.
        /// </summary>
        internal bool IsSetSqsQueueSinkConfiguration() => this.SqsQueueSinkConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The element type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaInsightsPipelineConfigurationElementType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VoiceAnalyticsProcessorConfiguration. 
        /// <para>
        /// The voice analytics configuration settings in a media insights pipeline configuration
        /// element.
        /// </para>
        /// </summary>
        public VoiceAnalyticsProcessorConfiguration VoiceAnalyticsProcessorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VoiceAnalyticsProcessorConfiguration property is set.
        /// </summary>
        internal bool IsSetVoiceAnalyticsProcessorConfiguration() => this.VoiceAnalyticsProcessorConfiguration != null;

        /// <summary>
        /// Gets and sets the property VoiceEnhancementSinkConfiguration. 
        /// <para>
        /// The configuration settings for voice enhancement sink in a media insights pipeline
        /// configuration element.
        /// </para>
        /// </summary>
        public VoiceEnhancementSinkConfiguration VoiceEnhancementSinkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VoiceEnhancementSinkConfiguration property is set.
        /// </summary>
        internal bool IsSetVoiceEnhancementSinkConfiguration() => this.VoiceEnhancementSinkConfiguration != null;
    }
}
