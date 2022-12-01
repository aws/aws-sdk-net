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
    /// Response Unmarshaller for PipeSourceActiveMQBrokerParameters Object
    /// </summary>  
    public class PipeSourceActiveMQBrokerParametersUnmarshaller : IUnmarshaller<PipeSourceActiveMQBrokerParameters, XmlUnmarshallerContext>, IUnmarshaller<PipeSourceActiveMQBrokerParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PipeSourceActiveMQBrokerParameters IUnmarshaller<PipeSourceActiveMQBrokerParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PipeSourceActiveMQBrokerParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PipeSourceActiveMQBrokerParameters unmarshalledObject = new PipeSourceActiveMQBrokerParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BatchSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BatchSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Credentials", targetDepth))
                {
                    var unmarshaller = MQBrokerAccessCredentialsUnmarshaller.Instance;
                    unmarshalledObject.Credentials = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumBatchingWindowInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumBatchingWindowInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueueName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueueName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PipeSourceActiveMQBrokerParametersUnmarshaller _instance = new PipeSourceActiveMQBrokerParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipeSourceActiveMQBrokerParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}