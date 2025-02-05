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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FunctionResponse Object
    /// </summary>  
    public class FunctionResponseUnmarshaller : IJsonUnmarshaller<FunctionResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FunctionResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FunctionResponse unmarshalledObject = new FunctionResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("implementedBy", targetDepth))
                {
                    var unmarshaller = DataConnectorUnmarshaller.Instance;
                    unmarshalledObject.ImplementedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isInherited", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsInherited = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("requiredProperties", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RequiredProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scope = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FunctionResponseUnmarshaller _instance = new FunctionResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FunctionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}