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
    /// ModifyVpcEncryptionControl Request Marshaller
    /// </summary>
    public partial class ModifyVpcEncryptionControlRequestMarshaller : IMarshaller<IRequest, ModifyVpcEncryptionControlRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpcEncryptionControlRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyVpcEncryptionControlRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyVpcEncryptionControl");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEgressOnlyInternetGatewayExclusion())
            {
                request.Parameters.Add("EgressOnlyInternetGatewayExclusion", StringUtils.FromString(publicRequest.EgressOnlyInternetGatewayExclusion));
            }
            if (publicRequest.IsSetElasticFileSystemExclusion())
            {
                request.Parameters.Add("ElasticFileSystemExclusion", StringUtils.FromString(publicRequest.ElasticFileSystemExclusion));
            }
            if (publicRequest.IsSetInternetGatewayExclusion())
            {
                request.Parameters.Add("InternetGatewayExclusion", StringUtils.FromString(publicRequest.InternetGatewayExclusion));
            }
            if (publicRequest.IsSetLambdaExclusion())
            {
                request.Parameters.Add("LambdaExclusion", StringUtils.FromString(publicRequest.LambdaExclusion));
            }
            if (publicRequest.IsSetMode())
            {
                request.Parameters.Add("Mode", StringUtils.FromString(publicRequest.Mode));
            }
            if (publicRequest.IsSetNatGatewayExclusion())
            {
                request.Parameters.Add("NatGatewayExclusion", StringUtils.FromString(publicRequest.NatGatewayExclusion));
            }
            if (publicRequest.IsSetVirtualPrivateGatewayExclusion())
            {
                request.Parameters.Add("VirtualPrivateGatewayExclusion", StringUtils.FromString(publicRequest.VirtualPrivateGatewayExclusion));
            }
            if (publicRequest.IsSetVpcEncryptionControlId())
            {
                request.Parameters.Add("VpcEncryptionControlId", StringUtils.FromString(publicRequest.VpcEncryptionControlId));
            }
            if (publicRequest.IsSetVpcLatticeExclusion())
            {
                request.Parameters.Add("VpcLatticeExclusion", StringUtils.FromString(publicRequest.VpcLatticeExclusion));
            }
            if (publicRequest.IsSetVpcPeeringExclusion())
            {
                request.Parameters.Add("VpcPeeringExclusion", StringUtils.FromString(publicRequest.VpcPeeringExclusion));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyVpcEncryptionControlRequestMarshaller _instance = new();

        internal static ModifyVpcEncryptionControlRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyVpcEncryptionControlRequestMarshaller Instance => _instance;
    }
}
