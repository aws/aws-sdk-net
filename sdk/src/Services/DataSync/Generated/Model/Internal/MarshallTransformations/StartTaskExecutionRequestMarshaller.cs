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
    /// StartTaskExecution Request Marshaller
    /// </summary>       
    public class StartTaskExecutionRequestMarshaller : IMarshaller<IRequest, StartTaskExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartTaskExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartTaskExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.StartTaskExecution";
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
            if(publicRequest.IsSetExcludes())
            {
                context.Writer.WritePropertyName("Excludes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestExcludesListValue in publicRequest.Excludes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FilterRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestExcludesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIncludes())
            {
                context.Writer.WritePropertyName("Includes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIncludesListValue in publicRequest.Includes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FilterRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestIncludesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetManifestConfig())
            {
                context.Writer.WritePropertyName("ManifestConfig");
                context.Writer.WriteStartObject();

                var marshaller = ManifestConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ManifestConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOverrideOptions())
            {
                context.Writer.WritePropertyName("OverrideOptions");
                context.Writer.WriteStartObject();

                var marshaller = OptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.OverrideOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagListEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTaskArn())
            {
                context.Writer.WritePropertyName("TaskArn");
                context.Writer.WriteStringValue(publicRequest.TaskArn);
            }

            if(publicRequest.IsSetTaskReportConfig())
            {
                context.Writer.WritePropertyName("TaskReportConfig");
                context.Writer.WriteStartObject();

                var marshaller = TaskReportConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TaskReportConfig, context);

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
        private static StartTaskExecutionRequestMarshaller _instance = new StartTaskExecutionRequestMarshaller();        

        internal static StartTaskExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartTaskExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}