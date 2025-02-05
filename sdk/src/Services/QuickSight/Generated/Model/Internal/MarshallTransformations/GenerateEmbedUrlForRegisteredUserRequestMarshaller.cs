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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
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
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GenerateEmbedUrlForRegisteredUser Request Marshaller
    /// </summary>       
    public class GenerateEmbedUrlForRegisteredUserRequestMarshaller : IMarshaller<IRequest, GenerateEmbedUrlForRegisteredUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GenerateEmbedUrlForRegisteredUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GenerateEmbedUrlForRegisteredUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            request.ResourcePath = "/accounts/{AwsAccountId}/embed-url/registered-user";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowedDomains())
            {
                context.Writer.WritePropertyName("AllowedDomains");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedDomainsListValue in publicRequest.AllowedDomains)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedDomainsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetExperienceConfiguration())
            {
                context.Writer.WritePropertyName("ExperienceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RegisteredUserEmbeddingExperienceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExperienceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSessionLifetimeInMinutes())
            {
                context.Writer.WritePropertyName("SessionLifetimeInMinutes");
                context.Writer.WriteNumberValue(publicRequest.SessionLifetimeInMinutes.Value);
            }

            if(publicRequest.IsSetUserArn())
            {
                context.Writer.WritePropertyName("UserArn");
                context.Writer.WriteStringValue(publicRequest.UserArn);
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
        private static GenerateEmbedUrlForRegisteredUserRequestMarshaller _instance = new GenerateEmbedUrlForRegisteredUserRequestMarshaller();        

        internal static GenerateEmbedUrlForRegisteredUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GenerateEmbedUrlForRegisteredUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}