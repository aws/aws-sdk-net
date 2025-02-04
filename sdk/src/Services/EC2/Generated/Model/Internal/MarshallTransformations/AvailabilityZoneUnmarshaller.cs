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
    /// Response Unmarshaller for AvailabilityZone Object
    /// </summary>  
    public class AvailabilityZoneUnmarshaller : IXmlUnmarshaller<AvailabilityZone, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AvailabilityZone Unmarshall(XmlUnmarshallerContext context)
        {
            AvailabilityZone unmarshalledObject = new AvailabilityZone();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("groupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("messageSet/item", targetDepth))
                    {
                        var unmarshaller = AvailabilityZoneMessageUnmarshaller.Instance;
                        if (unmarshalledObject.Messages == null)
                        {
                            unmarshalledObject.Messages = new List<AvailabilityZoneMessage>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Messages.Add(item);
                        continue;
                    }
                    if (context.TestExpression("networkBorderGroup", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkBorderGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("optInStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptInStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("parentZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ParentZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("parentZoneName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ParentZoneName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("regionName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RegionName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("zoneState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("zoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("zoneName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ZoneName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("zoneType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ZoneType = unmarshaller.Unmarshall(context);
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

        private static AvailabilityZoneUnmarshaller _instance = new AvailabilityZoneUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AvailabilityZoneUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}