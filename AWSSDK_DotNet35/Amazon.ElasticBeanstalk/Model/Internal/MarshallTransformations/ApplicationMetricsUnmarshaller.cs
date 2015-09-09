/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ApplicationMetrics Object
    /// </summary>  
    public class ApplicationMetricsUnmarshaller : IUnmarshaller<ApplicationMetrics, XmlUnmarshallerContext>, IUnmarshaller<ApplicationMetrics, JsonUnmarshallerContext>
    {
        public ApplicationMetrics Unmarshall(XmlUnmarshallerContext context)
        {
            ApplicationMetrics unmarshalledObject = new ApplicationMetrics();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Latency", targetDepth))
                    {
                        var unmarshaller = LatencyUnmarshaller.Instance;
                        unmarshalledObject.Latency = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.RequestCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusCodes", targetDepth))
                    {
                        var unmarshaller = StatusCodesUnmarshaller.Instance;
                        unmarshalledObject.StatusCodes = unmarshaller.Unmarshall(context);
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

        public ApplicationMetrics Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ApplicationMetricsUnmarshaller _instance = new ApplicationMetricsUnmarshaller();        

        public static ApplicationMetricsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}