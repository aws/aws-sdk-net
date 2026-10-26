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

using Amazon.Pinpoint.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTemplateVersions Request Marshaller
    /// </summary>
    public partial class ListTemplateVersionsRequestMarshaller : IMarshaller<IRequest, ListTemplateVersionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTemplateVersionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListTemplateVersionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pinpoint");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetPageSize())
            {
                request.Parameters.Add("page-size", StringUtils.FromString(publicRequest.PageSize));
            }

            if (!publicRequest.IsSetTemplateName())
            {
                throw new AmazonPinpointException("Request object does not have required field TemplateName set");
            }
            request.AddPathResource("{TemplateName}", StringUtils.FromString(publicRequest.TemplateName));

            if (!publicRequest.IsSetTemplateType())
            {
                throw new AmazonPinpointException("Request object does not have required field TemplateType set");
            }
            request.AddPathResource("{TemplateType}", StringUtils.FromString(publicRequest.TemplateType));

            request.ResourcePath = "/v1/templates/{TemplateName}/{TemplateType}/versions";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListTemplateVersionsRequestMarshaller _instance = new();

        internal static ListTemplateVersionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListTemplateVersionsRequestMarshaller Instance => _instance;
    }
}
