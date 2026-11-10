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
    /// Response Unmarshaller for ServiceConfiguration Object
    /// </summary>
    public partial class ServiceConfigurationUnmarshaller : IXmlUnmarshaller<ServiceConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ServiceConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            ServiceConfiguration unmarshalledObject = new ServiceConfiguration();
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

                    if (context.TestExpression("gatewayLoadBalancerArnSet/item", targetDepth))
                    {
                        if (unmarshalledObject.GatewayLoadBalancerArns == null)
                        {
                            unmarshalledObject.GatewayLoadBalancerArns = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GatewayLoadBalancerArns.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("managesVpcEndpoints", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ManagesVpcEndpoints = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("networkLoadBalancerArnSet/item", targetDepth))
                    {
                        if (unmarshalledObject.NetworkLoadBalancerArns == null)
                        {
                            unmarshalledObject.NetworkLoadBalancerArns = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkLoadBalancerArns.Add(unmarshaller.Unmarshall(context));
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

                    if (context.TestExpression("privateDnsNameConfiguration", targetDepth))
                    {
                        var unmarshaller = PrivateDnsNameConfigurationUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsNameConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("remoteAccessEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RemoteAccessEnabled = unmarshaller.Unmarshall(context);
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

                    if (context.TestExpression("serviceState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceState = unmarshaller.Unmarshall(context);
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

                    if (context.TestExpression("supportedRegionSet/item", targetDepth))
                    {
                        if (unmarshalledObject.SupportedRegions == null)
                        {
                            unmarshalledObject.SupportedRegions = new List<SupportedRegionDetail>();
                        }
                        var unmarshaller = SupportedRegionDetailUnmarshaller.Instance;
                        unmarshalledObject.SupportedRegions.Add(unmarshaller.Unmarshall(context));
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

        private static ServiceConfigurationUnmarshaller _instance = new ServiceConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ServiceConfigurationUnmarshaller Instance => _instance;
    }
}
