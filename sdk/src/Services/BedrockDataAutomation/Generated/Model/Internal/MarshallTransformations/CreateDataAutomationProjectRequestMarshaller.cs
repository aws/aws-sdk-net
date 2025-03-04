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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
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
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataAutomationProject Request Marshaller
    /// </summary>       
    public class CreateDataAutomationProjectRequestMarshaller : IMarshaller<IRequest, CreateDataAutomationProjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataAutomationProjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataAutomationProjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/data-automation-projects/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCustomOutputConfiguration())
            {
                context.Writer.WritePropertyName("customOutputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CustomOutputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomOutputConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("encryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOverrideConfiguration())
            {
                context.Writer.WritePropertyName("overrideConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OverrideConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OverrideConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProjectDescription())
            {
                context.Writer.WritePropertyName("projectDescription");
                context.Writer.WriteStringValue(publicRequest.ProjectDescription);
            }

            if(publicRequest.IsSetProjectName())
            {
                context.Writer.WritePropertyName("projectName");
                context.Writer.WriteStringValue(publicRequest.ProjectName);
            }

            if(publicRequest.IsSetProjectStage())
            {
                context.Writer.WritePropertyName("projectStage");
                context.Writer.WriteStringValue(publicRequest.ProjectStage);
            }

            if(publicRequest.IsSetStandardOutputConfiguration())
            {
                context.Writer.WritePropertyName("standardOutputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = StandardOutputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.StandardOutputConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
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
        private static CreateDataAutomationProjectRequestMarshaller _instance = new CreateDataAutomationProjectRequestMarshaller();        

        internal static CreateDataAutomationProjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataAutomationProjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}