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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
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
namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateVpcAttachment Request Marshaller
    /// </summary>       
    public class UpdateVpcAttachmentRequestMarshaller : IMarshaller<IRequest, UpdateVpcAttachmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateVpcAttachmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateVpcAttachmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetAttachmentId())
                throw new AmazonNetworkManagerException("Request object does not have required field AttachmentId set");
            request.AddPathResource("{attachmentId}", StringUtils.FromString(publicRequest.AttachmentId));
            request.ResourcePath = "/vpc-attachments/{attachmentId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAddSubnetArns())
            {
                context.Writer.WritePropertyName("AddSubnetArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAddSubnetArnsListValue in publicRequest.AddSubnetArns)
                {
                        context.Writer.WriteStringValue(publicRequestAddSubnetArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteStartObject();

                var marshaller = VpcOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Options, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRemoveSubnetArns())
            {
                context.Writer.WritePropertyName("RemoveSubnetArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRemoveSubnetArnsListValue in publicRequest.RemoveSubnetArns)
                {
                        context.Writer.WriteStringValue(publicRequestRemoveSubnetArnsListValue);
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
        private static UpdateVpcAttachmentRequestMarshaller _instance = new UpdateVpcAttachmentRequestMarshaller();        

        internal static UpdateVpcAttachmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateVpcAttachmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}