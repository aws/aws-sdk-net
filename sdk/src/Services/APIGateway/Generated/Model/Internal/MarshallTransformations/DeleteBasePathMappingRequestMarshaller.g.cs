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

using Amazon.APIGateway.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteBasePathMapping Request Marshaller
    /// </summary>
    public partial class DeleteBasePathMappingRequestMarshaller : IMarshaller<IRequest, DeleteBasePathMappingRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBasePathMappingRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteBasePathMappingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetDomainNameId())
            {
                request.Parameters.Add("domainNameId", StringUtils.FromString(publicRequest.DomainNameId));
            }

            if (!publicRequest.IsSetBasePath())
            {
                throw new AmazonAPIGatewayException("Request object does not have required field BasePath set");
            }
            request.AddPathResource("{basePath}", StringUtils.FromString(publicRequest.BasePath));

            if (!publicRequest.IsSetDomainName())
            {
                throw new AmazonAPIGatewayException("Request object does not have required field DomainName set");
            }
            request.AddPathResource("{domainName}", StringUtils.FromString(publicRequest.DomainName));

            request.ResourcePath = "/domainnames/{domainName}/basepathmappings/{basePath}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteBasePathMappingRequestMarshaller _instance = new();

        internal static DeleteBasePathMappingRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteBasePathMappingRequestMarshaller Instance => _instance;
    }
}
