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
    /// ModifyVpcEndpoint Request Marshaller
    /// </summary>       
    public class ModifyVpcEndpointRequestMarshaller : IMarshaller<IRequest, ModifyVpcEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpcEndpointRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVpcEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVpcEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAddRouteTableIds())
                {
                    if (publicRequest.AddRouteTableIds.Count == 0)
                        request.Parameters.Add("AddRouteTableId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddRouteTableIds)
                         {
                             request.Parameters.Add("AddRouteTableId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAddSecurityGroupIds())
                {
                    if (publicRequest.AddSecurityGroupIds.Count == 0)
                        request.Parameters.Add("AddSecurityGroupId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddSecurityGroupIds)
                         {
                             request.Parameters.Add("AddSecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAddSubnetIds())
                {
                    if (publicRequest.AddSubnetIds.Count == 0)
                        request.Parameters.Add("AddSubnetId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddSubnetIds)
                         {
                             request.Parameters.Add("AddSubnetId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDnsOptions())
                {
                    if(publicRequest.DnsOptions.IsSetDnsRecordIpType())
                    {
                        request.Parameters.Add("DnsOptions" + "." + "DnsRecordIpType", StringUtils.FromString(publicRequest.DnsOptions.DnsRecordIpType));
                    }
                    if(publicRequest.DnsOptions.IsSetPrivateDnsOnlyForInboundResolverEndpoint())
                    {
                        request.Parameters.Add("DnsOptions" + "." + "PrivateDnsOnlyForInboundResolverEndpoint", StringUtils.FromBool(publicRequest.DnsOptions.PrivateDnsOnlyForInboundResolverEndpoint));
                    }
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetIpAddressType())
                {
                    request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
                }
                if(publicRequest.IsSetPolicyDocument())
                {
                    request.Parameters.Add("PolicyDocument", StringUtils.FromString(publicRequest.PolicyDocument));
                }
                if(publicRequest.IsSetPrivateDnsEnabled())
                {
                    request.Parameters.Add("PrivateDnsEnabled", StringUtils.FromBool(publicRequest.PrivateDnsEnabled));
                }
                if(publicRequest.IsSetRemoveRouteTableIds())
                {
                    if (publicRequest.RemoveRouteTableIds.Count == 0)
                        request.Parameters.Add("RemoveRouteTableId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveRouteTableIds)
                         {
                             request.Parameters.Add("RemoveRouteTableId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRemoveSecurityGroupIds())
                {
                    if (publicRequest.RemoveSecurityGroupIds.Count == 0)
                        request.Parameters.Add("RemoveSecurityGroupId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveSecurityGroupIds)
                         {
                             request.Parameters.Add("RemoveSecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRemoveSubnetIds())
                {
                    if (publicRequest.RemoveSubnetIds.Count == 0)
                        request.Parameters.Add("RemoveSubnetId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveSubnetIds)
                         {
                             request.Parameters.Add("RemoveSubnetId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetResetPolicy())
                {
                    request.Parameters.Add("ResetPolicy", StringUtils.FromBool(publicRequest.ResetPolicy));
                }
                if(publicRequest.IsSetSubnetConfigurations())
                {
                    if (publicRequest.SubnetConfigurations.Count == 0)
                        request.Parameters.Add("SubnetConfiguration", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SubnetConfigurations)
                         {
                            if(publicRequestlistValue.IsSetIpv4())
                            {
                                request.Parameters.Add("SubnetConfiguration" + "." + publicRequestlistValueIndex + "." + "Ipv4", StringUtils.FromString(publicRequestlistValue.Ipv4));
                            }
                            if(publicRequestlistValue.IsSetIpv6())
                            {
                                request.Parameters.Add("SubnetConfiguration" + "." + publicRequestlistValueIndex + "." + "Ipv6", StringUtils.FromString(publicRequestlistValue.Ipv6));
                            }
                            if(publicRequestlistValue.IsSetSubnetId())
                            {
                                request.Parameters.Add("SubnetConfiguration" + "." + publicRequestlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValue.SubnetId));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetVpcEndpointId())
                {
                    request.Parameters.Add("VpcEndpointId", StringUtils.FromString(publicRequest.VpcEndpointId));
                }
            }
            return request;
        }
                    private static ModifyVpcEndpointRequestMarshaller _instance = new ModifyVpcEndpointRequestMarshaller();        

        internal static ModifyVpcEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVpcEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}