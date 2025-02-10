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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Schemas.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Schemas.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeCodeBinding Request Marshaller
    /// </summary>       
    public class DescribeCodeBindingRequestMarshaller : IMarshaller<IRequest, DescribeCodeBindingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeCodeBindingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeCodeBindingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Schemas");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetLanguage())
                throw new AmazonSchemasException("Request object does not have required field Language set");
            request.AddPathResource("{language}", StringUtils.FromString(publicRequest.Language));
            if (!publicRequest.IsSetRegistryName())
                throw new AmazonSchemasException("Request object does not have required field RegistryName set");
            request.AddPathResource("{registryName}", StringUtils.FromString(publicRequest.RegistryName));
            if (!publicRequest.IsSetSchemaName())
                throw new AmazonSchemasException("Request object does not have required field SchemaName set");
            request.AddPathResource("{schemaName}", StringUtils.FromString(publicRequest.SchemaName));
            
            if (publicRequest.IsSetSchemaVersion())
                request.Parameters.Add("schemaVersion", StringUtils.FromString(publicRequest.SchemaVersion));
            request.ResourcePath = "/v1/registries/name/{registryName}/schemas/name/{schemaName}/language/{language}";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeCodeBindingRequestMarshaller _instance = new DescribeCodeBindingRequestMarshaller();        

        internal static DescribeCodeBindingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeCodeBindingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}