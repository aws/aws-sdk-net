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

using Amazon.IoT.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteCommandExecution Request Marshaller
    /// </summary>
    public partial class DeleteCommandExecutionRequestMarshaller : IMarshaller<IRequest, DeleteCommandExecutionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteCommandExecutionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteCommandExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "DELETE";

            if (string.IsNullOrEmpty(publicRequest.TargetArn))
            {
                throw new AmazonIoTException("Request object does not have required field TargetArn set");
            }

            if (publicRequest.IsSetTargetArn())
            {
                request.Parameters.Add("targetArn", StringUtils.FromString(publicRequest.TargetArn));
            }

            if (!publicRequest.IsSetExecutionId())
            {
                throw new AmazonIoTException("Request object does not have required field ExecutionId set");
            }
            request.AddPathResource("{executionId}", StringUtils.FromString(publicRequest.ExecutionId));

            request.ResourcePath = "/command-executions/{executionId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteCommandExecutionRequestMarshaller _instance = new();

        internal static DeleteCommandExecutionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteCommandExecutionRequestMarshaller Instance => _instance;
    }
}
