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

using Amazon.MarketplaceCatalog.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeEntity Request Marshaller
    /// </summary>
    public partial class DescribeEntityRequestMarshaller : IMarshaller<IRequest, DescribeEntityRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeEntityRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeEntityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceCatalog");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-17";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.Catalog))
            {
                throw new AmazonMarketplaceCatalogException("Request object does not have required field Catalog set");
            }

            if (publicRequest.IsSetCatalog())
            {
                request.Parameters.Add("catalog", StringUtils.FromString(publicRequest.Catalog));
            }

            if (string.IsNullOrEmpty(publicRequest.EntityId))
            {
                throw new AmazonMarketplaceCatalogException("Request object does not have required field EntityId set");
            }

            if (publicRequest.IsSetEntityId())
            {
                request.Parameters.Add("entityId", StringUtils.FromString(publicRequest.EntityId));
            }

            request.ResourcePath = "/DescribeEntity";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeEntityRequestMarshaller _instance = new();

        internal static DescribeEntityRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeEntityRequestMarshaller Instance => _instance;
    }
}
