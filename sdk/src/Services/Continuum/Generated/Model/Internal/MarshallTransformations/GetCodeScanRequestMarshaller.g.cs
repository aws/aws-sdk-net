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

using Amazon.Continuum.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Continuum.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCodeScan Request Marshaller
    /// </summary>
    public partial class GetCodeScanRequestMarshaller : IMarshaller<IRequest, GetCodeScanRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCodeScanRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetCodeScanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Continuum");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetEnvironmentId())
            {
                throw new AmazonContinuumException("Request object does not have required field EnvironmentId set");
            }
            request.AddPathResource("{environmentId}", StringUtils.FromString(publicRequest.EnvironmentId));

            if (!publicRequest.IsSetScanRunId())
            {
                throw new AmazonContinuumException("Request object does not have required field ScanRunId set");
            }
            request.AddPathResource("{scanRunId}", StringUtils.FromString(publicRequest.ScanRunId));

            request.ResourcePath = "/environments/{environmentId}/code-scans/{scanRunId}";

            return request;
        }

        private static readonly GetCodeScanRequestMarshaller _instance = new();

        internal static GetCodeScanRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetCodeScanRequestMarshaller Instance => _instance;
    }
}
