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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Route Object
    /// </summary>  
    public class RouteUnmarshaller : IUnmarshaller<Route, XmlUnmarshallerContext>, IUnmarshaller<Route, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Route IUnmarshaller<Route, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Route Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Route unmarshalledObject = new Route();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("apiKeyRequired", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ApiKeyRequired = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorizationScopes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AuthorizationScopes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorizationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuthorizationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorizerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuthorizerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modelSelectionExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelSelectionExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("operationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OperationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestModels", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.RequestModels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ParameterConstraints, StringUnmarshaller, ParameterConstraintsUnmarshaller>(StringUnmarshaller.Instance, ParameterConstraintsUnmarshaller.Instance);
                    unmarshalledObject.RequestParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("routeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RouteId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("routeKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RouteKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("routeResponseSelectionExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RouteResponseSelectionExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("target", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Target = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RouteUnmarshaller _instance = new RouteUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}