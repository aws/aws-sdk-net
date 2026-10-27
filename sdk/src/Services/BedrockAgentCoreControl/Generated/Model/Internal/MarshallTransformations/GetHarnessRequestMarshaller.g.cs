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

using Amazon.BedrockAgentCoreControl.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetHarness Request Marshaller
    /// </summary>
    public partial class GetHarnessRequestMarshaller : IMarshaller<IRequest, GetHarnessRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetHarnessRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetHarnessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetHarnessVersion())
            {
                request.Parameters.Add("harnessVersion", StringUtils.FromString(publicRequest.HarnessVersion));
            }

            if (!publicRequest.IsSetHarnessId())
            {
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field HarnessId set");
            }
            request.AddPathResource("{harnessId}", StringUtils.FromString(publicRequest.HarnessId));

            request.ResourcePath = "/harnesses/{harnessId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetHarnessRequestMarshaller _instance = new();

        internal static GetHarnessRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetHarnessRequestMarshaller Instance => _instance;
    }
}
