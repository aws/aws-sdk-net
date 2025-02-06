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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MediaInsightsPipelineConfigurationElement Object
    /// </summary>  
    public class MediaInsightsPipelineConfigurationElementUnmarshaller : IJsonUnmarshaller<MediaInsightsPipelineConfigurationElement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MediaInsightsPipelineConfigurationElement Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MediaInsightsPipelineConfigurationElement unmarshalledObject = new MediaInsightsPipelineConfigurationElement();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AmazonTranscribeCallAnalyticsProcessorConfiguration", targetDepth))
                {
                    var unmarshaller = AmazonTranscribeCallAnalyticsProcessorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AmazonTranscribeCallAnalyticsProcessorConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AmazonTranscribeProcessorConfiguration", targetDepth))
                {
                    var unmarshaller = AmazonTranscribeProcessorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AmazonTranscribeProcessorConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KinesisDataStreamSinkConfiguration", targetDepth))
                {
                    var unmarshaller = KinesisDataStreamSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KinesisDataStreamSinkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LambdaFunctionSinkConfiguration", targetDepth))
                {
                    var unmarshaller = LambdaFunctionSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionSinkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3RecordingSinkConfiguration", targetDepth))
                {
                    var unmarshaller = S3RecordingSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3RecordingSinkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SnsTopicSinkConfiguration", targetDepth))
                {
                    var unmarshaller = SnsTopicSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SnsTopicSinkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SqsQueueSinkConfiguration", targetDepth))
                {
                    var unmarshaller = SqsQueueSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SqsQueueSinkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VoiceAnalyticsProcessorConfiguration", targetDepth))
                {
                    var unmarshaller = VoiceAnalyticsProcessorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VoiceAnalyticsProcessorConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VoiceEnhancementSinkConfiguration", targetDepth))
                {
                    var unmarshaller = VoiceEnhancementSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VoiceEnhancementSinkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MediaInsightsPipelineConfigurationElementUnmarshaller _instance = new MediaInsightsPipelineConfigurationElementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MediaInsightsPipelineConfigurationElementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}