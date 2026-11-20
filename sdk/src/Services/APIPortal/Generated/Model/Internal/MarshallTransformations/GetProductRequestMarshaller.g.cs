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

using Amazon.APIPortal.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.APIPortal.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetProduct Request Marshaller
    /// </summary>
    public partial class GetProductRequestMarshaller : IMarshaller<IRequest, GetProductRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetProductRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetProductRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIPortal");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-04-30";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetResourceOwnerAccountId())
            {
                request.Parameters.Add("resourceOwnerAccountId", StringUtils.FromString(publicRequest.ResourceOwnerAccountId));
            }

            if (!publicRequest.IsSetProductId())
            {
                throw new AmazonAPIPortalException("Request object does not have required field ProductId set");
            }
            request.AddPathResource("{productId}", StringUtils.FromString(publicRequest.ProductId));

            request.ResourcePath = "/products/{productId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetProductRequestMarshaller _instance = new();

        internal static GetProductRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetProductRequestMarshaller Instance => _instance;
    }
}
