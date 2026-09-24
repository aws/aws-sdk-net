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

using Amazon.Artifact.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Artifact.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetReport Request Marshaller
    /// </summary>
    public partial class GetReportRequestMarshaller : IMarshaller<IRequest, GetReportRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetReportRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Artifact");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.ReportId))
            {
                throw new AmazonArtifactException("Request object does not have required field ReportId set");
            }

            if (publicRequest.IsSetReportId())
            {
                request.Parameters.Add("reportId", StringUtils.FromString(publicRequest.ReportId));
            }

            if (publicRequest.IsSetReportVersion())
            {
                request.Parameters.Add("reportVersion", StringUtils.FromLong(publicRequest.ReportVersion.Value));
            }

            if (string.IsNullOrEmpty(publicRequest.TermToken))
            {
                throw new AmazonArtifactException("Request object does not have required field TermToken set");
            }

            if (publicRequest.IsSetTermToken())
            {
                request.Parameters.Add("termToken", StringUtils.FromString(publicRequest.TermToken));
            }

            request.ResourcePath = "/v1/report/get";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetReportRequestMarshaller _instance = new();

        internal static GetReportRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetReportRequestMarshaller Instance => _instance;
    }
}
