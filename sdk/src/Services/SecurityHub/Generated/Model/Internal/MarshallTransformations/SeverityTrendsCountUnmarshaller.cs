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

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SeverityTrendsCount Object
    /// </summary>  
    public class SeverityTrendsCountUnmarshaller : IUnmarshaller<SeverityTrendsCount, XmlUnmarshallerContext>, IUnmarshaller<SeverityTrendsCount, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SeverityTrendsCount IUnmarshaller<SeverityTrendsCount, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SeverityTrendsCount Unmarshall(JsonUnmarshallerContext context)
        {
            SeverityTrendsCount unmarshalledObject = new SeverityTrendsCount();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Critical", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Critical = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Fatal", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Fatal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("High", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.High = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Informational", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Informational = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Low", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Low = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Medium", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Medium = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Other", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Other = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unknown", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Unknown = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SeverityTrendsCountUnmarshaller _instance = new SeverityTrendsCountUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SeverityTrendsCountUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}