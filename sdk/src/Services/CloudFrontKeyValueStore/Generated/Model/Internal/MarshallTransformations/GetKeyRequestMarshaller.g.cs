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

using Amazon.CloudFrontKeyValueStore.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFrontKeyValueStore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetKey Request Marshaller
    /// </summary>
    public partial class GetKeyRequestMarshaller : IMarshaller<IRequest, GetKeyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetKeyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFrontKeyValueStore");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetKey())
            {
                throw new AmazonCloudFrontKeyValueStoreException("Request object does not have required field Key set");
            }
            request.AddPathResource("{Key}", StringUtils.FromString(publicRequest.Key));

            if (!publicRequest.IsSetKvsARN())
            {
                throw new AmazonCloudFrontKeyValueStoreException("Request object does not have required field KvsARN set");
            }
            request.AddPathResource("{KvsARN}", StringUtils.FromString(publicRequest.KvsARN));

            request.ResourcePath = "/key-value-stores/{KvsARN}/keys/{Key}";

            return request;
        }

        private static readonly GetKeyRequestMarshaller _instance = new();

        internal static GetKeyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetKeyRequestMarshaller Instance => _instance;
    }
}
