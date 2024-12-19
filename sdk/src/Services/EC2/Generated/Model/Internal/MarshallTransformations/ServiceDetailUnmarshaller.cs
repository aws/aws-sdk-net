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
    /// Response Unmarshaller for ServiceDetail Object
    /// </summary>  
    public class ServiceDetailUnmarshaller : IXmlUnmarshaller<ServiceDetail, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServiceDetail Unmarshall(XmlUnmarshallerContext context)
        {
            ServiceDetail unmarshalledObject = new ServiceDetail();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("acceptanceRequired", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AcceptanceRequired = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("availabilityZoneSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AvailabilityZones == null)
                        {
                            unmarshalledObject.AvailabilityZones = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AvailabilityZones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("baseEndpointDnsNameSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.BaseEndpointDnsNames == null)
                        {
                            unmarshalledObject.BaseEndpointDnsNames = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BaseEndpointDnsNames.Add(item);
                        continue;
                    }
                    if (context.TestExpression("managesVpcEndpoints", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ManagesVpcEndpoints = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("owner", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Owner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("payerResponsibility", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PayerResponsibility = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateDnsName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateDnsNameSet/item", targetDepth))
                    {
                        var unmarshaller = PrivateDnsDetailsUnmarshaller.Instance;
                        if (unmarshalledObject.PrivateDnsNames == null)
                        {
                            unmarshalledObject.PrivateDnsNames = new List<PrivateDnsDetails>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PrivateDnsNames.Add(item);
                        continue;
                    }
                    if (context.TestExpression("privateDnsNameVerificationState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsNameVerificationState = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("serviceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("serviceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("serviceType/item", targetDepth))
                    {
                        var unmarshaller = ServiceTypeDetailUnmarshaller.Instance;
                        if (unmarshalledObject.ServiceType == null)
                        {
                            unmarshalledObject.ServiceType = new List<ServiceTypeDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ServiceType.Add(item);
                        continue;
                    }
                    if (context.TestExpression("supportedIpAddressTypeSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedIpAddressTypes == null)
                        {
                            unmarshalledObject.SupportedIpAddressTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedIpAddressTypes.Add(item);
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
                    if (context.TestExpression("vpcEndpointPolicySupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointPolicySupported = unmarshaller.Unmarshall(context);
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

        private static ServiceDetailUnmarshaller _instance = new ServiceDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}