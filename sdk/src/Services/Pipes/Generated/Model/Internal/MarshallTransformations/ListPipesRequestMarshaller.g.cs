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

using Amazon.Pipes.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPipes Request Marshaller
    /// </summary>
    public partial class ListPipesRequestMarshaller : IMarshaller<IRequest, ListPipesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPipesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListPipesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pipes");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-07";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetCurrentState())
            {
                request.Parameters.Add("CurrentState", StringUtils.FromString(publicRequest.CurrentState));
            }

            if (publicRequest.IsSetDesiredState())
            {
                request.Parameters.Add("DesiredState", StringUtils.FromString(publicRequest.DesiredState));
            }

            if (publicRequest.IsSetLimit())
            {
                request.Parameters.Add("Limit", StringUtils.FromInt(publicRequest.Limit.Value));
            }

            if (publicRequest.IsSetNamePrefix())
            {
                request.Parameters.Add("NamePrefix", StringUtils.FromString(publicRequest.NamePrefix));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetSourcePrefix())
            {
                request.Parameters.Add("SourcePrefix", StringUtils.FromString(publicRequest.SourcePrefix));
            }

            if (publicRequest.IsSetTargetPrefix())
            {
                request.Parameters.Add("TargetPrefix", StringUtils.FromString(publicRequest.TargetPrefix));
            }

            request.ResourcePath = "/v1/pipes";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListPipesRequestMarshaller _instance = new();

        internal static ListPipesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListPipesRequestMarshaller Instance => _instance;
    }
}
