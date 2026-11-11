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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyVpcPeeringConnectionOptions Request Marshaller
    /// </summary>
    public partial class ModifyVpcPeeringConnectionOptionsRequestMarshaller : IMarshaller<IRequest, ModifyVpcPeeringConnectionOptionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpcPeeringConnectionOptionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyVpcPeeringConnectionOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyVpcPeeringConnectionOptions");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAccepterPeeringConnectionOptions())
            {
                if (publicRequest.AccepterPeeringConnectionOptions.IsSetAllowDnsResolutionFromRemoteVpc())
                {
                    request.Parameters.Add("AccepterPeeringConnectionOptions" + ".AllowDnsResolutionFromRemoteVpc", StringUtils.FromBool(publicRequest.AccepterPeeringConnectionOptions.AllowDnsResolutionFromRemoteVpc.Value));
                }
                if (publicRequest.AccepterPeeringConnectionOptions.IsSetAllowEgressFromLocalClassicLinkToRemoteVpc())
                {
                    request.Parameters.Add("AccepterPeeringConnectionOptions" + ".AllowEgressFromLocalClassicLinkToRemoteVpc", StringUtils.FromBool(publicRequest.AccepterPeeringConnectionOptions.AllowEgressFromLocalClassicLinkToRemoteVpc.Value));
                }
                if (publicRequest.AccepterPeeringConnectionOptions.IsSetAllowEgressFromLocalVpcToRemoteClassicLink())
                {
                    request.Parameters.Add("AccepterPeeringConnectionOptions" + ".AllowEgressFromLocalVpcToRemoteClassicLink", StringUtils.FromBool(publicRequest.AccepterPeeringConnectionOptions.AllowEgressFromLocalVpcToRemoteClassicLink.Value));
                }
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetRequesterPeeringConnectionOptions())
            {
                if (publicRequest.RequesterPeeringConnectionOptions.IsSetAllowDnsResolutionFromRemoteVpc())
                {
                    request.Parameters.Add("RequesterPeeringConnectionOptions" + ".AllowDnsResolutionFromRemoteVpc", StringUtils.FromBool(publicRequest.RequesterPeeringConnectionOptions.AllowDnsResolutionFromRemoteVpc.Value));
                }
                if (publicRequest.RequesterPeeringConnectionOptions.IsSetAllowEgressFromLocalClassicLinkToRemoteVpc())
                {
                    request.Parameters.Add("RequesterPeeringConnectionOptions" + ".AllowEgressFromLocalClassicLinkToRemoteVpc", StringUtils.FromBool(publicRequest.RequesterPeeringConnectionOptions.AllowEgressFromLocalClassicLinkToRemoteVpc.Value));
                }
                if (publicRequest.RequesterPeeringConnectionOptions.IsSetAllowEgressFromLocalVpcToRemoteClassicLink())
                {
                    request.Parameters.Add("RequesterPeeringConnectionOptions" + ".AllowEgressFromLocalVpcToRemoteClassicLink", StringUtils.FromBool(publicRequest.RequesterPeeringConnectionOptions.AllowEgressFromLocalVpcToRemoteClassicLink.Value));
                }
            }
            if (publicRequest.IsSetVpcPeeringConnectionId())
            {
                request.Parameters.Add("VpcPeeringConnectionId", StringUtils.FromString(publicRequest.VpcPeeringConnectionId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyVpcPeeringConnectionOptionsRequestMarshaller _instance = new();

        internal static ModifyVpcPeeringConnectionOptionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyVpcPeeringConnectionOptionsRequestMarshaller Instance => _instance;
    }
}
