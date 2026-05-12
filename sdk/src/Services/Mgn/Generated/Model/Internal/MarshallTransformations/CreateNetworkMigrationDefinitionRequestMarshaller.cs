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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
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
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNetworkMigrationDefinition Request Marshaller
    /// </summary>       
    public class CreateNetworkMigrationDefinitionRequestMarshaller : IMarshaller<IRequest, CreateNetworkMigrationDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkMigrationDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNetworkMigrationDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Mgn");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/network-migration/CreateNetworkMigrationDefinition";
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
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetScopeTags())
            {
                context.Writer.WritePropertyName("scopeTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestScopeTagsKvp in publicRequest.ScopeTags)
                {
                    context.Writer.WritePropertyName(publicRequestScopeTagsKvp.Key);
                    var publicRequestScopeTagsValue = publicRequestScopeTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestScopeTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceConfigurations())
            {
                context.Writer.WritePropertyName("sourceConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourceConfigurationsListValue in publicRequest.SourceConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SourceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourceConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTargetDeployment())
            {
                context.Writer.WritePropertyName("targetDeployment");
                context.Writer.WriteStringValue(publicRequest.TargetDeployment);
            }

            if(publicRequest.IsSetTargetNetwork())
            {
                context.Writer.WritePropertyName("targetNetwork");
                context.Writer.WriteStartObject();

                var marshaller = TargetNetworkMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetNetwork, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTargetS3Configuration())
            {
                context.Writer.WritePropertyName("targetS3Configuration");
                context.Writer.WriteStartObject();

                var marshaller = TargetS3ConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetS3Configuration, context);

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
        private static CreateNetworkMigrationDefinitionRequestMarshaller _instance = new CreateNetworkMigrationDefinitionRequestMarshaller();        

        internal static CreateNetworkMigrationDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNetworkMigrationDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}