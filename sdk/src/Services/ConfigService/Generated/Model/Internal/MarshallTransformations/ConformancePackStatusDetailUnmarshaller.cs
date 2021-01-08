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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConformancePackStatusDetail Object
    /// </summary>  
    public class ConformancePackStatusDetailUnmarshaller : IUnmarshaller<ConformancePackStatusDetail, XmlUnmarshallerContext>, IUnmarshaller<ConformancePackStatusDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConformancePackStatusDetail IUnmarshaller<ConformancePackStatusDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConformancePackStatusDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConformancePackStatusDetail unmarshalledObject = new ConformancePackStatusDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConformancePackArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConformancePackArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConformancePackId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConformancePackId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConformancePackName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConformancePackName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConformancePackState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConformancePackState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConformancePackStatusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConformancePackStatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateCompletedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateCompletedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateRequestedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateRequestedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StackArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StackArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConformancePackStatusDetailUnmarshaller _instance = new ConformancePackStatusDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConformancePackStatusDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}