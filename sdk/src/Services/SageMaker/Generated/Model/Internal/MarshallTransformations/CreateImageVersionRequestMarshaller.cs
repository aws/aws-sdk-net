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
    /// CreateImageVersion Request Marshaller
    /// </summary>       
    public class CreateImageVersionRequestMarshaller : IMarshaller<IRequest, CreateImageVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateImageVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateImageVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateImageVersion";
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
            if(publicRequest.IsSetAliases())
            {
                context.Writer.WritePropertyName("Aliases");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAliasesListValue in publicRequest.Aliases)
                {
                        context.Writer.WriteStringValue(publicRequestAliasesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBaseImage())
            {
                context.Writer.WritePropertyName("BaseImage");
                context.Writer.WriteStringValue(publicRequest.BaseImage);
            }

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
            if(publicRequest.IsSetHorovod())
            {
                context.Writer.WritePropertyName("Horovod");
                context.Writer.WriteBooleanValue(publicRequest.Horovod.Value);
            }

            if(publicRequest.IsSetImageName())
            {
                context.Writer.WritePropertyName("ImageName");
                context.Writer.WriteStringValue(publicRequest.ImageName);
            }

            if(publicRequest.IsSetJobType())
            {
                context.Writer.WritePropertyName("JobType");
                context.Writer.WriteStringValue(publicRequest.JobType);
            }

            if(publicRequest.IsSetMLFramework())
            {
                context.Writer.WritePropertyName("MLFramework");
                context.Writer.WriteStringValue(publicRequest.MLFramework);
            }

            if(publicRequest.IsSetProcessor())
            {
                context.Writer.WritePropertyName("Processor");
                context.Writer.WriteStringValue(publicRequest.Processor);
            }

            if(publicRequest.IsSetProgrammingLang())
            {
                context.Writer.WritePropertyName("ProgrammingLang");
                context.Writer.WriteStringValue(publicRequest.ProgrammingLang);
            }

            if(publicRequest.IsSetReleaseNotes())
            {
                context.Writer.WritePropertyName("ReleaseNotes");
                context.Writer.WriteStringValue(publicRequest.ReleaseNotes);
            }

            if(publicRequest.IsSetVendorGuidance())
            {
                context.Writer.WritePropertyName("VendorGuidance");
                context.Writer.WriteStringValue(publicRequest.VendorGuidance);
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
        private static CreateImageVersionRequestMarshaller _instance = new CreateImageVersionRequestMarshaller();        

        internal static CreateImageVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateImageVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}