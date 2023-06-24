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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipeSourceManagedStreamingKafkaParameters Object
    /// </summary>  
    public class PipeSourceManagedStreamingKafkaParametersUnmarshaller : IUnmarshaller<PipeSourceManagedStreamingKafkaParameters, XmlUnmarshallerContext>, IUnmarshaller<PipeSourceManagedStreamingKafkaParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PipeSourceManagedStreamingKafkaParameters IUnmarshaller<PipeSourceManagedStreamingKafkaParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PipeSourceManagedStreamingKafkaParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PipeSourceManagedStreamingKafkaParameters unmarshalledObject = new PipeSourceManagedStreamingKafkaParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BatchSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BatchSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConsumerGroupID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConsumerGroupID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Credentials", targetDepth))
                {
                    var unmarshaller = MSKAccessCredentialsUnmarshaller.Instance;
                    unmarshalledObject.Credentials = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumBatchingWindowInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumBatchingWindowInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartingPosition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartingPosition = unmarshaller.Unmarshall(context);
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


        private static PipeSourceManagedStreamingKafkaParametersUnmarshaller _instance = new PipeSourceManagedStreamingKafkaParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipeSourceManagedStreamingKafkaParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}