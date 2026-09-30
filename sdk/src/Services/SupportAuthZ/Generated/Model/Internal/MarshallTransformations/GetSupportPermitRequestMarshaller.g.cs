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

using Amazon.SupportAuthZ.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SupportAuthZ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSupportPermit Request Marshaller
    /// </summary>
    public partial class GetSupportPermitRequestMarshaller : IMarshaller<IRequest, GetSupportPermitRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSupportPermitRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSupportPermitRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SupportAuthZ");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-06-30";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetSupportPermitIdentifier())
            {
                throw new AmazonSupportAuthZException("Request object does not have required field SupportPermitIdentifier set");
            }
            request.AddPathResource("{supportPermitIdentifier}", StringUtils.FromString(publicRequest.SupportPermitIdentifier));

            request.ResourcePath = "/support-permits/{supportPermitIdentifier}";

            return request;
        }

        private static readonly GetSupportPermitRequestMarshaller _instance = new();

        internal static GetSupportPermitRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSupportPermitRequestMarshaller Instance => _instance;
    }
}
