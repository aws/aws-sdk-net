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
    /// Response Unmarshaller for TopicReplication Object
    /// </summary>  
    public class TopicReplicationUnmarshaller : IUnmarshaller<TopicReplication, XmlUnmarshallerContext>, IUnmarshaller<TopicReplication, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TopicReplication IUnmarshaller<TopicReplication, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TopicReplication Unmarshall(JsonUnmarshallerContext context)
        {
            TopicReplication unmarshalledObject = new TopicReplication();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("copyAccessControlListsForTopics", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyAccessControlListsForTopics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("copyTopicConfigurations", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTopicConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("detectAndCopyNewTopics", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DetectAndCopyNewTopics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startingPosition", targetDepth))
                {
                    var unmarshaller = ReplicationStartingPositionUnmarshaller.Instance;
                    unmarshalledObject.StartingPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("topicNameConfiguration", targetDepth))
                {
                    var unmarshaller = ReplicationTopicNameConfigurationUnmarshaller.Instance;
                    unmarshalledObject.TopicNameConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("topicsToExclude", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TopicsToExclude = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("topicsToReplicate", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TopicsToReplicate = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TopicReplicationUnmarshaller _instance = new TopicReplicationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TopicReplicationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}