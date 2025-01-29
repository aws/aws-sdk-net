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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
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
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMigrationProject Request Marshaller
    /// </summary>       
    public class CreateMigrationProjectRequestMarshaller : IMarshaller<IRequest, CreateMigrationProjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMigrationProjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMigrationProjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.CreateMigrationProject";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
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
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetInstanceProfileIdentifier())
            {
                context.Writer.WritePropertyName("InstanceProfileIdentifier");
                context.Writer.WriteStringValue(publicRequest.InstanceProfileIdentifier);
            }

            if(publicRequest.IsSetMigrationProjectName())
            {
                context.Writer.WritePropertyName("MigrationProjectName");
                context.Writer.WriteStringValue(publicRequest.MigrationProjectName);
            }

            if(publicRequest.IsSetSchemaConversionApplicationAttributes())
            {
                context.Writer.WritePropertyName("SchemaConversionApplicationAttributes");
                context.Writer.WriteStartObject();

                var marshaller = SCApplicationAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.SchemaConversionApplicationAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceDataProviderDescriptors())
            {
                context.Writer.WritePropertyName("SourceDataProviderDescriptors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourceDataProviderDescriptorsListValue in publicRequest.SourceDataProviderDescriptors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataProviderDescriptorDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourceDataProviderDescriptorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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

            if(publicRequest.IsSetTargetDataProviderDescriptors())
            {
                context.Writer.WritePropertyName("TargetDataProviderDescriptors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetDataProviderDescriptorsListValue in publicRequest.TargetDataProviderDescriptors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataProviderDescriptorDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestTargetDataProviderDescriptorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTransformationRules())
            {
                context.Writer.WritePropertyName("TransformationRules");
                context.Writer.WriteStringValue(publicRequest.TransformationRules);
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
        private static CreateMigrationProjectRequestMarshaller _instance = new CreateMigrationProjectRequestMarshaller();        

        internal static CreateMigrationProjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMigrationProjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}