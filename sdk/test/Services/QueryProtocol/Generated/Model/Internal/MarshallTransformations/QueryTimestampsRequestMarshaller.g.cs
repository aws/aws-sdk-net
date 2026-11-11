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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.QueryProtocol.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryTimestamps Request Marshaller
    /// </summary>
    public partial class QueryTimestampsRequestMarshaller : IMarshaller<IRequest, QueryTimestampsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryTimestampsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(QueryTimestampsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QueryProtocol");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "QueryTimestamps");
            request.Parameters.Add("Version", "2020-01-08");

            if (publicRequest.IsSetEpochMember())
            {
                request.Parameters.Add("epochMember", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EpochMember.Value));
            }
            if (publicRequest.IsSetEpochTarget())
            {
                request.Parameters.Add("epochTarget", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EpochTarget.Value));
            }
            if (publicRequest.IsSetNormalFormat())
            {
                request.Parameters.Add("normalFormat", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.NormalFormat.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly QueryTimestampsRequestMarshaller _instance = new();

        internal static QueryTimestampsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static QueryTimestampsRequestMarshaller Instance => _instance;
    }
}
