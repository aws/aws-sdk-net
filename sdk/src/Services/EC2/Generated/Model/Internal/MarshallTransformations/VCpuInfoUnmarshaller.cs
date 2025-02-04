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
    /// Response Unmarshaller for VCpuInfo Object
    /// </summary>  
    public class VCpuInfoUnmarshaller : IXmlUnmarshaller<VCpuInfo, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VCpuInfo Unmarshall(XmlUnmarshallerContext context)
        {
            VCpuInfo unmarshalledObject = new VCpuInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("defaultCores", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DefaultCores = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("defaultThreadsPerCore", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DefaultThreadsPerCore = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("defaultVCpus", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DefaultVCpus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("validCores/item", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        if (unmarshalledObject.ValidCores == null)
                        {
                            unmarshalledObject.ValidCores = new List<int>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ValidCores.Add(item);
                        continue;
                    }
                    if (context.TestExpression("validThreadsPerCore/item", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        if (unmarshalledObject.ValidThreadsPerCore == null)
                        {
                            unmarshalledObject.ValidThreadsPerCore = new List<int>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ValidThreadsPerCore.Add(item);
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

        private static VCpuInfoUnmarshaller _instance = new VCpuInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VCpuInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}