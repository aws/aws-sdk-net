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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsApiGatewayMethodSettings Object
    /// </summary>  
    public class AwsApiGatewayMethodSettingsUnmarshaller : IUnmarshaller<AwsApiGatewayMethodSettings, XmlUnmarshallerContext>, IUnmarshaller<AwsApiGatewayMethodSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsApiGatewayMethodSettings IUnmarshaller<AwsApiGatewayMethodSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsApiGatewayMethodSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsApiGatewayMethodSettings unmarshalledObject = new AwsApiGatewayMethodSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CacheDataEncrypted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CacheDataEncrypted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CacheTtlInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CacheTtlInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CachingEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CachingEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataTraceEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DataTraceEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HttpMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HttpMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LoggingLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LoggingLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricsEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MetricsEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequireAuthorizationForCacheControl", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequireAuthorizationForCacheControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourcePath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourcePath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThrottlingBurstLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ThrottlingBurstLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThrottlingRateLimit", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ThrottlingRateLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnauthorizedCacheControlHeaderStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UnauthorizedCacheControlHeaderStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsApiGatewayMethodSettingsUnmarshaller _instance = new AwsApiGatewayMethodSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsApiGatewayMethodSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}