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
    /// Response Unmarshaller for Image Object
    /// </summary>  
    public class ImageUnmarshaller : IXmlUnmarshaller<Image, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Image Unmarshall(XmlUnmarshallerContext context)
        {
            Image unmarshalledObject = new Image();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("architecture", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Architecture = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        var unmarshaller = BlockDeviceMappingUnmarshaller.Instance;
                        if (unmarshalledObject.BlockDeviceMappings == null)
                        {
                            unmarshalledObject.BlockDeviceMappings = new List<BlockDeviceMapping>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BlockDeviceMappings.Add(item);
                        continue;
                    }
                    if (context.TestExpression("bootMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BootMode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("creationDate", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deprecationTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeprecationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deregistrationProtection", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeregistrationProtection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enaSupport", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnaSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("hypervisor", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Hypervisor = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageLocation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageLocation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageOwnerAlias", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageOwnerAlias = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imdsSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImdsSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("kernelId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KernelId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastLaunchedTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LastLaunchedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageOwnerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("platform", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("platformDetails", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformDetails = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("isPublic", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Public = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ramdiskId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RamdiskId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rootDeviceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RootDeviceName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rootDeviceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RootDeviceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceInstanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceInstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sriovNetSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SriovNetSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("stateReason", targetDepth))
                    {
                        var unmarshaller = StateReasonUnmarshaller.Instance;
                        unmarshalledObject.StateReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("tpmSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TpmSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("usageOperation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UsageOperation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("virtualizationType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VirtualizationType = unmarshaller.Unmarshall(context);
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

        private static ImageUnmarshaller _instance = new ImageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}