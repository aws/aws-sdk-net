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

using Amazon.Neptunedata.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSparqlStream Request Marshaller
    /// </summary>
    public partial class GetSparqlStreamRequestMarshaller : IMarshaller<IRequest, GetSparqlStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSparqlStreamRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSparqlStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptunedata");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetCommitNum())
            {
                request.Parameters.Add("commitNum", StringUtils.FromLong(publicRequest.CommitNum.Value));
            }

            if (publicRequest.IsSetIteratorType())
            {
                request.Parameters.Add("iteratorType", StringUtils.FromString(publicRequest.IteratorType));
            }

            if (publicRequest.IsSetLimit())
            {
                request.Parameters.Add("limit", StringUtils.FromLong(publicRequest.Limit.Value));
            }

            if (publicRequest.IsSetOpNum())
            {
                request.Parameters.Add("opNum", StringUtils.FromLong(publicRequest.OpNum.Value));
            }

            if (publicRequest.IsSetEncoding())
            {
                request.Headers["Accept-Encoding"] = publicRequest.Encoding;
            }

            request.ResourcePath = "/sparql/stream";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetSparqlStreamRequestMarshaller _instance = new();

        internal static GetSparqlStreamRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSparqlStreamRequestMarshaller Instance => _instance;
    }
}
