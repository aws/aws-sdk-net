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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.RTBFabric.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.RTBFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCertificateAssociation Request Marshaller
    /// </summary>
    public partial class GetCertificateAssociationRequestMarshaller : IMarshaller<IRequest, GetCertificateAssociationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCertificateAssociationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetCertificateAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RTBFabric");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-15";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.AcmCertificateArn))
            {
                throw new AmazonRTBFabricException("Request object does not have required field AcmCertificateArn set");
            }

            if (publicRequest.IsSetAcmCertificateArn())
            {
                request.Parameters.Add("acmCertificateArn", StringUtils.FromString(publicRequest.AcmCertificateArn));
            }

            if (!publicRequest.IsSetGatewayId())
            {
                throw new AmazonRTBFabricException("Request object does not have required field GatewayId set");
            }
            request.AddPathResource("{gatewayId}", StringUtils.FromString(publicRequest.GatewayId));

            request.ResourcePath = "/responder-gateway/{gatewayId}/certificate";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetCertificateAssociationRequestMarshaller _instance = new();

        internal static GetCertificateAssociationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetCertificateAssociationRequestMarshaller Instance => _instance;
    }
}
