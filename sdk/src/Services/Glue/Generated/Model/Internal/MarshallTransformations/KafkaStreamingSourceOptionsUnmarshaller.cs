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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KafkaStreamingSourceOptions Object
    /// </summary>  
    public class KafkaStreamingSourceOptionsUnmarshaller : IJsonUnmarshaller<KafkaStreamingSourceOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public KafkaStreamingSourceOptions Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            KafkaStreamingSourceOptions unmarshalledObject = new KafkaStreamingSourceOptions();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AddRecordTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddRecordTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Assign", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Assign = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BootstrapServers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapServers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Classification", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Classification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectionName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Delimiter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Delimiter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EmitConsumerLagMetrics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmitConsumerLagMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndingOffsets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndingOffsets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IncludeHeaders", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeHeaders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxOffsetsPerTrigger", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.MaxOffsetsPerTrigger = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MinPartitions", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MinPartitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NumRetries", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NumRetries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PollTimeoutMs", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.PollTimeoutMs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RetryIntervalMs", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.RetryIntervalMs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecurityProtocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityProtocol = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartingOffsets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartingOffsets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartingTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartingTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubscribePattern", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubscribePattern = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TopicName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TopicName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static KafkaStreamingSourceOptionsUnmarshaller _instance = new KafkaStreamingSourceOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KafkaStreamingSourceOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}