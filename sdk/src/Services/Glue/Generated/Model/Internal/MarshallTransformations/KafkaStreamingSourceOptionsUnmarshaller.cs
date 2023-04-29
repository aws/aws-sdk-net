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
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KafkaStreamingSourceOptions Object
    /// </summary>  
    public class KafkaStreamingSourceOptionsUnmarshaller : IUnmarshaller<KafkaStreamingSourceOptions, XmlUnmarshallerContext>, IUnmarshaller<KafkaStreamingSourceOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KafkaStreamingSourceOptions IUnmarshaller<KafkaStreamingSourceOptions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KafkaStreamingSourceOptions Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            KafkaStreamingSourceOptions unmarshalledObject = new KafkaStreamingSourceOptions();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AddRecordTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddRecordTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Assign", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Assign = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BootstrapServers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapServers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Classification", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Classification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Delimiter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Delimiter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmitConsumerLagMetrics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmitConsumerLagMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndingOffsets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndingOffsets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeHeaders", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeHeaders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxOffsetsPerTrigger", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxOffsetsPerTrigger = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinPartitions", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinPartitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumRetries", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumRetries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PollTimeoutMs", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.PollTimeoutMs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryIntervalMs", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.RetryIntervalMs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityProtocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityProtocol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartingOffsets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartingOffsets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubscribePattern", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubscribePattern = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TopicName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TopicName = unmarshaller.Unmarshall(context);
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