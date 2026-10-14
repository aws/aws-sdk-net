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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QueryCompatibleRpcV2Protocol.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.QueryCompatibleRpcV2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryCompatibleOperation Request Marshaller
    /// </summary>
    public partial class QueryCompatibleOperationRequestMarshaller : IMarshaller<IRequest, QueryCompatibleOperationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryCompatibleOperationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(QueryCompatibleOperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QueryCompatibleRpcV2Protocol");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-06-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/QueryCompatibleRpcV2Protocol/operation/QueryCompatibleOperation";

            return request;
        }

        private static readonly QueryCompatibleOperationRequestMarshaller _instance = new();

        internal static QueryCompatibleOperationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static QueryCompatibleOperationRequestMarshaller Instance => _instance;
    }
}
