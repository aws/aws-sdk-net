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
    /// CreateNetworkInterface Request Marshaller
    /// </summary>       
    public class CreateNetworkInterfaceRequestMarshaller : IMarshaller<IRequest, CreateNetworkInterfaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkInterfaceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNetworkInterfaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateNetworkInterface");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetConnectionTrackingSpecification())
                {
                    if(publicRequest.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                    {
                        request.Parameters.Add("ConnectionTrackingSpecification" + "." + "TcpEstablishedTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.TcpEstablishedTimeout));
                    }
                    if(publicRequest.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                    {
                        request.Parameters.Add("ConnectionTrackingSpecification" + "." + "UdpStreamTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.UdpStreamTimeout));
                    }
                    if(publicRequest.ConnectionTrackingSpecification.IsSetUdpTimeout())
                    {
                        request.Parameters.Add("ConnectionTrackingSpecification" + "." + "UdpTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.UdpTimeout));
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEnablePrimaryIpv6())
                {
                    request.Parameters.Add("EnablePrimaryIpv6", StringUtils.FromBool(publicRequest.EnablePrimaryIpv6));
                }
                if(publicRequest.IsSetGroups())
                {
                    if (publicRequest.Groups.Count == 0)
                        request.Parameters.Add("SecurityGroupId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Groups)
                         {
                             request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetInterfaceType())
                {
                    request.Parameters.Add("InterfaceType", StringUtils.FromString(publicRequest.InterfaceType));
                }
                if(publicRequest.IsSetIpv4PrefixCount())
                {
                    request.Parameters.Add("Ipv4PrefixCount", StringUtils.FromInt(publicRequest.Ipv4PrefixCount));
                }
                if(publicRequest.IsSetIpv4Prefixes())
                {
                    if (publicRequest.Ipv4Prefixes.Count == 0)
                        request.Parameters.Add("Ipv4Prefix", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Ipv4Prefixes)
                         {
                            if(publicRequestlistValue.IsSetIpv4Prefix())
                            {
                                request.Parameters.Add("Ipv4Prefix" + "." + publicRequestlistValueIndex + "." + "Ipv4Prefix", StringUtils.FromString(publicRequestlistValue.Ipv4Prefix));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetIpv6AddressCount())
                {
                    request.Parameters.Add("Ipv6AddressCount", StringUtils.FromInt(publicRequest.Ipv6AddressCount));
                }
                if(publicRequest.IsSetIpv6Addresses())
                {
                    if (publicRequest.Ipv6Addresses.Count == 0)
                        request.Parameters.Add("Ipv6Addresses", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Ipv6Addresses)
                         {
                            if(publicRequestlistValue.IsSetIpv6Address())
                            {
                                request.Parameters.Add("Ipv6Addresses" + "." + publicRequestlistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestlistValue.Ipv6Address));
                            }
                            if(publicRequestlistValue.IsSetIsPrimaryIpv6())
                            {
                                request.Parameters.Add("Ipv6Addresses" + "." + publicRequestlistValueIndex + "." + "IsPrimaryIpv6", StringUtils.FromBool(publicRequestlistValue.IsPrimaryIpv6));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetIpv6PrefixCount())
                {
                    request.Parameters.Add("Ipv6PrefixCount", StringUtils.FromInt(publicRequest.Ipv6PrefixCount));
                }
                if(publicRequest.IsSetIpv6Prefixes())
                {
                    if (publicRequest.Ipv6Prefixes.Count == 0)
                        request.Parameters.Add("Ipv6Prefix", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Ipv6Prefixes)
                         {
                            if(publicRequestlistValue.IsSetIpv6Prefix())
                            {
                                request.Parameters.Add("Ipv6Prefix" + "." + publicRequestlistValueIndex + "." + "Ipv6Prefix", StringUtils.FromString(publicRequestlistValue.Ipv6Prefix));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetOperator())
                {
                    if(publicRequest.Operator.IsSetPrincipal())
                    {
                        request.Parameters.Add("Operator" + "." + "Principal", StringUtils.FromString(publicRequest.Operator.Principal));
                    }
                }
                if(publicRequest.IsSetPrivateIpAddress())
                {
                    request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(publicRequest.PrivateIpAddress));
                }
                if(publicRequest.IsSetPrivateIpAddresses())
                {
                    if (publicRequest.PrivateIpAddresses.Count == 0)
                        request.Parameters.Add("PrivateIpAddresses", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.PrivateIpAddresses)
                         {
                            if(publicRequestlistValue.IsSetPrimary())
                            {
                                request.Parameters.Add("PrivateIpAddresses" + "." + publicRequestlistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestlistValue.Primary));
                            }
                            if(publicRequestlistValue.IsSetPrivateIpAddress())
                            {
                                request.Parameters.Add("PrivateIpAddresses" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestlistValue.PrivateIpAddress));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSecondaryPrivateIpAddressCount())
                {
                    request.Parameters.Add("SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequest.SecondaryPrivateIpAddressCount));
                }
                if(publicRequest.IsSetSubnetId())
                {
                    request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
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
            }
            return request;
        }
                    private static CreateNetworkInterfaceRequestMarshaller _instance = new CreateNetworkInterfaceRequestMarshaller();        

        internal static CreateNetworkInterfaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNetworkInterfaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}