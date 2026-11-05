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

using Amazon.Lambda.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDurableExecution Request Marshaller
    /// </summary>
    public partial class GetDurableExecutionRequestMarshaller : IMarshaller<IRequest, GetDurableExecutionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDurableExecutionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetDurableExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetIncludeExecutionData())
            {
                request.Parameters.Add("IncludeExecutionData", StringUtils.FromBool(publicRequest.IncludeExecutionData.Value));
            }

            if (!publicRequest.IsSetDurableExecutionArn())
            {
                throw new AmazonLambdaException("Request object does not have required field DurableExecutionArn set");
            }
            request.AddPathResource("{DurableExecutionArn}", StringUtils.FromString(publicRequest.DurableExecutionArn));

            request.ResourcePath = "/2025-12-01/durable-executions/{DurableExecutionArn}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetDurableExecutionRequestMarshaller _instance = new();

        internal static GetDurableExecutionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDurableExecutionRequestMarshaller Instance => _instance;
    }
}
