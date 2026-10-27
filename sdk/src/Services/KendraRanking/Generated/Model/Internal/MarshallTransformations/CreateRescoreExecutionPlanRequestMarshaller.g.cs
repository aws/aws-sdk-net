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

using Amazon.KendraRanking.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.KendraRanking.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRescoreExecutionPlan Request Marshaller
    /// </summary>
    public partial class CreateRescoreExecutionPlanRequestMarshaller : IMarshaller<IRequest, CreateRescoreExecutionPlanRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRescoreExecutionPlanRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateRescoreExecutionPlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KendraRanking");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWSKendraRerankingFrontendService/operation/CreateRescoreExecutionPlan";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetCapacityUnits())
                {
                    context.Writer.WriteTextString("CapacityUnits");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CapacityUnitsConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CapacityUnits, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
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

        private static readonly CreateRescoreExecutionPlanRequestMarshaller _instance = new();

        internal static CreateRescoreExecutionPlanRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateRescoreExecutionPlanRequestMarshaller Instance => _instance;
    }
}
