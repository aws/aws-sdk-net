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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CacheSettings Object
    /// </summary>  
    public class CacheSettingsUnmarshaller : IJsonUnmarshaller<CacheSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CacheSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CacheSettings unmarshalledObject = new CacheSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("allowedHTTPMethods", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AllowedHTTPMethods = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cachedHTTPMethods", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CachedHTTPMethods = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("defaultTTL", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.DefaultTTL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("forwardedCookies", targetDepth))
                {
                    var unmarshaller = CookieObjectUnmarshaller.Instance;
                    unmarshalledObject.ForwardedCookies = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("forwardedHeaders", targetDepth))
                {
                    var unmarshaller = HeaderObjectUnmarshaller.Instance;
                    unmarshalledObject.ForwardedHeaders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("forwardedQueryStrings", targetDepth))
                {
                    var unmarshaller = QueryStringObjectUnmarshaller.Instance;
                    unmarshalledObject.ForwardedQueryStrings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maximumTTL", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.MaximumTTL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("minimumTTL", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.MinimumTTL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CacheSettingsUnmarshaller _instance = new CacheSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CacheSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}