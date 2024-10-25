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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PatternToken Object
    /// </summary>  
    public class PatternTokenUnmarshaller : IUnmarshaller<PatternToken, XmlUnmarshallerContext>, IUnmarshaller<PatternToken, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PatternToken IUnmarshaller<PatternToken, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PatternToken Unmarshall(JsonUnmarshallerContext context)
        {
            PatternToken unmarshalledObject = new PatternToken();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("dynamicTokenPosition", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DynamicTokenPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enumerations", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance);
                    unmarshalledObject.Enumerations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inferredTokenName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InferredTokenName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isDynamic", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsDynamic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tokenString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TokenString = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PatternTokenUnmarshaller _instance = new PatternTokenUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PatternTokenUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}