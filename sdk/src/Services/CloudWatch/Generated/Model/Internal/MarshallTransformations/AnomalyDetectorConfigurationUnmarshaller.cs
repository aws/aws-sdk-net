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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnomalyDetectorConfiguration Object
    /// </summary>  
    public class AnomalyDetectorConfigurationUnmarshaller : IXmlUnmarshaller<AnomalyDetectorConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AnomalyDetectorConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            AnomalyDetectorConfiguration unmarshalledObject = new AnomalyDetectorConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ExcludedTimeRanges/member", targetDepth))
                    {
                        var unmarshaller = RangeUnmarshaller.Instance;
                        if (unmarshalledObject.ExcludedTimeRanges == null)
                        {
                            unmarshalledObject.ExcludedTimeRanges = new List<Range>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ExcludedTimeRanges.Add(item);
                        continue;
                    }
                    if (context.TestExpression("MetricTimezone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MetricTimezone = unmarshaller.Unmarshall(context);
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

        private static AnomalyDetectorConfigurationUnmarshaller _instance = new AnomalyDetectorConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnomalyDetectorConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}