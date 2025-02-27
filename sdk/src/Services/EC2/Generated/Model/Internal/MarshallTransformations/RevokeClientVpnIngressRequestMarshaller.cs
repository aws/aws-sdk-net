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
    /// RevokeClientVpnIngress Request Marshaller
    /// </summary>       
    public class RevokeClientVpnIngressRequestMarshaller : IMarshaller<IRequest, RevokeClientVpnIngressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RevokeClientVpnIngressRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RevokeClientVpnIngressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RevokeClientVpnIngress");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccessGroupId())
                {
                    request.Parameters.Add("AccessGroupId", StringUtils.FromString(publicRequest.AccessGroupId));
                }
                if(publicRequest.IsSetClientVpnEndpointId())
                {
                    request.Parameters.Add("ClientVpnEndpointId", StringUtils.FromString(publicRequest.ClientVpnEndpointId));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetRevokeAllGroups())
                {
                    request.Parameters.Add("RevokeAllGroups", StringUtils.FromBool(publicRequest.RevokeAllGroups));
                }
                if(publicRequest.IsSetTargetNetworkCidr())
                {
                    request.Parameters.Add("TargetNetworkCidr", StringUtils.FromString(publicRequest.TargetNetworkCidr));
                }
            }
            return request;
        }
                    private static RevokeClientVpnIngressRequestMarshaller _instance = new RevokeClientVpnIngressRequestMarshaller();        

        internal static RevokeClientVpnIngressRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RevokeClientVpnIngressRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}