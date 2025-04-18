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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceLevelIndicatorMetric Object
    /// </summary>  
    public class ServiceLevelIndicatorMetricUnmarshaller : IUnmarshaller<ServiceLevelIndicatorMetric, XmlUnmarshallerContext>, IUnmarshaller<ServiceLevelIndicatorMetric, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceLevelIndicatorMetric IUnmarshaller<ServiceLevelIndicatorMetric, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceLevelIndicatorMetric Unmarshall(JsonUnmarshallerContext context)
        {
            ServiceLevelIndicatorMetric unmarshalledObject = new ServiceLevelIndicatorMetric();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DependencyConfig", targetDepth))
                {
                    var unmarshaller = DependencyConfigUnmarshaller.Instance;
                    unmarshalledObject.DependencyConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyAttributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.KeyAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricDataQueries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricDataQuery, MetricDataQueryUnmarshaller>(MetricDataQueryUnmarshaller.Instance);
                    unmarshalledObject.MetricDataQueries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OperationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OperationName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceLevelIndicatorMetricUnmarshaller _instance = new ServiceLevelIndicatorMetricUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceLevelIndicatorMetricUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}