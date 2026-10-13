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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.IoTThingsGraph.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTThingsGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSystemInstance Request Marshaller
    /// </summary>
    public partial class CreateSystemInstanceRequestMarshaller : IMarshaller<IRequest, CreateSystemInstanceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSystemInstanceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateSystemInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTThingsGraph");
            string target = "IotThingsGraphFrontEndService.CreateSystemInstance";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDefinition())
            {
                context.Writer.WritePropertyName("definition");
                context.Writer.WriteStartObject();

                var marshaller = DefinitionDocumentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Definition, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFlowActionsRoleArn())
            {
                context.Writer.WritePropertyName("flowActionsRoleArn");
                context.Writer.WriteStringValue(publicRequest.FlowActionsRoleArn);
            }
            if (publicRequest.IsSetGreengrassGroupName())
            {
                context.Writer.WritePropertyName("greengrassGroupName");
                context.Writer.WriteStringValue(publicRequest.GreengrassGroupName);
            }
            if (publicRequest.IsSetMetricsConfiguration())
            {
                context.Writer.WritePropertyName("metricsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MetricsConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MetricsConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetS3BucketName())
            {
                context.Writer.WritePropertyName("s3BucketName");
                context.Writer.WriteStringValue(publicRequest.S3BucketName);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTarget())
            {
                context.Writer.WritePropertyName("target");
                context.Writer.WriteStringValue(publicRequest.Target);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateSystemInstanceRequestMarshaller _instance = new();

        internal static CreateSystemInstanceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateSystemInstanceRequestMarshaller Instance => _instance;
    }
}
