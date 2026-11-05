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

using Amazon.ApiGatewayV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportApi Request Marshaller
    /// </summary>
    public partial class ExportApiRequestMarshaller : IMarshaller<IRequest, ExportApiRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExportApiRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ExportApiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetExportVersion())
            {
                request.Parameters.Add("exportVersion", StringUtils.FromString(publicRequest.ExportVersion));
            }

            if (publicRequest.IsSetIncludeExtensions())
            {
                request.Parameters.Add("includeExtensions", StringUtils.FromBool(publicRequest.IncludeExtensions.Value));
            }

            if (string.IsNullOrEmpty(publicRequest.OutputType))
            {
                throw new AmazonApiGatewayV2Exception("Request object does not have required field OutputType set");
            }

            if (publicRequest.IsSetOutputType())
            {
                request.Parameters.Add("outputType", StringUtils.FromString(publicRequest.OutputType));
            }

            if (publicRequest.IsSetStageName())
            {
                request.Parameters.Add("stageName", StringUtils.FromString(publicRequest.StageName));
            }

            if (!publicRequest.IsSetApiId())
            {
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            }
            request.AddPathResource("{ApiId}", StringUtils.FromString(publicRequest.ApiId));

            if (!publicRequest.IsSetSpecification())
            {
                throw new AmazonApiGatewayV2Exception("Request object does not have required field Specification set");
            }
            request.AddPathResource("{Specification}", StringUtils.FromString(publicRequest.Specification));

            request.ResourcePath = "/v2/apis/{ApiId}/exports/{Specification}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ExportApiRequestMarshaller _instance = new();

        internal static ExportApiRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ExportApiRequestMarshaller Instance => _instance;
    }
}
