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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
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
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSchemaVersions Request Marshaller
    /// </summary>       
    public class ListSchemaVersionsRequestMarshaller : IMarshaller<IRequest, ListSchemaVersionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSchemaVersionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListSchemaVersionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTManagedIntegrations");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-03";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetType())
                throw new AmazonIoTManagedIntegrationsException("Request object does not have required field Type set");
            request.AddPathResource("{Type}", StringUtils.FromString(publicRequest.Type));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNamespace())
                request.Parameters.Add("NamespaceFilter", StringUtils.FromString(publicRequest.Namespace));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetSchemaId())
                request.Parameters.Add("SchemaIdFilter", StringUtils.FromString(publicRequest.SchemaId));
            
            if (publicRequest.IsSetSemanticVersion())
                request.Parameters.Add("SemanticVersionFilter", StringUtils.FromString(publicRequest.SemanticVersion));
            
            if (publicRequest.IsSetVisibility())
                request.Parameters.Add("VisibilityFilter", StringUtils.FromString(publicRequest.Visibility));
            request.ResourcePath = "/schema-versions/{Type}";
            request.UseQueryString = true;

            return request;
        }
        private static ListSchemaVersionsRequestMarshaller _instance = new ListSchemaVersionsRequestMarshaller();        

        internal static ListSchemaVersionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListSchemaVersionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}