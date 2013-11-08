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
     ///   Image Unmarshaller
     /// </summary>
    internal class ImageUnmarshaller : IUnmarshaller<Image, XmlUnmarshallerContext>, IUnmarshaller<Image, JsonUnmarshallerContext> 
    {
        public Image Unmarshall(XmlUnmarshallerContext context) 
        {
            Image image = new Image();
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
                        image.ImageId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("imageLocation", targetDepth))
                    {
                        image.ImageLocation = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("imageState", targetDepth))
                    {
                        image.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("imageOwnerId", targetDepth))
                    {
                        image.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("isPublic", targetDepth))
                    {
                        image.Public = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("productCodes/item", targetDepth))
                    {
                        image.ProductCodes.Add(ProductCodeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("architecture", targetDepth))
                    {
                        image.Architecture = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("imageType", targetDepth))
                    {
                        image.ImageType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("kernelId", targetDepth))
                    {
                        image.KernelId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ramdiskId", targetDepth))
                    {
                        image.RamdiskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("platform", targetDepth))
                    {
                        image.Platform = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("stateReason", targetDepth))
                    {
                        image.StateReason = StateReasonUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("imageOwnerAlias", targetDepth))
                    {
                        image.ImageOwnerAlias = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("name", targetDepth))
                    {
                        image.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        image.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("rootDeviceType", targetDepth))
                    {
                        image.RootDeviceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("rootDeviceName", targetDepth))
                    {
                        image.RootDeviceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        image.BlockDeviceMappings.Add(BlockDeviceMappingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("virtualizationType", targetDepth))
                    {
                        image.VirtualizationType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        image.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("hypervisor", targetDepth))
                    {
                        image.Hypervisor = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return image;
                }
            }
                        


            return image;
        }

        public Image Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ImageUnmarshaller instance;

        public static ImageUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ImageUnmarshaller();

            return instance;
        }
    }
}
    
