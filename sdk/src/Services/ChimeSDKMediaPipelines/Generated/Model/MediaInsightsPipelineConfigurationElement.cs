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
    /// An element in a media insights pipeline configuration.
    /// </summary>
    public partial class MediaInsightsPipelineConfigurationElement
    {
        private AmazonTranscribeCallAnalyticsProcessorConfiguration _amazonTranscribeCallAnalyticsProcessorConfiguration;
        private AmazonTranscribeProcessorConfiguration _amazonTranscribeProcessorConfiguration;
        private KinesisDataStreamSinkConfiguration _kinesisDataStreamSinkConfiguration;
        private LambdaFunctionSinkConfiguration _lambdaFunctionSinkConfiguration;
        private S3RecordingSinkConfiguration _s3RecordingSinkConfiguration;
        private SnsTopicSinkConfiguration _snsTopicSinkConfiguration;
        private SqsQueueSinkConfiguration _sqsQueueSinkConfiguration;
        private MediaInsightsPipelineConfigurationElementType _type;
        private VoiceAnalyticsProcessorConfiguration _voiceAnalyticsProcessorConfiguration;

        /// <summary>
        /// Gets and sets the property AmazonTranscribeCallAnalyticsProcessorConfiguration. 
        /// <para>
        /// The analytics configuration settings for transcribing audio in a media insights pipeline
        /// configuration element.
        /// </para>
        /// </summary>
        public AmazonTranscribeCallAnalyticsProcessorConfiguration AmazonTranscribeCallAnalyticsProcessorConfiguration
        {
            get { return this._amazonTranscribeCallAnalyticsProcessorConfiguration; }
            set { this._amazonTranscribeCallAnalyticsProcessorConfiguration = value; }
        }

        // Check to see if AmazonTranscribeCallAnalyticsProcessorConfiguration property is set
        internal bool IsSetAmazonTranscribeCallAnalyticsProcessorConfiguration()
        {
            return this._amazonTranscribeCallAnalyticsProcessorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonTranscribeProcessorConfiguration. 
        /// <para>
        /// The transcription processor configuration settings in a media insights pipeline configuration
        /// element.
        /// </para>
        /// </summary>
        public AmazonTranscribeProcessorConfiguration AmazonTranscribeProcessorConfiguration
        {
            get { return this._amazonTranscribeProcessorConfiguration; }
            set { this._amazonTranscribeProcessorConfiguration = value; }
        }

        // Check to see if AmazonTranscribeProcessorConfiguration property is set
        internal bool IsSetAmazonTranscribeProcessorConfiguration()
        {
            return this._amazonTranscribeProcessorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisDataStreamSinkConfiguration. 
        /// <para>
        /// The configuration settings for the Kinesis Data Stream Sink in a media insights pipeline
        /// configuration element.
        /// </para>
        /// </summary>
        public KinesisDataStreamSinkConfiguration KinesisDataStreamSinkConfiguration
        {
            get { return this._kinesisDataStreamSinkConfiguration; }
            set { this._kinesisDataStreamSinkConfiguration = value; }
        }

        // Check to see if KinesisDataStreamSinkConfiguration property is set
        internal bool IsSetKinesisDataStreamSinkConfiguration()
        {
            return this._kinesisDataStreamSinkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionSinkConfiguration. 
        /// <para>
        /// The configuration settings for the Amazon Web Services Lambda sink in a media insights
        /// pipeline configuration element.
        /// </para>
        /// </summary>
        public LambdaFunctionSinkConfiguration LambdaFunctionSinkConfiguration
        {
            get { return this._lambdaFunctionSinkConfiguration; }
            set { this._lambdaFunctionSinkConfiguration = value; }
        }

        // Check to see if LambdaFunctionSinkConfiguration property is set
        internal bool IsSetLambdaFunctionSinkConfiguration()
        {
            return this._lambdaFunctionSinkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3RecordingSinkConfiguration. 
        /// <para>
        /// The configuration settings for the Amazon S3 recording bucket in a media insights
        /// pipeline configuration element.
        /// </para>
        /// </summary>
        public S3RecordingSinkConfiguration S3RecordingSinkConfiguration
        {
            get { return this._s3RecordingSinkConfiguration; }
            set { this._s3RecordingSinkConfiguration = value; }
        }

        // Check to see if S3RecordingSinkConfiguration property is set
        internal bool IsSetS3RecordingSinkConfiguration()
        {
            return this._s3RecordingSinkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicSinkConfiguration. 
        /// <para>
        /// The configuration settings for an SNS topic sink in a media insights pipeline configuration
        /// element.
        /// </para>
        /// </summary>
        public SnsTopicSinkConfiguration SnsTopicSinkConfiguration
        {
            get { return this._snsTopicSinkConfiguration; }
            set { this._snsTopicSinkConfiguration = value; }
        }

        // Check to see if SnsTopicSinkConfiguration property is set
        internal bool IsSetSnsTopicSinkConfiguration()
        {
            return this._snsTopicSinkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SqsQueueSinkConfiguration. 
        /// <para>
        /// The configuration settings for an SQS queue sink in a media insights pipeline configuration
        /// element.
        /// </para>
        /// </summary>
        public SqsQueueSinkConfiguration SqsQueueSinkConfiguration
        {
            get { return this._sqsQueueSinkConfiguration; }
            set { this._sqsQueueSinkConfiguration = value; }
        }

        // Check to see if SqsQueueSinkConfiguration property is set
        internal bool IsSetSqsQueueSinkConfiguration()
        {
            return this._sqsQueueSinkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The element type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaInsightsPipelineConfigurationElementType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceAnalyticsProcessorConfiguration. 
        /// <para>
        /// The voice analytics configuration settings in a media insights pipeline configuration
        /// element.
        /// </para>
        /// </summary>
        public VoiceAnalyticsProcessorConfiguration VoiceAnalyticsProcessorConfiguration
        {
            get { return this._voiceAnalyticsProcessorConfiguration; }
            set { this._voiceAnalyticsProcessorConfiguration = value; }
        }

        // Check to see if VoiceAnalyticsProcessorConfiguration property is set
        internal bool IsSetVoiceAnalyticsProcessorConfiguration()
        {
            return this._voiceAnalyticsProcessorConfiguration != null;
        }

    }
}