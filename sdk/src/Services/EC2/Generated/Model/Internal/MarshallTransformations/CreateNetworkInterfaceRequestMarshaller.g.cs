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
    /// CreateNetworkInterface Request Marshaller
    /// </summary>
    public partial class CreateNetworkInterfaceRequestMarshaller : IMarshaller<IRequest, CreateNetworkInterfaceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkInterfaceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateNetworkInterfaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateNetworkInterface");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetConnectionTrackingSpecification())
            {
                if (publicRequest.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                {
                    request.Parameters.Add("ConnectionTrackingSpecification" + ".TcpEstablishedTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.TcpEstablishedTimeout.Value));
                }
                if (publicRequest.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                {
                    request.Parameters.Add("ConnectionTrackingSpecification" + ".UdpStreamTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.UdpStreamTimeout.Value));
                }
                if (publicRequest.ConnectionTrackingSpecification.IsSetUdpTimeout())
                {
                    request.Parameters.Add("ConnectionTrackingSpecification" + ".UdpTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.UdpTimeout.Value));
                }
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEnablePrimaryIpv6())
            {
                request.Parameters.Add("EnablePrimaryIpv6", StringUtils.FromBool(publicRequest.EnablePrimaryIpv6.Value));
            }
            if (publicRequest.IsSetGroups())
            {
                if (publicRequest.Groups.Count == 0)
                {
                    request.Parameters.Add("SecurityGroupId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Groups)
                    {
                        request.Parameters.Add("SecurityGroupId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetInterfaceType())
            {
                request.Parameters.Add("InterfaceType", StringUtils.FromString(publicRequest.InterfaceType));
            }
            if (publicRequest.IsSetIpv4PrefixCount())
            {
                request.Parameters.Add("Ipv4PrefixCount", StringUtils.FromInt(publicRequest.Ipv4PrefixCount.Value));
            }
            if (publicRequest.IsSetIpv4Prefixes())
            {
                if (publicRequest.Ipv4Prefixes.Count == 0)
                {
                    request.Parameters.Add("Ipv4Prefix", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Ipv4Prefixes)
                    {
                        if (item0.IsSetIpv4Prefix())
                        {
                            request.Parameters.Add("Ipv4Prefix" + "." + index0 + ".Ipv4Prefix", StringUtils.FromString(item0.Ipv4Prefix));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetIpv6AddressCount())
            {
                request.Parameters.Add("Ipv6AddressCount", StringUtils.FromInt(publicRequest.Ipv6AddressCount.Value));
            }
            if (publicRequest.IsSetIpv6Addresses())
            {
                if (publicRequest.Ipv6Addresses.Count == 0)
                {
                    request.Parameters.Add("Ipv6Addresses", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Ipv6Addresses)
                    {
                        if (item0.IsSetIpv6Address())
                        {
                            request.Parameters.Add("Ipv6Addresses" + "." + index0 + ".Ipv6Address", StringUtils.FromString(item0.Ipv6Address));
                        }
                        if (item0.IsSetIsPrimaryIpv6())
                        {
                            request.Parameters.Add("Ipv6Addresses" + "." + index0 + ".IsPrimaryIpv6", StringUtils.FromBool(item0.IsPrimaryIpv6.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetIpv6PrefixCount())
            {
                request.Parameters.Add("Ipv6PrefixCount", StringUtils.FromInt(publicRequest.Ipv6PrefixCount.Value));
            }
            if (publicRequest.IsSetIpv6Prefixes())
            {
                if (publicRequest.Ipv6Prefixes.Count == 0)
                {
                    request.Parameters.Add("Ipv6Prefix", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Ipv6Prefixes)
                    {
                        if (item0.IsSetIpv6Prefix())
                        {
                            request.Parameters.Add("Ipv6Prefix" + "." + index0 + ".Ipv6Prefix", StringUtils.FromString(item0.Ipv6Prefix));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetOperator())
            {
                if (publicRequest.Operator.IsSetPrincipal())
                {
                    request.Parameters.Add("Operator" + ".Principal", StringUtils.FromString(publicRequest.Operator.Principal));
                }
            }
            if (publicRequest.IsSetPrivateIpAddress())
            {
                request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(publicRequest.PrivateIpAddress));
            }
            if (publicRequest.IsSetPrivateIpAddresses())
            {
                if (publicRequest.PrivateIpAddresses.Count == 0)
                {
                    request.Parameters.Add("PrivateIpAddresses", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PrivateIpAddresses)
                    {
                        if (item0.IsSetPrimary())
                        {
                            request.Parameters.Add("PrivateIpAddresses" + "." + index0 + ".Primary", StringUtils.FromBool(item0.Primary.Value));
                        }
                        if (item0.IsSetPrivateIpAddress())
                        {
                            request.Parameters.Add("PrivateIpAddresses" + "." + index0 + ".PrivateIpAddress", StringUtils.FromString(item0.PrivateIpAddress));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSecondaryPrivateIpAddressCount())
            {
                request.Parameters.Add("SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequest.SecondaryPrivateIpAddressCount.Value));
            }
            if (publicRequest.IsSetSubnetId())
            {
                request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateNetworkInterfaceRequestMarshaller _instance = new();

        internal static CreateNetworkInterfaceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateNetworkInterfaceRequestMarshaller Instance => _instance;
    }
}
