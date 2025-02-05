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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageVod.Model;
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
namespace Amazon.MediaPackageVod.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAsset Request Marshaller
    /// </summary>       
    public class CreateAssetRequestMarshaller : IMarshaller<IRequest, CreateAssetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAssetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAssetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackageVod");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-07";
            request.HttpMethod = "POST";

            request.ResourcePath = "/assets";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(publicRequest.Id);
            }

            if(publicRequest.IsSetPackagingGroupId())
            {
                context.Writer.WritePropertyName("packagingGroupId");
                context.Writer.WriteStringValue(publicRequest.PackagingGroupId);
            }

            if(publicRequest.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.WriteStringValue(publicRequest.ResourceId);
            }

            if(publicRequest.IsSetSourceArn())
            {
                context.Writer.WritePropertyName("sourceArn");
                context.Writer.WriteStringValue(publicRequest.SourceArn);
            }

            if(publicRequest.IsSetSourceRoleArn())
            {
                context.Writer.WritePropertyName("sourceRoleArn");
                context.Writer.WriteStringValue(publicRequest.SourceRoleArn);
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
            


            return request;
        }
        private static CreateAssetRequestMarshaller _instance = new CreateAssetRequestMarshaller();        

        internal static CreateAssetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAssetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}