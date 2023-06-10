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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAmazonTranscribeCallAnalyticsProcessorConfiguration())
            {
                context.Writer.WritePropertyName("AmazonTranscribeCallAnalyticsProcessorConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AmazonTranscribeCallAnalyticsProcessorConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonTranscribeCallAnalyticsProcessorConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAmazonTranscribeProcessorConfiguration())
            {
                context.Writer.WritePropertyName("AmazonTranscribeProcessorConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AmazonTranscribeProcessorConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonTranscribeProcessorConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesisDataStreamSinkConfiguration())
            {
                context.Writer.WritePropertyName("KinesisDataStreamSinkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisDataStreamSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisDataStreamSinkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLambdaFunctionSinkConfiguration())
            {
                context.Writer.WritePropertyName("LambdaFunctionSinkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = LambdaFunctionSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaFunctionSinkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3RecordingSinkConfiguration())
            {
                context.Writer.WritePropertyName("S3RecordingSinkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = S3RecordingSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3RecordingSinkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSnsTopicSinkConfiguration())
            {
                context.Writer.WritePropertyName("SnsTopicSinkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = SnsTopicSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SnsTopicSinkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSqsQueueSinkConfiguration())
            {
                context.Writer.WritePropertyName("SqsQueueSinkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = SqsQueueSinkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SqsQueueSinkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetVoiceAnalyticsProcessorConfiguration())
            {
                context.Writer.WritePropertyName("VoiceAnalyticsProcessorConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = VoiceAnalyticsProcessorConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VoiceAnalyticsProcessorConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MediaInsightsPipelineConfigurationElementMarshaller Instance = new MediaInsightsPipelineConfigurationElementMarshaller();

    }
}