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
    /// ModifyVpcPeeringConnectionOptions Request Marshaller
    /// </summary>       
    public class ModifyVpcPeeringConnectionOptionsRequestMarshaller : IMarshaller<IRequest, ModifyVpcPeeringConnectionOptionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpcPeeringConnectionOptionsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVpcPeeringConnectionOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVpcPeeringConnectionOptions");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccepterPeeringConnectionOptions())
                {
                    if(publicRequest.AccepterPeeringConnectionOptions.IsSetAllowDnsResolutionFromRemoteVpc())
                    {
                        request.Parameters.Add("AccepterPeeringConnectionOptions" + "." + "AllowDnsResolutionFromRemoteVpc", StringUtils.FromBool(publicRequest.AccepterPeeringConnectionOptions.AllowDnsResolutionFromRemoteVpc));
                    }
                    if(publicRequest.AccepterPeeringConnectionOptions.IsSetAllowEgressFromLocalClassicLinkToRemoteVpc())
                    {
                        request.Parameters.Add("AccepterPeeringConnectionOptions" + "." + "AllowEgressFromLocalClassicLinkToRemoteVpc", StringUtils.FromBool(publicRequest.AccepterPeeringConnectionOptions.AllowEgressFromLocalClassicLinkToRemoteVpc));
                    }
                    if(publicRequest.AccepterPeeringConnectionOptions.IsSetAllowEgressFromLocalVpcToRemoteClassicLink())
                    {
                        request.Parameters.Add("AccepterPeeringConnectionOptions" + "." + "AllowEgressFromLocalVpcToRemoteClassicLink", StringUtils.FromBool(publicRequest.AccepterPeeringConnectionOptions.AllowEgressFromLocalVpcToRemoteClassicLink));
                    }
                }
                if(publicRequest.IsSetRequesterPeeringConnectionOptions())
                {
                    if(publicRequest.RequesterPeeringConnectionOptions.IsSetAllowDnsResolutionFromRemoteVpc())
                    {
                        request.Parameters.Add("RequesterPeeringConnectionOptions" + "." + "AllowDnsResolutionFromRemoteVpc", StringUtils.FromBool(publicRequest.RequesterPeeringConnectionOptions.AllowDnsResolutionFromRemoteVpc));
                    }
                    if(publicRequest.RequesterPeeringConnectionOptions.IsSetAllowEgressFromLocalClassicLinkToRemoteVpc())
                    {
                        request.Parameters.Add("RequesterPeeringConnectionOptions" + "." + "AllowEgressFromLocalClassicLinkToRemoteVpc", StringUtils.FromBool(publicRequest.RequesterPeeringConnectionOptions.AllowEgressFromLocalClassicLinkToRemoteVpc));
                    }
                    if(publicRequest.RequesterPeeringConnectionOptions.IsSetAllowEgressFromLocalVpcToRemoteClassicLink())
                    {
                        request.Parameters.Add("RequesterPeeringConnectionOptions" + "." + "AllowEgressFromLocalVpcToRemoteClassicLink", StringUtils.FromBool(publicRequest.RequesterPeeringConnectionOptions.AllowEgressFromLocalVpcToRemoteClassicLink));
                    }
                }
                if(publicRequest.IsSetVpcPeeringConnectionId())
                {
                    request.Parameters.Add("VpcPeeringConnectionId", StringUtils.FromString(publicRequest.VpcPeeringConnectionId));
                }
            }
            return request;
        }
                    private static ModifyVpcPeeringConnectionOptionsRequestMarshaller _instance = new ModifyVpcPeeringConnectionOptionsRequestMarshaller();        

        internal static ModifyVpcPeeringConnectionOptionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVpcPeeringConnectionOptionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}