/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Transform
{
     /// <summary>
     ///   BlockDeviceMapping Unmarshaller
     /// </summary>
    internal class BlockDeviceMappingUnmarshaller : IUnmarshaller<BlockDeviceMapping, UnmarshallerContext> 
    {
        public BlockDeviceMapping Unmarshall(UnmarshallerContext context) 
        {
            BlockDeviceMapping blockDeviceMapping = new BlockDeviceMapping();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("VirtualName", targetDepth))
                    {
                        blockDeviceMapping.VirtualName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DeviceName", targetDepth))
                    {
                        blockDeviceMapping.DeviceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Ebs", targetDepth))
                    {
                        blockDeviceMapping.Ebs = EbsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return blockDeviceMapping;
                }
            }

            return blockDeviceMapping;
        }

        private static BlockDeviceMappingUnmarshaller instance;

        public static BlockDeviceMappingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new BlockDeviceMappingUnmarshaller();

            return instance;
        }
    }
}
    
