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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
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
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartAnnotationImportJob Request Marshaller
    /// </summary>       
    public class StartAnnotationImportJobRequestMarshaller : IMarshaller<IRequest, StartAnnotationImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartAnnotationImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartAnnotationImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/import/annotation";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAnnotationFields())
            {
                context.Writer.WritePropertyName("annotationFields");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAnnotationFieldsKvp in publicRequest.AnnotationFields)
                {
                    context.Writer.WritePropertyName(publicRequestAnnotationFieldsKvp.Key);
                    var publicRequestAnnotationFieldsValue = publicRequestAnnotationFieldsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAnnotationFieldsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDestinationName())
            {
                context.Writer.WritePropertyName("destinationName");
                context.Writer.WriteStringValue(publicRequest.DestinationName);
            }

            if(publicRequest.IsSetFormatOptions())
            {
                context.Writer.WritePropertyName("formatOptions");
                context.Writer.WriteStartObject();

                var marshaller = FormatOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.FormatOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetItems())
            {
                context.Writer.WritePropertyName("items");
                context.Writer.WriteStartArray();
                foreach(var publicRequestItemsListValue in publicRequest.Items)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AnnotationImportItemSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestItemsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetRunLeftNormalization())
            {
                context.Writer.WritePropertyName("runLeftNormalization");
                context.Writer.WriteBooleanValue(publicRequest.RunLeftNormalization.Value);
            }

            if(publicRequest.IsSetVersionName())
            {
                context.Writer.WritePropertyName("versionName");
                context.Writer.WriteStringValue(publicRequest.VersionName);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"analytics-";

            return request;
        }
        private static StartAnnotationImportJobRequestMarshaller _instance = new StartAnnotationImportJobRequestMarshaller();        

        internal static StartAnnotationImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartAnnotationImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}