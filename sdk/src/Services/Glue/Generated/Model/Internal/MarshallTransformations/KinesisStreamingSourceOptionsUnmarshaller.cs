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
    /// Response Unmarshaller for KinesisStreamingSourceOptions Object
    /// </summary>  
    public class KinesisStreamingSourceOptionsUnmarshaller : IUnmarshaller<KinesisStreamingSourceOptions, XmlUnmarshallerContext>, IUnmarshaller<KinesisStreamingSourceOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KinesisStreamingSourceOptions IUnmarshaller<KinesisStreamingSourceOptions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KinesisStreamingSourceOptions Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            KinesisStreamingSourceOptions unmarshalledObject = new KinesisStreamingSourceOptions();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AddIdleTimeBetweenReads", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AddIdleTimeBetweenReads = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AddRecordTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddRecordTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvoidEmptyBatches", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AvoidEmptyBatches = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Classification", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Classification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Delimiter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Delimiter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DescribeShardInterval", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DescribeShardInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmitConsumerLagMetrics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmitConsumerLagMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndpointUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdleTimeBetweenReadsInMs", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.IdleTimeBetweenReadsInMs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxFetchRecordsPerShard", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxFetchRecordsPerShard = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxFetchTimeInMs", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxFetchTimeInMs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxRecordPerRead", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxRecordPerRead = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxRetryIntervalMs", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxRetryIntervalMs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumRetries", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumRetries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryIntervalMs", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.RetryIntervalMs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleSessionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleSessionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartingPosition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartingPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static KinesisStreamingSourceOptionsUnmarshaller _instance = new KinesisStreamingSourceOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KinesisStreamingSourceOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}