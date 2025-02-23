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
    /// CreateVerifiedAccessEndpoint Request Marshaller
    /// </summary>       
    public class CreateVerifiedAccessEndpointRequestMarshaller : IMarshaller<IRequest, CreateVerifiedAccessEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVerifiedAccessEndpointRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVerifiedAccessEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateVerifiedAccessEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationDomain())
                {
                    request.Parameters.Add("ApplicationDomain", StringUtils.FromString(publicRequest.ApplicationDomain));
                }
                if(publicRequest.IsSetAttachmentType())
                {
                    request.Parameters.Add("AttachmentType", StringUtils.FromString(publicRequest.AttachmentType));
                }
                if(publicRequest.IsSetCidrOptions())
                {
                    if(publicRequest.CidrOptions.IsSetCidr())
                    {
                        request.Parameters.Add("CidrOptions" + "." + "Cidr", StringUtils.FromString(publicRequest.CidrOptions.Cidr));
                    }
                    if(publicRequest.CidrOptions.IsSetPortRanges())
                    {
                        if (publicRequest.CidrOptions.PortRanges.Count == 0)
                            request.Parameters.Add("CidrOptions" + "." + "PortRange", "");
                        else
                        {
                             int publicRequestCidrOptionslistValueIndex = 1;
                             foreach(var publicRequestCidrOptionslistValue in publicRequest.CidrOptions.PortRanges)
                             {
                                if(publicRequestCidrOptionslistValue.IsSetFromPort())
                                {
                                    request.Parameters.Add("CidrOptions" + "." + "PortRange" + "." + publicRequestCidrOptionslistValueIndex + "." + "FromPort", StringUtils.FromInt(publicRequestCidrOptionslistValue.FromPort));
                                }
                                if(publicRequestCidrOptionslistValue.IsSetToPort())
                                {
                                    request.Parameters.Add("CidrOptions" + "." + "PortRange" + "." + publicRequestCidrOptionslistValueIndex + "." + "ToPort", StringUtils.FromInt(publicRequestCidrOptionslistValue.ToPort));
                                }
                                 publicRequestCidrOptionslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.CidrOptions.IsSetProtocol())
                    {
                        request.Parameters.Add("CidrOptions" + "." + "Protocol", StringUtils.FromString(publicRequest.CidrOptions.Protocol));
                    }
                    if(publicRequest.CidrOptions.IsSetSubnetIds())
                    {
                        if (publicRequest.CidrOptions.SubnetIds.Count == 0)
                            request.Parameters.Add("CidrOptions" + "." + "SubnetId", "");
                        else
                        {
                             int publicRequestCidrOptionslistValueIndex = 1;
                             foreach(var publicRequestCidrOptionslistValue in publicRequest.CidrOptions.SubnetIds)
                             {
                                 request.Parameters.Add("CidrOptions" + "." + "SubnetId" + "." + publicRequestCidrOptionslistValueIndex, StringUtils.FromString(publicRequestCidrOptionslistValue));
                                 publicRequestCidrOptionslistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDomainCertificateArn())
                {
                    request.Parameters.Add("DomainCertificateArn", StringUtils.FromString(publicRequest.DomainCertificateArn));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEndpointDomainPrefix())
                {
                    request.Parameters.Add("EndpointDomainPrefix", StringUtils.FromString(publicRequest.EndpointDomainPrefix));
                }
                if(publicRequest.IsSetEndpointType())
                {
                    request.Parameters.Add("EndpointType", StringUtils.FromString(publicRequest.EndpointType));
                }
                if(publicRequest.IsSetLoadBalancerOptions())
                {
                    if(publicRequest.LoadBalancerOptions.IsSetLoadBalancerArn())
                    {
                        request.Parameters.Add("LoadBalancerOptions" + "." + "LoadBalancerArn", StringUtils.FromString(publicRequest.LoadBalancerOptions.LoadBalancerArn));
                    }
                    if(publicRequest.LoadBalancerOptions.IsSetPort())
                    {
                        request.Parameters.Add("LoadBalancerOptions" + "." + "Port", StringUtils.FromInt(publicRequest.LoadBalancerOptions.Port));
                    }
                    if(publicRequest.LoadBalancerOptions.IsSetPortRanges())
                    {
                        if (publicRequest.LoadBalancerOptions.PortRanges.Count == 0)
                            request.Parameters.Add("LoadBalancerOptions" + "." + "PortRange", "");
                        else
                        {
                             int publicRequestLoadBalancerOptionslistValueIndex = 1;
                             foreach(var publicRequestLoadBalancerOptionslistValue in publicRequest.LoadBalancerOptions.PortRanges)
                             {
                                if(publicRequestLoadBalancerOptionslistValue.IsSetFromPort())
                                {
                                    request.Parameters.Add("LoadBalancerOptions" + "." + "PortRange" + "." + publicRequestLoadBalancerOptionslistValueIndex + "." + "FromPort", StringUtils.FromInt(publicRequestLoadBalancerOptionslistValue.FromPort));
                                }
                                if(publicRequestLoadBalancerOptionslistValue.IsSetToPort())
                                {
                                    request.Parameters.Add("LoadBalancerOptions" + "." + "PortRange" + "." + publicRequestLoadBalancerOptionslistValueIndex + "." + "ToPort", StringUtils.FromInt(publicRequestLoadBalancerOptionslistValue.ToPort));
                                }
                                 publicRequestLoadBalancerOptionslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.LoadBalancerOptions.IsSetProtocol())
                    {
                        request.Parameters.Add("LoadBalancerOptions" + "." + "Protocol", StringUtils.FromString(publicRequest.LoadBalancerOptions.Protocol));
                    }
                    if(publicRequest.LoadBalancerOptions.IsSetSubnetIds())
                    {
                        if (publicRequest.LoadBalancerOptions.SubnetIds.Count == 0)
                            request.Parameters.Add("LoadBalancerOptions" + "." + "SubnetId", "");
                        else
                        {
                             int publicRequestLoadBalancerOptionslistValueIndex = 1;
                             foreach(var publicRequestLoadBalancerOptionslistValue in publicRequest.LoadBalancerOptions.SubnetIds)
                             {
                                 request.Parameters.Add("LoadBalancerOptions" + "." + "SubnetId" + "." + publicRequestLoadBalancerOptionslistValueIndex, StringUtils.FromString(publicRequestLoadBalancerOptionslistValue));
                                 publicRequestLoadBalancerOptionslistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetNetworkInterfaceOptions())
                {
                    if(publicRequest.NetworkInterfaceOptions.IsSetNetworkInterfaceId())
                    {
                        request.Parameters.Add("NetworkInterfaceOptions" + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceOptions.NetworkInterfaceId));
                    }
                    if(publicRequest.NetworkInterfaceOptions.IsSetPort())
                    {
                        request.Parameters.Add("NetworkInterfaceOptions" + "." + "Port", StringUtils.FromInt(publicRequest.NetworkInterfaceOptions.Port));
                    }
                    if(publicRequest.NetworkInterfaceOptions.IsSetPortRanges())
                    {
                        if (publicRequest.NetworkInterfaceOptions.PortRanges.Count == 0)
                            request.Parameters.Add("NetworkInterfaceOptions" + "." + "PortRange", "");
                        else
                        {
                             int publicRequestNetworkInterfaceOptionslistValueIndex = 1;
                             foreach(var publicRequestNetworkInterfaceOptionslistValue in publicRequest.NetworkInterfaceOptions.PortRanges)
                             {
                                if(publicRequestNetworkInterfaceOptionslistValue.IsSetFromPort())
                                {
                                    request.Parameters.Add("NetworkInterfaceOptions" + "." + "PortRange" + "." + publicRequestNetworkInterfaceOptionslistValueIndex + "." + "FromPort", StringUtils.FromInt(publicRequestNetworkInterfaceOptionslistValue.FromPort));
                                }
                                if(publicRequestNetworkInterfaceOptionslistValue.IsSetToPort())
                                {
                                    request.Parameters.Add("NetworkInterfaceOptions" + "." + "PortRange" + "." + publicRequestNetworkInterfaceOptionslistValueIndex + "." + "ToPort", StringUtils.FromInt(publicRequestNetworkInterfaceOptionslistValue.ToPort));
                                }
                                 publicRequestNetworkInterfaceOptionslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.NetworkInterfaceOptions.IsSetProtocol())
                    {
                        request.Parameters.Add("NetworkInterfaceOptions" + "." + "Protocol", StringUtils.FromString(publicRequest.NetworkInterfaceOptions.Protocol));
                    }
                }
                if(publicRequest.IsSetPolicyDocument())
                {
                    request.Parameters.Add("PolicyDocument", StringUtils.FromString(publicRequest.PolicyDocument));
                }
                if(publicRequest.IsSetRdsOptions())
                {
                    if(publicRequest.RdsOptions.IsSetPort())
                    {
                        request.Parameters.Add("RdsOptions" + "." + "Port", StringUtils.FromInt(publicRequest.RdsOptions.Port));
                    }
                    if(publicRequest.RdsOptions.IsSetProtocol())
                    {
                        request.Parameters.Add("RdsOptions" + "." + "Protocol", StringUtils.FromString(publicRequest.RdsOptions.Protocol));
                    }
                    if(publicRequest.RdsOptions.IsSetRdsDbClusterArn())
                    {
                        request.Parameters.Add("RdsOptions" + "." + "RdsDbClusterArn", StringUtils.FromString(publicRequest.RdsOptions.RdsDbClusterArn));
                    }
                    if(publicRequest.RdsOptions.IsSetRdsDbInstanceArn())
                    {
                        request.Parameters.Add("RdsOptions" + "." + "RdsDbInstanceArn", StringUtils.FromString(publicRequest.RdsOptions.RdsDbInstanceArn));
                    }
                    if(publicRequest.RdsOptions.IsSetRdsDbProxyArn())
                    {
                        request.Parameters.Add("RdsOptions" + "." + "RdsDbProxyArn", StringUtils.FromString(publicRequest.RdsOptions.RdsDbProxyArn));
                    }
                    if(publicRequest.RdsOptions.IsSetRdsEndpoint())
                    {
                        request.Parameters.Add("RdsOptions" + "." + "RdsEndpoint", StringUtils.FromString(publicRequest.RdsOptions.RdsEndpoint));
                    }
                    if(publicRequest.RdsOptions.IsSetSubnetIds())
                    {
                        if (publicRequest.RdsOptions.SubnetIds.Count == 0)
                            request.Parameters.Add("RdsOptions" + "." + "SubnetId", "");
                        else
                        {
                             int publicRequestRdsOptionslistValueIndex = 1;
                             foreach(var publicRequestRdsOptionslistValue in publicRequest.RdsOptions.SubnetIds)
                             {
                                 request.Parameters.Add("RdsOptions" + "." + "SubnetId" + "." + publicRequestRdsOptionslistValueIndex, StringUtils.FromString(publicRequestRdsOptionslistValue));
                                 publicRequestRdsOptionslistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    if (publicRequest.SecurityGroupIds.Count == 0)
                        request.Parameters.Add("SecurityGroupId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                         {
                             request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSseSpecification())
                {
                    if(publicRequest.SseSpecification.IsSetCustomerManagedKeyEnabled())
                    {
                        request.Parameters.Add("SseSpecification" + "." + "CustomerManagedKeyEnabled", StringUtils.FromBool(publicRequest.SseSpecification.CustomerManagedKeyEnabled));
                    }
                    if(publicRequest.SseSpecification.IsSetKmsKeyArn())
                    {
                        request.Parameters.Add("SseSpecification" + "." + "KmsKeyArn", StringUtils.FromString(publicRequest.SseSpecification.KmsKeyArn));
                    }
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetVerifiedAccessGroupId())
                {
                    request.Parameters.Add("VerifiedAccessGroupId", StringUtils.FromString(publicRequest.VerifiedAccessGroupId));
                }
            }
            return request;
        }
                    private static CreateVerifiedAccessEndpointRequestMarshaller _instance = new CreateVerifiedAccessEndpointRequestMarshaller();        

        internal static CreateVerifiedAccessEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVerifiedAccessEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}