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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
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
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCodeSigningConfig Request Marshaller
    /// </summary>       
    public class UpdateCodeSigningConfigRequestMarshaller : IMarshaller<IRequest, UpdateCodeSigningConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCodeSigningConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCodeSigningConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetCodeSigningConfigArn())
                throw new AmazonLambdaException("Request object does not have required field CodeSigningConfigArn set");
            request.AddPathResource("{CodeSigningConfigArn}", StringUtils.FromString(publicRequest.CodeSigningConfigArn));
            request.ResourcePath = "/2020-04-22/code-signing-configs/{CodeSigningConfigArn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowedPublishers())
            {
                context.Writer.WritePropertyName("AllowedPublishers");
                context.Writer.WriteStartObject();

                var marshaller = AllowedPublishersMarshaller.Instance;
                marshaller.Marshall(publicRequest.AllowedPublishers, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCodeSigningPolicies())
            {
                context.Writer.WritePropertyName("CodeSigningPolicies");
                context.Writer.WriteStartObject();

                var marshaller = CodeSigningPoliciesMarshaller.Instance;
                marshaller.Marshall(publicRequest.CodeSigningPolicies, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
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
        private static UpdateCodeSigningConfigRequestMarshaller _instance = new UpdateCodeSigningConfigRequestMarshaller();        

        internal static UpdateCodeSigningConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCodeSigningConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}