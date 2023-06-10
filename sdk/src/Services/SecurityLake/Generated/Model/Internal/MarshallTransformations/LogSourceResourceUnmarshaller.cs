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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LogSourceResource Object
    /// </summary>  
    public class LogSourceResourceUnmarshaller : IUnmarshaller<LogSourceResource, XmlUnmarshallerContext>, IUnmarshaller<LogSourceResource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LogSourceResource IUnmarshaller<LogSourceResource, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LogSourceResource Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LogSourceResource unmarshalledObject = new LogSourceResource();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("awsLogSource", targetDepth))
                {
                    var unmarshaller = AwsLogSourceResourceUnmarshaller.Instance;
                    unmarshalledObject.AwsLogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customLogSource", targetDepth))
                {
                    var unmarshaller = CustomLogSourceResourceUnmarshaller.Instance;
                    unmarshalledObject.CustomLogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LogSourceResourceUnmarshaller _instance = new LogSourceResourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LogSourceResourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}