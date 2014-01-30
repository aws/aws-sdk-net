/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   InstanceAttribute Unmarshaller
     /// </summary>
    internal class InstanceAttributeUnmarshaller : IUnmarshaller<InstanceAttribute, XmlUnmarshallerContext>, IUnmarshaller<InstanceAttribute, JsonUnmarshallerContext> 
    {
        public InstanceAttribute Unmarshall(XmlUnmarshallerContext context) 
        {
            InstanceAttribute instanceAttribute = new InstanceAttribute();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        instanceAttribute.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceType/value", targetDepth))
                    {
                        instanceAttribute.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("kernel/value", targetDepth))
                    {
                        instanceAttribute.KernelId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ramdisk/value", targetDepth))
                    {
                        instanceAttribute.RamdiskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("userData/value", targetDepth))
                    {
                        instanceAttribute.UserData = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("disableApiTermination/value", targetDepth))
                    {
                        instanceAttribute.DisableApiTermination = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceInitiatedShutdownBehavior/value", targetDepth))
                    {
                        instanceAttribute.InstanceInitiatedShutdownBehavior = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("rootDeviceName/value", targetDepth))
                    {
                        instanceAttribute.RootDeviceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        instanceAttribute.BlockDeviceMappings.Add(InstanceBlockDeviceMappingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("productCodes/item", targetDepth))
                    {
                        instanceAttribute.ProductCodes.Add(ProductCodeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("ebsOptimized/value", targetDepth))
                    {
                        instanceAttribute.EbsOptimized = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("sriovNetSupport/value", targetDepth))
                    {
                        instanceAttribute.SriovNetSupport = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return instanceAttribute;
                }
            }
                        


            return instanceAttribute;
        }

        public InstanceAttribute Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InstanceAttributeUnmarshaller instance;

        public static InstanceAttributeUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InstanceAttributeUnmarshaller();

            return instance;
        }
    }
}
    
