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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
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
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartChangeRequestExecution Request Marshaller
    /// </summary>       
    public class StartChangeRequestExecutionRequestMarshaller : IMarshaller<IRequest, StartChangeRequestExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartChangeRequestExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartChangeRequestExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.StartChangeRequestExecution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";
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
            if(publicRequest.IsSetAutoApprove())
            {
                context.Writer.WritePropertyName("AutoApprove");
                context.Writer.WriteBooleanValue(publicRequest.AutoApprove.Value);
            }

            if(publicRequest.IsSetChangeDetails())
            {
                context.Writer.WritePropertyName("ChangeDetails");
                context.Writer.WriteStringValue(publicRequest.ChangeDetails);
            }

            if(publicRequest.IsSetChangeRequestName())
            {
                context.Writer.WritePropertyName("ChangeRequestName");
                context.Writer.WriteStringValue(publicRequest.ChangeRequestName);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetDocumentName())
            {
                context.Writer.WritePropertyName("DocumentName");
                context.Writer.WriteStringValue(publicRequest.DocumentName);
            }

            if(publicRequest.IsSetDocumentVersion())
            {
                context.Writer.WritePropertyName("DocumentVersion");
                context.Writer.WriteStringValue(publicRequest.DocumentVersion);
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestParametersValueListValue in publicRequestParametersValue)
                    {
                            context.Writer.WriteStringValue(publicRequestParametersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRunbooks())
            {
                context.Writer.WritePropertyName("Runbooks");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRunbooksListValue in publicRequest.Runbooks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RunbookMarshaller.Instance;
                    marshaller.Marshall(publicRequestRunbooksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetScheduledEndTime())
            {
                context.Writer.WritePropertyName("ScheduledEndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ScheduledEndTime.Value)));
            }

            if(publicRequest.IsSetScheduledTime())
            {
                context.Writer.WritePropertyName("ScheduledTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ScheduledTime.Value)));
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
        private static StartChangeRequestExecutionRequestMarshaller _instance = new StartChangeRequestExecutionRequestMarshaller();        

        internal static StartChangeRequestExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartChangeRequestExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}