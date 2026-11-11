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

using Amazon.DataSync.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTask Request Marshaller
    /// </summary>
    public partial class UpdateTaskRequestMarshaller : IMarshaller<IRequest, UpdateTaskRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTaskRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/FmrsService/operation/UpdateTask";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetCloudWatchLogGroupArn())
                {
                    context.Writer.WriteTextString("CloudWatchLogGroupArn");
                    context.Writer.WriteTextString(publicRequest.CloudWatchLogGroupArn);
                }
                if (publicRequest.IsSetExcludes())
                {
                    context.Writer.WriteTextString("Excludes");
                    context.Writer.WriteStartArray(publicRequest.Excludes.Count);
                    foreach (var publicRequestExcludesListValue in publicRequest.Excludes)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = FilterRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestExcludesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetIncludes())
                {
                    context.Writer.WriteTextString("Includes");
                    context.Writer.WriteStartArray(publicRequest.Includes.Count);
                    foreach (var publicRequestIncludesListValue in publicRequest.Includes)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = FilterRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestIncludesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetManifestConfig())
                {
                    context.Writer.WriteTextString("ManifestConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ManifestConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ManifestConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetOptions())
                {
                    context.Writer.WriteTextString("Options");
                    context.Writer.WriteStartMap(null);

                    var marshaller = OptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Options, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSchedule())
                {
                    context.Writer.WriteTextString("Schedule");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TaskScheduleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Schedule, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTaskArn())
                {
                    context.Writer.WriteTextString("TaskArn");
                    context.Writer.WriteTextString(publicRequest.TaskArn);
                }
                if (publicRequest.IsSetTaskReportConfig())
                {
                    context.Writer.WriteTextString("TaskReportConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TaskReportConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TaskReportConfig, context);

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

        private static readonly UpdateTaskRequestMarshaller _instance = new();

        internal static UpdateTaskRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateTaskRequestMarshaller Instance => _instance;
    }
}
