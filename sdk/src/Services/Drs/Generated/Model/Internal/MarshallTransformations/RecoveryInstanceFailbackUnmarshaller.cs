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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecoveryInstanceFailback Object
    /// </summary>  
    public class RecoveryInstanceFailbackUnmarshaller : IUnmarshaller<RecoveryInstanceFailback, XmlUnmarshallerContext>, IUnmarshaller<RecoveryInstanceFailback, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecoveryInstanceFailback IUnmarshaller<RecoveryInstanceFailback, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecoveryInstanceFailback Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RecoveryInstanceFailback unmarshalledObject = new RecoveryInstanceFailback();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentLastSeenByServiceDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentLastSeenByServiceDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("elapsedReplicationDuration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElapsedReplicationDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failbackClientID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailbackClientID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failbackClientLastSeenByServiceDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailbackClientLastSeenByServiceDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failbackInitiationTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailbackInitiationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failbackJobID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailbackJobID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failbackLaunchType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailbackLaunchType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failbackToOriginalServer", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.FailbackToOriginalServer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firstByteDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirstByteDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RecoveryInstanceFailbackUnmarshaller _instance = new RecoveryInstanceFailbackUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecoveryInstanceFailbackUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}