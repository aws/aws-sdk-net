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

using Amazon.ChimeSDKMediaPipelines.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMediaInsightsPipelineConfiguration Request Marshaller
    /// </summary>
    public partial class UpdateMediaInsightsPipelineConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateMediaInsightsPipelineConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMediaInsightsPipelineConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateMediaInsightsPipelineConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMediaPipelines");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetIdentifier())
            {
                throw new AmazonChimeSDKMediaPipelinesException("Request object does not have required field Identifier set");
            }
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));

            request.ResourcePath = "/media-insights-pipeline-configurations/{Identifier}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetElements())
            {
                context.Writer.WritePropertyName("Elements");
                context.Writer.WriteStartArray();
                foreach (var publicRequestElementsListValue in publicRequest.Elements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MediaInsightsPipelineConfigurationElementMarshaller.Instance;
                    marshaller.Marshall(publicRequestElementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRealTimeAlertConfiguration())
            {
                context.Writer.WritePropertyName("RealTimeAlertConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RealTimeAlertConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.RealTimeAlertConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetResourceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ResourceAccessRoleArn");
                context.Writer.WriteStringValue(publicRequest.ResourceAccessRoleArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateMediaInsightsPipelineConfigurationRequestMarshaller _instance = new();

        internal static UpdateMediaInsightsPipelineConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateMediaInsightsPipelineConfigurationRequestMarshaller Instance => _instance;
    }
}
