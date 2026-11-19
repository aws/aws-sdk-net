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
    /// AssignPrivateNatGatewayAddress Request Marshaller
    /// </summary>
    public partial class AssignPrivateNatGatewayAddressRequestMarshaller : IMarshaller<IRequest, AssignPrivateNatGatewayAddressRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssignPrivateNatGatewayAddressRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssignPrivateNatGatewayAddressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AssignPrivateNatGatewayAddress");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetNatGatewayId())
            {
                request.Parameters.Add("NatGatewayId", StringUtils.FromString(publicRequest.NatGatewayId));
            }
            if (publicRequest.IsSetPrivateIpAddressCount())
            {
                request.Parameters.Add("PrivateIpAddressCount", StringUtils.FromInt(publicRequest.PrivateIpAddressCount.Value));
            }
            if (publicRequest.IsSetPrivateIpAddresses())
            {
                if (publicRequest.PrivateIpAddresses.Count == 0)
                {
                    request.Parameters.Add("PrivateIpAddress", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PrivateIpAddresses)
                    {
                        request.Parameters.Add("PrivateIpAddress" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly AssignPrivateNatGatewayAddressRequestMarshaller _instance = new();

        internal static AssignPrivateNatGatewayAddressRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssignPrivateNatGatewayAddressRequestMarshaller Instance => _instance;
    }
}
