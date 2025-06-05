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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RateBasedStatementCustomKey Object
    /// </summary>  
    public class RateBasedStatementCustomKeyUnmarshaller : IJsonUnmarshaller<RateBasedStatementCustomKey, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RateBasedStatementCustomKey Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RateBasedStatementCustomKey unmarshalledObject = new RateBasedStatementCustomKey();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ASN", targetDepth))
                {
                    var unmarshaller = RateLimitAsnUnmarshaller.Instance;
                    unmarshalledObject.ASN = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Cookie", targetDepth))
                {
                    var unmarshaller = RateLimitCookieUnmarshaller.Instance;
                    unmarshalledObject.Cookie = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ForwardedIP", targetDepth))
                {
                    var unmarshaller = RateLimitForwardedIPUnmarshaller.Instance;
                    unmarshalledObject.ForwardedIP = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Header", targetDepth))
                {
                    var unmarshaller = RateLimitHeaderUnmarshaller.Instance;
                    unmarshalledObject.Header = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HTTPMethod", targetDepth))
                {
                    var unmarshaller = RateLimitHTTPMethodUnmarshaller.Instance;
                    unmarshalledObject.HTTPMethod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IP", targetDepth))
                {
                    var unmarshaller = RateLimitIPUnmarshaller.Instance;
                    unmarshalledObject.IP = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JA3Fingerprint", targetDepth))
                {
                    var unmarshaller = RateLimitJA3FingerprintUnmarshaller.Instance;
                    unmarshalledObject.JA3Fingerprint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JA4Fingerprint", targetDepth))
                {
                    var unmarshaller = RateLimitJA4FingerprintUnmarshaller.Instance;
                    unmarshalledObject.JA4Fingerprint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LabelNamespace", targetDepth))
                {
                    var unmarshaller = RateLimitLabelNamespaceUnmarshaller.Instance;
                    unmarshalledObject.LabelNamespace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QueryArgument", targetDepth))
                {
                    var unmarshaller = RateLimitQueryArgumentUnmarshaller.Instance;
                    unmarshalledObject.QueryArgument = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QueryString", targetDepth))
                {
                    var unmarshaller = RateLimitQueryStringUnmarshaller.Instance;
                    unmarshalledObject.QueryString = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UriPath", targetDepth))
                {
                    var unmarshaller = RateLimitUriPathUnmarshaller.Instance;
                    unmarshalledObject.UriPath = unmarshaller.Unmarshall(context, ref reader);
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