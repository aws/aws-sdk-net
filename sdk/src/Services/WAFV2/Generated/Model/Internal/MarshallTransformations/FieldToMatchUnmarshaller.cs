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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FieldToMatch Object
    /// </summary>  
    public class FieldToMatchUnmarshaller : IUnmarshaller<FieldToMatch, XmlUnmarshallerContext>, IUnmarshaller<FieldToMatch, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FieldToMatch IUnmarshaller<FieldToMatch, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FieldToMatch Unmarshall(JsonUnmarshallerContext context)
        {
            FieldToMatch unmarshalledObject = new FieldToMatch();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllQueryArguments", targetDepth))
                {
                    var unmarshaller = AllQueryArgumentsUnmarshaller.Instance;
                    unmarshalledObject.AllQueryArguments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Body", targetDepth))
                {
                    var unmarshaller = BodyUnmarshaller.Instance;
                    unmarshalledObject.Body = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Cookies", targetDepth))
                {
                    var unmarshaller = CookiesUnmarshaller.Instance;
                    unmarshalledObject.Cookies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HeaderOrder", targetDepth))
                {
                    var unmarshaller = HeaderOrderUnmarshaller.Instance;
                    unmarshalledObject.HeaderOrder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Headers", targetDepth))
                {
                    var unmarshaller = HeadersUnmarshaller.Instance;
                    unmarshalledObject.Headers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JA3Fingerprint", targetDepth))
                {
                    var unmarshaller = JA3FingerprintUnmarshaller.Instance;
                    unmarshalledObject.JA3Fingerprint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JA4Fingerprint", targetDepth))
                {
                    var unmarshaller = JA4FingerprintUnmarshaller.Instance;
                    unmarshalledObject.JA4Fingerprint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JsonBody", targetDepth))
                {
                    var unmarshaller = JsonBodyUnmarshaller.Instance;
                    unmarshalledObject.JsonBody = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Method", targetDepth))
                {
                    var unmarshaller = MethodUnmarshaller.Instance;
                    unmarshalledObject.Method = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryString", targetDepth))
                {
                    var unmarshaller = QueryStringUnmarshaller.Instance;
                    unmarshalledObject.QueryString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SingleHeader", targetDepth))
                {
                    var unmarshaller = SingleHeaderUnmarshaller.Instance;
                    unmarshalledObject.SingleHeader = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SingleQueryArgument", targetDepth))
                {
                    var unmarshaller = SingleQueryArgumentUnmarshaller.Instance;
                    unmarshalledObject.SingleQueryArgument = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UriFragment", targetDepth))
                {
                    var unmarshaller = UriFragmentUnmarshaller.Instance;
                    unmarshalledObject.UriFragment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UriPath", targetDepth))
                {
                    var unmarshaller = UriPathUnmarshaller.Instance;
                    unmarshalledObject.UriPath = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FieldToMatchUnmarshaller _instance = new FieldToMatchUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FieldToMatchUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}