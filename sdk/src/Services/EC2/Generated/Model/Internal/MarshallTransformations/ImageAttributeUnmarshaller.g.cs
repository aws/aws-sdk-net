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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImageAttribute Object
    /// </summary>
    public partial class ImageAttributeUnmarshaller : IXmlUnmarshaller<ImageAttribute, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ImageAttribute Unmarshall(XmlUnmarshallerContext context)
        {
            ImageAttribute unmarshalledObject = new ImageAttribute();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        if (unmarshalledObject.BlockDeviceMappings == null)
                        {
                            unmarshalledObject.BlockDeviceMappings = new List<BlockDeviceMapping>();
                        }
                        var unmarshaller = BlockDeviceMappingUnmarshaller.Instance;
                        unmarshalledObject.BlockDeviceMappings.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("bootMode/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BootMode = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("deregistrationProtection/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeregistrationProtection = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("description/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("imageId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("imdsSupport/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImdsSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("kernel/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KernelId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("lastLaunchedTime/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LastLaunchedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("launchPermission/item", targetDepth))
                    {
                        if (unmarshalledObject.LaunchPermissions == null)
                        {
                            unmarshalledObject.LaunchPermissions = new List<LaunchPermission>();
                        }
                        var unmarshaller = LaunchPermissionUnmarshaller.Instance;
                        unmarshalledObject.LaunchPermissions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("productCodes/item", targetDepth))
                    {
                        if (unmarshalledObject.ProductCodes == null)
                        {
                            unmarshalledObject.ProductCodes = new List<ProductCode>();
                        }
                        var unmarshaller = ProductCodeUnmarshaller.Instance;
                        unmarshalledObject.ProductCodes.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ramdisk/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RamdiskId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("sriovNetSupport/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SriovNetSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("tpmSupport/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TpmSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("uefiData/value", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UefiData = unmarshaller.Unmarshall(context);
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

        private static ImageAttributeUnmarshaller _instance = new ImageAttributeUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImageAttributeUnmarshaller Instance => _instance;
    }
}
