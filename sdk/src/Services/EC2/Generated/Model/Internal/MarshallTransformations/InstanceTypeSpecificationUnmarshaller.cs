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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceTypeSpecification Object
    /// </summary>  
    public class InstanceTypeSpecificationUnmarshaller : IXmlUnmarshaller<InstanceTypeSpecification, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceTypeSpecification Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceTypeSpecification unmarshalledObject = new InstanceTypeSpecification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("supportedInstanceTypeSet/item", targetDepth))
                    {
                        var unmarshaller = InstanceTypeItemUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedInstanceTypes == null)
                        {
                            unmarshalledObject.SupportedInstanceTypes = new List<InstanceTypeItem>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedInstanceTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("unsupportedInstanceTypeSet/item", targetDepth))
                    {
                        var unmarshaller = InstanceTypeItemUnmarshaller.Instance;
                        if (unmarshalledObject.UnsupportedInstanceTypes == null)
                        {
                            unmarshalledObject.UnsupportedInstanceTypes = new List<InstanceTypeItem>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.UnsupportedInstanceTypes.Add(item);
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

        private static InstanceTypeSpecificationUnmarshaller _instance = new InstanceTypeSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceTypeSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}