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
    /// ImportClientBranding Request Marshaller
    /// </summary>       
    public class ImportClientBrandingRequestMarshaller : IMarshaller<IRequest, ImportClientBrandingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportClientBrandingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportClientBrandingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            string target = "WorkspacesService.ImportClientBranding";
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
            if(publicRequest.IsSetDeviceTypeAndroid())
            {
                context.Writer.WritePropertyName("DeviceTypeAndroid");
                context.Writer.WriteStartObject();

                var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceTypeAndroid, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeviceTypeIos())
            {
                context.Writer.WritePropertyName("DeviceTypeIos");
                context.Writer.WriteStartObject();

                var marshaller = IosImportClientBrandingAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceTypeIos, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeviceTypeLinux())
            {
                context.Writer.WritePropertyName("DeviceTypeLinux");
                context.Writer.WriteStartObject();

                var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceTypeLinux, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeviceTypeOsx())
            {
                context.Writer.WritePropertyName("DeviceTypeOsx");
                context.Writer.WriteStartObject();

                var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceTypeOsx, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeviceTypeWeb())
            {
                context.Writer.WritePropertyName("DeviceTypeWeb");
                context.Writer.WriteStartObject();

                var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceTypeWeb, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeviceTypeWindows())
            {
                context.Writer.WritePropertyName("DeviceTypeWindows");
                context.Writer.WriteStartObject();

                var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceTypeWindows, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.WriteStringValue(publicRequest.ResourceId);
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
        private static ImportClientBrandingRequestMarshaller _instance = new ImportClientBrandingRequestMarshaller();        

        internal static ImportClientBrandingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportClientBrandingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}