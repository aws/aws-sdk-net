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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
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
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLocationAzureBlob Request Marshaller
    /// </summary>       
    public class UpdateLocationAzureBlobRequestMarshaller : IMarshaller<IRequest, UpdateLocationAzureBlobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLocationAzureBlobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLocationAzureBlobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.UpdateLocationAzureBlob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
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
            if(publicRequest.IsSetAccessTier())
            {
                context.Writer.WritePropertyName("AccessTier");
                context.Writer.WriteStringValue(publicRequest.AccessTier);
            }

            if(publicRequest.IsSetAgentArns())
            {
                context.Writer.WritePropertyName("AgentArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAgentArnsListValue in publicRequest.AgentArns)
                {
                        context.Writer.WriteStringValue(publicRequestAgentArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAuthenticationType())
            {
                context.Writer.WritePropertyName("AuthenticationType");
                context.Writer.WriteStringValue(publicRequest.AuthenticationType);
            }

            if(publicRequest.IsSetBlobType())
            {
                context.Writer.WritePropertyName("BlobType");
                context.Writer.WriteStringValue(publicRequest.BlobType);
            }

            if(publicRequest.IsSetCmkSecretConfig())
            {
                context.Writer.WritePropertyName("CmkSecretConfig");
                context.Writer.WriteStartObject();

                var marshaller = CmkSecretConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CmkSecretConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCustomSecretConfig())
            {
                context.Writer.WritePropertyName("CustomSecretConfig");
                context.Writer.WriteStartObject();

                var marshaller = CustomSecretConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomSecretConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLocationArn())
            {
                context.Writer.WritePropertyName("LocationArn");
                context.Writer.WriteStringValue(publicRequest.LocationArn);
            }

            if(publicRequest.IsSetSasConfiguration())
            {
                context.Writer.WritePropertyName("SasConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AzureBlobSasConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SasConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSubdirectory())
            {
                context.Writer.WritePropertyName("Subdirectory");
                context.Writer.WriteStringValue(publicRequest.Subdirectory);
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
        private static UpdateLocationAzureBlobRequestMarshaller _instance = new UpdateLocationAzureBlobRequestMarshaller();        

        internal static UpdateLocationAzureBlobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLocationAzureBlobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}