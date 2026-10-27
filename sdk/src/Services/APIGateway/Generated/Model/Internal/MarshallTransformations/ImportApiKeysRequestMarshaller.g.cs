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

using Amazon.APIGateway.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportApiKeys Request Marshaller
    /// </summary>
    public partial class ImportApiKeysRequestMarshaller : IMarshaller<IRequest, ImportApiKeysRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportApiKeysRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportApiKeysRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetFailOnWarnings())
            {
                request.Parameters.Add("failonwarnings", StringUtils.FromBool(publicRequest.FailOnWarnings.Value));
            }

            if (string.IsNullOrEmpty(publicRequest.Format))
            {
                throw new AmazonAPIGatewayException("Request object does not have required field Format set");
            }

            if (publicRequest.IsSetFormat())
            {
                request.Parameters.Add("format", StringUtils.FromString(publicRequest.Format));
            }

            request.AddSubResource("mode", "import");
            request.ResourcePath = "/apikeys";
            request.ContentStream = publicRequest.Body ?? new MemoryStream();
            if (request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ImportApiKeysRequestMarshaller _instance = new();

        internal static ImportApiKeysRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportApiKeysRequestMarshaller Instance => _instance;
    }
}
