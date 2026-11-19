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
    /// ProvisionIpamPoolCidr Request Marshaller
    /// </summary>
    public partial class ProvisionIpamPoolCidrRequestMarshaller : IMarshaller<IRequest, ProvisionIpamPoolCidrRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ProvisionIpamPoolCidrRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ProvisionIpamPoolCidrRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ProvisionIpamPoolCidr");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetCidr())
            {
                request.Parameters.Add("Cidr", StringUtils.FromString(publicRequest.Cidr));
            }
            if (publicRequest.IsSetCidrAuthorizationContext())
            {
                if (publicRequest.CidrAuthorizationContext.IsSetMessage())
                {
                    request.Parameters.Add("CidrAuthorizationContext" + ".Message", StringUtils.FromString(publicRequest.CidrAuthorizationContext.Message));
                }
                if (publicRequest.CidrAuthorizationContext.IsSetSignature())
                {
                    request.Parameters.Add("CidrAuthorizationContext" + ".Signature", StringUtils.FromString(publicRequest.CidrAuthorizationContext.Signature));
                }
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetIpamExternalResourceVerificationTokenId())
            {
                request.Parameters.Add("IpamExternalResourceVerificationTokenId", StringUtils.FromString(publicRequest.IpamExternalResourceVerificationTokenId));
            }
            if (publicRequest.IsSetIpamPoolId())
            {
                request.Parameters.Add("IpamPoolId", StringUtils.FromString(publicRequest.IpamPoolId));
            }
            if (publicRequest.IsSetNetmaskLength())
            {
                request.Parameters.Add("NetmaskLength", StringUtils.FromInt(publicRequest.NetmaskLength.Value));
            }
            if (publicRequest.IsSetVerificationMethod())
            {
                request.Parameters.Add("VerificationMethod", StringUtils.FromString(publicRequest.VerificationMethod));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ProvisionIpamPoolCidrRequestMarshaller _instance = new();

        internal static ProvisionIpamPoolCidrRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ProvisionIpamPoolCidrRequestMarshaller Instance => _instance;
    }
}
