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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
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
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportResourcesToDraftAppVersion Request Marshaller
    /// </summary>       
    public class ImportResourcesToDraftAppVersionRequestMarshaller : IMarshaller<IRequest, ImportResourcesToDraftAppVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportResourcesToDraftAppVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportResourcesToDraftAppVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/import-resources-to-draft-app-version";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAppArn())
            {
                context.Writer.WritePropertyName("appArn");
                context.Writer.WriteStringValue(publicRequest.AppArn);
            }

            if(publicRequest.IsSetEksSources())
            {
                context.Writer.WritePropertyName("eksSources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEksSourcesListValue in publicRequest.EksSources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EksSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestEksSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImportStrategy())
            {
                context.Writer.WritePropertyName("importStrategy");
                context.Writer.WriteStringValue(publicRequest.ImportStrategy);
            }

            if(publicRequest.IsSetSourceArns())
            {
                context.Writer.WritePropertyName("sourceArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourceArnsListValue in publicRequest.SourceArns)
                {
                        context.Writer.WriteStringValue(publicRequestSourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTerraformSources())
            {
                context.Writer.WritePropertyName("terraformSources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTerraformSourcesListValue in publicRequest.TerraformSources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TerraformSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestTerraformSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static ImportResourcesToDraftAppVersionRequestMarshaller _instance = new ImportResourcesToDraftAppVersionRequestMarshaller();        

        internal static ImportResourcesToDraftAppVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportResourcesToDraftAppVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}