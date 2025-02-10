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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAssetModel Request Marshaller
    /// </summary>       
    public class CreateAssetModelRequestMarshaller : IMarshaller<IRequest, CreateAssetModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAssetModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAssetModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "/asset-models";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssetModelCompositeModels())
            {
                context.Writer.WritePropertyName("assetModelCompositeModels");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssetModelCompositeModelsListValue in publicRequest.AssetModelCompositeModels)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetModelCompositeModelDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssetModelCompositeModelsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAssetModelDescription())
            {
                context.Writer.WritePropertyName("assetModelDescription");
                context.Writer.WriteStringValue(publicRequest.AssetModelDescription);
            }

            if(publicRequest.IsSetAssetModelExternalId())
            {
                context.Writer.WritePropertyName("assetModelExternalId");
                context.Writer.WriteStringValue(publicRequest.AssetModelExternalId);
            }

            if(publicRequest.IsSetAssetModelHierarchies())
            {
                context.Writer.WritePropertyName("assetModelHierarchies");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssetModelHierarchiesListValue in publicRequest.AssetModelHierarchies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetModelHierarchyDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssetModelHierarchiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAssetModelId())
            {
                context.Writer.WritePropertyName("assetModelId");
                context.Writer.WriteStringValue(publicRequest.AssetModelId);
            }

            if(publicRequest.IsSetAssetModelName())
            {
                context.Writer.WritePropertyName("assetModelName");
                context.Writer.WriteStringValue(publicRequest.AssetModelName);
            }

            if(publicRequest.IsSetAssetModelProperties())
            {
                context.Writer.WritePropertyName("assetModelProperties");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssetModelPropertiesListValue in publicRequest.AssetModelProperties)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetModelPropertyDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssetModelPropertiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAssetModelType())
            {
                context.Writer.WritePropertyName("assetModelType");
                context.Writer.WriteStringValue(publicRequest.AssetModelType);
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

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static CreateAssetModelRequestMarshaller _instance = new CreateAssetModelRequestMarshaller();        

        internal static CreateAssetModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAssetModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}