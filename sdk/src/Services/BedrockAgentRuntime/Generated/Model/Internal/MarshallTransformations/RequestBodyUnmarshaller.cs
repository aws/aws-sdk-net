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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RequestBody Object
    /// </summary>  
    public class RequestBodyUnmarshaller : IUnmarshaller<RequestBody, XmlUnmarshallerContext>, IUnmarshaller<RequestBody, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RequestBody IUnmarshaller<RequestBody, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RequestBody Unmarshall(JsonUnmarshallerContext context)
        {
            RequestBody unmarshalledObject = new RequestBody();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("content", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<Parameter>, StringUnmarshaller, ListUnmarshaller<Parameter, ParameterUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<Parameter, ParameterUnmarshaller>(ParameterUnmarshaller.Instance));
                    unmarshalledObject.Content = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RequestBodyUnmarshaller _instance = new RequestBodyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestBodyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}