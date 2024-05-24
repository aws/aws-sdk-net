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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReplicatorSummary Object
    /// </summary>  
    public class ReplicatorSummaryUnmarshaller : IUnmarshaller<ReplicatorSummary, XmlUnmarshallerContext>, IUnmarshaller<ReplicatorSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReplicatorSummary IUnmarshaller<ReplicatorSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ReplicatorSummary Unmarshall(JsonUnmarshallerContext context)
        {
            ReplicatorSummary unmarshalledObject = new ReplicatorSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isReplicatorReference", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsReplicatorReference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kafkaClustersSummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KafkaClusterSummary, KafkaClusterSummaryUnmarshaller>(KafkaClusterSummaryUnmarshaller.Instance);
                    unmarshalledObject.KafkaClustersSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationInfoSummaryList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ReplicationInfoSummary, ReplicationInfoSummaryUnmarshaller>(ReplicationInfoSummaryUnmarshaller.Instance);
                    unmarshalledObject.ReplicationInfoSummaryList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicatorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicatorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicatorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicatorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicatorResourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicatorResourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicatorState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicatorState = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ReplicatorSummaryUnmarshaller _instance = new ReplicatorSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicatorSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}