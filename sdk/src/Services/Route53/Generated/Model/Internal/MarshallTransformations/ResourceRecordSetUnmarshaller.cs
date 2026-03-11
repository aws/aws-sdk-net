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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceRecordSet Object
    /// </summary>  
    public partial class ResourceRecordSetUnmarshaller : IXmlUnmarshaller<ResourceRecordSet, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceRecordSet Unmarshall(XmlUnmarshallerContext context)
        {
            ResourceRecordSet unmarshalledObject = new ResourceRecordSet();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SetIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SetIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Weight", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.Weight = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Region", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GeoLocation", targetDepth))
                    {
                        var unmarshaller = GeoLocationUnmarshaller.Instance;
                        unmarshalledObject.GeoLocation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Failover", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Failover = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MultiValueAnswer", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.MultiValueAnswer = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TTL", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.TTL = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceRecords/ResourceRecord", targetDepth))
                    {
                        if (unmarshalledObject.ResourceRecords == null)
                        {
                            unmarshalledObject.ResourceRecords = new List<ResourceRecord>();
                        }
                        var unmarshaller = ResourceRecordUnmarshaller.Instance;
                        unmarshalledObject.ResourceRecords.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("AliasTarget", targetDepth))
                    {
                        var unmarshaller = AliasTargetUnmarshaller.Instance;
                        unmarshalledObject.AliasTarget = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HealthCheckId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TrafficPolicyInstanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficPolicyInstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CidrRoutingConfig", targetDepth))
                    {
                        var unmarshaller = CidrRoutingConfigUnmarshaller.Instance;
                        unmarshalledObject.CidrRoutingConfig = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GeoProximityLocation", targetDepth))
                    {
                        var unmarshaller = GeoProximityLocationUnmarshaller.Instance;
                        unmarshalledObject.GeoProximityLocation = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    XmlStructureUnmarshallCustomization(context, unmarshalledObject, targetDepth);
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, ResourceRecordSet unmarshalledObject, int targetDepth);

        private static ResourceRecordSetUnmarshaller _instance = new ResourceRecordSetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceRecordSetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}