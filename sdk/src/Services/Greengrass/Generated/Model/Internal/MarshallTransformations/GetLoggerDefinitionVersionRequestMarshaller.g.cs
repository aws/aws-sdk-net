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
    /// GetLoggerDefinitionVersion Request Marshaller
    /// </summary>
    public partial class GetLoggerDefinitionVersionRequestMarshaller : IMarshaller<IRequest, GetLoggerDefinitionVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetLoggerDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetLoggerDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetLoggerDefinitionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field LoggerDefinitionId set");
            }
            request.AddPathResource("{LoggerDefinitionId}", StringUtils.FromString(publicRequest.LoggerDefinitionId));

            if (!publicRequest.IsSetLoggerDefinitionVersionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field LoggerDefinitionVersionId set");
            }
            request.AddPathResource("{LoggerDefinitionVersionId}", StringUtils.FromString(publicRequest.LoggerDefinitionVersionId));

            request.ResourcePath = "/greengrass/definition/loggers/{LoggerDefinitionId}/versions/{LoggerDefinitionVersionId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetLoggerDefinitionVersionRequestMarshaller _instance = new();

        internal static GetLoggerDefinitionVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetLoggerDefinitionVersionRequestMarshaller Instance => _instance;
    }
}
