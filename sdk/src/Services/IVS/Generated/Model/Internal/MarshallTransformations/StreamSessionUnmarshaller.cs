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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IVS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StreamSession Object
    /// </summary>  
    public class StreamSessionUnmarshaller : IJsonUnmarshaller<StreamSession, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public StreamSession Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            StreamSession unmarshalledObject = new StreamSession();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("channel", targetDepth))
                {
                    var unmarshaller = ChannelUnmarshaller.Instance;
                    unmarshalledObject.Channel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("endTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ingestConfiguration", targetDepth))
                {
                    var unmarshaller = IngestConfigurationUnmarshaller.Instance;
                    unmarshalledObject.IngestConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ingestConfigurations", targetDepth))
                {
                    var unmarshaller = IngestConfigurationsUnmarshaller.Instance;
                    unmarshalledObject.IngestConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recordingConfiguration", targetDepth))
                {
                    var unmarshaller = RecordingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RecordingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("streamId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("truncatedEvents", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StreamEvent, StreamEventUnmarshaller>(StreamEventUnmarshaller.Instance);
                    unmarshalledObject.TruncatedEvents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StreamSessionUnmarshaller _instance = new StreamSessionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StreamSessionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}