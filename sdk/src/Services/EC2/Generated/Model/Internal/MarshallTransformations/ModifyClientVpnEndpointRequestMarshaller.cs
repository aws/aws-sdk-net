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
    /// ModifyClientVpnEndpoint Request Marshaller
    /// </summary>       
    public class ModifyClientVpnEndpointRequestMarshaller : IMarshaller<IRequest, ModifyClientVpnEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyClientVpnEndpointRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyClientVpnEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyClientVpnEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientVpnEndpointId())
                {
                    request.Parameters.Add("ClientVpnEndpointId", StringUtils.FromString(publicRequest.ClientVpnEndpointId));
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
                    if(publicRequest.DnsServers.IsSetCustomDnsServers())
                    {
                        int publicRequestDnsServerslistValueIndex = 1;
                        foreach(var publicRequestDnsServerslistValue in publicRequest.DnsServers.CustomDnsServers)
                        {
                            request.Parameters.Add("DnsServers" + "." + "CustomDnsServers" + "." + publicRequestDnsServerslistValueIndex, StringUtils.FromString(publicRequestDnsServerslistValue));
                            publicRequestDnsServerslistValueIndex++;
                        }
                    }
                    if(publicRequest.DnsServers.IsSetEnabled())
                    {
                        request.Parameters.Add("DnsServers" + "." + "Enabled", StringUtils.FromBool(publicRequest.DnsServers.Enabled));
                    }
                }
                if(publicRequest.IsSetServerCertificateArn())
                {
                    request.Parameters.Add("ServerCertificateArn", StringUtils.FromString(publicRequest.ServerCertificateArn));
                }
            }
            return request;
        }
                    private static ModifyClientVpnEndpointRequestMarshaller _instance = new ModifyClientVpnEndpointRequestMarshaller();        

        internal static ModifyClientVpnEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyClientVpnEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}