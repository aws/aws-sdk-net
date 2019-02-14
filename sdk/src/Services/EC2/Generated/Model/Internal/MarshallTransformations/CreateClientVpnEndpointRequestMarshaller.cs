/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateClientVpnEndpoint Request Marshaller
    /// </summary>       
    public class CreateClientVpnEndpointRequestMarshaller : IMarshaller<IRequest, CreateClientVpnEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClientVpnEndpointRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateClientVpnEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateClientVpnEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAuthenticationOptions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.AuthenticationOptions)
                    {
                        if(publicRequestlistValue.IsSetActiveDirectory())
                        {
                            if(publicRequestlistValue.ActiveDirectory.IsSetDirectoryId())
                            {
                                request.Parameters.Add("Authentication" + "." + publicRequestlistValueIndex + "." + "ActiveDirectory" + "." + "DirectoryId", StringUtils.FromString(publicRequestlistValue.ActiveDirectory.DirectoryId));
                            }
                        }
                        if(publicRequestlistValue.IsSetMutualAuthentication())
                        {
                            if(publicRequestlistValue.MutualAuthentication.IsSetClientRootCertificateChainArn())
                            {
                                request.Parameters.Add("Authentication" + "." + publicRequestlistValueIndex + "." + "MutualAuthentication" + "." + "ClientRootCertificateChainArn", StringUtils.FromString(publicRequestlistValue.MutualAuthentication.ClientRootCertificateChainArn));
                            }
                        }
                        if(publicRequestlistValue.IsSetType())
                        {
                            request.Parameters.Add("Authentication" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetClientCidrBlock())
                {
                    request.Parameters.Add("ClientCidrBlock", StringUtils.FromString(publicRequest.ClientCidrBlock));
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetConnectionLogOptions())
                {
                    if(publicRequest.ConnectionLogOptions.IsSetCloudwatchLogGroup())
                    {
                        request.Parameters.Add("ConnectionLogOptions" + "." + "CloudwatchLogGroup", StringUtils.FromString(publicRequest.ConnectionLogOptions.CloudwatchLogGroup));
                    }
                    if(publicRequest.ConnectionLogOptions.IsSetCloudwatchLogStream())
                    {
                        request.Parameters.Add("ConnectionLogOptions" + "." + "CloudwatchLogStream", StringUtils.FromString(publicRequest.ConnectionLogOptions.CloudwatchLogStream));
                    }
                    if(publicRequest.ConnectionLogOptions.IsSetEnabled())
                    {
                        request.Parameters.Add("ConnectionLogOptions" + "." + "Enabled", StringUtils.FromBool(publicRequest.ConnectionLogOptions.Enabled));
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDnsServers())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.DnsServers)
                    {
                        request.Parameters.Add("DnsServers" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetServerCertificateArn())
                {
                    request.Parameters.Add("ServerCertificateArn", StringUtils.FromString(publicRequest.ServerCertificateArn));
                }
                if(publicRequest.IsSetTagSpecifications())
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
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTransportProtocol())
                {
                    request.Parameters.Add("TransportProtocol", StringUtils.FromString(publicRequest.TransportProtocol));
                }
            }
            return request;
        }
                    private static CreateClientVpnEndpointRequestMarshaller _instance = new CreateClientVpnEndpointRequestMarshaller();        

        internal static CreateClientVpnEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateClientVpnEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}