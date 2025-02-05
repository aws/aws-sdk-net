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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IntegrationResponse Object
    /// </summary>  
    public class IntegrationResponseUnmarshaller : IJsonUnmarshaller<IntegrationResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public IntegrationResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            IntegrationResponse unmarshalledObject = new IntegrationResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("contentHandlingStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContentHandlingStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("integrationResponseId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntegrationResponseId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("integrationResponseKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntegrationResponseKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("responseParameters", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.ResponseParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("responseTemplates", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.ResponseTemplates = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("templateSelectionExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateSelectionExpression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IntegrationResponseUnmarshaller _instance = new IntegrationResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IntegrationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}