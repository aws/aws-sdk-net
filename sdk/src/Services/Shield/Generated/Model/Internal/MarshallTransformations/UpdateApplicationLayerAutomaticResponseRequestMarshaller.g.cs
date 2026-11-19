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

using Amazon.Shield.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Shield.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApplicationLayerAutomaticResponse Request Marshaller
    /// </summary>
    public partial class UpdateApplicationLayerAutomaticResponseRequestMarshaller : IMarshaller<IRequest, UpdateApplicationLayerAutomaticResponseRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationLayerAutomaticResponseRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateApplicationLayerAutomaticResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Shield");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWSShield_20160616/operation/UpdateApplicationLayerAutomaticResponse";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAction())
                {
                    context.Writer.WriteTextString("Action");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ResponseActionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Action, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetResourceArn())
                {
                    context.Writer.WriteTextString("ResourceArn");
                    context.Writer.WriteTextString(publicRequest.ResourceArn);
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

        private static readonly UpdateApplicationLayerAutomaticResponseRequestMarshaller _instance = new();

        internal static UpdateApplicationLayerAutomaticResponseRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateApplicationLayerAutomaticResponseRequestMarshaller Instance => _instance;
    }
}
