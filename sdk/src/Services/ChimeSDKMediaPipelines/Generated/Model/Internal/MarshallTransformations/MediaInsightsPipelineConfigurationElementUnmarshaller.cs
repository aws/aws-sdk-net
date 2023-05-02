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
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MediaInsightsPipelineConfigurationElement Object
    /// </summary>  
    public class MediaInsightsPipelineConfigurationElementUnmarshaller : IUnmarshaller<MediaInsightsPipelineConfigurationElement, XmlUnmarshallerContext>, IUnmarshaller<MediaInsightsPipelineConfigurationElement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MediaInsightsPipelineConfigurationElement IUnmarshaller<MediaInsightsPipelineConfigurationElement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MediaInsightsPipelineConfigurationElement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MediaInsightsPipelineConfigurationElement unmarshalledObject = new MediaInsightsPipelineConfigurationElement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmazonTranscribeCallAnalyticsProcessorConfiguration", targetDepth))
                {
                    var unmarshaller = AmazonTranscribeCallAnalyticsProcessorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AmazonTranscribeCallAnalyticsProcessorConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AmazonTranscribeProcessorConfiguration", targetDepth))
                {
                    var unmarshaller = AmazonTranscribeProcessorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AmazonTranscribeProcessorConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisDataStreamSinkConfiguration", targetDepth))
                {
                    var unmarshaller = KinesisDataStreamSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KinesisDataStreamSinkConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LambdaFunctionSinkConfiguration", targetDepth))
                {
                    var unmarshaller = LambdaFunctionSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionSinkConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3RecordingSinkConfiguration", targetDepth))
                {
                    var unmarshaller = S3RecordingSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3RecordingSinkConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnsTopicSinkConfiguration", targetDepth))
                {
                    var unmarshaller = SnsTopicSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SnsTopicSinkConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SqsQueueSinkConfiguration", targetDepth))
                {
                    var unmarshaller = SqsQueueSinkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SqsQueueSinkConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VoiceAnalyticsProcessorConfiguration", targetDepth))
                {
                    var unmarshaller = VoiceAnalyticsProcessorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VoiceAnalyticsProcessorConfiguration = unmarshaller.Unmarshall(context);
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