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
     ///   ImageAttribute Unmarshaller
     /// </summary>
    internal class ImageAttributeUnmarshaller : IUnmarshaller<ImageAttribute, XmlUnmarshallerContext>, IUnmarshaller<ImageAttribute, JsonUnmarshallerContext> 
    {
        public ImageAttribute Unmarshall(XmlUnmarshallerContext context) 
        {
            ImageAttribute imageAttribute = new ImageAttribute();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("imageId", targetDepth))
                    {
                        imageAttribute.ImageId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("launchPermission/item", targetDepth))
                    {
                        imageAttribute.LaunchPermissions.Add(LaunchPermissionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("productCodes/item", targetDepth))
                    {
                        imageAttribute.ProductCodes.Add(ProductCodeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("kernel/value", targetDepth))
                    {
                        imageAttribute.KernelId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ramdisk/value", targetDepth))
                    {
                        imageAttribute.RamdiskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description/value", targetDepth))
                    {
                        imageAttribute.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("sriovNetSupport/value", targetDepth))
                    {
                        imageAttribute.SriovNetSupport = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        imageAttribute.BlockDeviceMappings.Add(BlockDeviceMappingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return imageAttribute;
                }
            }
                        


            return imageAttribute;
        }

        public ImageAttribute Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ImageAttributeUnmarshaller instance;

        public static ImageAttributeUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ImageAttributeUnmarshaller();

            return instance;
        }
    }
}
    
