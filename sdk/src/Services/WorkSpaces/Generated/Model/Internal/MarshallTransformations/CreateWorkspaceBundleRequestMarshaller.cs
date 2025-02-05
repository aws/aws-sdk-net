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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
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
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorkspaceBundle Request Marshaller
    /// </summary>       
    public class CreateWorkspaceBundleRequestMarshaller : IMarshaller<IRequest, CreateWorkspaceBundleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkspaceBundleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWorkspaceBundleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            string target = "WorkspacesService.CreateWorkspaceBundle";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
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
            if(publicRequest.IsSetBundleDescription())
            {
                context.Writer.WritePropertyName("BundleDescription");
                context.Writer.WriteStringValue(publicRequest.BundleDescription);
            }

            if(publicRequest.IsSetBundleName())
            {
                context.Writer.WritePropertyName("BundleName");
                context.Writer.WriteStringValue(publicRequest.BundleName);
            }

            if(publicRequest.IsSetComputeType())
            {
                context.Writer.WritePropertyName("ComputeType");
                context.Writer.WriteStartObject();

                var marshaller = ComputeTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.ComputeType, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetImageId())
            {
                context.Writer.WritePropertyName("ImageId");
                context.Writer.WriteStringValue(publicRequest.ImageId);
            }

            if(publicRequest.IsSetRootStorage())
            {
                context.Writer.WritePropertyName("RootStorage");
                context.Writer.WriteStartObject();

                var marshaller = RootStorageMarshaller.Instance;
                marshaller.Marshall(publicRequest.RootStorage, context);

                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetUserStorage())
            {
                context.Writer.WritePropertyName("UserStorage");
                context.Writer.WriteStartObject();

                var marshaller = UserStorageMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserStorage, context);

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
        private static CreateWorkspaceBundleRequestMarshaller _instance = new CreateWorkspaceBundleRequestMarshaller();        

        internal static CreateWorkspaceBundleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWorkspaceBundleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}