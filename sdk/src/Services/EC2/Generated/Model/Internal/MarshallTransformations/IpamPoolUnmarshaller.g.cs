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
    /// Response Unmarshaller for IpamPool Object
    /// </summary>
    public partial class IpamPoolUnmarshaller : IXmlUnmarshaller<IpamPool, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public IpamPool Unmarshall(XmlUnmarshallerContext context)
        {
            IpamPool unmarshalledObject = new IpamPool();
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
                    if (context.TestExpression("addressFamily", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AddressFamily = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("allocationDefaultNetmaskLength", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AllocationDefaultNetmaskLength = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("allocationMaxNetmaskLength", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AllocationMaxNetmaskLength = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("allocationMinNetmaskLength", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AllocationMinNetmaskLength = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("allocationResourceTagSet/item", targetDepth))
                    {
                        if (unmarshalledObject.AllocationResourceTags == null)
                        {
                            unmarshalledObject.AllocationResourceTags = new List<IpamResourceTag>();
                        }
                        var unmarshaller = IpamResourceTagUnmarshaller.Instance;
                        unmarshalledObject.AllocationResourceTags.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("autoImport", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AutoImport = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("awsService", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AwsService = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamPoolArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamPoolArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamPoolId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamPoolId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamScopeArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamScopeArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipamScopeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamScopeType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("locale", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Locale = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("poolDepth", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.PoolDepth = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("publicIpSource", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublicIpSource = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("publiclyAdvertisable", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.PubliclyAdvertisable = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("sourceIpamPoolId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceIpamPoolId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("sourceResource", targetDepth))
                    {
                        var unmarshaller = IpamPoolSourceResourceUnmarshaller.Instance;
                        unmarshalledObject.SourceResource = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("stateMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StateMessage = unmarshaller.Unmarshall(context);
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

        private static IpamPoolUnmarshaller _instance = new IpamPoolUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static IpamPoolUnmarshaller Instance => _instance;
    }
}
