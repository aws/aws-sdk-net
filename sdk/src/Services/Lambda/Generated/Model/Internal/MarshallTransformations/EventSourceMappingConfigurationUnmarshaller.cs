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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EventSourceMappingConfiguration Object
    /// </summary>  
    public class EventSourceMappingConfigurationUnmarshaller : IUnmarshaller<EventSourceMappingConfiguration, XmlUnmarshallerContext>, IUnmarshaller<EventSourceMappingConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EventSourceMappingConfiguration IUnmarshaller<EventSourceMappingConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EventSourceMappingConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EventSourceMappingConfiguration unmarshalledObject = new EventSourceMappingConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmazonManagedKafkaEventSourceConfig", targetDepth))
                {
                    var unmarshaller = AmazonManagedKafkaEventSourceConfigUnmarshaller.Instance;
                    unmarshalledObject.AmazonManagedKafkaEventSourceConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BatchSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BatchSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BisectBatchOnFunctionError", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.BisectBatchOnFunctionError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationConfig", targetDepth))
                {
                    var unmarshaller = DestinationConfigUnmarshaller.Instance;
                    unmarshalledObject.DestinationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventSourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventSourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterCriteria", targetDepth))
                {
                    var unmarshaller = FilterCriteriaUnmarshaller.Instance;
                    unmarshalledObject.FilterCriteria = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FunctionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FunctionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FunctionResponseTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FunctionResponseTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModified", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastProcessingResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastProcessingResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumBatchingWindowInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumBatchingWindowInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumRecordAgeInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumRecordAgeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumRetryAttempts", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumRetryAttempts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParallelizationFactor", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ParallelizationFactor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Queues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Queues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalingConfig", targetDepth))
                {
                    var unmarshaller = ScalingConfigUnmarshaller.Instance;
                    unmarshalledObject.ScalingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelfManagedEventSource", targetDepth))
                {
                    var unmarshaller = SelfManagedEventSourceUnmarshaller.Instance;
                    unmarshalledObject.SelfManagedEventSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelfManagedKafkaEventSourceConfig", targetDepth))
                {
                    var unmarshaller = SelfManagedKafkaEventSourceConfigUnmarshaller.Instance;
                    unmarshalledObject.SelfManagedKafkaEventSourceConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceAccessConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SourceAccessConfiguration, SourceAccessConfigurationUnmarshaller>(SourceAccessConfigurationUnmarshaller.Instance);
                    unmarshalledObject.SourceAccessConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartingPosition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartingPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartingPositionTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartingPositionTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateTransitionReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateTransitionReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Topics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Topics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TumblingWindowInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TumblingWindowInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UUID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UUID = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EventSourceMappingConfigurationUnmarshaller _instance = new EventSourceMappingConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EventSourceMappingConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}