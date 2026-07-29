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
    /// CreateExportImageTask Request Marshaller
    /// </summary>       
    public class CreateExportImageTaskRequestMarshaller : IMarshaller<IRequest, CreateExportImageTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateExportImageTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateExportImageTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/PhotonAdminProxyService/operation/CreateExportImageTask";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAmiDescription())
                {
                    context.Writer.WriteTextString("AmiDescription");
                    context.Writer.WriteTextString(publicRequest.AmiDescription);
                }
                if (publicRequest.IsSetAmiName())
                {
                    context.Writer.WriteTextString("AmiName");
                    context.Writer.WriteTextString(publicRequest.AmiName);
                }
                if (publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WriteTextString("IamRoleArn");
                    context.Writer.WriteTextString(publicRequest.IamRoleArn);
                }
                if (publicRequest.IsSetImageName())
                {
                    context.Writer.WriteTextString("ImageName");
                    context.Writer.WriteTextString(publicRequest.ImageName);
                }
                if (publicRequest.IsSetTagSpecifications())
                {
                    context.Writer.WriteTextString("TagSpecifications");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestTagSpecificationsKvp in publicRequest.TagSpecifications)
                    {
                        context.Writer.WriteTextString(publicRequestTagSpecificationsKvp.Key);
                        var publicRequestTagSpecificationsValue = publicRequestTagSpecificationsKvp.Value;

                            context.Writer.WriteTextString(publicRequestTagSpecificationsValue);
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
        private static CreateExportImageTaskRequestMarshaller _instance = new CreateExportImageTaskRequestMarshaller();        

        internal static CreateExportImageTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateExportImageTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}