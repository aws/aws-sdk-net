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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
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
namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateImageRecipe Request Marshaller
    /// </summary>       
    public class CreateImageRecipeRequestMarshaller : IMarshaller<IRequest, CreateImageRecipeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateImageRecipeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateImageRecipeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/CreateImageRecipe";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalInstanceConfiguration())
            {
                context.Writer.WritePropertyName("additionalInstanceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AdditionalInstanceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AdditionalInstanceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAmiTags())
            {
                context.Writer.WritePropertyName("amiTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAmiTagsKvp in publicRequest.AmiTags)
                {
                    context.Writer.WritePropertyName(publicRequestAmiTagsKvp.Key);
                    var publicRequestAmiTagsValue = publicRequestAmiTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAmiTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBlockDeviceMappings())
            {
                context.Writer.WritePropertyName("blockDeviceMappings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBlockDeviceMappingsListValue in publicRequest.BlockDeviceMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceBlockDeviceMappingMarshaller.Instance;
                    marshaller.Marshall(publicRequestBlockDeviceMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

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
            if(publicRequest.IsSetComponents())
            {
                context.Writer.WritePropertyName("components");
                context.Writer.WriteStartArray();
                foreach(var publicRequestComponentsListValue in publicRequest.Components)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ComponentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestComponentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

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

            if(publicRequest.IsSetParentImage())
            {
                context.Writer.WritePropertyName("parentImage");
                context.Writer.WriteStringValue(publicRequest.ParentImage);
            }

            if(publicRequest.IsSetSemanticVersion())
            {
                context.Writer.WritePropertyName("semanticVersion");
                context.Writer.WriteStringValue(publicRequest.SemanticVersion);
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

            if(publicRequest.IsSetWorkingDirectory())
            {
                context.Writer.WritePropertyName("workingDirectory");
                context.Writer.WriteStringValue(publicRequest.WorkingDirectory);
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
        private static CreateImageRecipeRequestMarshaller _instance = new CreateImageRecipeRequestMarshaller();        

        internal static CreateImageRecipeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateImageRecipeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}