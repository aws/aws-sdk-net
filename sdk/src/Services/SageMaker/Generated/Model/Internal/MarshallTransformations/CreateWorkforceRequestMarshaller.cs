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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorkforce Request Marshaller
    /// </summary>       
    public class CreateWorkforceRequestMarshaller : IMarshaller<IRequest, CreateWorkforceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkforceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWorkforceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateWorkforce";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCognitoConfig())
            {
                context.Writer.WritePropertyName("CognitoConfig");
                context.Writer.WriteStartObject();

                var marshaller = CognitoConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CognitoConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("IpAddressType");
                context.Writer.WriteStringValue(publicRequest.IpAddressType);
            }

            if(publicRequest.IsSetOidcConfig())
            {
                context.Writer.WritePropertyName("OidcConfig");
                context.Writer.WriteStartObject();

                var marshaller = OidcConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OidcConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceIpConfig())
            {
                context.Writer.WritePropertyName("SourceIpConfig");
                context.Writer.WriteStartObject();

                var marshaller = SourceIpConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceIpConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWorkforceName())
            {
                context.Writer.WritePropertyName("WorkforceName");
                context.Writer.WriteStringValue(publicRequest.WorkforceName);
            }

            if(publicRequest.IsSetWorkforceVpcConfig())
            {
                context.Writer.WritePropertyName("WorkforceVpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = WorkforceVpcConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.WorkforceVpcConfig, context);

                context.Writer.WriteEndObject();
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
        private static CreateWorkforceRequestMarshaller _instance = new CreateWorkforceRequestMarshaller();        

        internal static CreateWorkforceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWorkforceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}