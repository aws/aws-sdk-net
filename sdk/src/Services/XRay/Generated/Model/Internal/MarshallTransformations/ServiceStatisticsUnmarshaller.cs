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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceStatistics Object
    /// </summary>  
    public class ServiceStatisticsUnmarshaller : IUnmarshaller<ServiceStatistics, XmlUnmarshallerContext>, IUnmarshaller<ServiceStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceStatistics IUnmarshaller<ServiceStatistics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServiceStatistics Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ServiceStatistics unmarshalledObject = new ServiceStatistics();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ErrorStatistics", targetDepth))
                {
                    var unmarshaller = ErrorStatisticsUnmarshaller.Instance;
                    unmarshalledObject.ErrorStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FaultStatistics", targetDepth))
                {
                    var unmarshaller = FaultStatisticsUnmarshaller.Instance;
                    unmarshalledObject.FaultStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OkCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.OkCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalResponseTime", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.TotalResponseTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ServiceStatisticsUnmarshaller _instance = new ServiceStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}