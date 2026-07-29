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
 * Do not modify this file. This file is generated from the lambda-core-2026-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LambdaCore.Model;
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
namespace Amazon.LambdaCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateNetworkConnector Request Marshaller
    /// </summary>       
    public class UpdateNetworkConnectorRequestMarshaller : IMarshaller<IRequest, UpdateNetworkConnectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNetworkConnectorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNetworkConnectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LambdaCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-04-30";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonLambdaCoreException("Request object does not have required field Identifier set");
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/2026-04-04/network-connectors/{Identifier}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("Configuration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConnectorConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOperatorRole())
            {
                context.Writer.WritePropertyName("OperatorRole");
                context.Writer.WriteStringValue(publicRequest.OperatorRole);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateNetworkConnectorRequestMarshaller _instance = new UpdateNetworkConnectorRequestMarshaller();        

        internal static UpdateNetworkConnectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNetworkConnectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}