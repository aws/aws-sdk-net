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

using Amazon.S3Tables.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Tables.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTableReplicationStatus Request Marshaller
    /// </summary>
    public partial class GetTableReplicationStatusRequestMarshaller : IMarshaller<IRequest, GetTableReplicationStatusRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTableReplicationStatusRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetTableReplicationStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Tables");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.TableArn))
            {
                throw new AmazonS3TablesException("Request object does not have required field TableArn set");
            }

            if (publicRequest.IsSetTableArn())
            {
                request.Parameters.Add("tableArn", StringUtils.FromString(publicRequest.TableArn));
            }

            request.ResourcePath = "/replication-status";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetTableReplicationStatusRequestMarshaller _instance = new();

        internal static GetTableReplicationStatusRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetTableReplicationStatusRequestMarshaller Instance => _instance;
    }
}
