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

using Amazon.Translate.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Translate.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportTerminology Request Marshaller
    /// </summary>
    public partial class ImportTerminologyRequestMarshaller : IMarshaller<IRequest, ImportTerminologyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportTerminologyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportTerminologyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Translate");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWSShineFrontendService_20170701/operation/ImportTerminology";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEncryptionKey())
                {
                    context.Writer.WriteTextString("EncryptionKey");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EncryptionKeyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionKey, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetMergeStrategy())
                {
                    context.Writer.WriteTextString("MergeStrategy");
                    context.Writer.WriteTextString(publicRequest.MergeStrategy);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTerminologyData())
                {
                    context.Writer.WriteTextString("TerminologyData");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TerminologyDataMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TerminologyData, context);

                    context.Writer.WriteEndMap();
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

        private static readonly ImportTerminologyRequestMarshaller _instance = new();

        internal static ImportTerminologyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportTerminologyRequestMarshaller Instance => _instance;
    }
}
