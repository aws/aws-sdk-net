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

using Amazon.ElasticLoadBalancingV2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetSubnets Request Marshaller
    /// </summary>
    public partial class SetSubnetsRequestMarshaller : IMarshaller<IRequest, SetSubnetsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetSubnetsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SetSubnetsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SetSubnets");
            request.Parameters.Add("Version", "2015-12-01");

            if (publicRequest.IsSetEnablePrefixForIpv6SourceNat())
            {
                request.Parameters.Add("EnablePrefixForIpv6SourceNat", StringUtils.FromString(publicRequest.EnablePrefixForIpv6SourceNat));
            }
            if (publicRequest.IsSetIpAddressType())
            {
                request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
            }
            if (publicRequest.IsSetLoadBalancerArn())
            {
                request.Parameters.Add("LoadBalancerArn", StringUtils.FromString(publicRequest.LoadBalancerArn));
            }
            if (publicRequest.IsSetSubnetMappings())
            {
                if (publicRequest.SubnetMappings.Count == 0)
                {
                    request.Parameters.Add("SubnetMappings", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SubnetMappings)
                    {
                        if (item0.IsSetAllocationId())
                        {
                            request.Parameters.Add("SubnetMappings" + ".member" + "." + index0 + ".AllocationId", StringUtils.FromString(item0.AllocationId));
                        }
                        if (item0.IsSetIPv6Address())
                        {
                            request.Parameters.Add("SubnetMappings" + ".member" + "." + index0 + ".IPv6Address", StringUtils.FromString(item0.IPv6Address));
                        }
                        if (item0.IsSetPrivateIPv4Address())
                        {
                            request.Parameters.Add("SubnetMappings" + ".member" + "." + index0 + ".PrivateIPv4Address", StringUtils.FromString(item0.PrivateIPv4Address));
                        }
                        if (item0.IsSetSourceNatIpv6Prefix())
                        {
                            request.Parameters.Add("SubnetMappings" + ".member" + "." + index0 + ".SourceNatIpv6Prefix", StringUtils.FromString(item0.SourceNatIpv6Prefix));
                        }
                        if (item0.IsSetSubnetId())
                        {
                            request.Parameters.Add("SubnetMappings" + ".member" + "." + index0 + ".SubnetId", StringUtils.FromString(item0.SubnetId));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSubnets())
            {
                if (publicRequest.Subnets.Count == 0)
                {
                    request.Parameters.Add("Subnets", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Subnets)
                    {
                        request.Parameters.Add("Subnets" + ".member" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly SetSubnetsRequestMarshaller _instance = new();

        internal static SetSubnetsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SetSubnetsRequestMarshaller Instance => _instance;
    }
}
