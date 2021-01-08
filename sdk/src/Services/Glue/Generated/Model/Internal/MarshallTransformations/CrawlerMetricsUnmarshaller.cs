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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CrawlerMetrics Object
    /// </summary>  
    public class CrawlerMetricsUnmarshaller : IUnmarshaller<CrawlerMetrics, XmlUnmarshallerContext>, IUnmarshaller<CrawlerMetrics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CrawlerMetrics IUnmarshaller<CrawlerMetrics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CrawlerMetrics Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CrawlerMetrics unmarshalledObject = new CrawlerMetrics();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CrawlerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CrawlerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastRuntimeSeconds", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LastRuntimeSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MedianRuntimeSeconds", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.MedianRuntimeSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StillEstimating", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.StillEstimating = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TablesCreated", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TablesCreated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TablesDeleted", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TablesDeleted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TablesUpdated", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TablesUpdated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeLeftSeconds", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.TimeLeftSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CrawlerMetricsUnmarshaller _instance = new CrawlerMetricsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CrawlerMetricsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}