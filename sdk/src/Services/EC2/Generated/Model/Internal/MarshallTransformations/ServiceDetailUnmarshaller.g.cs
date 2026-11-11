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
    /// Response Unmarshaller for ServiceDetail Object
    /// </summary>
    public partial class ServiceDetailUnmarshaller : IXmlUnmarshaller<ServiceDetail, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ServiceDetail Unmarshall(XmlUnmarshallerContext context)
        {
            ServiceDetail unmarshalledObject = new ServiceDetail();
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
                    if (context.TestExpression("acceptanceRequired", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AcceptanceRequired = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("availabilityZoneIdSet/item", targetDepth))
                    {
                        if (unmarshalledObject.AvailabilityZoneIds == null)
                        {
                            unmarshalledObject.AvailabilityZoneIds = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneIds.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("availabilityZoneSet/item", targetDepth))
                    {
                        if (unmarshalledObject.AvailabilityZones == null)
                        {
                            unmarshalledObject.AvailabilityZones = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZones.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("baseEndpointDnsNameSet/item", targetDepth))
                    {
                        if (unmarshalledObject.BaseEndpointDnsNames == null)
                        {
                            unmarshalledObject.BaseEndpointDnsNames = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BaseEndpointDnsNames.Add(unmarshaller.Unmarshall(context));
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

                    if (context.TestExpression("privateDnsNameVerificationState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsNameVerificationState = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("privateDnsNameSet/item", targetDepth))
                    {
                        if (unmarshalledObject.PrivateDnsNames == null)
                        {
                            unmarshalledObject.PrivateDnsNames = new List<PrivateDnsDetails>();
                        }
                        var unmarshaller = PrivateDnsDetailsUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsNames.Add(unmarshaller.Unmarshall(context));
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

                    if (context.TestExpression("serviceRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("serviceType/item", targetDepth))
                    {
                        if (unmarshalledObject.ServiceType == null)
                        {
                            unmarshalledObject.ServiceType = new List<ServiceTypeDetail>();
                        }
                        var unmarshaller = ServiceTypeDetailUnmarshaller.Instance;
                        unmarshalledObject.ServiceType.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("supportedIpAddressTypeSet/item", targetDepth))
                    {
                        if (unmarshalledObject.SupportedIpAddressTypes == null)
                        {
                            unmarshalledObject.SupportedIpAddressTypes = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SupportedIpAddressTypes.Add(unmarshaller.Unmarshall(context));
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
        public static ServiceDetailUnmarshaller Instance => _instance;
    }
}
