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

using Amazon.EntityResolution.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListProviderServices Request Marshaller
    /// </summary>
    public partial class ListProviderServicesRequestMarshaller : IMarshaller<IRequest, ListProviderServicesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListProviderServicesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListProviderServicesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EntityResolution");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetProviderName())
            {
                request.Parameters.Add("providerName", StringUtils.FromString(publicRequest.ProviderName));
            }

            request.ResourcePath = "/providerservices";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListProviderServicesRequestMarshaller _instance = new();

        internal static ListProviderServicesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListProviderServicesRequestMarshaller Instance => _instance;
    }
}
