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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceQuotas.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceQuotas.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceQuota Object
    /// </summary>  
    public class ServiceQuotaUnmarshaller : IUnmarshaller<ServiceQuota, XmlUnmarshallerContext>, IUnmarshaller<ServiceQuota, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceQuota IUnmarshaller<ServiceQuota, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServiceQuota Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ServiceQuota unmarshalledObject = new ServiceQuota();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Adjustable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Adjustable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorReason", targetDepth))
                {
                    var unmarshaller = ErrorReasonUnmarshaller.Instance;
                    unmarshalledObject.ErrorReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GlobalQuota", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.GlobalQuota = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Period", targetDepth))
                {
                    var unmarshaller = QuotaPeriodUnmarshaller.Instance;
                    unmarshalledObject.Period = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuotaArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuotaArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuotaCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuotaCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuotaName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuotaName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Unit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsageMetric", targetDepth))
                {
                    var unmarshaller = MetricInfoUnmarshaller.Instance;
                    unmarshalledObject.UsageMetric = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Value", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Value = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ServiceQuotaUnmarshaller _instance = new ServiceQuotaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceQuotaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}