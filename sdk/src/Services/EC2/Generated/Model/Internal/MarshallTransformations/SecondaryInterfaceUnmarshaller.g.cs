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
    /// Response Unmarshaller for SecondaryInterface Object
    /// </summary>
    public partial class SecondaryInterfaceUnmarshaller : IXmlUnmarshaller<SecondaryInterface, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SecondaryInterface Unmarshall(XmlUnmarshallerContext context)
        {
            SecondaryInterface unmarshalledObject = new SecondaryInterface();
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
                    if (context.TestExpression("attachment", targetDepth))
                    {
                        var unmarshaller = SecondaryInterfaceAttachmentUnmarshaller.Instance;
                        unmarshalledObject.Attachment = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("availabilityZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("macAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MacAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("privateIpv4AddressSet/item", targetDepth))
                    {
                        if (unmarshalledObject.PrivateIpv4Addresses == null)
                        {
                            unmarshalledObject.PrivateIpv4Addresses = new List<SecondaryInterfaceIpv4Address>();
                        }
                        var unmarshaller = SecondaryInterfaceIpv4AddressUnmarshaller.Instance;
                        unmarshalledObject.PrivateIpv4Addresses.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("secondaryInterfaceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecondaryInterfaceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("secondaryInterfaceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecondaryInterfaceId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("secondaryInterfaceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecondaryInterfaceType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("secondaryNetworkId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecondaryNetworkId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("secondaryNetworkType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecondaryNetworkType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("secondarySubnetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecondarySubnetId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("sourceDestCheck", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SourceDestCheck = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
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

        private static SecondaryInterfaceUnmarshaller _instance = new SecondaryInterfaceUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SecondaryInterfaceUnmarshaller Instance => _instance;
    }
}
