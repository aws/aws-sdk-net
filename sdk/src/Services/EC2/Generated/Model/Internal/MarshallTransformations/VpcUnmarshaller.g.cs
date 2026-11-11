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
    /// Response Unmarshaller for Vpc Object
    /// </summary>
    public partial class VpcUnmarshaller : IXmlUnmarshaller<Vpc, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Vpc Unmarshall(XmlUnmarshallerContext context)
        {
            Vpc unmarshalledObject = new Vpc();
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
                    if (context.TestExpression("blockPublicAccessStates", targetDepth))
                    {
                        var unmarshaller = BlockPublicAccessStatesUnmarshaller.Instance;
                        unmarshalledObject.BlockPublicAccessStates = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("cidrBlock", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CidrBlock = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("cidrBlockAssociationSet/item", targetDepth))
                    {
                        if (unmarshalledObject.CidrBlockAssociationSet == null)
                        {
                            unmarshalledObject.CidrBlockAssociationSet = new List<VpcCidrBlockAssociation>();
                        }
                        var unmarshaller = VpcCidrBlockAssociationUnmarshaller.Instance;
                        unmarshalledObject.CidrBlockAssociationSet.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("dhcpOptionsId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DhcpOptionsId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("encryptionControl", targetDepth))
                    {
                        var unmarshaller = VpcEncryptionControlUnmarshaller.Instance;
                        unmarshalledObject.EncryptionControl = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("instanceTenancy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceTenancy = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipv6CidrBlockAssociationSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Ipv6CidrBlockAssociationSet == null)
                        {
                            unmarshalledObject.Ipv6CidrBlockAssociationSet = new List<VpcIpv6CidrBlockAssociation>();
                        }
                        var unmarshaller = VpcIpv6CidrBlockAssociationUnmarshaller.Instance;
                        unmarshalledObject.Ipv6CidrBlockAssociationSet.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("isDefault", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsDefault = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
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

                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
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

        private static VpcUnmarshaller _instance = new VpcUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static VpcUnmarshaller Instance => _instance;
    }
}
