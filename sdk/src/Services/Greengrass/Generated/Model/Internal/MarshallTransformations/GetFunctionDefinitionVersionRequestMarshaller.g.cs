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

using Amazon.Greengrass.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetFunctionDefinitionVersion Request Marshaller
    /// </summary>
    public partial class GetFunctionDefinitionVersionRequestMarshaller : IMarshaller<IRequest, GetFunctionDefinitionVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetFunctionDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetFunctionDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetFunctionDefinitionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field FunctionDefinitionId set");
            }
            request.AddPathResource("{FunctionDefinitionId}", StringUtils.FromString(publicRequest.FunctionDefinitionId));

            if (!publicRequest.IsSetFunctionDefinitionVersionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field FunctionDefinitionVersionId set");
            }
            request.AddPathResource("{FunctionDefinitionVersionId}", StringUtils.FromString(publicRequest.FunctionDefinitionVersionId));

            request.ResourcePath = "/greengrass/definition/functions/{FunctionDefinitionId}/versions/{FunctionDefinitionVersionId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetFunctionDefinitionVersionRequestMarshaller _instance = new();

        internal static GetFunctionDefinitionVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetFunctionDefinitionVersionRequestMarshaller Instance => _instance;
    }
}
