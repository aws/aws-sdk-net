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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubRefactorSpaces.Model;
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
namespace Amazon.MigrationHubRefactorSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRoute Request Marshaller
    /// </summary>       
    public class UpdateRouteRequestMarshaller : IMarshaller<IRequest, UpdateRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRouteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubRefactorSpaces");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-10-26";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetApplicationIdentifier())
                throw new AmazonMigrationHubRefactorSpacesException("Request object does not have required field ApplicationIdentifier set");
            request.AddPathResource("{ApplicationIdentifier}", StringUtils.FromString(publicRequest.ApplicationIdentifier));
            if (!publicRequest.IsSetEnvironmentIdentifier())
                throw new AmazonMigrationHubRefactorSpacesException("Request object does not have required field EnvironmentIdentifier set");
            request.AddPathResource("{EnvironmentIdentifier}", StringUtils.FromString(publicRequest.EnvironmentIdentifier));
            if (!publicRequest.IsSetRouteIdentifier())
                throw new AmazonMigrationHubRefactorSpacesException("Request object does not have required field RouteIdentifier set");
            request.AddPathResource("{RouteIdentifier}", StringUtils.FromString(publicRequest.RouteIdentifier));
            request.ResourcePath = "/environments/{EnvironmentIdentifier}/applications/{ApplicationIdentifier}/routes/{RouteIdentifier}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActivationState())
            {
                context.Writer.WritePropertyName("ActivationState");
                context.Writer.WriteStringValue(publicRequest.ActivationState);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateRouteRequestMarshaller _instance = new UpdateRouteRequestMarshaller();        

        internal static UpdateRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}