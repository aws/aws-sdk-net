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

using Amazon.Polly.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Polly.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeVoices Request Marshaller
    /// </summary>
    public partial class DescribeVoicesRequestMarshaller : IMarshaller<IRequest, DescribeVoicesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeVoicesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeVoicesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Polly");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-10";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
            }

            if (publicRequest.IsSetIncludeAdditionalLanguageCodes())
            {
                request.Parameters.Add("IncludeAdditionalLanguageCodes", StringUtils.FromBool(publicRequest.IncludeAdditionalLanguageCodes.Value));
            }

            if (publicRequest.IsSetLanguageCode())
            {
                request.Parameters.Add("LanguageCode", StringUtils.FromString(publicRequest.LanguageCode));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            request.ResourcePath = "/v1/voices";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeVoicesRequestMarshaller _instance = new();

        internal static DescribeVoicesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeVoicesRequestMarshaller Instance => _instance;
    }
}
