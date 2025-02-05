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
    /// Response Unmarshaller for MediaStreamPipeline Object
    /// </summary>  
    public class MediaStreamPipelineUnmarshaller : IJsonUnmarshaller<MediaStreamPipeline, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MediaStreamPipeline Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MediaStreamPipeline unmarshalledObject = new MediaStreamPipeline();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreatedTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MediaPipelineArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaPipelineArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MediaPipelineId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaPipelineId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Sinks", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MediaStreamSink, MediaStreamSinkUnmarshaller>(MediaStreamSinkUnmarshaller.Instance);
                    unmarshalledObject.Sinks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Sources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MediaStreamSource, MediaStreamSourceUnmarshaller>(MediaStreamSourceUnmarshaller.Instance);
                    unmarshalledObject.Sources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdatedTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MediaStreamPipelineUnmarshaller _instance = new MediaStreamPipelineUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MediaStreamPipelineUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}