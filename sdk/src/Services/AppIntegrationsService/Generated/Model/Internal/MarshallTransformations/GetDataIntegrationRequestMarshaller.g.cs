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

using Amazon.AppIntegrationsService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AppIntegrationsService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDataIntegration Request Marshaller
    /// </summary>
    public partial class GetDataIntegrationRequestMarshaller : IMarshaller<IRequest, GetDataIntegrationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDataIntegrationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetDataIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppIntegrationsService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetIdentifier())
            {
                throw new AmazonAppIntegrationsServiceException("Request object does not have required field Identifier set");
            }
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));

            request.ResourcePath = "/dataIntegrations/{Identifier}";

            return request;
        }

        private static readonly GetDataIntegrationRequestMarshaller _instance = new();

        internal static GetDataIntegrationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDataIntegrationRequestMarshaller Instance => _instance;
    }
}
