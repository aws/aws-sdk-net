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
    /// Response Unmarshaller for InstanceAttribute Object
    /// </summary>  
    public class InstanceAttributeUnmarshaller : IXmlUnmarshaller<InstanceAttribute, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceAttribute Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceAttribute unmarshalledObject = new InstanceAttribute();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        var unmarshaller = InstanceBlockDeviceMappingUnmarshaller.Instance;
                        if (unmarshalledObject.BlockDeviceMappings == null)
                        {
                            unmarshalledObject.BlockDeviceMappings = new List<InstanceBlockDeviceMapping>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BlockDeviceMappings.Add(item);
                        continue;
                    }
                    if (context.TestExpression("disableApiStop/value", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.DisableApiStop = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("disableApiTermination/value", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.DisableApiTermination = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ebsOptimized/value", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EbsOptimized = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enaSupport/value", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnaSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enclaveOptions", targetDepth))
                    {
                        var unmarshaller = EnclaveOptionsUnmarshaller.Instance;
                        unmarshalledObject.EnclaveOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        var unmarshaller = GroupIdentifierUnmarshaller.Instance;
                        if (unmarshalledObject.Groups == null)
                        {
                            unmarshalledObject.Groups = new List<GroupIdentifier>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Groups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceInitiatedShutdownBehavior/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceInitiatedShutdownBehavior = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceType/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("kernel/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KernelId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("productCodes/item", targetDepth))
                    {
                        var unmarshaller = ProductCodeUnmarshaller.Instance;
                        if (unmarshalledObject.ProductCodes == null)
                        {
                            unmarshalledObject.ProductCodes = new List<ProductCode>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ProductCodes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ramdisk/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RamdiskId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rootDeviceName/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RootDeviceName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceDestCheck/value", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SourceDestCheck = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sriovNetSupport/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SriovNetSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("userData/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UserData = unmarshaller.Unmarshall(context);
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

        private static InstanceAttributeUnmarshaller _instance = new InstanceAttributeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceAttributeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}