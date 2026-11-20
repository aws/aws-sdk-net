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

using Amazon.Textract.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Textract.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDocumentInsights Request Marshaller
    /// </summary>
    public partial class StartDocumentInsightsRequestMarshaller : IMarshaller<IRequest, StartDocumentInsightsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDocumentInsightsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartDocumentInsightsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Textract");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/Textract/operation/StartDocumentInsights";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBlueprints())
                {
                    context.Writer.WriteTextString("Blueprints");
                    context.Writer.WriteStartArray(publicRequest.Blueprints.Count);
                    foreach (var publicRequestBlueprintsListValue in publicRequest.Blueprints)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = BlueprintItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestBlueprintsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WriteTextString("EncryptionConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetInputConfiguration())
                {
                    context.Writer.WriteTextString("InputConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = InputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetNotificationConfiguration())
                {
                    context.Writer.WriteTextString("NotificationConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = NotificationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetOutputConfiguration())
                {
                    context.Writer.WriteTextString("OutputConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = OutputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetProjectArn())
                {
                    context.Writer.WriteTextString("ProjectArn");
                    context.Writer.WriteTextString(publicRequest.ProjectArn);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WriteTextString(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;
                        context.Writer.WriteTextString(publicRequestTagsValue);
                    }
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

        private static readonly StartDocumentInsightsRequestMarshaller _instance = new();

        internal static StartDocumentInsightsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartDocumentInsightsRequestMarshaller Instance => _instance;
    }
}
