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

using Amazon.IotData.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IotData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetConnection Request Marshaller
    /// </summary>
    public partial class GetConnectionRequestMarshaller : IMarshaller<IRequest, GetConnectionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetConnectionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IotData");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetIncludeSocketInformation())
            {
                request.Parameters.Add("includeSocketInformation", StringUtils.FromBool(publicRequest.IncludeSocketInformation.Value));
            }

            if (!publicRequest.IsSetClientId())
            {
                throw new AmazonIotDataException("Request object does not have required field ClientId set");
            }
            request.AddPathResource("{clientId}", StringUtils.FromString(publicRequest.ClientId));

            request.ResourcePath = "/connections/{clientId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetConnectionRequestMarshaller _instance = new();

        internal static GetConnectionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetConnectionRequestMarshaller Instance => _instance;
    }
}
