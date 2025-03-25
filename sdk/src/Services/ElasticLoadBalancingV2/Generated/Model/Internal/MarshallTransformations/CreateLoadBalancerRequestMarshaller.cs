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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLoadBalancer Request Marshaller
    /// </summary>       
    public class CreateLoadBalancerRequestMarshaller : IMarshaller<IRequest, CreateLoadBalancerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLoadBalancerRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLoadBalancerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "CreateLoadBalancer");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCustomerOwnedIpv4Pool())
                {
                    request.Parameters.Add("CustomerOwnedIpv4Pool", StringUtils.FromString(publicRequest.CustomerOwnedIpv4Pool));
                }
                if(publicRequest.IsSetEnablePrefixForIpv6SourceNat())
                {
                    request.Parameters.Add("EnablePrefixForIpv6SourceNat", StringUtils.FromString(publicRequest.EnablePrefixForIpv6SourceNat));
                }
                if(publicRequest.IsSetIpAddressType())
                {
                    request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
                }
                if(publicRequest.IsSetIpamPools())
                {
                    if(publicRequest.IpamPools.IsSetIpv4IpamPoolId())
                    {
                        request.Parameters.Add("IpamPools" + "." + "Ipv4IpamPoolId", StringUtils.FromString(publicRequest.IpamPools.Ipv4IpamPoolId));
                    }
                }
                if(publicRequest.IsSetName())
                {
                    request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
                }
                if(publicRequest.IsSetScheme())
                {
                    request.Parameters.Add("Scheme", StringUtils.FromString(publicRequest.Scheme));
                }
                if(publicRequest.IsSetSecurityGroups())
                {
                    if (publicRequest.SecurityGroups.Count == 0)
                        request.Parameters.Add("SecurityGroups", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroups)
                         {
                             request.Parameters.Add("SecurityGroups" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSubnetMappings())
                {
                    if (publicRequest.SubnetMappings.Count == 0)
                        request.Parameters.Add("SubnetMappings", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SubnetMappings)
                         {
                            if(publicRequestlistValue.IsSetAllocationId())
                            {
                                request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AllocationId", StringUtils.FromString(publicRequestlistValue.AllocationId));
                            }
                            if(publicRequestlistValue.IsSetIPv6Address())
                            {
                                request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IPv6Address", StringUtils.FromString(publicRequestlistValue.IPv6Address));
                            }
                            if(publicRequestlistValue.IsSetPrivateIPv4Address())
                            {
                                request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "PrivateIPv4Address", StringUtils.FromString(publicRequestlistValue.PrivateIPv4Address));
                            }
                            if(publicRequestlistValue.IsSetSourceNatIpv6Prefix())
                            {
                                request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "SourceNatIpv6Prefix", StringUtils.FromString(publicRequestlistValue.SourceNatIpv6Prefix));
                            }
                            if(publicRequestlistValue.IsSetSubnetId())
                            {
                                request.Parameters.Add("SubnetMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValue.SubnetId));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSubnets())
                {
                    if (publicRequest.Subnets.Count == 0)
                        request.Parameters.Add("Subnets", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Subnets)
                         {
                             request.Parameters.Add("Subnets" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetType())
                {
                    request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
                }
            }
            return request;
        }
                    private static CreateLoadBalancerRequestMarshaller _instance = new CreateLoadBalancerRequestMarshaller();        

        internal static CreateLoadBalancerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLoadBalancerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}