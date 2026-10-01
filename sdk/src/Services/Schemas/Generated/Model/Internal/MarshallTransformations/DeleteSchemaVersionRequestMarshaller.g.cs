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

using Amazon.Schemas.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Schemas.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteSchemaVersion Request Marshaller
    /// </summary>
    public partial class DeleteSchemaVersionRequestMarshaller : IMarshaller<IRequest, DeleteSchemaVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteSchemaVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteSchemaVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Schemas");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetRegistryName())
            {
                throw new AmazonSchemasException("Request object does not have required field RegistryName set");
            }
            request.AddPathResource("{RegistryName}", StringUtils.FromString(publicRequest.RegistryName));

            if (!publicRequest.IsSetSchemaName())
            {
                throw new AmazonSchemasException("Request object does not have required field SchemaName set");
            }
            request.AddPathResource("{SchemaName}", StringUtils.FromString(publicRequest.SchemaName));

            if (!publicRequest.IsSetSchemaVersion())
            {
                throw new AmazonSchemasException("Request object does not have required field SchemaVersion set");
            }
            request.AddPathResource("{SchemaVersion}", StringUtils.FromString(publicRequest.SchemaVersion));

            request.ResourcePath = "/v1/registries/name/{RegistryName}/schemas/name/{SchemaName}/version/{SchemaVersion}";

            return request;
        }

        private static readonly DeleteSchemaVersionRequestMarshaller _instance = new();

        internal static DeleteSchemaVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteSchemaVersionRequestMarshaller Instance => _instance;
    }
}
