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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateUpdatedImage Request Marshaller
    /// </summary>       
    public class CreateUpdatedImageRequestMarshaller : IMarshaller<IRequest, CreateUpdatedImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUpdatedImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateUpdatedImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/PhotonAdminProxyService/operation/CreateUpdatedImage";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDryRun())
                {
                    context.Writer.WriteTextString("dryRun");
                    context.Writer.WriteBoolean(publicRequest.DryRun.Value);
                }
                if (publicRequest.IsSetExistingImageName())
                {
                    context.Writer.WriteTextString("existingImageName");
                    context.Writer.WriteTextString(publicRequest.ExistingImageName);
                }
                if (publicRequest.IsSetNewImageDescription())
                {
                    context.Writer.WriteTextString("newImageDescription");
                    context.Writer.WriteTextString(publicRequest.NewImageDescription);
                }
                if (publicRequest.IsSetNewImageDisplayName())
                {
                    context.Writer.WriteTextString("newImageDisplayName");
                    context.Writer.WriteTextString(publicRequest.NewImageDisplayName);
                }
                if (publicRequest.IsSetNewImageName())
                {
                    context.Writer.WriteTextString("newImageName");
                    context.Writer.WriteTextString(publicRequest.NewImageName);
                }
                if (publicRequest.IsSetNewImageTags())
                {
                    context.Writer.WriteTextString("newImageTags");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestNewImageTagsKvp in publicRequest.NewImageTags)
                    {
                        context.Writer.WriteTextString(publicRequestNewImageTagsKvp.Key);
                        var publicRequestNewImageTagsValue = publicRequestNewImageTagsKvp.Value;

                            context.Writer.WriteTextString(publicRequestNewImageTagsValue);
                    }
                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static CreateUpdatedImageRequestMarshaller _instance = new CreateUpdatedImageRequestMarshaller();        

        internal static CreateUpdatedImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateUpdatedImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}