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
    /// CreateAssetModelCompositeModel Request Marshaller
    /// </summary>       
    public class CreateAssetModelCompositeModelRequestMarshaller : IMarshaller<IRequest, CreateAssetModelCompositeModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAssetModelCompositeModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAssetModelCompositeModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAssetModelId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field AssetModelId set");
            request.AddPathResource("{assetModelId}", StringUtils.FromString(publicRequest.AssetModelId));
            request.ResourcePath = "/asset-models/{assetModelId}/composite-models";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssetModelCompositeModelDescription())
            {
                context.Writer.WritePropertyName("assetModelCompositeModelDescription");
                context.Writer.WriteStringValue(publicRequest.AssetModelCompositeModelDescription);
            }

            if(publicRequest.IsSetAssetModelCompositeModelExternalId())
            {
                context.Writer.WritePropertyName("assetModelCompositeModelExternalId");
                context.Writer.WriteStringValue(publicRequest.AssetModelCompositeModelExternalId);
            }

            if(publicRequest.IsSetAssetModelCompositeModelId())
            {
                context.Writer.WritePropertyName("assetModelCompositeModelId");
                context.Writer.WriteStringValue(publicRequest.AssetModelCompositeModelId);
            }

            if(publicRequest.IsSetAssetModelCompositeModelName())
            {
                context.Writer.WritePropertyName("assetModelCompositeModelName");
                context.Writer.WriteStringValue(publicRequest.AssetModelCompositeModelName);
            }

            if(publicRequest.IsSetAssetModelCompositeModelProperties())
            {
                context.Writer.WritePropertyName("assetModelCompositeModelProperties");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssetModelCompositeModelPropertiesListValue in publicRequest.AssetModelCompositeModelProperties)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetModelPropertyDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssetModelCompositeModelPropertiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAssetModelCompositeModelType())
            {
                context.Writer.WritePropertyName("assetModelCompositeModelType");
                context.Writer.WriteStringValue(publicRequest.AssetModelCompositeModelType);
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
            if(publicRequest.IsSetComposedAssetModelId())
            {
                context.Writer.WritePropertyName("composedAssetModelId");
                context.Writer.WriteStringValue(publicRequest.ComposedAssetModelId);
            }

            if(publicRequest.IsSetParentAssetModelCompositeModelId())
            {
                context.Writer.WritePropertyName("parentAssetModelCompositeModelId");
                context.Writer.WriteStringValue(publicRequest.ParentAssetModelCompositeModelId);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
        
            if (publicRequest.IsSetIfNoneMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.IfNoneMatch;
            }
        
            if (publicRequest.IsSetMatchForVersionType()) 
            {
                request.Headers["Match-For-Version-Type"] = publicRequest.MatchForVersionType;
            }
            
            request.HostPrefix = $"api.";

            return request;
        }
        private static CreateAssetModelCompositeModelRequestMarshaller _instance = new CreateAssetModelCompositeModelRequestMarshaller();        

        internal static CreateAssetModelCompositeModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAssetModelCompositeModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}