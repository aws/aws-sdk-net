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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MaxP95Performance Object
    /// </summary>  
    public class MaxP95PerformanceUnmarshaller : IUnmarshaller<MaxP95Performance, XmlUnmarshallerContext>, IUnmarshaller<MaxP95Performance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MaxP95Performance IUnmarshaller<MaxP95Performance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MaxP95Performance Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MaxP95Performance unmarshalledObject = new MaxP95Performance();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("IopsOther", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.IopsOther = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IopsRead", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.IopsRead = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IopsTotal", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.IopsTotal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IopsWrite", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.IopsWrite = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatencyOther", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LatencyOther = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatencyRead", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LatencyRead = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatencyWrite", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LatencyWrite = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThroughputOther", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ThroughputOther = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThroughputRead", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ThroughputRead = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThroughputTotal", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ThroughputTotal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThroughputWrite", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ThroughputWrite = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MaxP95PerformanceUnmarshaller _instance = new MaxP95PerformanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MaxP95PerformanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}