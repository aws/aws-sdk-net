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

using Amazon.Comprehend.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFlywheel Request Marshaller
    /// </summary>
    public partial class CreateFlywheelRequestMarshaller : IMarshaller<IRequest, CreateFlywheelRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFlywheelRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateFlywheelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Comprehend");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/Comprehend_20171127/operation/CreateFlywheel";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetActiveModelArn())
                {
                    context.Writer.WriteTextString("ActiveModelArn");
                    context.Writer.WriteTextString(publicRequest.ActiveModelArn);
                }
                if (publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WriteTextString("ClientRequestToken");
                    context.Writer.WriteTextString(publicRequest.ClientRequestToken);
                }
                else
                {
                    context.Writer.WriteTextString("ClientRequestToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetDataAccessRoleArn())
                {
                    context.Writer.WriteTextString("DataAccessRoleArn");
                    context.Writer.WriteTextString(publicRequest.DataAccessRoleArn);
                }
                if (publicRequest.IsSetDataLakeS3Uri())
                {
                    context.Writer.WriteTextString("DataLakeS3Uri");
                    context.Writer.WriteTextString(publicRequest.DataLakeS3Uri);
                }
                if (publicRequest.IsSetDataSecurityConfig())
                {
                    context.Writer.WriteTextString("DataSecurityConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DataSecurityConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSecurityConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetFlywheelName())
                {
                    context.Writer.WriteTextString("FlywheelName");
                    context.Writer.WriteTextString(publicRequest.FlywheelName);
                }
                if (publicRequest.IsSetModelType())
                {
                    context.Writer.WriteTextString("ModelType");
                    context.Writer.WriteTextString(publicRequest.ModelType);
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
                if (publicRequest.IsSetTaskConfig())
                {
                    context.Writer.WriteTextString("TaskConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TaskConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TaskConfig, context);

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

        private static readonly CreateFlywheelRequestMarshaller _instance = new();

        internal static CreateFlywheelRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateFlywheelRequestMarshaller Instance => _instance;
    }
}
