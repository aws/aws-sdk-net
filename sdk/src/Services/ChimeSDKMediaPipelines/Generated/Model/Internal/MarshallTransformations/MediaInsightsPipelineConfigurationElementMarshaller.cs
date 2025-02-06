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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MediaInsightsPipelineConfigurationElement Marshaller
    /// </summary>
    public class MediaInsightsPipelineConfigurationElementMarshaller : IRequestMarshaller<MediaInsightsPipelineConfigurationElement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MediaInsightsPipelineConfigurationElement requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmazonTranscribeCallAnalyticsProcessorConfiguration())
            {
                context.Writer.WritePropertyName("AmazonTranscribeCallAnalyticsProcessorConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AmazonTranscribeCallAnalyticsProcessorConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonTranscribeCallAnalyticsProcessorConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAmazonTranscribeProcessorConfiguration())
            {
                context.Writer.WritePropertyName("AmazonTranscribeProcessorConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AmazonTranscribeProcessorConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonTranscribeProcessorConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisDataStreamSinkConfiguration())
            {
                context.Writer.WritePropertyName("KinesisDataStreamSinkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KinesisDataStreamSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisDataStreamSinkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLambdaFunctionSinkConfiguration())
            {
                context.Writer.WritePropertyName("LambdaFunctionSinkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LambdaFunctionSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaFunctionSinkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3RecordingSinkConfiguration())
            {
                context.Writer.WritePropertyName("S3RecordingSinkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = S3RecordingSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3RecordingSinkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnsTopicSinkConfiguration())
            {
                context.Writer.WritePropertyName("SnsTopicSinkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SnsTopicSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SnsTopicSinkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqsQueueSinkConfiguration())
            {
                context.Writer.WritePropertyName("SqsQueueSinkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SqsQueueSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SqsQueueSinkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetVoiceAnalyticsProcessorConfiguration())
            {
                context.Writer.WritePropertyName("VoiceAnalyticsProcessorConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = VoiceAnalyticsProcessorConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VoiceAnalyticsProcessorConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVoiceEnhancementSinkConfiguration())
            {
                context.Writer.WritePropertyName("VoiceEnhancementSinkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = VoiceEnhancementSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VoiceEnhancementSinkConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MediaInsightsPipelineConfigurationElementMarshaller Instance = new MediaInsightsPipelineConfigurationElementMarshaller();

    }
}