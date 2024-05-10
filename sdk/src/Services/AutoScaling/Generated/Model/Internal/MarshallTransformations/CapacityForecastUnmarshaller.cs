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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CapacityForecast Object
    /// </summary>  
    public class CapacityForecastUnmarshaller : IUnmarshaller<CapacityForecast, XmlUnmarshallerContext>, IUnmarshaller<CapacityForecast, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CapacityForecast Unmarshall(XmlUnmarshallerContext context)
        {
            CapacityForecast unmarshalledObject = new CapacityForecast();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Timestamps/member", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        if (unmarshalledObject.Timestamps == null)
                        {
                            unmarshalledObject.Timestamps = new List<DateTime>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Timestamps.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Values/member", targetDepth))
                    {
                        var unmarshaller = DoubleUnmarshaller.Instance;
                        if (unmarshalledObject.Values == null)
                        {
                            unmarshalledObject.Values = new List<double>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Values.Add(item);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CapacityForecast Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static CapacityForecastUnmarshaller _instance = new CapacityForecastUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CapacityForecastUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}