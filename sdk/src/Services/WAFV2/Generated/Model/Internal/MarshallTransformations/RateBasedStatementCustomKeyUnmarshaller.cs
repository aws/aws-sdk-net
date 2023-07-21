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

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RateBasedStatementCustomKey Object
    /// </summary>  
    public class RateBasedStatementCustomKeyUnmarshaller : IUnmarshaller<RateBasedStatementCustomKey, XmlUnmarshallerContext>, IUnmarshaller<RateBasedStatementCustomKey, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RateBasedStatementCustomKey IUnmarshaller<RateBasedStatementCustomKey, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RateBasedStatementCustomKey Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RateBasedStatementCustomKey unmarshalledObject = new RateBasedStatementCustomKey();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Cookie", targetDepth))
                {
                    var unmarshaller = RateLimitCookieUnmarshaller.Instance;
                    unmarshalledObject.Cookie = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForwardedIP", targetDepth))
                {
                    var unmarshaller = RateLimitForwardedIPUnmarshaller.Instance;
                    unmarshalledObject.ForwardedIP = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Header", targetDepth))
                {
                    var unmarshaller = RateLimitHeaderUnmarshaller.Instance;
                    unmarshalledObject.Header = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HTTPMethod", targetDepth))
                {
                    var unmarshaller = RateLimitHTTPMethodUnmarshaller.Instance;
                    unmarshalledObject.HTTPMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IP", targetDepth))
                {
                    var unmarshaller = RateLimitIPUnmarshaller.Instance;
                    unmarshalledObject.IP = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelNamespace", targetDepth))
                {
                    var unmarshaller = RateLimitLabelNamespaceUnmarshaller.Instance;
                    unmarshalledObject.LabelNamespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryArgument", targetDepth))
                {
                    var unmarshaller = RateLimitQueryArgumentUnmarshaller.Instance;
                    unmarshalledObject.QueryArgument = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryString", targetDepth))
                {
                    var unmarshaller = RateLimitQueryStringUnmarshaller.Instance;
                    unmarshalledObject.QueryString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UriPath", targetDepth))
                {
                    var unmarshaller = RateLimitUriPathUnmarshaller.Instance;
                    unmarshalledObject.UriPath = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RateBasedStatementCustomKeyUnmarshaller _instance = new RateBasedStatementCustomKeyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RateBasedStatementCustomKeyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}