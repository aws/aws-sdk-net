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
 * Do not modify this file. This file is generated from the restxmldataplane-1999-12-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MetricDataResult Object
    /// </summary>  
    public partial class MetricDataResultUnmarshaller : IXmlUnmarshaller<MetricDataResult, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MetricDataResult Unmarshall(XmlUnmarshallerContext context)
        {
            MetricDataResult unmarshalledObject = new MetricDataResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Id", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Label", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Label = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Messages/member", targetDepth))
                    {
                        if (unmarshalledObject.Messages == null)
                        {
                            unmarshalledObject.Messages = new List<MessageData>();
                        }
                        var unmarshaller = MessageDataUnmarshaller.Instance;
                        unmarshalledObject.Messages.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("StatusCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Timestamps/member", targetDepth))
                    {
                        if (unmarshalledObject.Timestamps == null)
                        {
                            unmarshalledObject.Timestamps = new List<DateTime>();
                        }
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.Timestamps.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("Values/member", targetDepth))
                    {
                        if (unmarshalledObject.Values == null)
                        {
                            unmarshalledObject.Values = new List<double>();
                        }
                        var unmarshaller = DoubleUnmarshaller.Instance;
                        unmarshalledObject.Values.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    XmlStructureUnmarshallCustomization(context, unmarshalledObject, targetDepth);
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, MetricDataResult unmarshalledObject, int targetDepth);

        private static MetricDataResultUnmarshaller _instance = new MetricDataResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetricDataResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}