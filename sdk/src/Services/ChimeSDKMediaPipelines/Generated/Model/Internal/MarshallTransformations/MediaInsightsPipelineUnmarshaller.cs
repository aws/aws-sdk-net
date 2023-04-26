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
    /// Response Unmarshaller for MediaInsightsPipeline Object
    /// </summary>  
    public class MediaInsightsPipelineUnmarshaller : IUnmarshaller<MediaInsightsPipeline, XmlUnmarshallerContext>, IUnmarshaller<MediaInsightsPipeline, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MediaInsightsPipeline IUnmarshaller<MediaInsightsPipeline, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MediaInsightsPipeline Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MediaInsightsPipeline unmarshalledObject = new MediaInsightsPipeline();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisVideoStreamRecordingSourceRuntimeConfiguration", targetDepth))
                {
                    var unmarshaller = KinesisVideoStreamRecordingSourceRuntimeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KinesisVideoStreamRecordingSourceRuntimeConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisVideoStreamSourceRuntimeConfiguration", targetDepth))
                {
                    var unmarshaller = KinesisVideoStreamSourceRuntimeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KinesisVideoStreamSourceRuntimeConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaInsightsPipelineConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaInsightsPipelineConfigurationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaInsightsRuntimeMetadata", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.MediaInsightsRuntimeMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaPipelineArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaPipelineArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaPipelineId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaPipelineId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3RecordingSinkRuntimeConfiguration", targetDepth))
                {
                    var unmarshaller = S3RecordingSinkRuntimeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3RecordingSinkRuntimeConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MediaInsightsPipelineUnmarshaller _instance = new MediaInsightsPipelineUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MediaInsightsPipelineUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}