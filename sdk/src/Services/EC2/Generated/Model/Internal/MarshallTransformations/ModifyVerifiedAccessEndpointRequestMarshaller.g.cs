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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyVerifiedAccessEndpoint Request Marshaller
    /// </summary>
    public partial class ModifyVerifiedAccessEndpointRequestMarshaller : IMarshaller<IRequest, ModifyVerifiedAccessEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVerifiedAccessEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyVerifiedAccessEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyVerifiedAccessEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetCidrOptions())
            {
                if (publicRequest.CidrOptions.IsSetPortRanges())
                {
                    if (publicRequest.CidrOptions.PortRanges.Count == 0)
                    {
                        request.Parameters.Add("CidrOptions" + ".PortRange", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.CidrOptions.PortRanges)
                        {
                            if (item1.IsSetFromPort())
                            {
                                request.Parameters.Add("CidrOptions" + ".PortRange" + "." + index1 + ".FromPort", StringUtils.FromInt(item1.FromPort.Value));
                            }
                            if (item1.IsSetToPort())
                            {
                                request.Parameters.Add("CidrOptions" + ".PortRange" + "." + index1 + ".ToPort", StringUtils.FromInt(item1.ToPort.Value));
                            }
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetLoadBalancerOptions())
            {
                if (publicRequest.LoadBalancerOptions.IsSetPort())
                {
                    request.Parameters.Add("LoadBalancerOptions" + ".Port", StringUtils.FromInt(publicRequest.LoadBalancerOptions.Port.Value));
                }
                if (publicRequest.LoadBalancerOptions.IsSetPortRanges())
                {
                    if (publicRequest.LoadBalancerOptions.PortRanges.Count == 0)
                    {
                        request.Parameters.Add("LoadBalancerOptions" + ".PortRange", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LoadBalancerOptions.PortRanges)
                        {
                            if (item1.IsSetFromPort())
                            {
                                request.Parameters.Add("LoadBalancerOptions" + ".PortRange" + "." + index1 + ".FromPort", StringUtils.FromInt(item1.FromPort.Value));
                            }
                            if (item1.IsSetToPort())
                            {
                                request.Parameters.Add("LoadBalancerOptions" + ".PortRange" + "." + index1 + ".ToPort", StringUtils.FromInt(item1.ToPort.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LoadBalancerOptions.IsSetProtocol())
                {
                    request.Parameters.Add("LoadBalancerOptions" + ".Protocol", StringUtils.FromString(publicRequest.LoadBalancerOptions.Protocol));
                }
                if (publicRequest.LoadBalancerOptions.IsSetSubnetIds())
                {
                    if (publicRequest.LoadBalancerOptions.SubnetIds.Count == 0)
                    {
                        request.Parameters.Add("LoadBalancerOptions" + ".SubnetId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LoadBalancerOptions.SubnetIds)
                        {
                            request.Parameters.Add("LoadBalancerOptions" + ".SubnetId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetNetworkInterfaceOptions())
            {
                if (publicRequest.NetworkInterfaceOptions.IsSetPort())
                {
                    request.Parameters.Add("NetworkInterfaceOptions" + ".Port", StringUtils.FromInt(publicRequest.NetworkInterfaceOptions.Port.Value));
                }
                if (publicRequest.NetworkInterfaceOptions.IsSetPortRanges())
                {
                    if (publicRequest.NetworkInterfaceOptions.PortRanges.Count == 0)
                    {
                        request.Parameters.Add("NetworkInterfaceOptions" + ".PortRange", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.NetworkInterfaceOptions.PortRanges)
                        {
                            if (item1.IsSetFromPort())
                            {
                                request.Parameters.Add("NetworkInterfaceOptions" + ".PortRange" + "." + index1 + ".FromPort", StringUtils.FromInt(item1.FromPort.Value));
                            }
                            if (item1.IsSetToPort())
                            {
                                request.Parameters.Add("NetworkInterfaceOptions" + ".PortRange" + "." + index1 + ".ToPort", StringUtils.FromInt(item1.ToPort.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.NetworkInterfaceOptions.IsSetProtocol())
                {
                    request.Parameters.Add("NetworkInterfaceOptions" + ".Protocol", StringUtils.FromString(publicRequest.NetworkInterfaceOptions.Protocol));
                }
            }
            if (publicRequest.IsSetRdsOptions())
            {
                if (publicRequest.RdsOptions.IsSetPort())
                {
                    request.Parameters.Add("RdsOptions" + ".Port", StringUtils.FromInt(publicRequest.RdsOptions.Port.Value));
                }
                if (publicRequest.RdsOptions.IsSetRdsEndpoint())
                {
                    request.Parameters.Add("RdsOptions" + ".RdsEndpoint", StringUtils.FromString(publicRequest.RdsOptions.RdsEndpoint));
                }
                if (publicRequest.RdsOptions.IsSetSubnetIds())
                {
                    if (publicRequest.RdsOptions.SubnetIds.Count == 0)
                    {
                        request.Parameters.Add("RdsOptions" + ".SubnetId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.RdsOptions.SubnetIds)
                        {
                            request.Parameters.Add("RdsOptions" + ".SubnetId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetVerifiedAccessEndpointId())
            {
                request.Parameters.Add("VerifiedAccessEndpointId", StringUtils.FromString(publicRequest.VerifiedAccessEndpointId));
            }
            if (publicRequest.IsSetVerifiedAccessGroupId())
            {
                request.Parameters.Add("VerifiedAccessGroupId", StringUtils.FromString(publicRequest.VerifiedAccessGroupId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyVerifiedAccessEndpointRequestMarshaller _instance = new();

        internal static ModifyVerifiedAccessEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyVerifiedAccessEndpointRequestMarshaller Instance => _instance;
    }
}
