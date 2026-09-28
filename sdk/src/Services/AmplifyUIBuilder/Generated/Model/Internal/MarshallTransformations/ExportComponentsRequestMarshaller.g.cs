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

using Amazon.AmplifyUIBuilder.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportComponents Request Marshaller
    /// </summary>
    public partial class ExportComponentsRequestMarshaller : IMarshaller<IRequest, ExportComponentsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExportComponentsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ExportComponentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AmplifyUIBuilder");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-11";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetAppId())
            {
                throw new AmazonAmplifyUIBuilderException("Request object does not have required field AppId set");
            }
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));

            if (!publicRequest.IsSetEnvironmentName())
            {
                throw new AmazonAmplifyUIBuilderException("Request object does not have required field EnvironmentName set");
            }
            request.AddPathResource("{environmentName}", StringUtils.FromString(publicRequest.EnvironmentName));

            request.ResourcePath = "/export/app/{appId}/environment/{environmentName}/components";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ExportComponentsRequestMarshaller _instance = new();

        internal static ExportComponentsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ExportComponentsRequestMarshaller Instance => _instance;
    }
}
