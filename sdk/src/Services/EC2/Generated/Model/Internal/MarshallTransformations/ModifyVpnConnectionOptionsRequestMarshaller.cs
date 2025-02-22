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
    /// ModifyVpnConnectionOptions Request Marshaller
    /// </summary>       
    public class ModifyVpnConnectionOptionsRequestMarshaller : IMarshaller<IRequest, ModifyVpnConnectionOptionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpnConnectionOptionsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVpnConnectionOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVpnConnectionOptions");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetLocalIpv4NetworkCidr())
                {
                    request.Parameters.Add("LocalIpv4NetworkCidr", StringUtils.FromString(publicRequest.LocalIpv4NetworkCidr));
                }
                if(publicRequest.IsSetLocalIpv6NetworkCidr())
                {
                    request.Parameters.Add("LocalIpv6NetworkCidr", StringUtils.FromString(publicRequest.LocalIpv6NetworkCidr));
                }
                if(publicRequest.IsSetRemoteIpv4NetworkCidr())
                {
                    request.Parameters.Add("RemoteIpv4NetworkCidr", StringUtils.FromString(publicRequest.RemoteIpv4NetworkCidr));
                }
                if(publicRequest.IsSetRemoteIpv6NetworkCidr())
                {
                    request.Parameters.Add("RemoteIpv6NetworkCidr", StringUtils.FromString(publicRequest.RemoteIpv6NetworkCidr));
                }
                if(publicRequest.IsSetVpnConnectionId())
                {
                    request.Parameters.Add("VpnConnectionId", StringUtils.FromString(publicRequest.VpnConnectionId));
                }
            }
            return request;
        }
                    private static ModifyVpnConnectionOptionsRequestMarshaller _instance = new ModifyVpnConnectionOptionsRequestMarshaller();        

        internal static ModifyVpnConnectionOptionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVpnConnectionOptionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}