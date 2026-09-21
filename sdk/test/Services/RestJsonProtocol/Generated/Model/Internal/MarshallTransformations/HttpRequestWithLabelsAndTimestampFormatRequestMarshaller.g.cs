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

using Amazon.RestJsonProtocol.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpRequestWithLabelsAndTimestampFormat Request Marshaller
    /// </summary>
    public partial class HttpRequestWithLabelsAndTimestampFormatRequestMarshaller : IMarshaller<IRequest, HttpRequestWithLabelsAndTimestampFormatRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpRequestWithLabelsAndTimestampFormatRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(HttpRequestWithLabelsAndTimestampFormatRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDefaultFormat())
            {
                throw new AmazonRestJsonProtocolException("Request object does not have required field DefaultFormat set");
            }
            request.AddPathResource("{defaultFormat}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.DefaultFormat));

            if (!publicRequest.IsSetMemberDateTime())
            {
                throw new AmazonRestJsonProtocolException("Request object does not have required field MemberDateTime set");
            }
            request.AddPathResource("{memberDateTime}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.MemberDateTime));

            if (!publicRequest.IsSetMemberEpochSeconds())
            {
                throw new AmazonRestJsonProtocolException("Request object does not have required field MemberEpochSeconds set");
            }
            request.AddPathResource("{memberEpochSeconds}", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.MemberEpochSeconds));

            if (!publicRequest.IsSetMemberHttpDate())
            {
                throw new AmazonRestJsonProtocolException("Request object does not have required field MemberHttpDate set");
            }
            request.AddPathResource("{memberHttpDate}", StringUtils.FromDateTimeToRFC822(publicRequest.MemberHttpDate));

            if (!publicRequest.IsSetTargetDateTime())
            {
                throw new AmazonRestJsonProtocolException("Request object does not have required field TargetDateTime set");
            }
            request.AddPathResource("{targetDateTime}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.TargetDateTime));

            if (!publicRequest.IsSetTargetEpochSeconds())
            {
                throw new AmazonRestJsonProtocolException("Request object does not have required field TargetEpochSeconds set");
            }
            request.AddPathResource("{targetEpochSeconds}", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.TargetEpochSeconds));

            if (!publicRequest.IsSetTargetHttpDate())
            {
                throw new AmazonRestJsonProtocolException("Request object does not have required field TargetHttpDate set");
            }
            request.AddPathResource("{targetHttpDate}", StringUtils.FromDateTimeToRFC822(publicRequest.TargetHttpDate));

            request.ResourcePath = "/HttpRequestWithLabelsAndTimestampFormat/{memberEpochSeconds}/{memberHttpDate}/{memberDateTime}/{defaultFormat}/{targetEpochSeconds}/{targetHttpDate}/{targetDateTime}";

            return request;
        }

        private static readonly HttpRequestWithLabelsAndTimestampFormatRequestMarshaller _instance = new();

        internal static HttpRequestWithLabelsAndTimestampFormatRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static HttpRequestWithLabelsAndTimestampFormatRequestMarshaller Instance => _instance;
    }
}
