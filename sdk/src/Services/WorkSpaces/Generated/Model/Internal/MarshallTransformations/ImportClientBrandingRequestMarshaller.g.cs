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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportClientBranding Request Marshaller
    /// </summary>
    public partial class ImportClientBrandingRequestMarshaller : IMarshaller<IRequest, ImportClientBrandingRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportClientBrandingRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportClientBrandingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/WorkspacesService/operation/ImportClientBranding";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDeviceTypeAndroid())
                {
                    context.Writer.WriteTextString("DeviceTypeAndroid");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceTypeAndroid, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDeviceTypeIos())
                {
                    context.Writer.WriteTextString("DeviceTypeIos");
                    context.Writer.WriteStartMap(null);

                    var marshaller = IosImportClientBrandingAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceTypeIos, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDeviceTypeLinux())
                {
                    context.Writer.WriteTextString("DeviceTypeLinux");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceTypeLinux, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDeviceTypeOsx())
                {
                    context.Writer.WriteTextString("DeviceTypeOsx");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceTypeOsx, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDeviceTypeWeb())
                {
                    context.Writer.WriteTextString("DeviceTypeWeb");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceTypeWeb, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDeviceTypeWindows())
                {
                    context.Writer.WriteTextString("DeviceTypeWindows");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DefaultImportClientBrandingAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceTypeWindows, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetResourceId())
                {
                    context.Writer.WriteTextString("ResourceId");
                    context.Writer.WriteTextString(publicRequest.ResourceId);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
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

        private static readonly ImportClientBrandingRequestMarshaller _instance = new();

        internal static ImportClientBrandingRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportClientBrandingRequestMarshaller Instance => _instance;
    }
}
