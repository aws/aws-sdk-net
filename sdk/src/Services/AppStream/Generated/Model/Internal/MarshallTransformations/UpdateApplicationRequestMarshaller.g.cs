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

using Amazon.AppStream.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApplication Request Marshaller
    /// </summary>
    public partial class UpdateApplicationRequestMarshaller : IMarshaller<IRequest, UpdateApplicationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/PhotonAdminProxyService/operation/UpdateApplication";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAppBlockArn())
                {
                    context.Writer.WriteTextString("AppBlockArn");
                    context.Writer.WriteTextString(publicRequest.AppBlockArn);
                }
                if (publicRequest.IsSetAttributesToDelete())
                {
                    context.Writer.WriteTextString("AttributesToDelete");
                    context.Writer.WriteStartArray(publicRequest.AttributesToDelete.Count);
                    foreach (var publicRequestAttributesToDeleteListValue in publicRequest.AttributesToDelete)
                    {
                        context.Writer.WriteTextString(publicRequestAttributesToDeleteListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetDisplayName())
                {
                    context.Writer.WriteTextString("DisplayName");
                    context.Writer.WriteTextString(publicRequest.DisplayName);
                }
                if (publicRequest.IsSetIconS3Location())
                {
                    context.Writer.WriteTextString("IconS3Location");
                    context.Writer.WriteStartMap(null);

                    var marshaller = S3LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IconS3Location, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetLaunchParameters())
                {
                    context.Writer.WriteTextString("LaunchParameters");
                    context.Writer.WriteTextString(publicRequest.LaunchParameters);
                }
                if (publicRequest.IsSetLaunchPath())
                {
                    context.Writer.WriteTextString("LaunchPath");
                    context.Writer.WriteTextString(publicRequest.LaunchPath);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetWorkingDirectory())
                {
                    context.Writer.WriteTextString("WorkingDirectory");
                    context.Writer.WriteTextString(publicRequest.WorkingDirectory);
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

        private static readonly UpdateApplicationRequestMarshaller _instance = new();

        internal static UpdateApplicationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateApplicationRequestMarshaller Instance => _instance;
    }
}
