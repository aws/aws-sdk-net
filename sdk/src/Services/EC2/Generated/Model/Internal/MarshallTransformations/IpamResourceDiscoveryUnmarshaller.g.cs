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
    /// Response Unmarshaller for IpamResourceDiscovery Object
    /// </summary>
    public partial class IpamResourceDiscoveryUnmarshaller : IXmlUnmarshaller<IpamResourceDiscovery, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public IpamResourceDiscovery Unmarshall(XmlUnmarshallerContext context)
        {
            IpamResourceDiscovery unmarshalledObject = new IpamResourceDiscovery();
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
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamResourceDiscoveryArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamResourceDiscoveryArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamResourceDiscoveryId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamResourceDiscoveryId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamResourceDiscoveryRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamResourceDiscoveryRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("isDefault", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsDefault = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("operatingRegionSet/item", targetDepth))
                    {
                        if (unmarshalledObject.OperatingRegions == null)
                        {
                            unmarshalledObject.OperatingRegions = new List<IpamOperatingRegion>();
                        }
                        var unmarshaller = IpamOperatingRegionUnmarshaller.Instance;
                        unmarshalledObject.OperatingRegions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("organizationalUnitExclusionSet/item", targetDepth))
                    {
                        if (unmarshalledObject.OrganizationalUnitExclusions == null)
                        {
                            unmarshalledObject.OrganizationalUnitExclusions = new List<IpamOrganizationalUnitExclusion>();
                        }
                        var unmarshaller = IpamOrganizationalUnitExclusionUnmarshaller.Instance;
                        unmarshalledObject.OrganizationalUnitExclusions.Add(unmarshaller.Unmarshall(context));
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
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static IpamResourceDiscoveryUnmarshaller _instance = new IpamResourceDiscoveryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static IpamResourceDiscoveryUnmarshaller Instance => _instance;
    }
}
