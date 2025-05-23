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
    /// Response Unmarshaller for CpuPerformanceFactorRequest Object
    /// </summary>  
    public class CpuPerformanceFactorRequestUnmarshaller : IXmlUnmarshaller<CpuPerformanceFactorRequest, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CpuPerformanceFactorRequest Unmarshall(XmlUnmarshallerContext context)
        {
            CpuPerformanceFactorRequest unmarshalledObject = new CpuPerformanceFactorRequest();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Reference/item", targetDepth))
                    {
                        var unmarshaller = PerformanceFactorReferenceRequestUnmarshaller.Instance;
                        if (unmarshalledObject.References == null)
                        {
                            unmarshalledObject.References = new List<PerformanceFactorReferenceRequest>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.References.Add(item);
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

        private static CpuPerformanceFactorRequestUnmarshaller _instance = new CpuPerformanceFactorRequestUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CpuPerformanceFactorRequestUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}