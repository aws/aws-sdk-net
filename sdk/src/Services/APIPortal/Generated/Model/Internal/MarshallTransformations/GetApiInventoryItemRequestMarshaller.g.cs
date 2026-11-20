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
    /// GetApiInventoryItem Request Marshaller
    /// </summary>
    public partial class GetApiInventoryItemRequestMarshaller : IMarshaller<IRequest, GetApiInventoryItemRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetApiInventoryItemRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetApiInventoryItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIPortal");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-04-30";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.Host))
            {
                throw new AmazonAPIPortalException("Request object does not have required field Host set");
            }

            if (publicRequest.IsSetHost())
            {
                request.Parameters.Add("host", StringUtils.FromString(publicRequest.Host));
            }

            if (string.IsNullOrEmpty(publicRequest.Method))
            {
                throw new AmazonAPIPortalException("Request object does not have required field Method set");
            }

            if (publicRequest.IsSetMethod())
            {
                request.Parameters.Add("method", StringUtils.FromString(publicRequest.Method));
            }

            if (string.IsNullOrEmpty(publicRequest.Path))
            {
                throw new AmazonAPIPortalException("Request object does not have required field Path set");
            }

            if (publicRequest.IsSetPath())
            {
                request.Parameters.Add("path", StringUtils.FromString(publicRequest.Path));
            }

            if (publicRequest.Port == null)
            {
                throw new AmazonAPIPortalException("Request object does not have required field Port set");
            }

            if (publicRequest.IsSetPort())
            {
                request.Parameters.Add("port", StringUtils.FromInt(publicRequest.Port.Value));
            }

            if (string.IsNullOrEmpty(publicRequest.ResourceArn))
            {
                throw new AmazonAPIPortalException("Request object does not have required field ResourceArn set");
            }

            if (publicRequest.IsSetResourceArn())
            {
                request.Parameters.Add("resourceArn", StringUtils.FromString(publicRequest.ResourceArn));
            }

            request.ResourcePath = "/api-inventory/item";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetApiInventoryItemRequestMarshaller _instance = new();

        internal static GetApiInventoryItemRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetApiInventoryItemRequestMarshaller Instance => _instance;
    }
}
