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
    /// Response Unmarshaller for IpamRouteProtectionFinding Object
    /// </summary>  
    public class IpamRouteProtectionFindingUnmarshaller : IXmlUnmarshaller<IpamRouteProtectionFinding, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IpamRouteProtectionFinding Unmarshall(XmlUnmarshallerContext context)
        {
            IpamRouteProtectionFinding unmarshalledObject = new IpamRouteProtectionFinding();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("advertisementType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AdvertisementType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("asn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Asn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("cidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Cidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipamPoolId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamPoolId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkBorderGroup", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkBorderGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("poolId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PoolId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceOwnerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceOwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("roaSet/item", targetDepth))
                    {
                        var unmarshaller = IpamRouteOriginAuthorizationUnmarshaller.Instance;
                        if (unmarshalledObject.Roas == null)
                        {
                            unmarshalledObject.Roas = new List<IpamRouteOriginAuthorization>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Roas.Add(item);
                        continue;
                    }
                    if (context.TestExpression("roaSampleTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.RoaSampleTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("routeOverlapSet/item", targetDepth))
                    {
                        var unmarshaller = IpamRouteOverlapUnmarshaller.Instance;
                        if (unmarshalledObject.RouteOverlaps == null)
                        {
                            unmarshalledObject.RouteOverlaps = new List<IpamRouteOverlap>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RouteOverlaps.Add(item);
                        continue;
                    }
                    if (context.TestExpression("rpkiStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RpkiStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rpkiStrength", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RpkiStrength = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sampleTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.SampleTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
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

        private static IpamRouteProtectionFindingUnmarshaller _instance = new IpamRouteProtectionFindingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IpamRouteProtectionFindingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}