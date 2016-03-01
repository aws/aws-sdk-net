/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MethodSetting Object
    /// </summary>  
    public class MethodSettingUnmarshaller : IUnmarshaller<MethodSetting, XmlUnmarshallerContext>, IUnmarshaller<MethodSetting, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MethodSetting IUnmarshaller<MethodSetting, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MethodSetting Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MethodSetting unmarshalledObject = new MethodSetting();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cacheDataEncrypted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CacheDataEncrypted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cacheTtlInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CacheTtlInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cachingEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CachingEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataTraceEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DataTraceEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loggingLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LoggingLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricsEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MetricsEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requireAuthorizationForCacheControl", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequireAuthorizationForCacheControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("throttlingBurstLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ThrottlingBurstLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("throttlingRateLimit", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ThrottlingRateLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unauthorizedCacheControlHeaderStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UnauthorizedCacheControlHeaderStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MethodSettingUnmarshaller _instance = new MethodSettingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MethodSettingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}