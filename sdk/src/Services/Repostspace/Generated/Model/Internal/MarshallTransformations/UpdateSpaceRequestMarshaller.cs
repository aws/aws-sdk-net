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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Repostspace.Model;
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
namespace Amazon.Repostspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSpace Request Marshaller
    /// </summary>       
    public class UpdateSpaceRequestMarshaller : IMarshaller<IRequest, UpdateSpaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSpaceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSpaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Repostspace");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-05-13";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetSpaceId())
                throw new AmazonRepostspaceException("Request object does not have required field SpaceId set");
            request.AddPathResource("{spaceId}", StringUtils.FromString(publicRequest.SpaceId));
            request.ResourcePath = "/spaces/{spaceId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetSupportedEmailDomains())
            {
                context.Writer.WritePropertyName("supportedEmailDomains");
                context.Writer.WriteStartObject();

                var marshaller = SupportedEmailDomainsParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.SupportedEmailDomains, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTier())
            {
                context.Writer.WritePropertyName("tier");
                context.Writer.WriteStringValue(publicRequest.Tier);
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
        private static UpdateSpaceRequestMarshaller _instance = new UpdateSpaceRequestMarshaller();        

        internal static UpdateSpaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSpaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}