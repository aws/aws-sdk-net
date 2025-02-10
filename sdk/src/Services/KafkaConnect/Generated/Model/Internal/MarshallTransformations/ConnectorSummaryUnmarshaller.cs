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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KafkaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.KafkaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConnectorSummary Object
    /// </summary>  
    public class ConnectorSummaryUnmarshaller : IJsonUnmarshaller<ConnectorSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ConnectorSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ConnectorSummary unmarshalledObject = new ConnectorSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("capacity", targetDepth))
                {
                    var unmarshaller = CapacityDescriptionUnmarshaller.Instance;
                    unmarshalledObject.Capacity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("connectorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("connectorDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("connectorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("connectorState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kafkaCluster", targetDepth))
                {
                    var unmarshaller = KafkaClusterDescriptionUnmarshaller.Instance;
                    unmarshalledObject.KafkaCluster = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kafkaClusterClientAuthentication", targetDepth))
                {
                    var unmarshaller = KafkaClusterClientAuthenticationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.KafkaClusterClientAuthentication = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kafkaClusterEncryptionInTransit", targetDepth))
                {
                    var unmarshaller = KafkaClusterEncryptionInTransitDescriptionUnmarshaller.Instance;
                    unmarshalledObject.KafkaClusterEncryptionInTransit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kafkaConnectVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KafkaConnectVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logDelivery", targetDepth))
                {
                    var unmarshaller = LogDeliveryDescriptionUnmarshaller.Instance;
                    unmarshalledObject.LogDelivery = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("plugins", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PluginDescription, PluginDescriptionUnmarshaller>(PluginDescriptionUnmarshaller.Instance);
                    unmarshalledObject.Plugins = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceExecutionRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceExecutionRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workerConfiguration", targetDepth))
                {
                    var unmarshaller = WorkerConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.WorkerConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConnectorSummaryUnmarshaller _instance = new ConnectorSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConnectorSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}